using System;

namespace Onepay.Miura.Data
{
    public class MpiUpdateData
    {
        private int returnStatus;
        private String returnReason;

        public int ReturnStatus { get => returnStatus; set => returnStatus = value; }
        public string ReturnReason { get => returnReason; set => returnReason = value; }
    }
}