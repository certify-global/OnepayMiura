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

namespace Onepay.Miura.Api
{
    public class Connect
    {
        public void ConnectDevice(string btAddress, ConnectListener listener)
        {
            ConnectApi.Instance.Connect(btAddress, listener);
        }

        public class ConnectListener : Java.Lang.Object, ConnectApi.IDeviceConnectListener
        {
            public void OnConnectionError()
            {
                //throw new NotImplementedException();
            }

            public void OnConnectionSuccess()
            {
                //throw new NotImplementedException();
            }

            public void OnDeviceDisconnected()
            {
                //throw new NotImplementedException();
            }
        }
    }
}