using System;

namespace Onepay.Miura.Data
{
    public class TransactionData
    {
        private String deviceCode;
        private String entryMode;
        private String encryptedCardData;
        private double amount;
        private int returnStatus;
        private String returnReason;
        private String cardHolderName;
        private String cardNumber;
        private String accountFirstFour;
        private String accountLastFour;
        private String expiryDate;
        private String deviceId;
        private String kSN;
        private String maskedTrack2Data;

        public string DeviceCode { get => deviceCode; set => deviceCode = value; }
        public string EntryMode { get => entryMode; set => entryMode = value; }
        public string EncryptedCardData { get => encryptedCardData; set => encryptedCardData = value; }
        public double Amount { get => amount; set => amount = value; }
        public int ReturnStatus { get => returnStatus; set => returnStatus = value; }
        public string ReturnReason { get => returnReason; set => returnReason = value; }
        public string CardHolderName { get => cardHolderName; set => cardHolderName = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string AccountFirstFour { get => accountFirstFour; set => accountFirstFour = value; }
        public string AccountLastFour { get => accountLastFour; set => accountLastFour = value; }
        public string ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string DeviceId { get => deviceId; set => deviceId = value; }
        public string KSN { get => kSN; set => kSN = value; }
        public string MaskedTrack2Data { get => maskedTrack2Data; set => maskedTrack2Data = value; }
    }
}