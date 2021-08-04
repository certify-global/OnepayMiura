using Com.Onepay.Miura.Api;
using Com.Onepay.Miura.Data;
using Onepay.Miura.Data;
using System;

namespace Onepay.Miura.Api
{
    public class MpiUpdate
    {
         public static event EventHandler<MpiUpdateData> MpiUpdateComplete;
         public void PerformMpiUpdate(String btAddress, int tOut, String filePath, string configFileName)
         {
             try
             {
                MpiUpdateApi.Instance.SetPerformMpiUpdate(btAddress, tOut, filePath, configFileName);
                MpiUpdateApi.Instance.PerformMpiUpdate(new MpiUpdate.MpiUpdateListener());
            }
            catch (Exception exception)
             {
                MpiUpdateApiData mpiUpdateApiData = new MpiUpdateApiData();
                mpiUpdateApiData.SetReturnStatus(2);
                mpiUpdateApiData.SetReturnReason(exception.ToString());
                new MpiUpdateListener().OnMpiUpdateComplete(mpiUpdateApiData);
            }
         }

        public class MpiUpdateListener : Java.Lang.Object, MpiUpdateApi.IMpiUpdateListener
        {
            public void OnMpiUpdateComplete(MpiUpdateApiData mpiUpdateApiData)
            {
                MpiUpdateData mpiUpdateData = new MpiUpdateData();
                mpiUpdateData.ReturnReason = mpiUpdateApiData.ReturnReason();
                mpiUpdateData.ReturnStatus = mpiUpdateApiData.ReturnStatus();

                MpiUpdateComplete?.Invoke(this, mpiUpdateData);
            }
        }

    }
}