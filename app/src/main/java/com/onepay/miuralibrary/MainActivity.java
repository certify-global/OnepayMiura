package com.onepay.miuralibrary;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.onepay.miuralibrary.api.Config;
import com.onepay.miuralibrary.api.Device;
import com.onepay.miuralibrary.api.Transaction;
import com.onepay.miuralibrary.data.DeviceData;
import com.onepay.miuralibrary.data.TransactionData;

public class MainActivity extends Activity {

    Button deviceInfo, transaction, cancelTransaction;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        deviceInfo = findViewById(R.id.deviceInfoButton);
        transaction = findViewById(R.id.transactionButton);
        cancelTransaction = findViewById(R.id.cancelTransactionButton);

    }

    public void deviceInfo(View view) {
        //initDevice("C4:3A:35:D0:29:A4");
        Device.getInstance().getDeviceInfo("0C:9A:42:89:2E:B9", new Device.DeviceInfoListener() {
            @Override
            public void onGetDeviceInfoSuccess(DeviceData data) {
                Log.d("TAG", "Naga...... address : " + data.address());
                Log.d("TAG", "Naga...... type : " + data.type());
                Log.d("TAG", "Naga...... serialNumber : " + data.serialNumber());
                Log.d("TAG", "Naga...... osType : " + data.osType());
                Log.d("TAG", "Naga...... osVersion : " + data.osVersion());
                Log.d("TAG", "Naga...... mpiType : " + data.mpiType());
                Log.d("TAG", "Naga...... mpiVersion : " + data.mpiVersion());
                Log.d("TAG", "Naga...... chargingStatus : " + data.chargingStatus());
                Log.d("TAG", "Naga...... batteryLevel : " + data.batteryLevel());
                Log.d("TAG", "Naga...... pinKeyStatus : " + data.pinKeyStatus());
                Log.d("TAG", "Naga...... sRedStatus : " + data.sREDStatus());
                Log.d("TAG", "Naga...... dateTime : " + data.dateTime());
            }

            @Override
            public void onGetDeviceInfoError(String errorMessage) {

            }
        });

    }

    public void onTransaction(View view) {
        Transaction.getInstance().setTransactionParams(1, "", "0C:9A:42:89:2E:B9", 60);
        Transaction.getInstance().performTransaction(new Transaction.TransactionListener() {
            @Override
            public void onTransactionSuccess(TransactionData data) {
                Log.d("TAG", "Naga...... transactionType : " + data.entryMode());
                Log.d("TAG", "Naga...... cardData : " + data.cardData());
                Log.d("TAG", "Naga...... amount : " + data.amount());
                Log.d("TAG", "Naga...... returnStatus : " + data.returnStatus());
                Log.d("TAG", "Naga...... cardHolderName : " + data.cardHolderName());
                Log.d("TAG", "Naga...... cardNumber : " + data.cardNumber());
                Log.d("TAG", "Naga...... ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", "Naga...... ccLastFour : " + data.accountLastFour());
                Log.d("TAG", "Naga...... expiryDate : " + data.expiryDate());
                Log.d("TAG", "Naga...... pedDeviceId : " + data.deviceId());
                Log.d("TAG", "Naga...... sRedKSN : " + data.KSN());
            }

            @Override
            public void onTransactionError(String errorMessage) {
                Log.d("TAG", "Naga1........" + errorMessage);
            }

            @Override
            public void onTransactionAborted(boolean status) {

            }
        });
    }

    public void onCancelTransaction(View view) {
        Transaction.getInstance().cancelTransaction();
    }

    public void onUpdateConfig(View view){
        Config.getInstance().performConfig(this, "0C:9A:42:89:2E:B9", new Config.ConfigInfoListener() {
            @Override
            public void onConfigSuccess() {

            }

            @Override
            public void onConfigError(String errorMessage) {

                Log.d("TAG", "Naga1........" + errorMessage);
            }
        });
    }
}