package com.onepay.miura.api;

import android.util.Log;

import androidx.annotation.NonNull;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SelectFileMode;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.data.ConfigApiData;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ConfigApi {
    private static final String TAG = ConfigApi.class.getSimpleName();
    private static ConfigApi instance = null;
    private ConfigInfoListener listener;
    private String bluetoothAddress = "";
    private int mTimeOut = 60;
    private boolean isTimerTimedOut = false;
    private ConfigApiData configData = null;
    private Timer mTimer;
    private String returnReason = "";
    private String filepath = "";
    private int returnStatus = 0;
    private MpiClient mpiClient;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;

    public interface ConfigInfoListener {
        void onConfigUpdateComplete(ConfigApiData data);
    }

    public static ConfigApi getInstance() {
        if (instance == null) {
            instance = new ConfigApi();
        }
        return instance;
    }

    /**
     * Method that sets the config parameters
     *
     * @param btAddress   Miura bluetooth device address
     * @param tOut        Timeout process
     * @param filePath    Config file path
     */
    public void performConfig(String btAddress, int tOut, String filePath) {
        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.filepath = filePath;
        configData = new ConfigApiData();
        startTimer();

        setDeviceReconnectListener();
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    public void setConfigListener(ConfigInfoListener listener) {
        this.listener = listener;
    }

    private void reConnectDevice() {
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "onConnectionSuccess: ");
                MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess(final ArrayList<Capability> capabilities) {
                        MiuraManager.getInstance().executeAsync(new MiuraManager.AsyncRunnable() {
                            @Override
                            public void runOnAsyncThread(MpiClient client) {
                                try {
                                    doFileUploads(client);
                                } catch (IOException e) {
                                    Log.e(TAG, "runOnAsyncThread: " + e.toString());
                                    if (listener != null) {
                                        returnReason = Constants.ErrorReason;
                                        returnStatus = Constants.ErrorStatus;
                                        listener.onConfigUpdateComplete(createConfigData());
                                    }
                                    mpiClient.closeSession();
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

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (listener != null) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    listener.onConfigUpdateComplete(createConfigData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                /*if (listener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    listener.onConfigUpdateComplete(createConfigData());
                }*/
            }
        };
    }

    private void doFileUploads(@NonNull MpiClient client) throws IOException {
        InterfaceType interfaceType = InterfaceType.MPI;

        this.mpiClient = client;
        boolean ok = client.displayText(MPI, DisplayTextUtils.getCenteredText("Updating....\nConfig files..."),
                true, true, true);
        if (!ok) {
            Log.e(TAG, "Text failed");
        }

        ArrayList<String> configArray = new ArrayList<String>();

        configArray.add("AACDOL.CFG");
        configArray.add("ARQCDOL.CFG");
        configArray.add("contactless.cfg");
        configArray.add("ctls-prompts.txt");
        configArray.add("emv.cfg");
        configArray.add("OPDOL.CFG");
        configArray.add("P2PEDOL.CFG");
        configArray.add("TCDOL.CFG");
        configArray.add("TDOL.CFG");
        configArray.add("TRMDOL.CFG");
        configArray.add("MPI-Dynamic.cfg");

        for (String filename : configArray) {
            String path = this.filepath + filename;
            FileInputStream inputStream = new FileInputStream(path);

            Log.d(TAG, "Config file uploaded-: " + path);

            int size = inputStream.available();
            final byte[] buffer = new byte[size];
            inputStream.read(buffer);
            inputStream.close();

            int pedFileSize = client.selectFile(interfaceType, SelectFileMode.Truncate, filename);

            //noinspection SimplifiableIfStatement
            if (pedFileSize < 0) {
                showBadFileUploadMessage(filename);
                return;
            }
            ok = client.streamBinary(
                    interfaceType, buffer, 0, 0, buffer.length, 100);
            if (!ok) {
                showBadFileUploadMessage(filename);
                if (listener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    listener.onConfigUpdateComplete(createConfigData());
                }
                Log.e(TAG, "Error Config-file");
                client.closeSession();
            }
        }

        if (listener != null) {
            returnReason = Constants.SuccessReason;
            returnStatus = Constants.SuccessStatus;
            listener.onConfigUpdateComplete(createConfigData());
        }
        client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);
    }

    private void showBadFileUploadMessage(final String filename) {
        if (listener != null) {
            returnReason = Constants.ErrorReason;
            returnStatus = Constants.ErrorStatus;
            listener.onConfigUpdateComplete(configData);
        }
        Log.d(TAG, filename + " uploaded Error");
        BluetoothModule.getInstance();
    }

    private ConfigApiData createConfigData() {
        configData.setReturnReason(returnReason);
        configData.setReturnStatus(returnStatus);
        cancelTimer();
        return configData;
    }

    /**
     * Timer
     */
    private void startTimer() {
        isTimerTimedOut = false;
        cancelTimer();
        mTimer = new Timer();
        mTimer.schedule(new TimerTask() {
            public void run() {
                isTimerTimedOut = true;
                BluetoothModule.getInstance().closeSession();
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
}