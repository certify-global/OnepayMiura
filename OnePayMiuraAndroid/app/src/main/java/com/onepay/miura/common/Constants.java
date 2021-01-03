package com.onepay.miura.common;

public class Constants {
    public static String SuccessReason = "Success";
    public static String ErrorReason = "Error";
    public static String CancelReason = "Cancel";
    public static String BluetoothConnectionErrorReason = "Bluetooth Connection Error";
    public static String BluetoothDisconnectedReason = "Bluetooth Disconnected";
    public static String TimeoutReason = "Timeout";
    public static String InvalidParametersReason = "Invalid Parameters";
    public static String NoDirectoryReason = "No Such file or Directory";
    public static String BadFileUploadedReason = "BadFileUploaded";

    public static int SuccessStatus = 1 ;
    public static int ErrorStatus = 2;
    public static int CancelStatus = 3;
    public static int BluetoothConnectionErrorStatus = 4;
    public static int BluetoothDisconnectedStatus = 5;
    public static int TimeoutStatus = 6;
    public static int InvalidParametersStatus = 7;
    public static int NoDirectoryStatus = 8;
    public static int BadFileUploadedStatus = 9;
    public static int Exception = 10;
    public static int AbortException = 11;


    public static String Unknown = "00";
    public static String Manual = "01";
    public static String Swipe = "02";
    public static String Chip = "05";
    public static String NFC = "07";
    public static String EmvSwipe = "08";
}