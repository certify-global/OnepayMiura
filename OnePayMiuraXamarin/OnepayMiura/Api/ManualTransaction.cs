﻿using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;
using System;

namespace Onepay.Miura.Api
{
    public class ManualTransaction
    {
        public static event EventHandler<TransactionData> ManualTransactionComplete;
        public void PerformTransaction(double amt, String desc, String btAddress, int tOut, bool isEbt, bool isCvv = false)
        {
            try { 
            ManualTransactionApi.Instance.SetManualTransactionParams(amt, desc, btAddress, tOut, isEbt, isCvv);
            ManualTransactionApi.Instance.PerformManualTransaction(new ManualTransactionListener());
            }
            catch (Exception exception)
            {
                TransactionApiData transactionData = new TransactionApiData();
                transactionData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileTransactionInXamarin);
                transactionData.SetReturnReason(exception.ToString());
                new ManualTransactionListener().OnManualTransactionComplete(transactionData);
            }
        }
        public void CancelTransaction()
        {
            try { 
            ManualTransactionApi.Instance.CancelTransaction();
            }
            catch (Exception exception)
            {
                TransactionApiData transactionData = new TransactionApiData();
                transactionData.SetReturnStatus((int)ConnectionStatus.ExceptionWhileAbortInXamarin);
                transactionData.SetReturnReason(exception.ToString());
                new ManualTransactionListener().OnManualTransactionComplete(transactionData);
            }
        }

        public class ManualTransactionListener : Java.Lang.Object, ManualTransactionApi.IManualTransactionListener
        {
            TransactionData transactionData = new TransactionData();

            public void OnManualTransactionComplete(TransactionApiData transactionApiData)
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

                ManualTransactionComplete?.Invoke(this, transactionData);
            }
        }
    }
}