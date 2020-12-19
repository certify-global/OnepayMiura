package com.onepay.miura.bluetooth;

import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;

import androidx.annotation.UiThread;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.onepay.miura.api.ConnectApi;

public class BluetoothConnect {
    private BluetoothDevice mBluetoothDevice;
    private BluetoothDeviceType mDeviceType;
    private DeviceConnectListener connectListener;
    private static BluetoothConnect instance = null;

    public interface DeviceConnectListener {
        void onConnectionSuccess();

        void onConnectionError();

        void onDeviceDisconnected();
    }

    public static BluetoothConnect getInstance() {
        if (instance == null) {
            instance = new BluetoothConnect();
        }
        return instance;
    }


    /**
     * For connecting to the Miura device
     * @param btAddress Miura device bluetooth address
     * @param listener callback listener for the connection results
     */
    public void connect(String btAddress, DeviceConnectListener listener) {
        mBluetoothDevice = BluetoothAdapter.getDefaultAdapter().getRemoteDevice(btAddress);
        this.connectListener = listener;
        mDeviceType = BluetoothDeviceType.getByDeviceTypeByName(mBluetoothDevice.getName());
        BluetoothModule.getInstance().setTimeoutEnable(false);
        BluetoothModule.getInstance().setSelectedBluetoothDevice(mBluetoothDevice);
        bindConnection();
    }

    /**
     * Miura device bluetooth connection
     */
    private void bindConnection() {

        MiuraManager.getInstance().setDeviceType(mDeviceType == BluetoothDeviceType.PED ?
                MiuraManager.DeviceType.PED : MiuraManager.DeviceType.POS);
        BluetoothModule.getInstance().setTimeoutEnable(true);
        BluetoothModule.getInstance().openSessionDefaultDevice(
                new BluetoothConnectionListener() {
                    @UiThread
                    @Override
                    public void onConnected() {
                        if (connectListener != null) {
                            connectListener.onConnectionSuccess();
                        }
                    }

                    @UiThread
                    @Override
                    public void onDisconnected() {
                        if (connectListener != null) {
                            connectListener.onDeviceDisconnected();
                        }
                    }

                    @UiThread
                    @Override
                    public void onConnectionAttemptFailed() {

                    }
                }
        );
    }
}
