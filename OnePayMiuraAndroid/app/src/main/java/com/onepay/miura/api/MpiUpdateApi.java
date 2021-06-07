package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.content.Context;
import android.util.Log;
import android.util.Pair;

import androidx.annotation.AnyThread;
import androidx.annotation.NonNull;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiBatteryStatusListener;
import com.miurasystems.mpi.api.listener.ApiGetConfigListener;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSystemClockListener;
import com.miurasystems.mpi.api.listener.ApiP2PEStatusListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.api.objects.P2PEStatus;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.enums.DeviceStatus;
import com.miurasystems.mpi.enums.GetEncryptedPanError;
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SelectFileMode;
import com.miurasystems.mpi.events.DeviceStatusChange;
import com.miurasystems.mpi.events.MpiEventHandler;
import com.miurasystems.mpi.events.MpiEvents;
import com.miurasystems.mpi.tlv.CardData;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothDeviceType;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.data.MpiUpdateApiData;
import com.onepay.miura.data.TransactionApiData;
import com.onepay.miura.transactions.ManualTransactionAsync;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.text.DateFormat;
import java.text.DecimalFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;
import java.util.zip.GZIPInputStream;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class MpiUpdateApi {
    private static final String TAG = MpiUpdateApi.class.getSimpleName();
    private static MpiUpdateApi instance = null;
    private MpiUpdateListener mpiUpdateListener;
    private String bluetoothAddress = "";
    private int mTimeOut = 60;
    private boolean isTimerTimedOut = false;
    private boolean isTimeOut = false;
    private MpiUpdateApiData mpiUpdateData = null;
    private Timer mTimer;
    private String returnReason = "";
    private int returnStatus = 0;
    private String filepath = "";
    private MpiClient mpiClient;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
    private double deviceVersion = 0.0, fileVersion = 0.0;
    private Boolean isFileExtension = false;
    private Boolean isCygnusCfgExits = false;
    private Boolean isRebootRequired = false;
    private Context context = null;
    String mpiVersion = "";

    public interface MpiUpdateListener {
        void onMpiUpdateComplete(MpiUpdateApiData data);
    }

    public static MpiUpdateApi getInstance() {
        if (instance == null) {
            instance = new MpiUpdateApi();
        }
        return instance;
    }


    public void setPerformMpiUpdate(String btAddress, int tOut, String filePath, Context context) {
        Log.d(TAG, "###RB#### setManualTransactionParams: ");

        clearData();
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.filepath = filePath;
        this.context = context;
        mpiUpdateData = new MpiUpdateApiData();

    }

    public void performMpiUpdate(MpiUpdateListener listener) {
        Log.d(TAG, "###RB#### performManualTransaction: ");
        startTimer();
        this.mpiUpdateListener = listener;

        if (BluetoothModule.getInstance().isSessionOpen()) {
            checkDevice();
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
                        checkDevice();
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        Log.d(TAG, "###RB#### MiuraManager Instance Error: ");
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

            }

            @Override
            public void onDeviceDisconnected() {
                Log.d(TAG, "###RB#### onDeviceDisconnected: ");
                Log.d("TAG", "onDeviceDisconnected: ");

            }
        };
    }


    private void checkDevice() {
        Log.d(TAG, "###RB#### checkDevice: ");
        try {
            BluetoothModule.getInstance().setTimeoutEnable(true);
            BluetoothDevice device = BluetoothModule.getInstance().getSelectedBluetoothDevice();
            if (device != null) {
                getMpiVersion();
            }
        } catch (Exception e) {

        }
    }

    private void getMpiVersion() {
        Log.d(TAG, "###RB#### loadTransactionData: ");
        try {
            MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

                @WorkerThread
                @Override
                public void onSuccess(SoftwareInfo softwareInfo) {
                    mpiVersion = softwareInfo.getMpiVersion();
                    getDeviceInfo();
                }

                @WorkerThread
                @Override
                public void onError() {
                    //TODO check error
                }
            });

        } catch (Exception e) {
            if (mpiUpdateListener != null) {
                returnReason = "Failure";
                returnStatus = 2;
                mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
            }
        }
    }


    private void getDeviceInfo() {
        MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
            @WorkerThread
            @Override
            public void onSuccess(final ArrayList<Capability> capabilities) {
                MiuraManager.getInstance().executeAsync(new MiuraManager.AsyncRunnable() {
                    @Override
                    public void runOnAsyncThread(MpiClient client) {
                        if (!isTimeOut) {
                            try {
                                doFileUploads(client);
                            } catch (IOException e) {
                                Log.e(TAG, "runOnAsyncThread: " + e.toString());
                                if (mpiUpdateListener != null) {
                                    returnReason = "Storage Permission, Failure";
                                    returnStatus = 2;
                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                }
                                mpiClient.closeSession();
                            }
                        }
                        if (BluetoothModule.getInstance().isSessionOpen()) {
                            BluetoothModule.getInstance().closeSession();
                        }
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                BluetoothModule.getInstance().closeSession();
            }
        });
    }


    private void doFileUploads(@NonNull MpiClient client) throws IOException {
        InterfaceType interfaceType = InterfaceType.MPI;

        client.displayText(MPI, DisplayTextUtils.getCenteredText("\nUpdating....\n  MPI ..."),
                true, true, true);

        ArrayList<String> configArray = new ArrayList<String>();

        configArray.add("M000-TESTMPI-V1-60b.tar.gz");

        for (String filename : configArray) {
            String path = "mpi_update/" + filename;

            client.selectFile(interfaceType, SelectFileMode.Truncate, path);

        }

        if (mpiUpdateListener != null) {
            returnReason = "Success";
            returnStatus = 2;
            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
        }
        client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);
    }

    
    private MpiUpdateApiData createMpiUpdateData() {
        mpiUpdateData.setReturnReason(returnReason);
        mpiUpdateData.setReturnStatus(returnStatus);
        clearData();
        return mpiUpdateData;
    }

    /**
     * Timer
     */
    private void startTimer() {
        isTimerTimedOut = false;
        isTimeOut = false;
        cancelTimer();
        mTimer = new Timer();
        mTimer.schedule(new TimerTask() {
            public void run() {
                isTimeOut = true;
                isTimerTimedOut = true;
                if (mpiUpdateListener != null) {
                    returnReason = "Timeout, Failure";
                    returnStatus = 2;
                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                }
                this.cancel();
            }
        }, mTimeOut * 1000);
    }

    private void cancelTimer() {
        if (mTimer != null) {
            mTimer.cancel();
            mTimer = null;
        }
    }

    private void clearData() {
        mpiUpdateListener = null;
        deviceConnectListener = null;
        isTimerTimedOut = false;
        cancelTimer();
    }
}