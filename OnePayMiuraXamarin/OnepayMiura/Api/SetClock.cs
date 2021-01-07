using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;


namespace Onepay.Miura.Api
{
    public class SetClock
    {

        public static event EventHandler<SetClockData> ConnectionComplete;

        public void SetDeviceClock(string btAddress, int timeOut, DateTime dateTime)
        {
            try
            {
                string sDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                SetClockApi.Instance.SetClockListener(new ClockListener());
                SetClockApi.Instance.SetDeviceClock(btAddress, timeOut, sDate);
            }
            catch (Exception exception)
            {
                SetClockApiData setClockData = new SetClockApiData();
                setClockData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileTransactionInXamarin);
                setClockData.SetReturnReason(exception.ToString());
                new ClockListener().OnConnectionComplete(setClockData);
            }
        }

        public class ClockListener : Java.Lang.Object, SetClockApi.ISetClockListener
        {
            public void OnConnectionComplete(SetClockApiData clockData)
            {
                SetClockData setClockData = new SetClockData();
                setClockData.ReturnReason = clockData.ReturnReason();
                setClockData.ReturnStatus = clockData.ReturnStatus();

                ConnectionComplete?.Invoke(this, setClockData);
            }
        }

    }
}