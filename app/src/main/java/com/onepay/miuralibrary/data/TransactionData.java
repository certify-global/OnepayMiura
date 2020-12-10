package com.onepay.miuralibrary.data;

public class TransactionData {
    private String deviceCode;
    private String entryMode;
    private String  encryptedCardData;
    private float amount;
    private boolean returnStatus;
    private String returnReason;
    private String cardHolderName;
    private String cardNumber;
    private String accountFirstFour;
    private String accountLastFour;
    private String expiryDate;
    private String deviceId;
    private String kSN;
    private String maskedTrack2Data;

    public String getDeviceCode() {
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

    public String cardData() {
        return encryptedCardData;
    }

    public void setCardData(String cardData) {
        this.encryptedCardData = cardData;
    }

    public float amount() {
        return amount;
    }

    public void setAmount(float amount) {
        this.amount = amount;
    }

    public boolean returnStatus() {
        return returnStatus;
    }

    public void setReturnStatus(boolean returnStatus) {
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

    public String getReturnReason() {
        return returnReason;
    }

    public void setReturnReason(String returnReason) {
        this.returnReason = returnReason;
    }

    public String getMaskedTrack2Data() {
        return maskedTrack2Data;
    }

    public void setMaskedTrack2Data(String maskedTrack2Data) {
        this.maskedTrack2Data = maskedTrack2Data;
    }

}
