package com.onepay.miuralibrary.api;

import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.util.Log;

import androidx.annotation.UiThread;
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
import com.onepay.miuralibrary.bluetooth.BluetoothConnect;
import com.onepay.miuralibrary.bluetooth.BluetoothConnectionListener;
import com.onepay.miuralibrary.bluetooth.BluetoothDeviceType;
import com.onepay.miuralibrary.bluetooth.BluetoothModule;
import com.onepay.miuralibrary.core.Config;
import com.onepay.miuralibrary.data.DeviceData;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;

public class Device {
    private static final String TAG = Device.class.getSimpleName();
    private static Device instance = null;
    private DeviceInfoListener listener;
    private DeviceData deviceData = null;
    private String btAddress ="";

    public interface DeviceInfoListener {
        void onGetDeviceInfoSuccess(DeviceData data);

        void onGetDeviceInfoError(String errorMessage);
    }

    public static Device getInstance() {
        if (instance == null) {
            instance = new Device();
        }
        return instance;
    }

    /**
     * @param btAddress Miura device bluetooth address
     * @param listener  Call back listener for device information
     */
    public void getDeviceInfo(String btAddress, DeviceInfoListener listener) {
        this.listener = listener;
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
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d("TAG", "onDeviceDisconnected: ");
            }
        });
    }

    private void loadDataPED() {
        deviceData = new DeviceData();
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

                        if (listener != null) {
                            listener.onGetDeviceInfoSuccess(deviceData);
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
                                        if (listener != null) {
                                            listener.onGetDeviceInfoError("Error! device p2peStatus");
                                        }
                                    }
                                });
                            }

                            @WorkerThread
                            @Override
                            public void onError() {
                                if (listener != null) {
                                    listener.onGetDeviceInfoError("Error! device config fetch failed");
                                }
                            }
                        });
                    }

                    @WorkerThread
                    @Override
                    public void onError() {
                        if (listener != null) {
                            listener.onGetDeviceInfoError("Error! Couldn't find the MIURA device");
                        }
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
