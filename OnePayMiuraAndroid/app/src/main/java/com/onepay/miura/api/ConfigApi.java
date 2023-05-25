package com.onepay.miura.api;

import android.content.Context;
import android.util.Log;

import androidx.annotation.NonNull;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.api.utils.StreamBinaryFile;
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SelectFileMode;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.data.ConfigApiData;
import com.onepay.miura.data.MpiUpdateApiData;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
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
    private boolean isTimeOut = false;
    private ConfigApiData configData = null;
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
    private Context mContext;

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
     * @param btAddress Miura bluetooth device address
     * @param tOut      Timeout process
     * @param filePath  Config file path
     */
    public void performConfig(Context context, String btAddress, int tOut, String filePath) {
        this.mContext = context;
        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.filepath = filePath;
        configData = new ConfigApiData();
        startTimer();

        if (BluetoothModule.getInstance().isSessionOpen()) {
            getDeviceInfo();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
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
                getDeviceInfo();
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (listener != null) {
                    returnReason = "Bluetooth connection, Failure";
                    returnStatus = 2;
                    listener.onConfigUpdateComplete(createConfigData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");
            }
        };
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
                                //doFileUploads(client);
                                writeConfigFiles(client);

                            } catch (Exception e) {
                                Log.e(TAG, "runOnAsyncThread: " + e.toString());
                                if (listener != null) {
                                    returnReason = "Storage Permission, Failure";
                                    returnStatus = 2;
                                    listener.onConfigUpdateComplete(createConfigData());
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

    private void writeConfigFiles(MpiClient client) {
        System.out.println();
        this.mpiClient = client;
        boolean ok = client.displayText(MPI, DisplayTextUtils.getCenteredText("Updating....\nConfig files..."),
                true, true, true);
        if (!ok) {
            Log.e(TAG, "Text failed");
        }

        /*try {
            String[] fileNames = mContext.getAssets().list("mpi_config/");
            for (String fileName : fileNames) {
                streamBinaryFile(client, fileName);
            }
            client.resetDevice(InterfaceType.MPI, ResetDeviceType.Hard_Reset);

            client.closeSession();
            listener.onConfigUpdateComplete(createConfigData());
        } catch (IOException e) {
            e.printStackTrace();
        }*/

        streamBinaryFile(client, "ARQCDOL.CFG");
        streamBinaryFile(client, "capkeys.cfg");
        streamBinaryFile(client, "capkeys.cfg.sig");
        streamBinaryFile(client, "contactless.cfg");
        streamBinaryFile(client, "emv.cfg");
        streamBinaryFile(client, "MPI-Production.cfg");

        client.resetDevice(MPI, ResetDeviceType.Hard_Reset);

        client.closeSession();
        listener.onConfigUpdateComplete(createConfigData());

        /*InterfaceType interfaceType = InterfaceType.MPI;
        try {
            InputStream is = mContext.getAssets().open("mpi_config/ARQCDOL.CFG");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "ARQCDOL.CFG", is, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is1 = mContext.getAssets().open("mpi_config/capkeys.cfg");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "capkeys.cfg", is1, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is2 = mContext.getAssets().open("mpi_config/capkeys.cfg.sig");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "capkeys.cfg", is2, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is3 = mContext.getAssets().open("mpi_config/contactless.cfg");
            boolean result = StreamBinaryFile.streamBinaryFile(client, interfaceType, "contactless.cfg", is3, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is4 = mContext.getAssets().open("mpi_config/emv.cfg");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "emv.cfg", is4, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is5 = mContext.getAssets().open("mpi_config/capkeys.cfg");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "capkeys.cfg", is5, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            InputStream is6 = mContext.getAssets().open("mpi_config/capkeys.cfg.sig");
            StreamBinaryFile.streamBinaryFile(client, interfaceType, "capkeys.cfg", is6, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });

            client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);

            client.closeSession();
            listener.onConfigUpdateComplete(createConfigData());
        } catch (IOException e) {
            e.printStackTrace();
        }*/
    }

    private void streamBinaryFile(MpiClient client, String fileName) {
        InputStream is = null;
        try {
            is = mContext.getAssets().open("mpi_config/" + fileName);
            StreamBinaryFile.streamBinaryFile(client, InterfaceType.MPI, fileName, is, new StreamBinaryFile.ProgressCallback() {
                @Override
                public void onProgress(int i) {
                    Log.d(TAG, "Progress " + i);
                }
            });
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void doFileUploads(@NonNull MpiClient client) throws IOException {
        try {
            InterfaceType interfaceType = InterfaceType.MPI;

            System.out.println();
            this.mpiClient = client;
            boolean ok = client.displayText(MPI, DisplayTextUtils.getCenteredText("Updating....\nConfig files..."),
                    true, true, true);
            if (!ok) {
                Log.e(TAG, "Text failed");
            }

            HashMap<String, String> configMap = new HashMap<>();

            HashMap<String, String> versionMap = mpiClient.getConfiguration();
            for (Map.Entry entry : versionMap.entrySet()) {
                String name = (String) entry.getKey();
                String filePath = this.filepath + name;

                File file = new File(filePath);
                if (file.exists()) {
                    configMap.put((String) entry.getKey(), (String) entry.getValue());
                }
                String sigFilePath = this.filepath + name + ".sig";
                File sigFile = new File(sigFilePath);
                if (sigFile.exists()) {
                    configMap.put((String) entry.getKey() + ".sig", (String) entry.getValue());
                }
                if (name.equalsIgnoreCase("cygnus.cfg")) {
                    isCygnusCfgExits = true;
                }
            }
            File[] filesList = getListOfFiles();
            for (int i = 0; i < filesList.length; i++) {
                String filepath = filesList[i].toString();
                int lastIndexOfFilePath = filepath.lastIndexOf('/');
                String fileName = filepath.substring(lastIndexOfFilePath);
                String[] part = fileName.split("/");
                String file = part[1].trim();

                int lastIndexOf = file.lastIndexOf(".");
                String fileExtension = file.substring(lastIndexOf);

                if (file.equalsIgnoreCase("cygnus.cfg") && !isCygnusCfgExits) {
                    configMap.put(file, "1.0");
                }
                if ((fileExtension.equalsIgnoreCase(".png")
                        || fileExtension.equalsIgnoreCase(".bmp")) && !isCygnusCfgExits) {

                    isFileExtension = true;
                    configMap.put(file, "1.0");
                }

            }

            if (configMap.size() > 0) {
                for (Map.Entry entry : configMap.entrySet()) {

                    String name = (String) entry.getKey();
                    if (name.contains(".sig")) {
                        String sigName = name.replace(".sig", "");
                        String path = this.filepath + sigName;
                        FileInputStream inputStream = new FileInputStream(path);

                        int size = inputStream.available();
                        final byte[] buffer = new byte[size];
                        inputStream.read(buffer);
                        inputStream.close();

                        if (!getVersion(buffer).isEmpty() && getVersion(buffer) != null) {
                            fileVersion = Double.parseDouble(getVersion(buffer));
                        }

                    }
                    String path = this.filepath + name;

                    FileInputStream inputStream = new FileInputStream(path);

                    int size = inputStream.available();
                    final byte[] buffer = new byte[size];
                    inputStream.read(buffer);
                    inputStream.close();

                    if (!getVersion(buffer).isEmpty() && getVersion(buffer) != null) {
                        fileVersion = Double.parseDouble(getVersion(buffer));
                    }

                    if (entry.getValue().toString().contains("OnePay")) {
                        try {
                            deviceVersion = Double.parseDouble(getDeviceVersion((String) entry.getValue()));
                        } catch (Exception e) {
                            int pedFileSize = client.selectFile(interfaceType, SelectFileMode.Truncate, (String) entry.getKey());

                            if (pedFileSize < 0) {
                                showBadFileUploadMessage((String) entry.getKey());
                                return;
                            }
                            ok = client.streamBinary(
                                    interfaceType, buffer, 0, 0, buffer.length, 100);
                            if (!ok) {
                                showBadFileUploadMessage((String) entry.getKey());
                                Log.e(TAG, "Error Config-file");
                                client.closeSession();
                                return;
                            }
                            if (listener != null) {
                                returnReason = "Config Success, Applied";
                                returnStatus = 1;
                                listener.onConfigUpdateComplete(createConfigData());
                            }
                            client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);
                            return;
                        }
                    }

                    if (fileVersion > deviceVersion || !isFileExtension) {
                        isRebootRequired = true;
                        int pedFileSize = client.selectFile(interfaceType, SelectFileMode.Truncate, (String) entry.getKey());

                        if (pedFileSize < 0) {
                            showBadFileUploadMessage((String) entry.getKey());
                            return;
                        }
                        ok = client.streamBinary(
                                interfaceType, buffer, 0, 0, buffer.length, 100);
                        if (!ok) {
                            showBadFileUploadMessage((String) entry.getKey());
                            Log.e(TAG, "Error Config-file");
                            client.closeSession();
                            return;
                        }
                    }
                }

                if (isRebootRequired) {
                    if (listener != null) {
                        returnReason = "Config Success, Applied";
                        returnStatus = 1;
                        listener.onConfigUpdateComplete(createConfigData());
                    }
                    isFileExtension = false;
                    client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);
                } else {
                    if (BluetoothModule.getInstance().isSessionOpen()) {
                        BluetoothModule.getInstance().closeSession();
                    }
                    Log.d(TAG, "Config file are upto date");

                    if (listener != null) {
                        returnReason = "Config Success, Not Applied";
                        returnStatus = 0;
                        listener.onConfigUpdateComplete(createConfigData());
                    }
                }


            } else {
                if (BluetoothModule.getInstance().isSessionOpen()) {
                    BluetoothModule.getInstance().closeSession();
                }
                Log.d(TAG, "Config file are upto date");

                if (listener != null) {
                    returnReason = "No Directory/Files, Failure";
                    returnStatus = 2;
                    listener.onConfigUpdateComplete(createConfigData());
                }
            }
        } catch (Exception e) {
            Log.d(TAG, "DoFileUploads: " + e.toString());
        }

    }

    private void showBadFileUploadMessage(final String filename) {
        if (listener != null) {
            returnReason = "Failure";
            returnStatus = 2;
            listener.onConfigUpdateComplete(createConfigData());
        }
        Log.d(TAG, filename + " uploaded Error");
        BluetoothModule.getInstance();
    }


    private String getVersion(byte[] buffer) {
        String version = "";
        String text = new String(buffer);
        String lines[] = text.split("\\r?\\n");
        for (int i = 0; i < lines.length; i++) {
            if (lines[i].contains("$Revision:")) {
                String[] part = lines[i].split(":");
                String part2 = part[1].trim();
                String[] split = part2.split(" ");
                String part3 = split[1].trim();
                if (part3.contains("$")) {
                    String[] removeSign = part3.split("\\$");
                    part3 = removeSign[0].trim();
                    //part3 = part3.replaceAll("\\$", "");
                }
                String[] part4 = part3.split("V");
                version = part4[1].trim();
            }
        }
        return version;
    }

    private String getDeviceVersion(String version) {
        String[] part = version.split("V");
        version = part[1].trim();
        return version;
    }

    private File[] getListOfFiles() {
        try {
            Log.d("Files", "Path: " + this.filepath);
            File directory = new File(this.filepath);
            File[] files = directory.listFiles();
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

    private ConfigApiData createConfigData() {
        configData.setReturnReason(returnReason);
        configData.setReturnStatus(returnStatus);
        clearData();
        return configData;
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
                if (listener != null) {
                    returnReason = Constants.TimeoutReason;
                    returnStatus = Constants.TimeoutStatus;
                    listener.onConfigUpdateComplete(createConfigData());
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
        listener = null;
        deviceConnectListener = null;
        isTimerTimedOut = false;
        cancelTimer();
    }
}