package com.onepay.miura.utils;

public class Utils {

    public static int getByteData(String strValue) {
        return Integer.parseInt(strValue)/100;
    }

    public static boolean isNumeric(String str) {
        if (str.isEmpty()) {
            return false;
        }
        return str.matches("[+-]?\\d*(\\.\\d+)?");
    }

}
