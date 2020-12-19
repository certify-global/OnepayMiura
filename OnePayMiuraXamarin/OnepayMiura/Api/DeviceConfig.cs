using Android.Content;
using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;

namespace Onepay.Miura.Api
{
    public class DeviceConfig
    {
        public static event EventHandler<ConfigDeviceData> ConfigUpdateComplete;

        public void PerformConfig(string btAddress, int timeOut, string filePath)
        {
            ConfigApi.Instance.OnConfigInfo(new ConfigListner());
            ConfigApi.Instance.PerformConfig(btAddress, timeOut, filePath);
        }

        public class ConfigListner : Java.Lang.Object, ConfigApi.IConfigInfoListener
        {
            public void OnConfigUpdateComplete(ConfigApiData configApiData)
            {
                ConfigDeviceData configData = new ConfigDeviceData();
                configData.ReturnReason = configApiData.ReturnReason();
                configData.ReturnStatus = configApiData.ReturnStatus();

                ConfigUpdateComplete?.Invoke(this, configData);
            }
        }
    }
}