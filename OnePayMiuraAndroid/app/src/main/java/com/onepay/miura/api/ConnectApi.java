package com.onepay.miura.api;

import android.util.Log;

import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.data.ConnectApiData;

import java.util.Timer;
import java.util.TimerTask;

public class ConnectApi {

    private static final String TAG = ConnectApi.class.getSimpleName();
    private ConnectListener listener;
    private static ConnectApi instance = null;
    private ConnectApiData connectData = null;
    private int mTimeOut = 60;
    private String bluetoothAddress = "";
    private String returnReason = "";
    private int returnStatus = 0;
    private boolean isTimerTimedOut = false;
    private Timer mTimer, mBtDisconnectTimer;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;

    public interface ConnectListener {
        void onConnectionComplete(ConnectApiData data);
    }

    public static ConnectApi getInstance() {
        if (instance == null) {
            instance = new ConnectApi();
        }
        return instance;
    }

    /**
     * For connecting to the Miura device
     *
     * @param btAddress Miura device bluetooth address
     */
    public void connect(String btAddress, int tOut) {
        Log.d(TAG, "###RB#### connect method to set the parameters");
        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        connectData = new ConnectApiData();
        startTimer();

        setDeviceReconnectListener();
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    public void setConnectListener(ConnectListener listener) {
        Log.d(TAG, "###RB#### setConnectListener method to set the listener");
        this.listener = listener;
    }

    private void reConnectDevice() {
        Log.d(TAG, "###RB#### reconnecting the device");
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "###RB#### connection success: ");
                cancelTimer();
                if (listener != null) {
                    returnReason = Constants.SuccessReason;
                    returnStatus = Constants.SuccessStatus;
                    listener.onConnectionComplete(createConnectData());
                }
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "###RB#### connection error");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (listener != null) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    listener.onConnectionComplete(createConnectData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "###RB#### device disconnected");
                if (listener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    listener.onConnectionComplete(createConnectData());
                }
            }
        };
    }

    private ConnectApiData createConnectData() {
        connectData.setReturnReason(returnReason);
        connectData.setReturnStatus(returnStatus);
        return connectData;
    }

    private void endConnection() {
        if (listener != null) {
            returnReason = Constants.TimeoutReason;
            returnStatus = Constants.TimeoutStatus;
            listener.onConnectionComplete(createConnectData());
        }
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
                endConnection();
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