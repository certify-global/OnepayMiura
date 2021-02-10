using System;
using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;

namespace Onepay.Miura.Api

{
    public class Transaction
    {
        public static event EventHandler<TransactionData> TransactionComplete;
        public void PerformTransaction(double amt, String desc, String btAddress, bool isPinRequired, int tOut)
        {
            try
            {
                TransactionApi.Instance.SetTransactionParams(amt, desc, btAddress, isPinRequired, tOut);
                TransactionApi.Instance.PerformTransaction(new Transaction.TransactionListener());
            }
            catch (Exception exception)
            {
                TransactionApiData transactionData = new TransactionApiData();
                transactionData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileTransactionInXamarin);
                transactionData.SetReturnReason(exception.ToString());
                new TransactionListener().OnTransactionComplete(transactionData);
            }
        }
        public void CancelTransaction()
        {
            try
            {
                TransactionApi.Instance.CancelTransaction();
            }
            catch (Exception exception)
            {
                TransactionApiData transactionData = new TransactionApiData();
                transactionData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileAbortInXamarin);
                transactionData.SetReturnReason(exception.ToString());
                new TransactionListener().OnTransactionComplete(transactionData);
            }
        }

        public class TransactionListener : Java.Lang.Object, TransactionApi.ITransactionListener
        {
            TransactionData transactionData = new TransactionData();
            public void OnTransactionComplete(TransactionApiData transactionApiData)
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
                transactionData.PinData = transactionApiData.PinData();
                transactionData.PinKsn = transactionApiData.PinKsn();

                TransactionComplete?.Invoke(this, transactionData);
            }
        }

    }


}