package com.onepay.miura;

import android.Manifest;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

import com.onepay.miura.api.ConfigApi;
import com.onepay.miura.api.ConnectApi;
import com.onepay.miura.api.DeviceApi;
import com.onepay.miura.api.ManualTransactionApi;
import com.onepay.miura.api.SetClockApi;
import com.onepay.miura.api.TransactionApi;
import com.onepay.miura.data.ConfigApiData;
import com.onepay.miura.data.ConnectApiData;
import com.onepay.miura.data.DeviceApiData;
import com.onepay.miura.data.SetClockApiData;
import com.onepay.miura.data.TransactionApiData;

import java.text.SimpleDateFormat;
import java.util.Date;


public class MainActivity extends AppCompatActivity {

    Button deviceInfo, transaction, cancelTransaction, manualTransaction, cancelManualTransaction, setDeviceClock;

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
        setDeviceClock = findViewById(R.id.setDeviceClock);
    }

    //1.Event Handler 2. BroadCast Message
    public void deviceInfo(View view) {

        /*DeviceApi.getInstance().getDeviceInfo("0C:9A:42:89:2E:B9", new DeviceApi.DeviceInfoListener() {
            @Override
            public void onGetDeviceInfoComplete(DeviceApiData data) {
                Log.d("TAG", "Naga...... returnReason : " + data.dateTime());
            }
        });*/

        ConnectApi.getInstance().connect("0C:9A:42:89:2E:B9", 60, new ConnectApi.ConnectListener() {
            @Override
            public void onConnectionComplete(ConnectApiData data) {
                Log.d("TAG", "Naga...... returnReason : " + data.returnReason());
                Log.d("TAG", "Naga...... returnStatus : " + data.returnStatus());
            }
        });
    }

    public void onTransaction(View view) {
        TransactionApi.getInstance().setTransactionParams(1.00, "", "0C:9A:42:89:2E:B9",180 );
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
        String path1 = Environment.getExternalStorageDirectory() + "/miura/"; //getExternalFilesDir(null).getAbsolutePath() +  "/miura/";
        String path = "/storage/self/primary/mpi_config/";
        ConfigApi.getInstance().performConfig("0C:9A:42:89:2E:B9", 200, path, new ConfigApi.ConfigInfoListener() {
            @Override
            public void onConfigUpdateComplete(ConfigApiData data) {
                Log.d("TAG", "Naga2........" + data.returnReason());
                Log.d("TAG", "Naga2........" + data.returnStatus());
            }
        });
    }

    public void onManualTransaction(View view) {
        ManualTransactionApi.getInstance().setManualTransactionParams(1, "", "0C:9A:42:89:2E:B9", 60, false, false);

        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {

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

    public void onCancelManualTransaction(View view) {
        /**
         * Method that initiate for canceling transaction
         */
        ManualTransactionApi.getInstance().cancelTransaction();
    }

    public void setDeviceClock(View view) throws Exception {

       // String sDate1 = "2020-09-25 12:29:24";
        String sDate1 = "2021-01-03 05:18:37";
        //Log.d("TAG", "Naga...........setDeviceClock: " + sDate1);
        SetClockApi.getInstance().setDeviceClock("0C:9A:42:89:2E:B9", 30, sDate1, new SetClockApi.SetClockListener() {
            @Override
            public void onConnectionComplete(SetClockApiData data) {
                Log.d("TAG", "Naga............returnReason: " + data.returnReason());
                Log.d("TAG", "Naga............returnStatus: " + data.returnStatus());
            }
        });
    }

}