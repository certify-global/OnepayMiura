package com.onepay.miura.api;

import android.text.PrecomputedText;
import android.util.Log;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.data.SetClockApiData;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class SetClockApi {

    private SetClockListener listener;
    private static SetClockApi instance = null;
    private SetClockApiData setClockData = null;
    private int mTimeOut = 60;
    private String bluetoothAddress = "";
    private String returnReason = "";
    private int returnStatus = 0;
    private boolean isTimerTimedOut = false;
    private Timer mTimer, mBtDisconnectTimer;
    private Date date;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;

    public interface SetClockListener {
        void onConnectionComplete(SetClockApiData data);
    }

    public static SetClockApi getInstance() {
        if (instance == null) {
            instance = new SetClockApi();
        }
        return instance;
    }

    /**
     * For connecting to the Miura device
     * @param btAddress Miura device bluetooth address
     */
    public void setDeviceClock(String btAddress, int tOut, String dateTime, SetClockListener listener) throws Exception {
        this.listener = listener;

        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.date = convertDateTime(dateTime);
        setClockData = new SetClockApiData();
        startTimer();

        setDeviceReconnectListener();
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void reConnectDevice() {
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "onConnectionSuccess: ");

                setDeviceClock();
                disconnectBtTimer();
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
                    listener.onConnectionComplete(createSetClockData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                if (listener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
            }
        };
    }

    public Date convertDateTime(String dateTime) throws Exception {
        //String sDate1="12/21/2020 12:29:24";
        Date date=new SimpleDateFormat("dd/MM/yyyy HH:mm:ss").parse(dateTime);
        return date;
    }

    private int setDeviceClock(){
        MiuraManager.getInstance().setSystemClock(date, new MiuraDefaultListener() {
            @Override
            public void onSuccess() {
                if (listener != null) {
                    returnReason = Constants.SuccessReason;
                    returnStatus = Constants.SuccessStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
            }

            @Override
            public void onError() {
                if (listener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
            }
        });

        return 1;
    }

    private SetClockApiData createSetClockData() {
        setClockData.setDateTime(date);
        setClockData.setReturnReason(returnReason);
        setClockData.setReturnStatus(returnStatus);
        cancelTimer();
        return setClockData;
    }

    private void endConnection(){
        if (listener != null) {
            returnReason = Constants.TimeoutReason;
            returnStatus = Constants.TimeoutStatus;
            listener.onConnectionComplete(createSetClockData());
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

    private void disconnectBtTimer(){
        cancelDisconnectBtTimer();
        mBtDisconnectTimer = new Timer();
        mBtDisconnectTimer.schedule(new TimerTask() {
            public void run() {
                BluetoothModule.getInstance().closeSession();
                this.cancel();
            }
        }, 2 * 1000);
    }

    private void cancelDisconnectBtTimer() {
        if (mTimer != null) {
            mTimer.cancel();
            mTimer = null;
        }
    }
}