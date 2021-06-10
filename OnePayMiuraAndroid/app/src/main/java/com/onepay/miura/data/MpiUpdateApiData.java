package com.onepay.miura.data;

public class MpiUpdateApiData {
    private int returnStatus;
    private String returnReason;

    public int returnStatus() {
        return returnStatus;
    }

    public void setReturnStatus(int returnStatus) {
        this.returnStatus = returnStatus;
    }

    public String returnReason() {
        return returnReason;
    }

    public void setReturnReason(String returnReason) {
        this.returnReason = returnReason;
    }

}
