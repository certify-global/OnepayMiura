package com.onepay.miura;

import androidx.appcompat.app.AppCompatActivity;

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
import com.onepay.miura.data.DeviceApiData;
import com.onepay.miura.data.TransactionApiData;

public class MainActivity extends AppCompatActivity {

    Button deviceInfo, transaction, cancelTransaction, manualTransaction, cancelManualTransaction;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        deviceInfo = findViewById(R.id.deviceInfoButton);
        transaction = findViewById(R.id.transactionButton);
        cancelTransaction = findViewById(R.id.cancelTransactionButton);
        manualTransaction = findViewById(R.id.onManualTransaction);
        cancelManualTransaction = findViewById(R.id.onManualCancelTransaction);
    }

    public void deviceInfo(View view) {
        //initDevice("C4:3A:35:D0:29:A4");
        DeviceApi.getInstance().getDeviceInfo("0C:9A:42:89:2E:B9");
      /*  , new DeviceApi.DeviceInfoListener() {

            @Override
            public void onGetDeviceInfoComplete(DeviceApiData data) {
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
        });*/

    }

    public void onTransaction(View view) {
        TransactionApi.getInstance().setTransactionParams(1, "", "0C:9A:42:89:2E:B9", 60);
        TransactionApi.getInstance().performTransaction(new TransactionApi.TransactionListener() {
            @Override
            public void onTransactionComplete(TransactionApiData data) {
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

    public void onCancelTransaction(View view) {
        TransactionApi.getInstance().cancelTransaction();
    }

    public void onUpdateConfig(View view) {
        ConfigApi.getInstance().performConfig(this, "0C:9A:42:89:2E:B9", new ConfigApi.ConfigInfoListener() {
            @Override
            public void onConfigUpdateComplete(ConfigApiData data) {
                Log.d("TAG", "Naga1........" + data.returnReason());
            }
        });
    }

    public void onManualTransaction(View view) {
        ManualTransactionApi.getInstance().setManualTransactionParams(1, "", "0C:9A:42:89:2E:B9", 60);

        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {

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