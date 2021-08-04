package com.onepay.miura.core;

import android.util.Log;

import java.util.Arrays;
import java.util.Date;
import java.util.HashMap;
import java.util.List;

public class Config {

    private static final int MIN_BATTERY_LEVEL = 10;
    private static final String TEST_MPI_FILE_NAME_BASE = "M000-TESTMPI-V";
    private static final String REQUIRED_MPI_VERSION = "1-60b";
    private static final String FILE_EXTENSION = ".tar.gz";
    private static final String TEST_MPI_CONF_FILE_NAME = "M000-TESTMPI-Vx-x-CONF00-V6.tar.gz";
    private static final String TEST_MPI_CONF_FILE_NAME_BASE = "M000-TESTMPI-V";
    private static final String CONF_FILE_EXTENSION = "-CONF00-V6.tar.gz";


    public static boolean isBatteryValid(int batteryLevel) {
        return batteryLevel >= MIN_BATTERY_LEVEL;
    }

    public static String getTestMpiFileName(String mpiVersion) {
        return (TEST_MPI_FILE_NAME_BASE + mpiVersion + FILE_EXTENSION);
    }

    public static String getTestMpiConfFileName(String fileName) {
        //return (TEST_MPI_CONF_FILE_NAME_BASE + mpiVersion + CONF_FILE_EXTENSION);
        return fileName;
    }
}
