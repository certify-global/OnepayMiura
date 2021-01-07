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
    private boolean isExpireDate = false;
    Result<String, GetNumericDataError> expireDate;

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

        if (!isEbt) {
            isExpireDate = true;
            Result<String, GetNumericDataError> expireDate = mMpiClient.getNumericData(
                    GetNumericDataRequest.GetBuilder(0, 154, 155, 4, 0)
                            .setOption(GetCommandsOptions.KeyboardBacklightOn, true)
                            .setTimeoutInSeconds(30)
                            .build());

            if (expireDate.isSuccess()) {
                mExpireDate = expireDate.asSuccess().getValue();
            }
        }
    }

    @UiThread
    public void abortManualTransaction() {
        Log.d(TAG, "abortTransactionAsync");

        try {
            if (!isExpireDate) {
                mMpiClient.abort(MPI, false);
            }
            TimeUnit.SECONDS.sleep((long) 1);
            mMpiClient.abortTransaction(MPI);
        } catch (Exception e) {
            Log.e(TAG, "AbortManualTransaction: " + e);
        }
    }
}