using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;

namespace Onepay.Miura.Api

{
    public class Transaction
    {
        public static event EventHandler<TransactionData> TransactionComplete;
        public void PerformTransaction(float amt, String desc, String btAddress, int tOut)
        {
            TransactionApi.Instance.SetTransactionParams(amt, desc, btAddress, tOut);
            TransactionApi.Instance.PerformTransaction(new Transaction.TransactionListener());
        }
        public void CancelTransaction()
        {
            TransactionApi.Instance.CancelTransaction();

        }

        public void ClearData()
        {
            TransactionApi.Instance.ClearData();
        }

        public class TransactionListener : Java.Lang.Object, TransactionApi.ITransactionListener
        {
            TransactionData transactionData = new TransactionData();

            public void OnTransactionComplete(TransactionApiData transactionApiData )
            {
                transactionData.DeviceCode = transactionApiData.DeviceCode();
                transactionData.EntryMode = transactionApiData.EntryMode();
                transactionData.EncryptedCardData = transactionApiData.EncryptedCardData();
                transactionData.Amount = transactionApiData.Amount();
                transactionData.ReturnStatus = transactionApiData.ReturnStatus();
                transactionData.ReturnReason = transactionApiData.ReturnReason();
                transactionData.CardHolderName = transactionApiData.CardHolderName();
                transactionData.CardNumber = transactionApiData.CardNumber();
                transactionData.AccountFirstFour = transactionApiData.AccountFirstFour();
                transactionData.AccountLastFour = transactionApiData.AccountLastFour();
                transactionData.ExpiryDate = transactionApiData.ExpiryDate();
                transactionData.DeviceId = transactionApiData.DeviceId();
                transactionData.KSN = transactionApiData.KSN();
                transactionData.MaskedTrack2Data = transactionApiData.MaskedTrack2Data();

                TransactionComplete?.Invoke(this, transactionData);
            }
        }

    }

    
}