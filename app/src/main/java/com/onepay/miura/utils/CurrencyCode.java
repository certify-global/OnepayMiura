/*
 * Copyright © 2017 Miura Systems Ltd. All rights reserved.
 */
package com.onepay.miura.utils;

public enum CurrencyCode {

    USD(840, "\u0024");

    private int value;
    private String sign ="";

    CurrencyCode(int value, String sign) {
        this.value = value;
        this.sign = sign;
    }

    public int getValue() {
        return value;
    }

    public String getSign() {
        return sign;
    }
}
