package com.onepay.miura.api;

import android.annotation.SuppressLint;
import android.util.Log;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.events.MpiEvents;
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
    private boolean isSetClockDataCheck = false;

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
     * This method for device clock
     *
     * @param btAddress Miura device bluetooth address
     * @param tOut      Timeout for the setDeviceClock
     * @param dateTime  DateTime
     */
    public void setDeviceClock(String btAddress, int tOut, String dateTime) throws Exception {
        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        this.date = convertDateTime(dateTime);
        setClockData = new SetClockApiData();
        startTimer();
        isSetClockDataCheck = false;
        if (BluetoothModule.getInstance().isSessionOpen()) {
            setDeviceClock();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    public void setClockListener(SetClockListener listener) {
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

                setDeviceClock();
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (listener != null && !isSetClockDataCheck) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                if (listener != null && !isSetClockDataCheck) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
            }
        };
    }

    private void setDeviceClock() {
        MiuraManager.getInstance().setSystemClock(date, new MiuraDefaultListener() {
            @Override
            public void onSuccess() {
                if (listener != null && !isSetClockDataCheck) {
                    returnReason = Constants.SuccessReason;
                    returnStatus = Constants.SuccessStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
                disconnectBtTimer();
            }

            @Override
            public void onError() {
                if (listener != null && !isSetClockDataCheck) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    listener.onConnectionComplete(createSetClockData());
                }
                disconnectBtTimer();
            }
        });
    }

    private Date convertDateTime(String dateTime) throws Exception {
        @SuppressLint("SimpleDateFormat")
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        Date date = sdf.parse(dateTime);
        return date;
    }

    private SetClockApiData createSetClockData() {
        isSetClockDataCheck = true;
        setClockData.setReturnReason(returnReason);
        setClockData.setReturnStatus(returnStatus);
        cancelTimer();
        return setClockData;
    }

    private void endConnection() {
        if (listener != null && !isSetClockDataCheck) {
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
                isSetClockDataCheck = false;
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

    private void disconnectBtTimer() {
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