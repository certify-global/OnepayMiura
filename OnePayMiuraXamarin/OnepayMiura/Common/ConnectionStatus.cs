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

namespace Onepay.Miura
{
    public enum ConnectionStatus //I believe this is the ReturnStatus in TransactionData data model
    {
        Success = 1,
        Error = 2,
        Cancel = 3,
        BluetoothConnectionError = 4,
        BluetoothDisconnected = 5, //Hard Reset
        Timeout = 6,
        InvalidParameters = 7,
        NoPEDPaired = 8,
        ExceptionWhileTransaction = 10,
        ExceptionWhileAbort = 11,
        ExceptionWhileTransactionInXamarin = 12,
        ExceptionWhileAbortInXamarin = 13
    }
}