package com.onepay.miura.transactions;

import android.content.Intent;
import android.os.Message;
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
import com.onepay.miura.common.Constants;

import java.util.EnumSet;
import java.util.Objects;
import java.util.concurrent.TimeUnit;
import java.util.logging.Handler;
import java.util.logging.LogRecord;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ManualTransactionAsync {

    private static final String TAG = ManualTransactionAsync.class.getSimpleName();

    private final MiuraManager mMiuraManager;
    private final MpiClient mMpiClient;
    public Result<EncryptedPan, GetEncryptedPanError> result = null;
    public String mExpireDate = "";
    public int mReturnStatus = 0;
    public String mReturnReason = "";
    public boolean isUserCanceled = false;
    private boolean isExpireDate = false;
    Result<String, GetNumericDataError> expireDate;
    android.os.Handler handler;
    private int ABORT_MANUAL_TRANSACTION = 1;

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

        if (result.isError()) {
            isUserCanceled = true;
            switch (result.asError().getError()) {
                case UserCancelled:
                    mReturnReason = Constants.CanceledThroughPEDReason;
                    mReturnStatus = Constants.CanceledThroughPEDStatus;
                    Log.d(TAG, "ManualTransaction: UserCancelled");
                    return;
                case Timeout:
                    mReturnReason = Constants.TimeoutReason;
                    mReturnStatus = Constants.TimeoutStatus;
                    Log.d(TAG, "ManualTransaction: TimeOUt");
                    return;
                default:
                    mReturnReason = Constants.CanceledThroughPEDReason;
                    mReturnStatus = Constants.CanceledThroughPEDStatus;
                    Log.d(TAG, "ManualTransaction: default");
                    return;
            }
        }

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

            if (expireDate.isError()) {
                isUserCanceled = true;
                switch (expireDate.asError().getError()) {
                    case UserCancelled:
                        mReturnReason = Constants.CanceledThroughPEDReason;
                        mReturnStatus = Constants.CanceledThroughPEDStatus;
                        Log.d(TAG, "ManualTransaction: UserCancelled");
                        return;
                    case Timeout:
                        mReturnReason = Constants.TimeoutReason;
                        mReturnStatus = Constants.TimeoutStatus;
                        Log.d(TAG, "ManualTransaction: TimeOUt");
                        return;
                    default:
                        mReturnReason = Constants.CanceledThroughPEDReason;
                        mReturnStatus = Constants.CanceledThroughPEDStatus;
                        Log.d(TAG, "ManualTransaction: default");
                        return;
                }
            }
        }
    }

    @UiThread
    public void abortManualTransaction() {
        Log.d(TAG, "AbortTransactionAsync");

        try {
            createHandler();
            new Thread(new Runnable() {
                @Override
                public void run() {
                    if (!isExpireDate) {
                        mMpiClient.abort(MPI, false);
                    }
                    if (handler != null) {
                        handler.obtainMessage(ABORT_MANUAL_TRANSACTION).sendToTarget();
                    }
                }
            }).start();


        } catch (Exception e) {
            Log.e(TAG, "AbortManualTransaction: " + e);
        }
    }

    private void createHandler() {
        handler = new android.os.Handler(new android.os.Handler.Callback() {
            @Override
            public boolean handleMessage(Message message) {
                if (message.what == ABORT_MANUAL_TRANSACTION)
                    mMpiClient.abortTransaction(MPI);
                return false;
            }
        });
    }
}
