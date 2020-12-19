package com.onepay.miura;

import androidx.appcompat.app.AppCompatActivity;

import android.Manifest;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.onepay.miura.api.ConfigApi;
import com.onepay.miura.api.ConnectApi;
import com.onepay.miura.api.DeviceApi;
import com.onepay.miura.api.ManualTransactionApi;
import com.onepay.miura.api.TransactionApi;
import com.onepay.miura.data.ConfigApiData;
import com.onepay.miura.data.ConnectApiData;
import com.onepay.miura.data.DeviceApiData;
import com.onepay.miura.data.TransactionApiData;

public class MainActivity extends AppCompatActivity {

    Button deviceInfo, transaction, cancelTransaction, manualTransaction, cancelManualTransaction;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if (Build.VERSION.SDK_INT >= 26 && (checkSelfPermission(Manifest.permission.READ_PHONE_STATE) != PackageManager.PERMISSION_GRANTED)) {
            requestPermissions(new String[]{Manifest.permission.READ_PHONE_STATE}, 1000);
        }
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
            if (checkSelfPermission(Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED ||
                    checkSelfPermission(Manifest.permission.WRITE_EXTERNAL_STORAGE) != PackageManager.PERMISSION_GRANTED ||
                    checkSelfPermission(Manifest.permission.READ_PHONE_STATE) != PackageManager.PERMISSION_GRANTED) {
                requestPermissions(new String[]{Manifest.permission.CAMERA, Manifest.permission.WRITE_EXTERNAL_STORAGE, Manifest.permission.READ_PHONE_STATE}, 1000);
            }
        }

        deviceInfo = findViewById(R.id.deviceInfoButton);
        transaction = findViewById(R.id.transactionButton);
        cancelTransaction = findViewById(R.id.cancelTransactionButton);
        manualTransaction = findViewById(R.id.onManualTransaction);
        cancelManualTransaction = findViewById(R.id.onManualCancelTransaction);
    }

    public void deviceInfo(View view) {
        //initDevice("C4:3A:35:D0:29:A4");
        ConnectApi.getInstance().connect("0C:9A:42:89:2E:B9", 10, new ConnectApi.ConnectListener(){

            @Override
            public void onConnectionComplete(ConnectApiData data) {
                Log.d("TAG", "Naga...... returnReason : " + data.returnReason());
                Log.d("TAG", "Naga...... returnStatus : " + data.returnStatus());
            }
        });
       }

    public void onTransaction(View view) {
        TransactionApi.getInstance().setTransactionParams(1234.56, "", "0C:9A:42:89:2E:B9", 20);
        TransactionApi.getInstance().performTransaction(new TransactionApi.TransactionListener() {
            @Override
            public void onTransactionComplete(TransactionApiData data) {
                Log.d("TAG", "Naga...... transactionType : " + data.entryMode());
                Log.d("TAG", "Naga...... cardData : " + data.encryptedCardData());
                Log.d("TAG", "Naga...... amount : " + data.amount());
                Log.d("TAG", "Naga...... returnStatus : " + data.returnStatus());
                Log.d("TAG", "Naga...... returnReason : " + data.returnReason());
                Log.d("TAG", "Naga...... cardHolderName : " + data.cardHolderName());
                Log.d("TAG", "Naga...... cardNumber : " + data.cardNumber());
                Log.d("TAG", "Naga...... ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", "Naga...... ccLastFour : " + data.accountLastFour());
                Log.d("TAG", "Naga...... expiryDate : " + data.expiryDate());
                Log.d("TAG", "Naga...... pedDeviceId : " + data.deviceId());
                Log.d("TAG", "Naga...... sRedKSN : " + data.KSN());
            }
        });
    }

    public void onCancelTransaction(View view) {
        TransactionApi.getInstance().cancelTransaction();
    }

    public void onUpdateConfig(View view) {
        ConfigApi.getInstance().performConfig("0C:9A:42:89:2E:B9", 60, "", new ConfigApi.ConfigInfoListener() {
            @Override
            public void onConfigUpdateComplete(ConfigApiData data) {
                Log.d("TAG", "Naga2........" + data.returnReason());
                Log.d("TAG", "Naga2........" + data.returnStatus());
            }
        });
    }

    public void onManualTransaction(View view) {
        ManualTransactionApi.getInstance().setManualTransactionParams(1, "", "0C:9A:42:89:2E:B9", 60, true);

        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {

                Log.d("TAG", "Naga...... transactionType : " + data.entryMode());
                Log.d("TAG", "Naga...... cardData : " + data.encryptedCardData());
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
        });
    }

    public void onCancelManualTransaction(View view){
        /**
         * Method that initiate for canceling transaction
         */
        ManualTransactionApi.getInstance().cancelTransaction();
    }
}