package com.onepay.miura.transactions;

import android.util.Log;

import androidx.annotation.Nullable;
import androidx.annotation.UiThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.api.objects.GetNumericDataRequest;
import com.miurasystems.mpi.enums.GetCommandsOptions;
import com.miurasystems.mpi.enums.GetEncryptedPanError;
import com.miurasystems.mpi.enums.GetNumericDataError;

import java.util.EnumSet;
import java.util.Objects;
import java.util.concurrent.TimeUnit;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ManualTransactionAsync {

    private static final String TAG = ManualTransactionAsync.class.getSimpleName();

    private final MiuraManager mMiuraManager;
    private final MpiClient mMpiClient;
    public Result<EncryptedPan, GetEncryptedPanError> result = null;
    public String mExpireDate = "";
    private boolean isEbt = false;

    public ManualTransactionAsync(MiuraManager miuraManager) {
        MpiClient client = miuraManager.getMpiClient();
        if (client == null) {
            throw new IllegalArgumentException("MiuraManager has a null client?");
        }
        mMiuraManager = miuraManager;
        mMpiClient = client;
    }

    public void manualTransaction(boolean isEbt, boolean isCvv) {
        this.isEbt = isEbt;
        EnumSet<GetCommandsOptions> options;
        options = GetCommandsOptions.makeOptionsSet(
                GetCommandsOptions.BacklightOn,
                GetCommandsOptions.KeyboardBacklightOn,
                GetCommandsOptions.ShowStatusBar);

        result = mMpiClient.getSecureCardData(true, false, false, isCvv, false, options, 30);

        if (!isEbt) {

            Result<String, GetNumericDataError> expireDate = mMpiClient.getNumericData(
                    GetNumericDataRequest.GetBuilder(0, 154, 155, 4, 0)
                            .setOption(GetCommandsOptions.KeyboardBacklightOn, true)
                            .setTimeoutInSeconds(60)
                            .build());

            if (expireDate.isSuccess()) {
                mExpireDate = expireDate.asSuccess().getValue();
            }
            if (expireDate.isError()) {
                switch (expireDate.asError().getError()) {
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
    public void abortManualTransaction() throws InterruptedException {
        Log.d(TAG, "abortTransactionAsync");

        mMpiClient.abort(MPI, false);
        TimeUnit.SECONDS.sleep((long) 1);
        mMpiClient.abort(MPI, false);
        TimeUnit.SECONDS.sleep((long) 1);
        mMpiClient.abort(MPI, false);

        if(isEbt){

        }
    }
}
