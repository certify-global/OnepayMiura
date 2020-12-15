package com.onepay.miuralibrary.api;

import android.bluetooth.BluetoothDevice;
import android.util.Log;
import android.util.Base64;

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
import com.onepay.miuralibrary.bluetooth.BluetoothConnect;
import com.onepay.miuralibrary.bluetooth.BluetoothModule;
import com.onepay.miuralibrary.core.Config;
import com.onepay.miuralibrary.data.TransactionData;
import com.onepay.miuralibrary.transactions.MagSwipeTransactionAsync;

import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;

public class ManualTransaction {

    private static final String TAG = ManualTransaction.class.getSimpleName();
    private static ManualTransaction instance = null;
    private ManualTransactionListener manualTransactionListener;
    private String returnReason = "";
    private float amount = 0f;
    private String description = "";
    private String bluetoothAddress = "";
    private String pedDeviceId = "";
    private MagSwipeTransactionAsync mEmvTransactionAsync;
    private static final MpiEvents MPI_EVENTS = MiuraManager.getInstance().getMpiEvents();

    public interface ManualTransactionListener {
        void onManualTransactionSuccess(TransactionData data);

        void onManualTransactionError(String errorMessage);

        void onManualTransactionAborted(boolean status);
    }

    public static ManualTransaction getInstance() {
        if (instance == null) {
            instance = new ManualTransaction();
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
    public void setManualTransactionParams(float amt, String desc, String btAddress, int tOut) {
        this.amount = amt * 100;
        if (description != null)
            this.description = desc;
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
    }

    /**
     * Method that initiates the transaction
     *
     * @param listener callback listener for the transaction
     */
    public void performManualTransaction(ManualTransactionListener listener) {
        this.manualTransactionListener = listener;
        if (bluetoothAddress.isEmpty() || amount == 0) {
            if (listener != null) {
                //listener.onManualTransactionSuccess("Invalid Transaction parameters");
            }
            return;
        }

        BluetoothConnect.getInstance().connect(this.bluetoothAddress, new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
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
                Log.d("TAG", "onConnectionError: ");
                if (manualTransactionListener != null) {
                    manualTransactionListener.onManualTransactionError("Bluetooth Connection Error");
                    returnReason = "Bluetooth Connection Error";
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");
                if (manualTransactionListener != null) {
                    manualTransactionListener.onManualTransactionError("Bluetooth Disconnected");
                    returnReason = "Bluetooth Disconnected";
                }
            }
        });
    }

    public void cancelTransaction() {
        deregisterEventHandlers();
        BluetoothModule.getInstance().closeSession();
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
        registerEventHandlers();
        MiuraManager.getInstance().cardStatus(true);
        startManualTransaction();
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
        MPI_EVENTS.CardStatusChanged.register(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.register(mDeviceStatusHandler);
    }

    private final MpiEventHandler<CardData> mCardEventHandler = new MpiEventHandler<CardData>() {
        @Override
        public void handle(@NonNull CardData cardData) {
            Log.d(TAG, "cardData " + cardData);
            handleTransactionEvent(cardData);
        }
    };

    protected void handleTransactionEvent(CardData cardData) {
        if (!BluetoothModule.getInstance().isSessionOpen()) {
            return;
        }
        startManualTransaction();
    }

    private void startManualTransaction() {
        mEmvTransactionAsync = new MagSwipeTransactionAsync(MiuraManager.getInstance());
        mEmvTransactionAsync.manualTransaction();

        Result<EncryptedPan, GetEncryptedPanError> result = mEmvTransactionAsync.result;
        EncryptedPan data = result.asSuccess().getValue();
        manualTransactionListener.onManualTransactionSuccess(createTransactionData(data));

        //ClearData
        BluetoothModule.getInstance().closeSession();
    }

    private TransactionData createTransactionData(EncryptedPan data) {
        TransactionData transactionData = new TransactionData();

        transactionData.setDeviceId(pedDeviceId);
        transactionData.setAmount(this.amount);
        transactionData.setReturnReason(returnReason);
        transactionData.setDeviceCode("41");
        if (data != null) {
            if (data.RedactedPan != null) {
                transactionData.setCardNumber(data.RedactedPan);
                String number = data.RedactedPan;

                if (!number.isEmpty() && number.length() > 4) {
                    transactionData.setAccountFirstFour(number.substring(0, 4));
                    transactionData.setAccountLastFour(number.substring(number.length() - 4));
                }
            }
            String ksn = bytesToHexString(data.P2peSredKsn);
            String cardEncytpedData =  bytesToHexString(data.P2peSredData);
            transactionData.setKSN(ksn.toUpperCase());
            transactionData.setCardData(cardEncytpedData.toUpperCase());
            transactionData.setReturnStatus(true);
        } else {
            transactionData.setReturnStatus(false);
        }
        return transactionData;
    }

    public static String bytesToHexString(byte[] src) {
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

    private void deregisterEventHandlers() {
        MPI_EVENTS.CardStatusChanged.deregister(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.deregister(mDeviceStatusHandler);
    }

    // ClearData
}
