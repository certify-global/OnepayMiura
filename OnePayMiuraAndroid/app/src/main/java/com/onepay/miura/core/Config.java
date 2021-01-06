package com.onepay.miura.core;

import android.util.Log;

import java.util.Arrays;
import java.util.Date;
import java.util.HashMap;
import java.util.List;

public class Config {

    private static final int MIN_BATTERY_LEVEL = 10;

    public static boolean isBatteryValid(int batteryLevel) {
        return batteryLevel >= MIN_BATTERY_LEVEL;
    }
}
