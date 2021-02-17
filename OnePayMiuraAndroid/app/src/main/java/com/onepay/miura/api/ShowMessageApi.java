package com.onepay.miura.api;


import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.data.ShowMessageApiData;

public class ShowMessageApi {


    private static final String TAG = ShowMessageApi.class.getSimpleName();
    private static ShowMessageApi instance = null;
    private String bluetoothAddress = "";
    private int mTimeOut = 60;
    private String displayMessage = "";
    private ShowMessageApiData showMessageData = null;

    public interface TransactionListener {
        void onTransactionComplete(ShowMessageApiData data);
    }

    public static ShowMessageApi getInstance() {
        if (instance == null) {
            instance = new ShowMessageApi();
        }
        return instance;
    }

   /* public void displayMessage(String btAddress, int tOut, String message){
        bluetoothAddress = btAddress;
        mTimeOut = tOut;
        displayMessage = message;
        showMessageData = new ShowMessageApiData();
        startTimer();

        if (BluetoothModule.getInstance().isSessionOpen()) {
            getDeviceInfo();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }*/
}
