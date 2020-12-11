package com.onepay.miura.data;

public class DeviceApiData {
    private String address;
    private String type;
    private String serialNumber;
    private String osType;
    private String osVersion;
    private String mpiType;
    private String mpiVersion;
    private String chargingStatus;
    private String batteryLevel;
    private String pinKeyStatus;
    private String sREDStatus;
    private String dateTime;

    public String address() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String type() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String serialNumber() {
        return serialNumber;
    }

    public void setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
    }

    public String osType() {
        return osType;
    }

    public void setOsType(String osType) {
        this.osType = osType;
    }

    public String osVersion() {
        return osVersion;
    }

    public void setOsVersion(String osVersion) {
        this.osVersion = osVersion;
    }

    public String mpiType() {
        return mpiType;
    }

    public void setMpiType(String mpiType) {
        this.mpiType = mpiType;
    }

    public String mpiVersion() {
        return mpiVersion;
    }

    public void setMpiVersion(String mpiVersion) {
        this.mpiVersion = mpiVersion;
    }

    public String chargingStatus() {
        return chargingStatus;
    }

    public void setChargingStatus(String chargingStatus) {
        this.chargingStatus = chargingStatus;
    }

    public String batteryLevel() {
        return batteryLevel;
    }

    public void setBatteryLevel(String batteryLevel) {
        this.batteryLevel = batteryLevel;
    }

    public String pinKeyStatus() {
        return pinKeyStatus;
    }

    public void setPinKeyStatus(String pinKeyStatus) {
        this.pinKeyStatus = pinKeyStatus;
    }

    public String sREDStatus() {
        return sREDStatus;
    }

    public void setsREDStatus(String sREDStatus) {
        this.sREDStatus = sREDStatus;
    }

    public String dateTime() {
        return dateTime;
    }

    public void setDateTime(String dateTime) {
        this.dateTime = dateTime;
    }
}
