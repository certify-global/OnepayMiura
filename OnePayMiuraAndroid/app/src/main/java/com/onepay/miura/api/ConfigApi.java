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
import com.miurasystems.mpi.enums.InterfaceType;
import com.miurasystems.mpi.enums.ResetDeviceType;
import com.miurasystems.mpi.enums.SelectFileMode;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.core.Config;
import com.onepay.miura.data.ConfigApiData;

import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ConfigApi {
    private static final String TAG = ConfigApi.class.getSimpleName();
    private static ConfigApi instance = null;
    private ConfigInfoListener listener;
    private String bluetoothAddress = "";
    private Context context = null;
    private ConfigApiData configData = null;

    public interface ConfigInfoListener {
        void onConfigUpdateComplete(ConfigApiData data);
    }

    public static ConfigApi getInstance() {
        if (instance == null) {
            instance = new ConfigApi();
        }
        return instance;
    }

    public void performConfig(Context context, String btAddress, ConfigInfoListener listener) {
        configData = new ConfigApiData();
        this.listener = listener;
        this.context = context;
        bluetoothAddress = btAddress;

        ConnectApi.getInstance().connect(bluetoothAddress, new ConnectApi.DeviceConnectListener() {
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
                                    e.printStackTrace();
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
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");
            }
        });
    }

    private void doFileUploads(@NonNull MpiClient client) throws IOException {
        InterfaceType interfaceType = InterfaceType.MPI;

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

            String path = "mpi_config/" + filename;
            InputStream inputStream = context.getAssets().open(path);

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
                Log.e(TAG, "Error Config-file");
                client.closeSession();
            }
        }

        if (listener != null) {
            configData.setReturnStatus(1);
            configData.setReturnReason("Success");
            listener.onConfigUpdateComplete(configData);
        }
        client.resetDevice(interfaceType, ResetDeviceType.Hard_Reset);
    }

    private void showBadFileUploadMessage(final String filename) {
        configData.setReturnStatus(2);
        configData.setReturnReason(" uploaded Error");
        if (listener != null) {
            listener.onConfigUpdateComplete(configData);
        }
        Log.d(TAG, filename + " uploaded Error");
        closeSession(true);
    }

    public void closeSession(final boolean interrupted) {
        BluetoothModule.getInstance().closeSession();
        Log.d("TAG", "bluetooth interrupted");
    }
}
