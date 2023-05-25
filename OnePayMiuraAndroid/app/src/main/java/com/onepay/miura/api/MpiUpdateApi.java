package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.content.Context;
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

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Timer;
import java.util.TimerTask;

public class MpiUpdateApi {
    private static final String TAG = MpiUpdateApi.class.getSimpleName();
    private static MpiUpdateApi instance = null;
    private MpiUpdateListener mpiUpdateListener;
    private OSUpdateListener osUpdateListener;
    private String bluetoothAddress = "";
    private int mTimeOut = 60;
    private boolean isTimerTimedOut = false;
    private MpiUpdateApiData mpiUpdateData = null;
    private Timer mTimer;
    private String returnReason = "";
    private int returnStatus = 0;
    private String filepath = "";
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
    private int fileVersionNumber = 0;
    private int versionNumber = 0;
    private String versionFileName ="1-64";
    private String fileName = "";
    private Context mContext;
    private UpdateType updateType = UpdateType.NONE;

    public interface MpiUpdateListener {
        void onMpiUpdateComplete(MpiUpdateApiData data);
    }

    public interface OSUpdateListener {
        void onOSUpdateComplete(String message);
    }

    public interface TransferFileListener {
        void onFileTransferred(String fileName);
    }

    public enum UpdateType {
        NONE,
        OS_UPDATE,
        MPI_UPDATE
    }

    public static MpiUpdateApi getInstance() {
        if (instance == null) {
            instance = new MpiUpdateApi();
        }
        return instance;
    }


    public void setPerformOSMpiUpdate(Context context, String btAddress, int tOut, String filePath, String configFileName) {
        Log.d(TAG, "###RB#### setManualTransactionParams: ");

        this.mContext = context;
        clearData();
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.filepath = filePath;
        mpiUpdateData = new MpiUpdateApiData();
        this.fileName = configFileName;

    }

    public void performMpiUpdate(MpiUpdateListener listener) {
        Log.d(TAG, "###RB#### performManualTransaction: ");
        //startTimer();
        updateType = UpdateType.MPI_UPDATE;
        this.mpiUpdateListener = listener;

        if (BluetoothModule.getInstance().isSessionOpen()) {
            checkDevice(UpdateType.MPI_UPDATE);
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    public void performOSUpdate(OSUpdateListener listener) {
        startTimer();
        updateType = UpdateType.OS_UPDATE;
        this.osUpdateListener = listener;

        if (BluetoothModule.getInstance().isSessionOpen()) {
            checkDevice(UpdateType.OS_UPDATE);
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
                        if (updateType == UpdateType.OS_UPDATE) {
                            checkDevice(UpdateType.OS_UPDATE);
                        } else {
                            checkDevice(UpdateType.MPI_UPDATE);
                        }
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


    private void checkDevice(UpdateType updateType) {
        Log.d(TAG, "###RB#### checkDevice: ");
        try {
            BluetoothModule.getInstance().setTimeoutEnable(true);
            BluetoothDevice device = BluetoothModule.getInstance().getSelectedBluetoothDevice();
            if (device != null) {
                if (updateType == UpdateType.OS_UPDATE) {
                    getOSVersion();
                } else {
                    getMpiVersion();
                }
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
                    versionNumber = convertCurrentMpiVersion(currentMpiVersion);
                    if (versionNumber == 0) {
                        if (mpiUpdateListener != null) {
                            returnReason = "Not able to get the version number from the mpi";
                            returnStatus = Constants.ErrorStatus;
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
        final InputStream inputStream;
        final InputStream inputStreamConfig;
        final int mpiSize;
        final int configSize;
        final int totalSize;

        /*fileVersionNumber = fileNameVersion();

        if(!(fileVersionNumber > versionNumber)){
            if (mpiUpdateListener != null) {
                returnReason = Constants.LatestMPIReason;
                returnStatus = Constants.SuccessLevelOneStatus;
                mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
            }
            closeSession();
            return;
        }*/

        fileMPIPath = fileMPIPath + Config.getTestMpiFileName(versionFileName) + ".tmp";
        fileConfigPath = fileConfigPath + Config.getTestMpiConfFileName(fileName) + ".tmp";

        Log.d(TAG, fileMPIPath + " and " + fileConfigPath);

        MiuraManager.getInstance().displayText(" Updating MPI\n Please Wait...", new MiuraDefaultListener() {
            @WorkerThread
            @Override
            public void onSuccess() {
                MiuraManager.getInstance().clearDeviceMemory(new MiuraDefaultListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess() {
                        Log.d(TAG, "onSuccess: Transferring file: " + Config.getTestOsUpdateFileName() + "...");
                        try {
                            fileName = "mpi_update/M000-TESTMPI-Vx-x-CONF121-V1.tar.gz.tmp";
                            InputStream inputStream = mContext.getAssets().open(fileName);
                            Log.d(TAG, "MPI Update starting. Updating to: " + fileName + "...");
                            writeConfigData(inputStream, "M000-TESTMPI-Vx-x-CONF121-V1.tar.gz", new TransferFileListener() {
                                @Override
                                public void onFileTransferred(String fileName) {
                                    if (fileName.equalsIgnoreCase("M000-TESTMPI-Vx-x-CONF121-V1.tar.gz")) {
                                        updateMpiData();
                                    }
                                }
                            });
                        } catch (IOException e) {
                            e.printStackTrace();
                            Log.d(TAG, "updateMpi: An IOException was caught!");
                            if (mpiUpdateListener != null) {
                                returnReason = "MPI Update CONFIG file Not Found";
                                returnStatus = 4;
                                mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                            }
                            closeSession();
                            return;
                        }
                        cancelTimer();
                        /*if (mpiUpdateListener != null) {
                            returnReason = Constants.SuccessReason;
                            returnStatus = Constants.SuccessStatus;
                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                        }*/
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        Log.d(TAG, "Error on Clear device files");
                        /*if (mpiUpdateListener != null) {
                            returnReason = Constants.ErrorReason;
                            returnStatus = Constants.ErrorStatus;
                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                        }*/
                        closeSession();
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "onError: Display text failed");
              /*  if (mpiUpdateListener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                }*/
                closeSession();
            }
        });
    }

    private void writeConfigData(final InputStream inputStream, final String fileName, final TransferFileListener transferFileListener) {
        final int size;
        try {
            size = inputStream.available();
            MiuraManager.getInstance().transferFileToDevice(fileName, inputStream, new APITransferFileListener() {
                @WorkerThread
                @Override
                public void onSuccess() {
                    Log.d(TAG, "onSuccess: Successfully transferred file: " + fileName);
                    if (transferFileListener != null) {
                        transferFileListener.onFileTransferred(fileName);
                    }
                }

                @WorkerThread
                @Override
                public void onError() {
                    Log.d(TAG, "MPIUpdate error on file: " + Config.getTestMpiFileName(versionFileName));
                                   /* if (mpiUpdateListener != null) {
                                        returnReason = Constants.ErrorReason;
                                        returnStatus = Constants.ErrorStatus;
                                        mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                    }*/
                    closeSession();
                }

                @WorkerThread
                @Override
                public void onProgress(int bytesTransferred) {
                    //Log.d(TAG, "onProgress: Mpi Progress, transferred " + (100 * bytesTransferred) / size + "%");

                    //final int pc = (100 * bytesTransferred) / size;
                    //Log.d(TAG, ".... pc count " + pc);
                    //postOnUiThread(view -> view.setFileTransferProgress(pc));
                }
            });
        } catch (IOException e) {

        }
    }

    private void updateMpiData() {
        fileName = "mpi_update/M000-TESTMPI-V1-64.tar.gz.tmp";
        try {
            InputStream inputStream = mContext.getAssets().open(fileName);
            writeConfigData(inputStream, "M000-TESTMPI-V1-64.tar.gz", new TransferFileListener() {
                @Override
                public void onFileTransferred(String fileName) {
                    resetDevice();
                }
            });
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void getOSVersion() {
        Log.d(TAG, "###RB#### Get OS Version: ");
        try {
            MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

                @WorkerThread
                @Override
                public void onSuccess(SoftwareInfo softwareInfo) {
                    String currentOSVersion = softwareInfo.getOsVersion();
                    versionNumber = getCurrentOsVersion(currentOSVersion);
                    if (versionNumber == 0) {
                        if (osUpdateListener != null) {
                            returnReason = "Not able to get the version number from the mpi";
                            returnStatus = Constants.ErrorStatus;
                            osUpdateListener.onOSUpdateComplete(returnReason);
                        }
                        closeSession();
                    } else {
                        updateOS();
                    }
                }

                @WorkerThread
                @Override
                public void onError() {
                    Log.d(TAG, "onError");
                }
            });

        } catch (Exception e) {
            if (osUpdateListener != null) {
                returnReason = Constants.ErrorReason;
                returnStatus = Constants.ErrorStatus;
                osUpdateListener.onOSUpdateComplete(returnReason);
            }
        }
    }

    private void updateOS() {
        String fileOSUpdatePath = filepath;
        String fileOSPath = filepath;
        final InputStream inputStreamOSUpdate;
        final InputStream inputStreamOS;
        final int os_update_Size;
        final int os_Size;
        final int totalSize;

        //fileVersionNumber = fileNameVersion();

        fileOSUpdatePath = fileOSUpdatePath + Config.getTestOsUpdateFileName();
        fileOSPath = fileOSPath + Config.getTestOsFileName();

        Log.d(TAG, fileOSUpdatePath + " and " + fileOSPath);

        try {

            inputStreamOSUpdate = mContext.getAssets().open("os_update/M000-TESTOSUPDATE-V1-8.tar.gz.tmp");
            inputStreamOS = mContext.getAssets().open("os_update/M000-TESTOS-V9-7.tar.gz.tmp");

            os_update_Size = inputStreamOSUpdate.available();
            os_Size = inputStreamOS.available();
            totalSize = os_update_Size + os_Size;
            Log.d(TAG, "updateOS: ");
        } catch (IOException e) {
            e.printStackTrace();
            Log.d(TAG, "updateMpi: An IOException was caught!");
            if (osUpdateListener != null) {
                returnReason = "OS Update CONFIG file Not Found";
                returnStatus = 4;
                osUpdateListener.onOSUpdateComplete(returnReason);
            }
            closeSession();
            return;
        }
        cancelTimer();
        /*if (osUpdateListener != null) {
            returnReason = Constants.SuccessReason;
            returnStatus = Constants.SuccessStatus;
            osUpdateListener.onOSUpdateComplete(returnReason);
        }*/
        Log.d(TAG, "OS Update starting. Updating to: " + Config.getOsUpdateFileName());
        MiuraManager.getInstance().displayText(" Updating OS\n Please Wait...", new MiuraDefaultListener() {
            @WorkerThread
            @Override
            public void onSuccess() {
                MiuraManager.getInstance().clearDeviceMemory(new MiuraDefaultListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess() {
                        Log.d(TAG, "onSuccess: Transferring file: " + Config.getTestOsUpdateFileName() + "...");
                        MiuraManager.getInstance().transferFileToDevice(Config.getTestOsUpdateFileName(), inputStreamOSUpdate, new APITransferFileListener() {
                            @WorkerThread
                            @Override
                            public void onSuccess() {
                                Log.d(TAG, "onSuccess: Successfully transferred file: " + Config.getTestOsFileName());
                                Log.d(TAG, "onSuccess: Transferring OS file: " + Config.getTestOsFileName());
                                MiuraManager.getInstance().transferFileToDevice(Config.getTestOsFileName(), inputStreamOS, new APITransferFileListener() {
                                    @WorkerThread
                                    @Override
                                    public void onSuccess() {
                                        Log.d(TAG, "onSuccess: Successfully transferred file: " + Config.getTestOsFileName());
                                        Log.d(TAG, "onSuccess: Applying update...");
                                        //postOnUiThread(DeviceInfoActivity::showPostTransferHardResetDialog);
                                        if (osUpdateListener != null) {
                                            osUpdateListener.onOSUpdateComplete("OS Update complete");
                                        }

                                        MiuraManager.getInstance().hardReset(new MiuraDefaultListener() {
                                            @WorkerThread
                                            @Override
                                            public void onSuccess() {
                                                Log.d(TAG, "onSuccess: Update applied, restarting device.");

                                                closeSession();
                                            }

                                            @WorkerThread
                                            @Override
                                            public void onError() {
                                                Log.d(TAG, "onError: MPIUpdate " + "error reset");
                                               /* if (mpiUpdateListener != null) {
                                                    returnReason = Constants.ErrorReason;
                                                    returnStatus = Constants.ErrorStatus;
                                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                                }*/
                                                closeSession();
                                            }
                                        });
                                    }

                                    @WorkerThread
                                    @Override
                                    public void onError() {
                                        Log.d(TAG, "MPIUpdate error on file: " + Config.getOsFileName());
                                        /*if (mpiUpdateListener != null) {
                                            returnReason = Constants.ErrorReason;
                                            returnStatus = Constants.ErrorStatus;
                                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                        }*/
                                        closeSession();
                                    }

                                    @WorkerThread
                                    @Override
                                    public void onProgress(int bytesTransferred) {
                                        Log.d(TAG, "onProgress: config progress, transferred " + 100 * bytesTransferred / os_Size + "%");

                                        int totalTransferred = bytesTransferred + os_update_Size;
                                        final int pc = (100 * totalTransferred) / totalSize;
                                        //postOnUiThread(view -> view.setFileTransferProgress(pc));
                                    }
                                });
                            }

                            @WorkerThread
                            @Override
                            public void onError() {
                                Log.d(TAG, "MPIUpdate error on file: " + Config.getOsUpdateFileName());
                               /* if (mpiUpdateListener != null) {
                                    returnReason = Constants.ErrorReason;
                                    returnStatus = Constants.ErrorStatus;
                                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                                }*/
                                closeSession();
                            }

                            @WorkerThread
                            @Override
                            public void onProgress(int bytesTransferred) {
                                Log.d(TAG, "onProgress: Mpi Progress, transferred " + 100 * bytesTransferred / os_update_Size + "%");

                                final int pc = (100 * bytesTransferred) / totalSize;
                                Log.d(TAG, ".... pc count " + pc);
                                //postOnUiThread(view -> view.setFileTransferProgress(pc));
                            }
                        });
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        Log.d(TAG, "Error on Clear device files");
                        /*if (mpiUpdateListener != null) {
                            returnReason = Constants.ErrorReason;
                            returnStatus = Constants.ErrorStatus;
                            mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                        }*/
                        closeSession();
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "onError: Display text failed");
              /*  if (mpiUpdateListener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    mpiUpdateListener.onMpiUpdateComplete(createMpiUpdateData());
                }*/
                closeSession();
            }
        });
    }

    private File[] getListOfFiles() {
        try {
            Log.d("Files", "Path: " + this.filepath);
            File directory = new File(this.filepath);
            File[] files = directory.listFiles();
            String[] list = directory.list();
            Log.d("Files", "Size: " + files.length);
            for (int i = 0; i < files.length; i++) {
                Log.d("Files", "FileName:" + files[i].getName());
            }
            return files;
        } catch (Exception e) {
            Log.e(TAG, "getListOfFiles: " + e.getMessage());
            return null;
        }
    }

    private int fileNameVersion() {
        File[] filesList = getListOfFiles();

        for (File value : filesList) {
            String fileName = value.toString();
            if (fileName.contains("M000-TESTMPI")) {
                if (!fileName.contains("CONF")) {
                    String[] part = fileName.split("-V");
                    String file = part[1].trim();
                    String[] part2 = file.split(".tar");
                    String file2 = part2[0].trim();
                    versionFileName = file2;
                    String[] part3 = file2.split("1-");
                    String file3 = part3[1].trim();
                    file3 = file3.length() < 2 ? file3 : file3.substring(0, 2);

                    try {
                        fileVersionNumber = Integer.parseInt(file3);
                    } catch (Exception ex) {
                        fileVersionNumber = 0;
                    }
                }
            }
        }
        return fileVersionNumber;
    }

    private int convertCurrentMpiVersion(String mpiVersion) {
        String[] splitVersion = mpiVersion.split("1-");
        String versionName = splitVersion[1].trim();
        versionName = versionName.length() < 2 ? versionName : versionName.substring(0, 2);

        try {
            versionNumber = Integer.parseInt(versionName);
        } catch (Exception ex) {
            versionNumber = 0;
        }

        return versionNumber;
    }

    private int getCurrentOsVersion(String osVersion) {
        String[] splitVersion = osVersion.split("-");
        String versionName = splitVersion[0].trim();
        //versionName = versionName.length() < 2 ? versionName : versionName.substring(0, 2);

        try {
            versionNumber = Integer.parseInt(versionName);
        } catch (Exception ex) {
            versionNumber = 0;
        }

        return versionNumber;
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

    private void resetDevice() {
        MiuraManager.getInstance().hardReset(new MiuraDefaultListener() {
            @WorkerThread
            @Override
            public void onSuccess() {
                Log.d(TAG, "onSuccess: Update applied, restarting device.");

                closeSession();
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "onError: MPIUpdate " + "error reset");
                closeSession();
            }
        });
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
        fileVersionNumber = 0;
        versionNumber = 0;
        cancelTimer();
    }
}