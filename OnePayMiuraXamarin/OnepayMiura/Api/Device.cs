using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;

namespace Onepay.Miura.Api
{
    public class Device
    {
        public static event EventHandler<DeviceData> DeviceInformationComplete;

        public void GetDeviceInfo(string btAddress)
        {
            DeviceApi.Instance.OnDeviceInfo(new DeviceListener());
            DeviceApi.Instance.GetDeviceInfo(btAddress);
        }

        public class DeviceListener : Java.Lang.Object, DeviceApi.IDeviceInfoListener
        {
            public void OnGetDeviceInfoComplete(DeviceApiData deviceApiData)
            {
                DeviceData deviceData = new DeviceData();
                deviceData.Address = deviceApiData.Address();
                deviceData.SerialNumber = deviceApiData.SerialNumber();
                deviceData.OsType = deviceApiData.OsType();
                deviceData.OsVersion = deviceApiData.OsVersion();
                deviceData.MpiType = deviceApiData.MpiType();
                deviceData.MpiVersion = deviceApiData.MpiVersion();
                deviceData.ChargingStatus = deviceApiData.ChargingStatus();
                deviceData.BatteryLevel = deviceApiData.BatteryLevel();
                deviceData.PinKeyStatus = deviceApiData.PinKeyStatus();
                deviceData.SREDStatus = deviceApiData.SREDStatus();
                deviceData.DateTime = deviceApiData.DateTime();

                DeviceInformationComplete?.Invoke(this, deviceData);
            }
        }
    }

}