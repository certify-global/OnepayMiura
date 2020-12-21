﻿using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Java.Sql;
using Onepay.Miura.Data;


namespace Onepay.Miura.Api
{
    public class SetClock
    {

        public static event EventHandler<SetClockData> ConnectionComplete;

        public void SetDeviceClock(string btAddress, int timeOut, Date date)
        {
            SetClockApi.Instance.SetClockListener(new ClockListener());
            SetClockApi.Instance.SetDeviceClock(btAddress, timeOut, date);
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