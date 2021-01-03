package com.onepay.miura.transactions;

import android.util.Log;

import androidx.annotation.UiThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.api.objects.GetNumericDataRequest;
import com.miurasystems.mpi.enums.GetCommandsOptions;
import com.miurasystems.mpi.enums.GetEncryptedPanError;
import com.miurasystems.mpi.enums.GetNumericDataError;

import java.util.EnumSet;
import java.util.concurrent.TimeUnit;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ManualTransactionAsync {
    private static final String TAG = ManualTransactionAsync.class.getSimpleName();

    private final MiuraManager mMiuraManager;
    private final MpiClient mMpiClient;
    public Result<EncryptedPan, GetEncryptedPanError> result = null;
    public String mExpireDate = "";

    public ManualTransactionAsync(MiuraManager miuraManager) {
        MpiClient client = miuraManager.getMpiClient();
        if (client == null) {
            throw new IllegalArgumentException("MiuraManager has a null client?");
        }
        mMiuraManager = miuraManager;
        mMpiClient = client;
    }

    public void manualTransaction(boolean isEbt, int timeOut, boolean isCvv) {
        EnumSet<GetCommandsOptions> options;
        options = GetCommandsOptions.makeOptionsSet(
                GetCommandsOptions.BacklightOn,
                GetCommandsOptions.KeyboardBacklightOn,
                GetCommandsOptions.ShowStatusBar);

        result = mMpiClient.getSecureCardData(true, false, false, isCvv, false, options, timeOut);

        if(!isEbt){
            Result<String, GetNumericDataError> expireDate = mMpiClient.getNumericData(
                    GetNumericDataRequest.GetBuilder(0, 154, 155, 4, 0)
                            .setOption(GetCommandsOptions.KeyboardBacklightOn, true)
                            .setTimeoutInSeconds(timeOut)
                            .build());

            if (expireDate.isSuccess()) {
                mExpireDate = expireDate.asSuccess().getValue();
            }

            if (result.isError()) {
                switch (result.asError().getError()) {
                    case UserCancelled:
                        //Handle user cancelled on device
                    case Timeout:
                        //Handle timeout
                        return;
                    default:
                        //Other error.
                        return;
                }
            }
        }
    }

    @UiThread
    public void abortManualTransaction()  {
        Log.d(TAG, "abortTransactionAsync");

        try {
            mMpiClient.abort(MPI, false);
            TimeUnit.SECONDS.sleep((long) 1);
            mMpiClient.abort(MPI, false);
            mMpiClient.abortTransaction(MPI);
        }
        catch (Exception e){
            Log.e(TAG, "AbortManualTransaction: " + e);
        }
    }
}
