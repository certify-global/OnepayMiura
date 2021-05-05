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
            try { 
            ConfigApi.Instance.SetConfigListener(new ConfigListner());
            ConfigApi.Instance.PerformConfig(btAddress, timeOut, filePath);
            }
            catch (Exception exception)
            {
                ConfigApiData configData = new ConfigApiData();
                configData.SetReturnStatus(2);
                configData.SetReturnReason("Failure" +exception.ToString());
                new ConfigListner().OnConfigUpdateComplete(configData);
            }
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