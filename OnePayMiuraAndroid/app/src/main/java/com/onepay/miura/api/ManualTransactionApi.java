package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.util.Log;

import androidx.annotation.NonNull;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.objects.BatteryData;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.miurasystems.mpi.enums.DeviceStatus;
import com.miurasystems.mpi.enums.GetEncryptedPanError;
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SystemLogMode;
import com.miurasystems.mpi.events.DeviceStatusChange;
import com.miurasystems.mpi.events.MpiEventHandler;
import com.miurasystems.mpi.events.MpiEvents;
import com.miurasystems.mpi.tlv.CardData;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.core.Config;
import com.onepay.miura.data.TransactionApiData;
import com.onepay.miura.transactions.ManualTransactionAsync;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;

public class ManualTransactionApi {
    private static final String TAG = ManualTransactionApi.class.getSimpleName();
    private static ManualTransactionApi instance = null;
    private ManualTransactionListener manualTransactionListener;
    private String returnReason = "";
    private double amount = 0f;
    private String description = "";
    private String bluetoothAddress = "";
    private String pedDeviceId = "";
    private String expireDate = null;
    private boolean isEbt = false;
    private Timer mTimer;
    private int mTransactionTime = 60;
    private int returnStatus = 0;
    private String entryMode = Constants.Manual;
    private boolean isTimerTimedOut = false;
    private boolean isCvv = false;
    private boolean isTransactionTimeOut = false;
    private ManualTransactionAsync mManualTransactionAsync;
    private TransactionApiData transactionData = null;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
    private static final MpiEvents MPI_EVENTS = MiuraManager.getInstance().getMpiEvents();
    private EncryptedPan data = null;
    private static DecimalFormat decimalFormat = new DecimalFormat("#.##");
    private boolean isTransactionDataCheck = false;

    public interface ManualTransactionListener {
        void onManualTransactionComplete(TransactionApiData data);
    }

    public static ManualTransactionApi getInstance() {
        if (instance == null) {
            instance = new ManualTransactionApi();
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
    public void setManualTransactionParams(double amt, String desc, String btAddress, int tOut, boolean isEbt, boolean isCvvRequired) {
        Log.d(TAG, "###RB#### setManualTransactionParams: ");

        clearData();
        amt = Double.parseDouble(decimalFormat.format(amt));
        this.amount = amt;
        if (description != null)
            this.description = desc;
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        this.mTransactionTime = tOut;
        this.isCvv = isCvvRequired;
        this.isEbt = isEbt;

        isTransactionDataCheck = false;
        transactionData = new TransactionApiData();
    }

    /**
     * Method that initiates the transaction
     *
     * @param listener callback listener for the transaction
     */
    public void performManualTransaction(ManualTransactionListener listener) {
        Log.d(TAG, "###RB#### performManualTransaction: ");
        startTransactionTimer();
        isTransactionTimeOut = false;
        this.manualTransactionListener = listener;
        if (bluetoothAddress.isEmpty() || amount == 0) {
            if (manualTransactionListener != null) {
                returnReason = Constants.InvalidParametersReason;
                returnStatus = Constants.InvalidParametersStatus;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
            return;
        }

        if (BluetoothModule.getInstance().isSessionOpen()) {
            startPayment();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    private void reConnectDevice() {
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }


    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d(TAG, "###RB#### onConnectionSuccess: ");
                Log.d("TAG", "onConnectionSuccess: ");
                MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess(final ArrayList<Capability> capabilities) {
                        startPayment();
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
                Log.d(TAG, "###RB#### onConnectionError: ");
                Log.d("TAG", "onConnectionError: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }

                if (manualTransactionListener != null) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d(TAG, "###RB#### onDeviceDisconnected: ");
                Log.d("TAG", "onDeviceDisconnected: ");

                if (manualTransactionListener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                }
            }
        };
    }

    public void cancelTransaction() {
        Log.d(TAG, "###RB#### cancelTransaction: ");
        try {
            if (mManualTransactionAsync != null) {
                mManualTransactionAsync.abortManualTransaction();
            }

        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.AbortException;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

    public void updateManualTransactionStatus(){
        deregisterEventHandlers();
        isTransactionDataCheck = false;
        if (manualTransactionListener != null) {
            if (isTransactionTimeOut) {
                returnReason = Constants.TimeoutReason;
                returnStatus = Constants.TimeoutStatus;
            } else {
                returnReason = Constants.CancelReason;
                returnStatus = Constants.CancelStatus;
            }
            manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
        }
        clearData();
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
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
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

                    performTransaction();
                }
            });
        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

    private void performTransaction() {
        Log.d(TAG, "###RB#### performTransaction: ");
        try {
            Log.d(TAG, "Starting Transaction");
            registerEventHandlers();
            MiuraManager.getInstance().cardStatus(true);
            startManualTransaction();
        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

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
        try {
            MPI_EVENTS.CardStatusChanged.register(mCardEventHandler);
            MPI_EVENTS.DeviceStatusChanged.register(mDeviceStatusHandler);
        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

    private final MpiEventHandler<CardData> mCardEventHandler = new MpiEventHandler<CardData>() {
        @Override
        public void handle(@NonNull CardData cardData) {
            Log.d(TAG, "###RB#### Mpi event handler: ");
            Log.d(TAG, "cardData " + cardData);
            handleTransactionEvent();
        }
    };

    protected void handleTransactionEvent() {
        Log.d(TAG, "###RB#### handleTransactionEvent: ");
        try {
            if (!BluetoothModule.getInstance().isSessionOpen()) {
                return;
            }
            startManualTransaction();
        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

    private void startManualTransaction() {
        Log.d(TAG, "###RB#### startManualTransaction: ");
        try {
            mManualTransactionAsync = new ManualTransactionAsync(MiuraManager.getInstance());
            mManualTransactionAsync.manualTransaction(isEbt, mTransactionTime, isCvv);

            if (mManualTransactionAsync.isUserCanceled) {
                if (manualTransactionListener != null && !isTransactionDataCheck) {
                    returnReason = mManualTransactionAsync.mReturnReason;
                    returnStatus = mManualTransactionAsync.mReturnStatus;
                    manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                }
                BluetoothModule.getInstance().closeSession();
                clearTransactionData();
                clearData();
                return;
            }

            Result<EncryptedPan, GetEncryptedPanError> result = mManualTransactionAsync.result;

            try {
                data = result.asSuccess().getValue();
                expireDate = mManualTransactionAsync.mExpireDate;
                int date = 0;
                if (!checkExpireDate(expireDate).isEmpty() ) {
                    date = Integer.parseInt(checkExpireDate(expireDate));
                }

                if (date > 12 && !isEbt) {
                    if (manualTransactionListener != null && !isTransactionDataCheck) {
                        returnReason = Constants.InvalidExpireDateReason;
                        returnStatus = Constants.InvalidExpireDateStatus;
                        manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                    }
                } else if (data != null) {
                    if (manualTransactionListener != null && !isTransactionDataCheck) {
                        returnReason = Constants.SuccessReason;
                        returnStatus = Constants.SuccessStatus;
                        manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                    }
                }
            } catch (Exception e) {
                if (manualTransactionListener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
                }
            }

            BluetoothModule.getInstance().closeSession();
            clearTransactionData();
            clearData();
        } catch (Exception e) {
            if (manualTransactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                manualTransactionListener.onManualTransactionComplete(createTransactionData(data));
            }
        }
    }

    private TransactionApiData createTransactionData(EncryptedPan data) {
        Log.d(TAG, "###RB#### createTransactionData: ");
        isTransactionDataCheck = true;
        transactionData.setDeviceId(pedDeviceId);
        transactionData.setAmount(this.amount);
        transactionData.setReturnReason(returnReason);
        transactionData.setReturnStatus(returnStatus);
        transactionData.setDeviceCode("41");
        transactionData.setEntryMode(entryMode);
        if (data != null) {
            transactionData.setExpiryDate(expireDate);
            if (data.RedactedPan != null) {
                transactionData.setCardNumber(data.RedactedPan);
                String number = data.RedactedPan;

                if (!number.isEmpty() && number.length() > 4) {
                    transactionData.setAccountFirstFour(number.substring(0, 4));
                    transactionData.setAccountLastFour(number.substring(number.length() - 4));
                }
            }
            String ksn = bytesToHexString(data.P2peSredKsn);
            String cardEncytpedData = bytesToHexString(data.P2peSredData);
            transactionData.setKSN(ksn.toUpperCase());
            transactionData.setEncryptedCardData(cardEncytpedData.toUpperCase());
        } else {
            transactionData.setReturnStatus(returnStatus);
        }
        cancelTransactionTimer();
        return transactionData;
    }

    private static String bytesToHexString(byte[] src) {
        Log.d(TAG, "###RB#### bytesToHexString: ");
        StringBuilder stringBuilder = new StringBuilder("");
        if (src == null || src.length <= 0) {
            return null;
        }
        char[] buffer = new char[2];
        for (int i = 0; i < src.length; i++) {
            buffer[0] = Character.forDigit((src[i] >>> 4) & 0x0F, 16);
            buffer[1] = Character.forDigit(src[i] & 0x0F, 16);
            stringBuilder.append(buffer);
        }
        return stringBuilder.toString();
    }

    private static String checkExpireDate(String expireDate) {
        if (expireDate.length() > 2) {
            expireDate = expireDate.substring(0, 2);
        }
        return expireDate;
    }

    private void deregisterEventHandlers() {
        Log.d(TAG, "###RB#### deregisterEventHandlers: ");
        MPI_EVENTS.CardStatusChanged.deregister(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.deregister(mDeviceStatusHandler);
    }

    /**
     * Transaction Timer
     */
    private void startTransactionTimer() {
        Log.d(TAG, "###RB#### startTransactionTimer: ");
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
        mManualTransactionAsync = null;
        cancelTransactionTimer();
    }

    /**
     * Method that reset the transaction status
     */
    private void clearData() {
        cancelTransactionTimer();
        this.pedDeviceId = "";
        this.amount = 0.0d;
        this.description = "";
        this.isCvv = false;
        this.data = null;
        this.returnReason = "";
        this.returnStatus = 0;
        isTransactionTimeOut = false;
    }
}