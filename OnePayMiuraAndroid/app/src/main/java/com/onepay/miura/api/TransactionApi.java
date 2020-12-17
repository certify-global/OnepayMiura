package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.util.Log;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.api.objects.BatteryData;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.miurasystems.mpi.enums.DeviceStatus;
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SystemLogMode;
import com.miurasystems.mpi.enums.TransactionResponse;
import com.miurasystems.mpi.events.DeviceStatusChange;
import com.miurasystems.mpi.events.MpiEventHandler;
import com.miurasystems.mpi.events.MpiEvents;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.transactions.emv.EmvChipInsertStatus;
import com.miurasystems.transactions.emv.EmvTransactionException;
import com.miurasystems.transactions.emv.EmvTransactionSummary;
import com.miurasystems.transactions.emv.EmvTransactionType;
import com.miurasystems.transactions.magswipe.MagSwipeError;
import com.miurasystems.transactions.magswipe.MagSwipeSummary;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.core.Config;
import com.onepay.miura.core.MiuraApplication;
import com.onepay.miura.data.TransactionApiData;
import com.onepay.miura.transactions.EmvTransactionAsync;
import com.onepay.miura.transactions.MagSwipeTransaction;
import com.onepay.miura.transactions.MagSwipeTransactionAsync;

import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;

public class TransactionApi {
    private static final String TAG = TransactionApi.class.getSimpleName();
    private static TransactionApi instance = null;
    private float amount = 0f;
    private String description = "";
    private String bluetoothAddress = "";
    private String returnReason ="";
    private Timer mTimer;
    private int mTransactionTime = 60;
    private TransactionListener transactionListener;
    private Boolean transactionInProgress = false;
    private String pedDeviceId = "";
    private CardData cardData = null;
    private boolean isTimerTimedOut = false;
    private ConnectApi.DeviceConnectListener deviceConnectListener;
    private static final MpiEvents MPI_EVENTS = MiuraManager.getInstance().getMpiEvents();
    TransactionApiData transactionData = null;

    @Nullable
    private EmvTransactionAsync mEmvTransactionAsync;
    @Nullable
    private MagSwipeTransactionAsync mMagSwipeTransaction;


    public interface TransactionListener {
        void onTransactionComplete(TransactionApiData data);
    }

    public static TransactionApi getInstance() {
        if (instance == null) {
            instance = new TransactionApi();
        }
        return instance;
    }

    /**
     * Method that sets the transaction parameters
     * @param amt Payment amount for the transaction
     * @param desc Description for the transaction
     * @param btAddress Miura bluetooth device address
     * @param tOut Timeout for the transaction
     */
    public void setTransactionParams(float amt, String desc, String btAddress, int tOut) {
        startTransactionTimer();
        clearData();
        this.amount = amt * 100;
        if (description != null)
            this.description = desc;
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        this.mTransactionTime = tOut;
        transactionData = new TransactionApiData();
    }

    /**
     * Method that initiate for canceling transaction
     */
    public void cancelTransaction() {
        transactionInProgress = false;
        clearData();
        transactionData.setReturnStatus(3);
        if(mEmvTransactionAsync == null){
            Log.d(TAG, "Naga.....cancelTransaction: ");
            deregisterEventHandlers();
            BluetoothModule.getInstance().closeSession();

            if (transactionListener != null) {
                returnReason= "Abort success";
                transactionData.setReturnStatus(3);
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
            return;
        }
        boolean isChip = mEmvTransactionAsync != null;
        boolean isSwipe = mMagSwipeTransaction != null;

        MiuraDefaultListener listener = new MiuraDefaultListener() {
            @Override
            public void onSuccess() {
                Log.d(TAG, "Abort Success");
                deregisterEventHandlers();
                BluetoothModule.getInstance().closeSession();

                if (transactionListener != null) {
                    returnReason= "Abort success";
                    transactionData.setReturnStatus(3);
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }

            @Override
            public void onError() {
                Log.d(TAG, "Abort Failed");
                deregisterEventHandlers();
                BluetoothModule.getInstance().closeSession();

                if (transactionListener != null) {
                    returnReason= "Abort success";
                    transactionData.setReturnStatus(3);
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        };
        if (isChip) {
            abortEmvTransactionAsync(listener);
        } else {
            abortSwipeTransactionAsync(listener);
        }
    }

    /**
     * Method that initiates the transaction
     * @param listener callback listener for the transaction
     */
    public void performTransaction(final TransactionListener listener) {
        this.transactionListener = listener;
        if (bluetoothAddress.isEmpty() || amount == 0) {
            if (transactionListener != null) {
                returnReason= "Invalid Transaction parameters";
                transactionData.setReturnStatus(2);
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
            return;
        }
        if (transactionInProgress) {
            return;
        }
        transactionInProgress = true;

        setDeviceReconnectListener();
        ConnectApi.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void reConnectDevice(){
        ConnectApi.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }


    private void setDeviceReconnectListener(){
        deviceConnectListener = new ConnectApi.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "onConnectionSuccess: ");
                MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess(final ArrayList<Capability> capabilities) {
                        getDeviceCapabilities(capabilities);
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        BluetoothModule.getInstance().closeSession();

                    }
                });
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if(!isTimerTimedOut){
                    reConnectDevice();
                    return;
                }
                if (transactionListener != null) {
                    returnReason = "Bluetooth Connection Error";
                    transactionData.setReturnStatus(2);
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                if (transactionListener != null) {
                    returnReason = "Bluetooth Disconnected";
                    transactionData.setReturnStatus(2);
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        };
    }

    /**
     * Method that gets the miura device payment capabilities
     * @param capabilities list of capabilities supported
     */
    private void getDeviceCapabilities(ArrayList<Capability> capabilities) {
        ArrayList<String> keys = new ArrayList<>();

        for (Capability capability : capabilities) {
            String key = capability.getName();
            if (capability.getName() != null) {
                if (key.contains("Contactless")) {
                    startPayment();
                }
                keys.add(key);
            }
        }
        if (!(keys.contains("Contactless"))) {
            Log.d(TAG, "PED device doesn't support ContactLess");
            if (transactionListener != null) {
                returnReason = "PED device doesn't support ContactLess";
                transactionData.setReturnStatus(2);
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }

    }

    private void startPayment() {
        BluetoothModule.getInstance().setTimeoutEnable(true);
        BluetoothDevice device = BluetoothModule.getInstance().getSelectedBluetoothDevice();

        final boolean isPosDevice;
        if (device != null) {
            if (device.getName().toLowerCase().contains("pos")) {
                MiuraManager.getInstance().setDeviceType(MiuraManager.DeviceType.POS);
                isPosDevice = true;
            } else {
                MiuraManager.getInstance().setDeviceType(MiuraManager.DeviceType.PED);
                isPosDevice = false;
            }
            loadTransactionData(isPosDevice);
        }
    }

    private void loadTransactionData(final boolean isPosDevice) {
        MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

            @WorkerThread
            @Override
            public void onSuccess(SoftwareInfo softwareInfo) {
                pedDeviceId = softwareInfo.getSerialNumber();
            }

            @WorkerThread
            @Override
            public void onError() {
                //TODO check error
            }
        });

        MiuraManager.getInstance().executeAsync(new MiuraManager.AsyncRunnable() {
            @Override
            public void runOnAsyncThread(@NonNull MpiClient client) {

                if (isPosDevice) {
                    ArrayList<String> peripheralTypes = client.peripheralStatusCommand();
                    if (peripheralTypes == null) {
                        Log.d(TAG, "Peripheral Error");
                        BluetoothModule.getInstance().closeSession();

                        return;
                    } else if (!peripheralTypes.contains("PED")) {
                        Log.d(TAG, "PED not attached to POS");
                        BluetoothModule.getInstance().closeSession();
                        return;
                    }

                    // bit weird to do this, but it's what the old code did and we want to ensure
                    // calls still go when they are meant to go.
                    // There's also a threading issue here. Nothing else should be using
                    // MiuraManager at the same time as this is running, so it shouldn't be a
                    // problem.
                    MiuraManager.getInstance().setDeviceType(MiuraManager.DeviceType.PED);
                }

                BatteryData batteryData = client.getBatteryStatus();
                if (batteryData == null) {
                    Log.e(TAG, "Battery level check: Error");
                    BluetoothModule.getInstance().closeSession();

                    return;
                }
                Log.d(TAG, "Battery level check: Success");

                boolean b = client.systemLog(InterfaceType.MPI, SystemLogMode.Remove);
                if (!b) {
                    Log.d(TAG, "Delete Log: Error");
                    BluetoothModule.getInstance().closeSession();

                    return;
                }
                Log.d(TAG, "Delete Log: Success");

                Date dateTime = client.systemClock(InterfaceType.MPI);
                if (dateTime == null) {
                    Log.e(TAG, "Get Time: Error");
                    BluetoothModule.getInstance().closeSession();

                    return;
                }
                Log.d(TAG, "Get Time: Success");

                SoftwareInfo softwareInfo = client.resetDevice(
                        InterfaceType.MPI, ResetDeviceType.Soft_Reset);
                if (softwareInfo == null) {
                    Log.e(TAG, "Get Software Info: Error");
                    BluetoothModule.getInstance().closeSession();

                    return;
                }
                Log.e(TAG, "Get Software Info: Success");

                HashMap<String, String> versionMap = client.getConfiguration();
                if (versionMap == null) {
                    Log.e(TAG, "Get PED config: Error");
                    BluetoothModule.getInstance().closeSession();

                    return;
                }

                if (!versionMap.containsValue(Config.getConfigVersion())) {
                    Log.e(TAG, "Please update config files");
                } else {
                    Log.d(TAG, "Get PED Config: Success");
                }
                performTransaction();
            }
        });
    }

    private void performTransaction() {
        Log.d(TAG, "Starting Transaction");

        String deviceText = amount + "\n Swipe card";

        MiuraManager.getInstance().displayText(
                deviceText,
                new MiuraDefaultListener() {
                    @Override
                    public void onSuccess() {
                        registerEventHandlers();
                        MiuraManager.getInstance().cardStatus(true);
                    }

                    @Override
                    public void onError() {
                    }
                });
        /*registerEventHandlers();
        MiuraManager.getInstance().cardStatus(true);
        startEmvTransaction(EmvTransactionType.Contactless);*/
    }

    private final MpiEventHandler<CardData> mCardEventHandler = new MpiEventHandler<CardData>() {

        @Override
        public void handle(@NonNull CardData cardData) {
            Log.d(TAG, "cardData " + cardData);
            handleTransactionEvent(cardData);
        }
    };

    private final MpiEventHandler<DeviceStatusChange> mDeviceStatusHandler =
            new MpiEventHandler<DeviceStatusChange>() {
                @Override
                public void handle(DeviceStatusChange arg) {
                    DeviceStatus status = arg.deviceStatus;
                    final String text = arg.statusText;
                    Log.d(TAG, String.format(Locale.ENGLISH,
                            "Device status: '%s'. Text status %s", status.name(), text)
                    );
                }
            };

    private void registerEventHandlers() {
        MPI_EVENTS.CardStatusChanged.register(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.register(mDeviceStatusHandler);
    }


    private void startEmvTransaction(EmvTransactionType emvTransactionType) {
        mEmvTransactionAsync = new EmvTransactionAsync(
                MiuraManager.getInstance(), emvTransactionType
        );

        mEmvTransactionAsync.startTransactionAsync(
                (int) this.amount,
                MiuraApplication.currencyCode.getValue(),
                new EmvTransactionAsync.Callback() {
                    @Override
                    public void publishStartTransactionResult(@NonNull final String response) {
                        Log.d(TAG, "Start transaction success");
                    }

                    @Override
                    public void onSuccess(@NonNull final EmvTransactionSummary result) {
                        Log.d(TAG, "onSuccess: continue transaction success");
                    }

                    @Override
                    public void onError(@NonNull EmvTransactionException exception) {
                        TransactionResponse response = exception.mErrCode;
                        String explanation = exception.getMessage();

                        Log.d(TAG, String.format("onError(%s, %s)", response, explanation));

                        String text;
                        if (exception.getMessage() == null) {
                            text = "Transaction error";
                        } else {
                            text = explanation;
                        }

                        if (response != TransactionResponse.UNKNOWN) {
                            text += ": " + response;
                        }
                        resetTransactionState();
                    }
                });
    }

    private void abortEmvTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "abortEmvTransactionAsync");
        if (mEmvTransactionAsync == null) {
            Log.d(TAG, "abortEmvTransactionAsync: mEmvTransactionAsync == null");
            return;
        }
        mEmvTransactionAsync.abortTransactionAsync(listener);
        //mEmvTransactionAsync = null;
    }

    private void abortSwipeTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "abortSwipeTransactionAsync");

        if (mMagSwipeTransaction == null) {
            Log.d(TAG, "abortSwipeTransaction: mMagSwipeTransaction == null");
            return;
        }
        mMagSwipeTransaction.abortTransactionAsync(listener);
        //mMagSwipeTransaction = null;
    }


    protected void handleTransactionEvent(CardData cardData) {
        if (!BluetoothModule.getInstance().isSessionOpen()) {
            return;
        }

        EmvChipInsertStatus insertStatus = EmvTransactionAsync.canProcessEmvChip(cardData);
        if (insertStatus == EmvChipInsertStatus.CardInsertedOk) {
            //startEmvTransaction(EmvTransactionType.Chip);

            return;
        }

        Result<MagSwipeSummary, MagSwipeError> result =
                MagSwipeTransaction.canProcessMagSwipe(cardData);
        if (result.isError()) {
            MagSwipeError error = result.asError().getError();
            resetTransactionState();
            //transactionListener.onTransactionError("SWIPE ERROR Please try again");
            Log.d(TAG, "SWIPE ERROR Please try again");
            return;
        }

        this.cardData = cardData;
        if (transactionListener != null) {
            transactionListener.onTransactionComplete(createTransactionData(cardData));
        }
        BluetoothModule.getInstance().closeSession();
        clearTransactionData();
        clearData();
    }


    private void deregisterEventHandlers() {
        MPI_EVENTS.CardStatusChanged.deregister(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.deregister(mDeviceStatusHandler);
    }

    private void resetTransactionState() {
        transactionInProgress = false;
    }

    private TransactionApiData createTransactionData(CardData cardData) {

        transactionData.setDeviceId(pedDeviceId);
        transactionData.setAmount(this.amount);
        transactionData.setReturnReason(returnReason);
        transactionData.setDeviceCode("41");
        if (cardData != null) {
            transactionData.setCardHolderName(cardData.getCardholderName());
            if (cardData.getMaskedTrack2Data() != null) {
                transactionData.setExpiryDate(cardData.getMaskedTrack2Data().getExpirationDate());
                transactionData.setCardNumber(cardData.getMaskedTrack2Data().mPan);
                String number = cardData.getMaskedTrack2Data().mPan;

                if (!number.isEmpty() && number.length() > 4) {
                    transactionData.setAccountFirstFour(number.substring(0, 4));
                    transactionData.setAccountLastFour(number.substring(number.length() - 4));
                }
            }
            transactionData.setMaskedTrack2Data(cardData.getMaskedTrack2Data().toString());
            transactionData.setKSN(cardData.getSredKSN().toUpperCase());
            transactionData.setEncryptedCardData(cardData.getSredData().toUpperCase());
            //transactionData.setTransactionType("Swipe");
            transactionData.setReturnStatus(1);
        } else {
            transactionData.setReturnStatus(2);
        }
        transactionInProgress = true;
        return transactionData;
    }

    /**
     * Transaction Timer
     */
    private void startTransactionTimer() {
        isTimerTimedOut = false;
        cancelTransactionTimer();
        mTimer = new Timer();
        mTimer.schedule(new TimerTask() {
            public void run() {
                isTimerTimedOut = true;
                cancelTransaction();
                this.cancel();
            }
        }, mTransactionTime * 1000);
    }

    private void cancelTransactionTimer() {
        if (mTimer != null) {
            mTimer.cancel();
            mTimer = null;
        }
    }

    /**
     * Method that reset the transaction parameters
     */
    private void clearTransactionData(){
        mEmvTransactionAsync = null;
        mMagSwipeTransaction = null;
        transactionInProgress = false;
        cancelTransactionTimer();
    }

    /**
     * Method that reset the transaction status
     */
    public void clearData() {
        this.pedDeviceId = "";
        this.amount = 0.0f;
        this.description = "";
        this.cardData = null;
    }
}
