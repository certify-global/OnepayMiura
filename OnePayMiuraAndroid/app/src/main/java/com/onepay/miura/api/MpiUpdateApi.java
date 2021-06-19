package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.util.Log;

import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.APITransferFileListener;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.core.Config;
import com.onepay.miura.data.MpiUpdateApiData;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

public class MpiUpdateApi {
    private static final String TAG = MpiUpdateApi.class.getSimpleName();
    private static MpiUpdateApi instance = null;
    private MpiUpdateListener mpiUpdateListener;
    private String bluetoothAddress = "";
    private int mTimeOut = 60;
    private boolean isTimerTimedOut = false;
    private MpiUpdateApiData mpiUpdateData = null;
    private Timer mTimer;
    private String returnReason = "";
    private int returnStatus = 0;
    private String filepath = "";
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
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


    public void setPerformMpiUpdate(String btAddress, int tOut, String filePath, String mpiVersion) {
        Log.d(TAG, "###RB#### setManualTransactionParams: ");

        clearData();
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.filepath = filePath;
        this.mpiVersion = mpiVersion;
        mpiUpdateData = new MpiUpdateApiData();

        startTimer();

        if (BluetoothModule.getInstance().isSessionOpen()) {
            checkDevice();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }

    }

    public void performMpiUpdate(MpiUpdateListener listener) {
        Log.d(TAG, "###RB#### performManualTransaction: ");
        this.mpiUpdateListener = listener;
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
                    String currentMpiVersion = softwareInfo.getMpiVersion();
                    if (currentMpiVersion.equals(mpiVersion)) {
                        if (mpiUpdateListener != null) {
                            returnReason = Constants.LatestMPIReason;
                            returnStatus = Constants.SuccessLevelOneStatus;
                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                        }
                        closeSession();
                    } else {
                        updateMpi();
                    }
                }

                @WorkerThread
                @Override
                public void onError() {
                    //TODO check error
                }
            });

        } catch (Exception e) {
            if (mpiUpdateListener != null) {
                returnReason = Constants.ErrorReason;
                returnStatus = Constants.ErrorStatus;
                mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
            }
        }
    }


    private void updateMpi() {

        String fileMPIPath = filepath;
        String fileConfigPath = filepath;
        final FileInputStream inputStreamMPI;
        final FileInputStream inputStreamConfig;
        final int mpiSize;
        final int configSize;
        final int totalSize;

        fileMPIPath = fileMPIPath + Config.getTestMpiFileName(mpiVersion) + ".tmp";
        fileConfigPath = fileConfigPath + Config.getTestMpiConfFileName() + ".tmp";

        Log.d(TAG, fileMPIPath + " and " + fileConfigPath);

        try {
            inputStreamMPI = new FileInputStream(fileMPIPath);
            inputStreamConfig = new FileInputStream(fileMPIPath);

            mpiSize = inputStreamMPI.available();
            configSize = inputStreamConfig.available();
            totalSize = mpiSize + configSize;
            Log.d(TAG, "updateMpi: ");
        } catch (IOException e) {
            e.printStackTrace();
            Log.d(TAG, "updateMpi: An IOException was caught!");
            if (mpiUpdateListener != null) {
                returnReason = "File not found";
                returnStatus = Constants.ErrorStatus;
                mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
            }
            closeSession();
            return;
        }

        Log.d(TAG, "MPI Update starting. Updating to: " + Config.getTestMpiFileName(mpiVersion) + "...");
        MiuraManager.getInstance().displayText(" Updating MPI\n Please Wait...", new MiuraDefaultListener() {
            @WorkerThread
            @Override
            public void onSuccess() {
                MiuraManager.getInstance().clearDeviceMemory(new MiuraDefaultListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess() {
                        Log.d(TAG, "onSuccess: Transferring file: " + Config.getTestMpiFileName(mpiVersion) + "...");
                        MiuraManager.getInstance().transferFileToDevice(Config.getTestMpiFileName(mpiVersion), inputStreamMPI, new APITransferFileListener() {
                            @WorkerThread
                            @Override
                            public void onSuccess() {
                                Log.d(TAG, "onSuccess: Successfully transferred file: " + Config.getTestMpiFileName(mpiVersion));
                                Log.d(TAG, "onSuccess: Transferring MPI config file: " + Config.getTestMpiConfFileName());
                                MiuraManager.getInstance().transferFileToDevice(Config.getTestMpiConfFileName(), inputStreamConfig, new APITransferFileListener() {
                                    @WorkerThread
                                    @Override
                                    public void onSuccess() {
                                        Log.d(TAG, "onSuccess: Successfully transferred file: " + Config.getTestMpiConfFileName());
                                        Log.d(TAG, "onSuccess: Applying update...");
                                        //postOnUiThread(DeviceInfoActivity::showPostTransferHardResetDialog);

                                        MiuraManager.getInstance().hardReset(new MiuraDefaultListener() {
                                            @WorkerThread
                                            @Override
                                            public void onSuccess() {
                                                Log.d(TAG, "onSuccess: Update applied, restarting device.");
                                                if (mpiUpdateListener != null) {
                                                    returnReason = Constants.SuccessReason;
                                                    returnStatus = Constants.SuccessStatus;
                                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                                }
                                                closeSession();
                                            }

                                            @WorkerThread
                                            @Override
                                            public void onError() {
                                                Log.d(TAG, "onError: MPIUpdate " + "error reset");
                                                if (mpiUpdateListener != null) {
                                                    returnReason = Constants.ErrorReason;
                                                    returnStatus = Constants.ErrorStatus;
                                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                                }
                                                closeSession();
                                            }
                                        });
                                    }

                                    @WorkerThread
                                    @Override
                                    public void onError() {
                                        Log.d(TAG, "MPIUpdate error on file: " + Config.getTestMpiConfFileName());
                                        if (mpiUpdateListener != null) {
                                            returnReason = Constants.ErrorReason;
                                            returnStatus = Constants.ErrorStatus;
                                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                        }
                                        closeSession();
                                    }

                                    @WorkerThread
                                    @Override
                                    public void onProgress(int bytesTransferred) {
                                        Log.d(TAG, "onProgress: config progress, transferred " + 100 * bytesTransferred / configSize + "%");

                                        int totalTransferred = bytesTransferred + mpiSize;
                                        final int pc = (100 * totalTransferred) / totalSize;
                                        //postOnUiThread(view -> view.setFileTransferProgress(pc));
                                    }
                                });
                            }

                            @WorkerThread
                            @Override
                            public void onError() {
                                Log.d(TAG, "MPIUpdate error on file: " + Config.getTestMpiFileName(mpiVersion));
                                if (mpiUpdateListener != null) {
                                    returnReason = Constants.ErrorReason;
                                    returnStatus = Constants.ErrorStatus;
                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                }
                                closeSession();
                            }

                            @WorkerThread
                            @Override
                            public void onProgress(int bytesTransferred) {
                                Log.d(TAG, "onProgress: Mpi Progress, transferred " + 100 * bytesTransferred / mpiSize + "%");

                                final int pc = (100 * bytesTransferred) / totalSize;
                                Log.d(TAG, "Naga.......... pc count " + pc);
                                //postOnUiThread(view -> view.setFileTransferProgress(pc));
                            }
                        });
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        Log.d(TAG, "Error on Clear device files");
                        if (mpiUpdateListener != null) {
                            returnReason = Constants.ErrorReason;
                            returnStatus = Constants.ErrorStatus;
                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                        }
                        closeSession();
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "onError: Display text failed");
                if (mpiUpdateListener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                }
                closeSession();
            }
        });
    }

    private void closeSession() {
        BluetoothModule.getInstance().closeSession();
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
        cancelTimer();
        mTimer = new Timer();
        mTimer.schedule(new TimerTask() {
            public void run() {
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