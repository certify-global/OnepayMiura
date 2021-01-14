package com.onepay.miura.api;

import android.util.Log;

import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiBatteryStatusListener;
import com.miurasystems.mpi.api.listener.ApiGetConfigListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSystemClockListener;
import com.miurasystems.mpi.api.listener.ApiP2PEStatusListener;
import com.miurasystems.mpi.api.objects.P2PEStatus;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.core.Config;
import com.onepay.miura.data.DeviceApiData;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;

public class DeviceApi {
    private static final String TAG = DeviceApi.class.getSimpleName();
    private static DeviceApi instance = null;
    private DeviceInfoListener listener;
    private DeviceApiData deviceData = null;
    private String btAddress = "";
    private int mTimeOut = 60;
    private Timer mTimer;
    private boolean isTimerTimedOut = false;
    private boolean isDeviceInfoDataCheck = false;
    private String returnReason = "";
    private int returnStatus = 0;
    private String deviceSerialNumber = "";
    private String deviceOsType = "";
    private String deviceOsVersion = "";
    private String deviceMpiType = "";
    private String deviceMpiVersion = "";
    private String deviceChargingStatus = "";
    private String deviceBatteryLevel = "";
    private String devicePinKeyStatus = "";
    private String deviceSREDStatus = "";
    private String deviceDateTime = "";

    private BluetoothConnect.DeviceConnectListener deviceConnectListener;

    public interface DeviceInfoListener {
        void onGetDeviceInfoComplete(DeviceApiData data);
    }

    public static DeviceApi getInstance() {
        if (instance == null) {
            instance = new DeviceApi();
        }
        return instance;
    }

    /**
     * @param btAddress Miura device bluetooth address
     */
    public void getDeviceInfo(String btAddress, int tOut) {

        this.btAddress = btAddress;
        this.mTimeOut = tOut;
        startTimer();
        deviceData = new DeviceApiData();
        isDeviceInfoDataCheck = false;
        if (BluetoothModule.getInstance().isSessionOpen()) {
            loadDataPED();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.btAddress, deviceConnectListener);
        }
    }

    public void onDeviceInfo(DeviceInfoListener listener) {
        this.listener = listener;
    }

    private void reConnectDevice() {
        BluetoothConnect.getInstance().connect(this.btAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "onConnectionSuccess: ");

                loadDataPED();
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (listener != null && !isDeviceInfoDataCheck) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    listener.onGetDeviceInfoComplete(createDeviceApiData());
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");

                if (listener != null && !isDeviceInfoDataCheck) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    listener.onGetDeviceInfoComplete(createDeviceApiData());
                }
            }
        };
    }

    private void loadDataPED() {
        MiuraManager.getInstance().getSystemClock(new ApiGetSystemClockListener() {

            @WorkerThread
            @Override
            public void onSuccess(final Date dateTime) {
                DateFormat dateFormatApp = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss", Locale.ENGLISH);
                deviceData.setDateTime(dateFormatApp.format(dateTime));
            }

            @WorkerThread
            @Override
            public void onError() {
                closeSession();
            }
        });

        MiuraManager.getInstance().getBatteryStatus(new ApiBatteryStatusListener() {
            @WorkerThread
            @Override
            public void onSuccess(final int chargingStatus, int batteryLevel) {

                if (chargingStatus == 0) {
                    deviceChargingStatus = "OnBattery";
                } else if (chargingStatus == 1) {
                    deviceChargingStatus = "Charging";
                } else if (chargingStatus == 2) {
                    deviceChargingStatus = "OnBattery";
                }

                if (!Config.isBatteryValid(batteryLevel)) {
                    deviceBatteryLevel = "Please plug in charger";
                } else {
                    deviceBatteryLevel = batteryLevel + "%";
                }

                MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

                    @WorkerThread
                    @Override
                    public void onSuccess(SoftwareInfo softwareInfo) {
                        deviceSerialNumber = softwareInfo.getSerialNumber();
                        deviceOsType = softwareInfo.getOsType();
                        deviceOsVersion = softwareInfo.getOsVersion();
                        deviceMpiType = softwareInfo.getMpiType();
                        deviceMpiVersion = softwareInfo.getMpiVersion();
                        returnReason = Constants.SuccessReason;
                        returnStatus = Constants.SuccessStatus;
                        MiuraManager.getInstance().getPEDConfig(new ApiGetConfigListener() {
                            @WorkerThread
                            @Override
                            public void onSuccess(HashMap<String, String> configVersions) {

                                MiuraManager.getInstance().getP2PEStatus(new ApiP2PEStatusListener() {

                                    @WorkerThread
                                    @Override
                                    public void onSuccess(P2PEStatus P2PEStatus) {
                                        if (P2PEStatus.isPINReady) {
                                            devicePinKeyStatus = "Installed";
                                        } else {
                                            devicePinKeyStatus = "None";
                                        }
                                        if (P2PEStatus.isSREDReady) {
                                            deviceSREDStatus = "Installed";
                                        } else {
                                            deviceSREDStatus = "None";
                                        }

                                        if (listener != null && !isDeviceInfoDataCheck) {
                                            listener.onGetDeviceInfoComplete(createDeviceApiData());
                                        }
                                    }

                                    @WorkerThread
                                    @Override
                                    public void onError() {
                                        deviceData.setReturnStatus(2);
                                        deviceData.setReturnReason("Error! device p2peStatus");
                                    }
                                });
                            }

                            @WorkerThread
                            @Override
                            public void onError() {
                                deviceData.setReturnStatus(2);
                                deviceData.setReturnReason("Error! device config fetch failed");
                            }
                        });
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        if (listener != null && !isDeviceInfoDataCheck) {
                            returnReason = Constants.ErrorReason;
                            returnStatus = Constants.ErrorStatus;
                            listener.onGetDeviceInfoComplete(createDeviceApiData());
                        }
                        closeSession();
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                closeSession();
            }
        });
    }

    private DeviceApiData createDeviceApiData() {
        isDeviceInfoDataCheck = true;
        deviceData.setReturnReason(returnReason);
        deviceData.setReturnStatus(returnStatus);
        deviceData.setAddress(this.btAddress);
        deviceData.setType("PED");
        deviceData.setSerialNumber(deviceSerialNumber);
        deviceData.setOsType(deviceOsType);
        deviceData.setOsVersion(deviceOsVersion);
        deviceData.setMpiType(deviceMpiType);
        deviceData.setMpiVersion(deviceMpiVersion);
        deviceData.setChargingStatus(deviceChargingStatus);
        deviceData.setBatteryLevel(deviceBatteryLevel);
        deviceData.setPinKeyStatus(devicePinKeyStatus);
        deviceData.setsREDStatus(deviceSREDStatus);
        deviceData.setDateTime(deviceDateTime);

        cancelTimer();
        closeSession();
        return deviceData;
    }

    public void closeSession() {
        BluetoothModule.getInstance().closeSession();
        Log.d("TAG", "bluetooth interrupted");
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
                isDeviceInfoDataCheck = false;
                isTimerTimedOut = true;
                closeSession();
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