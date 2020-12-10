package com.onepay.miuralibrary.bluetooth;

import androidx.annotation.UiThread;

@UiThread
public interface BluetoothConnectionListener {

    void onConnected();

    void onDisconnected();

    void onConnectionAttemptFailed();
}
