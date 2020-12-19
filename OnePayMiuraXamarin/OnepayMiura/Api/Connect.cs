using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;

namespace Onepay.Miura.Api
{
    public class Connect
    {

        public static event EventHandler<ConnectData> ConnectionComplete;

        public void ConnectDevice(string btAddress, int timeOut)
        {
            ConnectApi.Instance.Connect(btAddress, timeOut);
        }

        public class ConnectListener : Java.Lang.Object, ConnectApi.IConnectListener
        {
            public void OnConnectionComplete(ConnectApiData connectApiData)
            {
                ConnectData connectData = new ConnectData();
                connectData.ReturnReason = connectApiData.ReturnReason();
                connectData.ReturnStatus = connectApiData.ReturnStatus();

                ConnectionComplete?.Invoke(this, connectData);
            }
        }
    }
}