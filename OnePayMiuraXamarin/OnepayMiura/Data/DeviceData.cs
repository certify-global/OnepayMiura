using System;

namespace Onepay.Miura.Data
{
    public  class DeviceData
    {
        private String address;
        private String type;
        private String serialNumber;
        private String osType;
        private String osVersion;
        private String mpiType;
        private String mpiVersion;
        private String chargingStatus;
        private String batteryLevel;
        private String pinKeyStatus;
        private String sREDStatus;
        private String dateTime;

        public string Address { get => address; set => address = value; }
        public string Type { get => type; set => type = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string OsType { get => osType; set => osType = value; }
        public string OsVersion { get => osVersion; set => osVersion = value; }
        public string MpiType { get => mpiType; set => mpiType = value; }
        public string MpiVersion { get => mpiVersion; set => mpiVersion = value; }
        public string ChargingStatus { get => chargingStatus; set => chargingStatus = value; }
        public string BatteryLevel { get => batteryLevel; set => batteryLevel = value; }
        public string PinKeyStatus { get => pinKeyStatus; set => pinKeyStatus = value; }
        public string SREDStatus { get => sREDStatus; set => sREDStatus = value; }
        public string DateTime { get => dateTime; set => dateTime = value; }
    }
}