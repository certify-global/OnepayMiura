package com.onepay.miura;

import android.Manifest;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import com.onepay.miura.api.ConfigApi;
import com.onepay.miura.api.ConnectApi;
import com.onepay.miura.api.DeviceApi;
import com.onepay.miura.api.ManualTransactionApi;
import com.onepay.miura.api.MpiUpdateApi;
import com.onepay.miura.api.SetClockApi;
import com.onepay.miura.api.TransactionApi;
import com.onepay.miura.data.ConfigApiData;
import com.onepay.miura.data.ConnectApiData;
import com.onepay.miura.data.DeviceApiData;
import com.onepay.miura.data.MpiUpdateApiData;
import com.onepay.miura.data.SetClockApiData;
import com.onepay.miura.data.TransactionApiData;


public class MainActivity extends AppCompatActivity {

    Button deviceInfo, transaction, cancelTransaction, manualTransaction, cancelManualTransaction, setDeviceClock;
    EditText edit_text_bt_address, edit_text_pin;
    //String btAddress = "0C:9A:42:89:2E:B9";
    //String btAddress = "C4:3A:35:40:56:51";
    //String btAddress  = "0C:9A:42:89:2E:CB";
    //String btAddress = "80:5E:4F:93:F6:AC";
    //String btAddress = "80:5E:4F:93:F6:CA";
    //String btAddress = "80:5E:4F:93:F8:1C";
    //80 5e 4f 93 f6 e5
    //String btAddress = "80:5E:4F:93:F6:E5";
    String btAddress = "C4:3A:35:D0:24:DD";
    //String btAddress = "C4:3A:35:D0:29:A4";
    boolean isPin = true;

    TextView showData;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

       /*if (Build.VERSION.SDK_INT >= 26 && (checkSelfPermission(Manifest.permission.READ_PHONE_STATE) != PackageManager.PERMISSION_GRANTED)) {
            requestPermissions(new String[]{Manifest.permission.READ_PHONE_STATE}, 1000);
        }*/
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
            if (checkSelfPermission(Manifest.permission.BLUETOOTH) != PackageManager.PERMISSION_GRANTED || checkSelfPermission(Manifest.permission.BLUETOOTH_ADMIN) != PackageManager.PERMISSION_GRANTED || checkSelfPermission(Manifest.permission.WRITE_EXTERNAL_STORAGE) != PackageManager.PERMISSION_GRANTED ||
                    checkSelfPermission(Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED
                    || checkSelfPermission(Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED || checkSelfPermission(Manifest.permission.READ_PHONE_STATE) != PackageManager.PERMISSION_GRANTED) {
                ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.BLUETOOTH, Manifest.permission.BLUETOOTH_ADMIN, Manifest.permission.WRITE_EXTERNAL_STORAGE,
                        Manifest.permission.ACCESS_COARSE_LOCATION, Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.READ_PHONE_STATE, Manifest.permission.READ_EXTERNAL_STORAGE}, 1000);
            }
        }

        //deviceInfo = findViewById(R.id.deviceInfoButton);
        transaction = findViewById(R.id.transactionButton);
        cancelTransaction = findViewById(R.id.cancelTransactionButton);
        cancelManualTransaction = findViewById(R.id.onManualCancelTransaction);
        showData = findViewById(R.id.show_text);
        edit_text_bt_address = findViewById(R.id.edit_text_bt_address);
        edit_text_pin = findViewById(R.id.edit_text_pin);
        edit_text_bt_address.setText(btAddress);
    }


    //1.Event Handler 2. BroadCast Message
    public void deviceInfo(View view) {

        /*DeviceApi.getInstance().getDeviceInfo("0C:9A:42:89:2E:B9", new DeviceApi.DeviceInfoListener() {
            @Override
            public void onGetDeviceInfoComplete(DeviceApiData data) {
                Log.d("TAG", " returnReason : " + data.dateTime());
            }
        });*/
        btAddress = edit_text_bt_address.getText().toString();
        ConnectApi.getInstance().connect(btAddress, 10, new ConnectApi.ConnectListener() {
            @Override
            public void onConnectionComplete(ConnectApiData data) {
                Log.d("TAG", " returnReason : " + data.returnReason());
                Log.d("TAG", " returnStatus : " + data.returnStatus());
                DeviceApi.getInstance().onDeviceInfo(new DeviceApi.DeviceInfoListener() {
                    @Override
                    public void onGetDeviceInfoComplete(DeviceApiData data) {
                        Log.d("TAG", " DeviceId : " + data.mpiVersion());

                    }
                });
                DeviceApi.getInstance().getDeviceInfo(btAddress, 10);
            }
        });
    }

    public void onTransaction(View view) {
       /* showData.setText("CARD DETAILS");
        btAddress = edit_text_bt_address.getText().toString();
        isPin = Boolean.parseBoolean(edit_text_pin.getText().toString().toLowerCase());*/
        btAddress = edit_text_bt_address.getText().toString();
        TransactionApi.getInstance().setTransactionParams(0.01, "", btAddress, true, false, 125);
        TransactionApi.getInstance().performTransaction(new TransactionApi.TransactionListener() {
            @Override
            public void onTransactionComplete(TransactionApiData data) {

                /* String cardData = "CARD DETAILS"
                        + "\n" + "TransactionType :" + data.entryMode()
                        + "\n" + "CardData :" + data.encryptedCardData()
                        + "\n" + "Amount :" + data.amount()
                        + "\n" + "ReturnStatus :" + data.returnStatus()
                        + "\n" + "ReturnReason :" + data.returnReason()
                        + "\n" + "CardHolderName :" + data.cardHolderName()
                        + "\n" + "CardNumber :" + data.cardNumber()
                        + "\n" + "CCFirstFour :" + data.accountFirstFour()
                        + "\n" + "CCLastFour :" + data.accountLastFour()
                        + "\n" + "ExpiryDate :" + data.expiryDate()
                        + "\n" + "PedDeviceId :" + data.deviceId()
                        + "\n" + "SRedKSN :" + data.KSN()
                        + "\n" + "PinKsn :" + data.pinKsn()
                        + "\n" + "PinData :" + data.pinData();
                showData.setText(cardData);*/

                Log.d("TAG", " DeviceId : " + data.deviceId());
                Log.d("TAG", " transactionType : " + data.entryMode());
                Log.d("TAG", " cardData : " + data.encryptedCardData());
                Log.d("TAG", " amount : " + data.amount());
                Log.d("TAG", " returnStatus : " + data.returnStatus());
                Log.d("TAG", " returnReason : " + data.returnReason());
                Log.d("TAG", " cardHolderName : " + data.cardHolderName());
                Log.d("TAG", " cardNumber : " + data.cardNumber());
                Log.d("TAG", " ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", " ccLastFour : " + data.accountLastFour());
                Log.d("TAG", " expiryDate : " + data.expiryDate());
                Log.d("TAG", " pedDeviceId : " + data.deviceId());
                Log.d("TAG", " sRedKSN : " + data.KSN());
                Log.d("TAG", " sPinKsn : " + data.pinKsn());
                Log.d("TAG", " sPinData : " + data.pinData());
                Log.d("TAG", " tlv : " + data.getTLVData());
            }
        });
    }

    public void onCancelTransaction(View view) {
        showData.setText("CARD DETAILS");
        TransactionApi.getInstance().cancelTransaction();

       /* ManualTransactionApi.getInstance().setManualTransactionParams(1, "", btAddress, 180, false, false);

        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {
                Log.d("TAG", " DeviceId : " + data.deviceId());
                Log.d("TAG", " transactionType : " + data.entryMode());
                Log.d("TAG", " cardData : " + data.encryptedCardData());
                Log.d("TAG", " amount : " + data.amount());
                Log.d("TAG", " returnStatus : " + data.returnStatus());
                Log.d("TAG", " returnReason : " + data.returnReason());
                Log.d("TAG", " cardHolderName : " + data.cardHolderName());
                Log.d("TAG", " cardNumber : " + data.cardNumber());
                Log.d("TAG", " ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", " ccLastFour : " + data.accountLastFour());
                Log.d("TAG", " expiryDate : " + data.expiryDate());
                Log.d("TAG", " pedDeviceId : " + data.deviceId());
                Log.d("TAG", " sRedKSN : " + data.KSN());

            }
        });*/
    }

  /*  public void onUpdateConfig(View view) {
        String path1 = Environment.getExternalStorageDirectory() + "/mpi_config/"; //getExternalFilesDir(null).getAbsolutePath() +  "/miura/";
        String path = "/storage/self/primary/prompt/";
        ConfigApi.getInstance().setConfigListener(new ConfigApi.ConfigInfoListener() {
            @Override
            public void onConfigUpdateComplete(ConfigApiData data) {
                Log.d("TAG", "Naga2........" + data.returnReason());
                Log.d("TAG", "Naga2........" + data.returnStatus());
            }
        });
        ConfigApi.getInstance().performConfig(btAddress, 380, path);
    }*/

    public void onOSUpdate(final View view) {
        String path = Environment.getExternalStorageDirectory() + "/Miura/";
        btAddress = edit_text_bt_address.getText().toString();

        MpiUpdateApi.getInstance().setPerformOSMpiUpdate(this, btAddress, 120, path, "M000-TESTOSUPDATE-V1-8.tar.gz.tmp");
        MpiUpdateApi.getInstance().performOSUpdate(new MpiUpdateApi.OSUpdateListener() {
            @Override
            public void onOSUpdateComplete(final String message) {
                Log.d("MainActivity", "onOSUpdate complete");
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(MainActivity.this, message, Toast.LENGTH_SHORT).show();
                        try {
                            Thread.sleep(20000);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                        onMpiUpdate(view);
                    }
                });
            }
        });
    }

    public void onMpiUpdate(View view) {
        String path = Environment.getExternalStorageDirectory() + "/Miura/"; //getExternalFilesDir(null).getAbsolutePath() +  "/miura/";
        btAddress = edit_text_bt_address.getText().toString();

        MpiUpdateApi.getInstance().setPerformOSMpiUpdate(this, btAddress, 120, path, "M000-TESTMPI-V1-64.tar.gz.tmp");

        MpiUpdateApi.getInstance().performMpiUpdate(new MpiUpdateApi.MpiUpdateListener() {
            @Override
            public void onMpiUpdateComplete(MpiUpdateApiData data) {
                Log.d("MainActivity", "onMpiUpdate complete");
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(MainActivity.this, "MPI Updated", Toast.LENGTH_SHORT).show();
                    }
                });
            }
        });
    }

    public void onUpdateConfig(View view) {

        //String path = getExternalFilesDir(null) + "/miura/"; //getExternalFilesDir(null).getAbsolutePath() +  "/miura/";
        String path = Environment.getExternalStorageDirectory() + "/Miura/"; //getExternalFilesDir(null).getAbsolutePath() +  "/miura/";
        btAddress = edit_text_bt_address.getText().toString();
        String path1 = "/storage/self/primary/mpi_config/";

        // 1-60b
        // 1-56
        /*MpiUpdateApi.getInstance().setPerformMpiUpdate(btAddress, 120, path, "M000-TESTMPI-V1-60.tar.gz");

        MpiUpdateApi.getInstance().performMpiUpdate(new MpiUpdateApi.MpiUpdateListener() {
            @Override
            public void onMpiUpdateComplete(MpiUpdateApiData data) {
                Log.d("TAG", " Reason : " + data.getReturnReason());
                Log.d("TAG", " status : " + data.getReturnStatus());

            }
        });*/

        ConfigApi.getInstance().setConfigListener(new ConfigApi.ConfigInfoListener() {
            @Override
            public void onConfigUpdateComplete(ConfigApiData data) {
                Log.d("MainActivity", "Config updated status ");
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(MainActivity.this, "Config files updated ", Toast.LENGTH_SHORT).show();
                    }
                });
            }
        });

        ConfigApi.getInstance().performConfig(this, btAddress, 120, path);
    }

    public void onManualTransaction(View view) {
        /*showData.setText("CARD DETAILS");*/
        btAddress = edit_text_bt_address.getText().toString();
        ManualTransactionApi.getInstance().setManualTransactionParams(0.01, "", btAddress, 180, false, false);

        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {

                /*String cardData = "CARD DETAILS"
                        + "\n" + "TransactionType :" + data.entryMode()
                        + "\n" + "CardData :" + data.encryptedCardData()
                        + "\n" + "Amount :" + data.amount()
                        + "\n" + "ReturnStatus :" + data.returnStatus()
                        + "\n" + "ReturnReason :" + data.returnReason()
                        + "\n" + "CardHolderName :" + data.cardHolderName()
                        + "\n" + "CardNumber :" + data.cardNumber()
                        + "\n" + "CCFirstFour :" + data.accountFirstFour()
                        + "\n" + "CCLastFour :" + data.accountLastFour()
                        + "\n" + "ExpiryDate :" + data.expiryDate()
                        + "\n" + "PedDeviceId :" + data.deviceId()
                        + "\n" + "SRedKSN :" + data.KSN();
                showData.setText(cardData);*/
                Log.d("TAG", " DeviceId : " + data.deviceId());
                Log.d("TAG", " transactionType : " + data.entryMode());
                Log.d("TAG", " cardData : " + data.encryptedCardData());
                Log.d("TAG", " amount : " + data.amount());
                Log.d("TAG", " returnStatus : " + data.returnStatus());
                Log.d("TAG", " returnReason : " + data.returnReason());
                Log.d("TAG", " cardHolderName : " + data.cardHolderName());
                Log.d("TAG", " cardNumber : " + data.cardNumber());
                Log.d("TAG", " ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", " ccLastFour : " + data.accountLastFour());
                Log.d("TAG", " expiryDate : " + data.expiryDate());
                Log.d("TAG", " pedDeviceId : " + data.deviceId());
                Log.d("TAG", " sRedKSN : " + data.KSN());
            }
        });
    }

    public void onManualEbtTransaction(View view) {
        btAddress = edit_text_bt_address.getText().toString();
        ManualTransactionApi.getInstance().setManualTransactionParams(0.01, "", btAddress, 180, true, false);
        ManualTransactionApi.getInstance().performManualTransaction(new ManualTransactionApi.ManualTransactionListener() {

            @Override
            public void onManualTransactionComplete(TransactionApiData data) {
                Log.d("TAG", " DeviceId : " + data.deviceId());
                Log.d("TAG", " transactionType : " + data.entryMode());
                Log.d("TAG", " cardData : " + data.encryptedCardData());
                Log.d("TAG", " amount : " + data.amount());
                Log.d("TAG", " returnStatus : " + data.returnStatus());
                Log.d("TAG", " returnReason : " + data.returnReason());
                Log.d("TAG", " cardHolderName : " + data.cardHolderName());
                Log.d("TAG", " cardNumber : " + data.cardNumber());
                Log.d("TAG", " ccFirstFour : " + data.accountFirstFour());
                Log.d("TAG", " ccLastFour : " + data.accountLastFour());
                Log.d("TAG", " expiryDate : " + data.expiryDate());
                Log.d("TAG", " pedDeviceId : " + data.deviceId());
                Log.d("TAG", " sRedKSN : " + data.KSN());

            }
        });
    }

    public void onCancelManualTransaction(View view) {
        showData.setText("CARD DETAILS");
        ManualTransactionApi.getInstance().cancelTransaction();
    }

    public void setDeviceClock(View view) throws Exception {

        // String sDate1 = "2020-09-25 12:29:24";
        String sDate1 = "2021-01-03 05:18:37";
        //Log.d("TAG", ".....setDeviceClock: " + sDate1);
      /*  DeviceApi.getInstance().onDeviceInfo(new SetClockApi.SetClockListener() {
            @Override
            public void onConnectionComplete(SetClockApiData data) {
                Log.d("TAG", "......returnReason: " + data.returnReason());
                Log.d("TAG", "......returnStatus: " + data.returnStatus());
            }
        });*/

        DeviceApi.getInstance().onDeviceInfo(new DeviceApi.DeviceInfoListener() {
            @Override
            public void onGetDeviceInfoComplete(DeviceApiData data) {
                Log.d("TAG", "......returnReason: " + data.returnReason());
                Log.d("TAG", "......returnStatus: " + data.returnStatus());
                Log.d("TAG", "......Address: " + data.address());
                Log.d("TAG", "......type: " + data.type());
                Log.d("TAG", "......SerialNumber: " + data.serialNumber());
                Log.d("TAG", "......OsType: " + data.osType());
                Log.d("TAG", "......osVersion: " + data.osVersion());
                Log.d("TAG", "......mpiType: " + data.mpiType());
                Log.d("TAG", "......mpiVersion: " + data.mpiVersion());
                Log.d("TAG", "......Charging Status : " + data.chargingStatus());
                Log.d("TAG", "......batteryLevel : " + data.batteryLevel());
                Log.d("TAG", "......pinKeyStatus: " + data.pinKeyStatus());
                Log.d("TAG", "......SRedStatus: " + data.sREDStatus());
            }
        });
        DeviceApi.getInstance().getDeviceInfo(btAddress, 380);
    }

    public void setDeviceInformation(View view) throws Exception {
        String sDate1 = "2021-01-03 05:18:37";

        Log.d("TAG", ".....setDeviceClock: " + sDate1);
        SetClockApi.getInstance().setClockListener(new SetClockApi.SetClockListener() {
            @Override
            public void onConnectionComplete(SetClockApiData data) {
                Log.d("TAG", "......returnReason: " + data.returnReason());
                Log.d("TAG", "......returnStatus: " + data.returnStatus());
            }
        });

        SetClockApi.getInstance().setDeviceClock(btAddress, 30, sDate1);
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
    }
}