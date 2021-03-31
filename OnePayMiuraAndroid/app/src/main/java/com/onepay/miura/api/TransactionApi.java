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
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.miurasystems.mpi.enums.DeviceStatus;
import com.miurasystems.mpi.events.DeviceStatusChange;
import com.miurasystems.mpi.events.MpiEventHandler;
import com.miurasystems.mpi.events.MpiEvents;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.transactions.emv.EmvChipInsertStatus;
import com.miurasystems.transactions.magswipe.MagSwipeError;
import com.miurasystems.transactions.magswipe.MagSwipeSummary;
import com.miurasystems.transactions.magswipe.MagSwipeTransactionException;
import com.miurasystems.transactions.magswipe.OnlinePinSummary;
import com.miurasystems.transactions.magswipe.PaymentMagType;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.core.MiuraApplication;
import com.onepay.miura.data.TransactionApiData;
import com.onepay.miura.transactions.EmvTransactionAsync;
import com.onepay.miura.transactions.MagSwipeTransaction;
import com.onepay.miura.transactions.MagSwipeTransactionAsync;
import com.onepay.miura.transactions.SignatureSummary;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class TransactionApi {
    private static final String TAG = TransactionApi.class.getSimpleName();
    private static TransactionApi instance = null;
    private double amount = 0.00d;
    private String description = "";
    private String bluetoothAddress = "";
    private String returnReason = "";
    private int returnStatus = 0;
    private String entryMode = Constants.Swipe;
    private Timer mTimer;
    private int mTransactionTime = 60;
    private TransactionListener transactionListener;
    private Boolean transactionInProgress = false;
    private String pedDeviceId = "";
    private CardData cardData = null;
    private boolean isTimerTimedOut = false;
    private boolean isTransactionTimeOut = false;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
    private static final MpiEvents MPI_EVENTS = MiuraManager.getInstance().getMpiEvents();
    private TransactionApiData transactionData = null;
    private static DecimalFormat decimalFormat = new DecimalFormat("#.##");
    private boolean isPinRequired = false;
    private String pinKsn = "";
    private String pinData = "";

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
     *
     * @param amt       Payment amount for the transaction
     * @param desc      Description for the transaction
     * @param btAddress Miura bluetooth device address
     * @param tOut      Timeout for the transaction
     */
    public void setTransactionParams(double amt, String desc, String btAddress, boolean isPinRequired, int tOut) {
        Log.d(TAG, "###RB#### set transaction parameters ");
        clearData();
        isTransactionTimeOut = false;
        amt = Double.parseDouble(decimalFormat.format(amt));
        this.amount = amt;
        this.isPinRequired = isPinRequired;
        if (description != null)
            this.description = desc;
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        this.mTransactionTime = tOut;
        transactionData = new TransactionApiData();
    }

    /**
     * Method that initiates the transaction
     *
     * @param listener callback listener for the transaction
     */
    public void performTransaction(final TransactionListener listener) {
        Log.d(TAG, "###RB#### perform transaction: ");
        startTransactionTimer();
        this.transactionListener = listener;
        if (bluetoothAddress.isEmpty() || amount == 0) {
            if (transactionListener != null) {
                returnReason = Constants.InvalidParametersReason;
                returnStatus = Constants.InvalidParametersStatus;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
            return;
        }

        if (BluetoothModule.getInstance().isSessionOpen()) {
            getDeviceInfo();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    private void reConnectDevice() {
        Log.d(TAG, "###RB#### reconnecting the device: ");
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "###RB#### onConnection Success ");
                getDeviceInfo();
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "###RB#### on Connection Error: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (transactionListener != null) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                if (transactionListener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        };
    }

    /**
     * Method that initiate for canceling transaction
     */
    public void cancelTransaction() {
        Log.d(TAG, "###RB#### cancelTransaction: ");
        try {
            transactionInProgress = false;

            boolean isChip = mEmvTransactionAsync != null;
            boolean isSwipe = mMagSwipeTransaction != null;

            if (!isChip && !isSwipe) {
                closeBtSession();

                if (transactionListener != null) {
                    if (isTransactionTimeOut) {
                        returnReason = Constants.TimeoutReason;
                        returnStatus = Constants.TimeoutStatus;
                    } else {
                        returnReason = Constants.CancelReason;
                        returnStatus = Constants.CancelStatus;
                    }

                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
                return;
            }

            MiuraDefaultListener listener = new MiuraDefaultListener() {
                @Override
                public void onSuccess() {
                    Log.d(TAG, "Abort Success");
                    closeBtSession();

                    if (transactionListener != null) {
                        if (isTransactionTimeOut) {
                            returnReason = Constants.TimeoutReason;
                            returnStatus = Constants.TimeoutStatus;
                        } else {
                            returnReason = Constants.CancelReason;
                            returnStatus = Constants.CancelStatus;
                        }
                        transactionListener.onTransactionComplete(createTransactionData(cardData));
                    }
                }

                @Override
                public void onError() {
                    Log.d(TAG, "Abort Failed");
                    closeBtSession();

                    if (transactionListener != null) {
                        returnReason = Constants.CancelReason;
                        returnStatus = Constants.CancelStatus;
                        transactionListener.onTransactionComplete(createTransactionData(cardData));
                    }
                }
            };
            if (isChip) {
                abortEmvTransactionAsync(listener);
            } else {
                abortSwipeTransactionAsync(listener);
            }
            clearData();
        } catch (Exception e) {
            /*if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.AbortException;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }*/
        }
    }

    private void getDeviceInfo() {
        startTransactionTimer();
        MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
            @WorkerThread
            @Override
            public void onSuccess(final ArrayList<Capability> capabilities) {
                getDeviceCapabilities(capabilities);
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "###RB#### get Device Info ");
            }
        });
    }

    /**
     * Method that gets the miura device payment capabilities
     *
     * @param capabilities list of capabilities supported
     */
    private void getDeviceCapabilities(ArrayList<Capability> capabilities) {
        Log.d(TAG, "###RB#### getDeviceCapabilities: ");
        try {
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
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void startPayment() {
        Log.d(TAG, "###RB#### startPayment: ");
        try {
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
        } catch (Exception e) {
            Log.d(TAG, "###RB#### startPayment: " + e.toString());
        }
    }

    private void loadTransactionData(final boolean isPosDevice) {
        Log.d(TAG, "###RB#### loadTransactionData: ");
        try {
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

            performTransaction();
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void performTransaction() {
        Log.d(TAG, "###RB#### performTransaction: ");
        try {
            Log.d(TAG, "Starting Transaction");

            String deviceText = amount + "\n Swipe card";

            MiuraManager.getInstance().displayText(
                    deviceText,
                    new MiuraDefaultListener() {
                        @Override
                        public void onSuccess() {
                            registerEventHandlers();
                            MpiClient client = MiuraManager.getInstance().getMpiClient();
                            if (client != null) {
                                client.cardStatus(MPI, true, false, true, true, false, true);
                            }
                            //MiuraManager.getInstance().cardStatus(true);
                        }

                        @Override
                        public void onError() {
                        }
                    });
        } catch (Exception e) {
            Log.d(TAG, "performTransaction: " + e.toString());
        }
    }

    private final MpiEventHandler<CardData> mCardEventHandler = new MpiEventHandler<CardData>() {

        @Override
        public void handle(@NonNull CardData cardData) {
            Log.d(TAG, "###RB#### MpiEventhandler: ");
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
        Log.d(TAG, "###RB#### registerEventHandlers: ");
        MPI_EVENTS.CardStatusChanged.register(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.register(mDeviceStatusHandler);
    }

    private void abortEmvTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "###RB#### abortEmvTransactionAsync: ");
        try {
            Log.d(TAG, "abortEmvTransactionAsync");
            if (mEmvTransactionAsync == null) {
                Log.d(TAG, "abortEmvTransactionAsync: mEmvTransactionAsync == null");
                return;
            }
            mEmvTransactionAsync.abortTransactionAsync(listener);
            //mEmvTransactionAsync = null;
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void abortSwipeTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "###RB#### abortSwipeTransactionAsync: ");
        try {
            Log.d(TAG, "abortSwipeTransactionAsync");

            if (mMagSwipeTransaction == null) {
                Log.d(TAG, "abortSwipeTransaction: mMagSwipeTransaction == null");
                return;
            }
            mMagSwipeTransaction.abortTransactionAsync(listener);
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    protected void handleTransactionEvent(CardData cardData) {
        Log.d(TAG, "###RB#### handleTransactionEvent: ");
        try {
            if (!BluetoothModule.getInstance().isSessionOpen()) {
                return;
            }

            EmvChipInsertStatus insertStatus = EmvTransactionAsync.canProcessEmvChip(cardData);
            if (insertStatus == EmvChipInsertStatus.CardInsertedOk) {
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

            if (isPinRequired) {
                PaymentMagType paymentMagType = PaymentMagType.Pin;
                MagSwipeSummary magSwipeSummary = result.asSuccess().getValue();
                startSwipeTransaction(magSwipeSummary, paymentMagType, cardData);
            } else {
                this.cardData = cardData;
                if (transactionListener != null) {
                    returnReason = Constants.SuccessReason;
                    returnStatus = Constants.SuccessStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
                closeBtSession();
                clearTransactionData();
                clearData();
            }
        } catch (Exception e) {
            Log.d(TAG, "handleTransactionEvent: ");
        }
    }

    protected void startSwipeTransaction(
            MagSwipeSummary magSwipeSummary,
            PaymentMagType paymentMagType,
            final CardData cardData
    ) {

        abortEmvTransactionAsync(null);
        abortSwipeTransactionAsync(null);

        mMagSwipeTransaction = new MagSwipeTransactionAsync(MiuraManager.getInstance(), paymentMagType);
        mMagSwipeTransaction.startTransactionAsync(
                magSwipeSummary,
                amount * 100,
                MiuraApplication.currencyCode.getValue(),
                new MagSwipeTransactionAsync.Callback() {

                    @Override
                    public void onPinSuccess(@NonNull MagSwipeSummary magSwipeSummary, @NonNull OnlinePinSummary onlinePinSummary) {

                        pinKsn = onlinePinSummary.mPinKSN;
                        pinData = onlinePinSummary.mPinData;

                        if (transactionListener != null) {
                            returnReason = Constants.SuccessReason;
                            returnStatus = Constants.SuccessStatus;
                            transactionListener.onTransactionComplete(createTransactionData(cardData));
                        }

                        closeBtSession();
                        clearTransactionData();
                        clearData();
                    }

                    @NonNull
                    @Override
                    public SignatureSummary getSignatureFromUser() throws MagSwipeTransactionException {
                        return null;
                    }

                    @Override
                    public void onSignatureSuccess(@NonNull MagSwipeSummary magSwipeSummary, @NonNull SignatureSummary signature) {

                    }

                    @Override
                    public void onError(@NonNull MagSwipeTransactionException exception) {
                    }
                });
    }

    private void deregisterEventHandlers() {
        Log.d(TAG, "###RB#### deregisterEventHandlers: ");
        try {
            MPI_EVENTS.CardStatusChanged.deregister(mCardEventHandler);
            MPI_EVENTS.DeviceStatusChanged.deregister(mDeviceStatusHandler);
        } catch (Exception e) {
            Log.d(TAG, "deregisterEventHandlers: " + e.toString());
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void resetTransactionState() {
        transactionInProgress = false;
    }

    private TransactionApiData createTransactionData(CardData cardData) {
        if (pedDeviceId != null) {
            transactionData.setDeviceId(pedDeviceId);
            transactionData.setAmount(this.amount);
            transactionData.setReturnReason(returnReason);
            transactionData.setReturnStatus(returnStatus);
            transactionData.setDeviceCode("41");
            if (cardData != null) {
                transactionData.setEntryMode(entryMode);
                transactionData.setCardHolderName(cardData.getCardholderName());
                if (cardData.getMaskedTrack2Data() != null) {
                    if (cardData.getMaskedTrack2Data().getExpirationDate() != null) {
                        String expireDate = expireDate(cardData.getMaskedTrack2Data().getExpirationDate());
                        transactionData.setExpiryDate(expireDate);
                    }
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

                transactionData.setPinData(pinData);
                transactionData.setPinKsn(pinKsn);
            }
        }
        cancelTransactionTimer();
        return transactionData;
    }

    private String expireDate(String expireNumber) {
        int number = Integer.parseInt(expireNumber);
        String firstTwo = Integer.toString(number / 100);
        if (firstTwo.length() < 2) {
            firstTwo = "0" + firstTwo;
        }
        String lastTwo = Integer.toString(number % 100);
        if (lastTwo.length() < 2) {
            lastTwo = "0" + lastTwo;
        }

        expireNumber = lastTwo + firstTwo;
        return expireNumber;
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
                isTransactionTimeOut = true;
                isTimerTimedOut = true;
                cancelTransaction();
                this.cancel();
            }
        }, mTransactionTime * 1000);
    }

    private void closeBtSession() {
        if (mEmvTransactionAsync == null) {
            deregisterEventHandlers();
            BluetoothModule.getInstance().closeSession();
        }
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
    private void clearTransactionData() {
        mEmvTransactionAsync = null;
        mMagSwipeTransaction = null;
        transactionInProgress = false;
        cancelTransactionTimer();
    }

    /**
     * Method that reset the transaction status
     */
    private void clearData() {
        cancelTransactionTimer();
        transactionData = null;
        isTransactionTimeOut = false;
        this.pedDeviceId = "";
        this.amount = 0.0d;
        this.description = "";
        this.cardData = null;
        this.returnReason = "";
        this.returnStatus = 0;
    }
}