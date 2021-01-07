using System;
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
            try
            {
                ConnectApi.Instance.SetConnectListener(new ConnectListener());
                ConnectApi.Instance.Connect(btAddress, timeOut);
            }
            catch (Exception exception)
            {
                ConnectApiData connectData = new ConnectApiData();
                connectData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileTransactionInXamarin);
                connectData.SetReturnReason(exception.ToString());
                new ConnectListener().OnConnectionComplete(connectData);
            }
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