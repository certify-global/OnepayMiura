package com.onepay.miura.api;

import android.util.Log;

import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiBatteryStatusListener;
import com.miurasystems.mpi.api.listener.ApiGetConfigListener;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSystemClockListener;
import com.miurasystems.mpi.api.listener.ApiP2PEStatusListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.P2PEStatus;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.core.Config;
import com.onepay.miura.data.DeviceApiData;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;

public class DeviceApi {
    private static final String TAG = DeviceApi.class.getSimpleName();
    private static DeviceApi instance = null;
    private DeviceInfoListener listener;
    private DeviceApiData deviceData = null;
    private String btAddress = "";

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
    public void getDeviceInfo(String btAddress) {

        this.btAddress = btAddress;
        BluetoothConnect.getInstance().connect(btAddress, new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d("TAG", "onConnectionSuccess: ");
                MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
                    @WorkerThread
                    @Override
                    public void onSuccess(final ArrayList<Capability> capabilities) {
                        BluetoothModule.getInstance().setTimeoutEnable(false);
                        loadDataPED();
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        BluetoothModule.getInstance().closeSession();

                    }
                });
            }

            @Override
            public void onConnectionError() {
                Log.d("TAG", "onConnectionError: ");
                if (listener != null) {
                    deviceData.setReturnStatus(2);
                    deviceData.setReturnReason("onConnectionError: ");
                    listener.onGetDeviceInfoComplete(deviceData);
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");
                if (listener != null) {
                    deviceData.setReturnStatus(2);
                    deviceData.setReturnReason("onDeviceDisconnected: ");
                    listener.onGetDeviceInfoComplete(deviceData);
                }
            }
        });
    }


    public void onDeviceInfo(DeviceInfoListener listener) {
        this.listener = listener;
    }

    private void loadDataPED() {
        deviceData = new DeviceApiData();
        deviceData.setAddress(btAddress);
        deviceData.setType("PED");
        MiuraManager.getInstance().getBatteryStatus(new ApiBatteryStatusListener() {
            @WorkerThread
            @Override
            public void onSuccess(final int chargingStatus, int batteryLevel) {

                if (chargingStatus == 0) {
                    deviceData.setChargingStatus("OnBattery");
                } else if (chargingStatus == 1) {
                    deviceData.setChargingStatus("Charging");
                } else if (chargingStatus == 2) {
                    deviceData.setChargingStatus("Charged");
                }

                if (!Config.isBatteryValid(batteryLevel)) {
                    deviceData.setBatteryLevel("Please plug in charger");
                } else {
                    deviceData.setBatteryLevel(batteryLevel + "%");
                }

                MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

                    @WorkerThread
                    @Override
                    public void onSuccess(SoftwareInfo softwareInfo) {
                        deviceData.setSerialNumber(softwareInfo.getSerialNumber());
                        deviceData.setOsType(softwareInfo.getOsType());
                        deviceData.setOsVersion(softwareInfo.getOsVersion());
                        deviceData.setMpiType(softwareInfo.getMpiType());
                        deviceData.setMpiVersion(softwareInfo.getMpiVersion());
                        deviceData.setReturnStatus(1);
                        deviceData.setReturnReason("Success");

                        if (listener != null) {
                            listener.onGetDeviceInfoComplete(deviceData);
                        }

                        MiuraManager.getInstance().getPEDConfig(new ApiGetConfigListener() {
                            @WorkerThread
                            @Override
                            public void onSuccess(HashMap<String, String> configVersions) {

                                MiuraManager.getInstance().getP2PEStatus(new ApiP2PEStatusListener() {

                                    @WorkerThread
                                    @Override
                                    public void onSuccess(P2PEStatus P2PEStatus) {
                                        if (P2PEStatus.isPINReady) {
                                            deviceData.setPinKeyStatus("Installed");
                                        } else {
                                            deviceData.setPinKeyStatus("None");
                                        }
                                        if (P2PEStatus.isSREDReady) {
                                            deviceData.setsREDStatus("Installed");
                                        } else {
                                            deviceData.setsREDStatus("None");
                                        }

                                        MiuraManager.getInstance().getSystemClock(new ApiGetSystemClockListener() {

                                            @WorkerThread
                                            @Override
                                            public void onSuccess(final Date dateTime) {
                                                DateFormat dateFormatApp = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss", Locale.ENGLISH);
                                                deviceData.setDateTime(dateFormatApp.format(dateTime));
                                                closeSession(false);
                                            }

                                            @WorkerThread
                                            @Override
                                            public void onError() {
                                                closeSession(true);
                                            }
                                        });
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
                        deviceData.setReturnStatus(2);
                        deviceData.setReturnReason("Error! Couldn't find the MIURA device");
                        closeSession(true);
                    }
                });
            }

            @WorkerThread
            @Override
            public void onError() {
                closeSession(true);
            }
        });
    }

    public void closeSession(final boolean interrupted) {
        BluetoothModule.getInstance().closeSession();
        Log.d("TAG", "bluetooth interrupted");
    }

}
