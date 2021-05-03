package com.onepay.miura.data;

public class TransactionApiData {
    private String deviceCode;
    private String entryMode;
    private String  encryptedCardData;
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
    private String pinData;
    private String pinKsn;
    private String TLVData;

    public String deviceCode() {
        return deviceCode;
    }

    public void setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
    }

    public String entryMode() {
        return entryMode;
    }

    public void setEntryMode(String entryMode) {
        this.entryMode = entryMode;
    }

    public String encryptedCardData() {
        return encryptedCardData;
    }

    public void setEncryptedCardData(String cardData) {
        this.encryptedCardData = cardData;
    }

    public double amount() {
        return amount;
    }

    public void setAmount(double amount) {
        this.amount = amount;
    }

    public int returnStatus() {
        return returnStatus;
    }

    public void setReturnStatus(int returnStatus) {
        this.returnStatus = returnStatus;
    }

    public String cardHolderName() {
        return cardHolderName;
    }

    public void setCardHolderName(String cardHolderName) {
        this.cardHolderName = cardHolderName;
    }

    public String cardNumber() {
        return cardNumber;
    }

    public void setCardNumber(String cardNumber) {
        this.cardNumber = cardNumber;
    }

    public String accountFirstFour() {
        return accountFirstFour;
    }

    public void setAccountFirstFour(String accountFirstFour) {
        this.accountFirstFour = accountFirstFour;
    }

    public String accountLastFour() {
        return accountLastFour;
    }

    public void setAccountLastFour(String accountLastFour) {
        this.accountLastFour = accountLastFour;
    }

    public String expiryDate() {
        return expiryDate;
    }

    public void setExpiryDate(String expiryDate) {
        this.expiryDate = expiryDate;
    }

    public String deviceId() {
        return deviceId;
    }

    public void setDeviceId(String deviceId) {
        this.deviceId = deviceId;
    }

    public String KSN() {
        return kSN;
    }

    public void setKSN(String kSN) {
        this.kSN = kSN;
    }

    public String returnReason() {
        return returnReason;
    }

    public void setReturnReason(String returnReason) {
        this.returnReason = returnReason;
    }

    public String maskedTrack2Data() {
        return maskedTrack2Data;
    }

    public void setMaskedTrack2Data(String maskedTrack2Data) {
        this.maskedTrack2Data = maskedTrack2Data;
    }

    public String pinData() {
        return pinData;
    }

    public void setPinData(String pinData) {
        this.pinData = pinData;
    }

    public String pinKsn() {
        return pinKsn;
    }

    public void setPinKsn(String pinKsn) {
        this.pinKsn = pinKsn;
    }

    public String tlvData() {
        return TLVData;
    }

    public void setTLVData(String TLVData) {
        this.TLVData = TLVData;
    }

}
