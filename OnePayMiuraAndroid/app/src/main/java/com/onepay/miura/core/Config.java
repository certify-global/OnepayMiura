package com.onepay.miura.core;

public class Config {

    private static final int MIN_BATTERY_LEVEL = 10;
    private static final String TEST_MPI_FILE_NAME_BASE = "M000-TESTMPI-V";
    private static final String FILE_EXTENSION = ".tar.gz";


    public static boolean isBatteryValid(int batteryLevel) {
        return batteryLevel >= MIN_BATTERY_LEVEL;
    }

    public static String getTestMpiFileName(String mpiVersion, String mpiFileNameBase) {
        return (mpiFileNameBase + mpiVersion + FILE_EXTENSION);
    }

    public static String getTestMpiConfFileName(String fileName) {
        return fileName;
    }
}
