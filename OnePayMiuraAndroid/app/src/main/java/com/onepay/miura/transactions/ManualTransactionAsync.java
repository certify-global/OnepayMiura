package com.onepay.miura.transactions;

import android.os.Message;
import android.util.Log;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.api.objects.GetNumericDataRequest;
import com.miurasystems.mpi.enums.ExpirationDateElementType;
import com.miurasystems.mpi.enums.GetCommandsOptions;
import com.miurasystems.mpi.enums.GetEncryptedPanError;
import com.miurasystems.mpi.enums.GetNumericDataError;
import com.onepay.miura.common.Constants;

import java.util.EnumSet;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class ManualTransactionAsync {

    private static final String TAG = ManualTransactionAsync.class.getSimpleName();

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
    private boolean isAbortTransaction = false;

    public ManualTransactionAsync(MiuraManager miuraManager) {
        MpiClient client = miuraManager.getMpiClient();
        if (client == null) {
            throw new IllegalArgumentException("MiuraManager has a null client?");
        }
        mMpiClient = client;
    }

    public void manualTransaction(boolean isEbt, int timeOut, boolean isCvv, String mpiVersion) {
        EnumSet<GetCommandsOptions> options;
        options = GetCommandsOptions.makeOptionsSet(
                GetCommandsOptions.EnablePanGrouping,
                GetCommandsOptions.BacklightOn,
                GetCommandsOptions.KeyboardBacklightOn,
                GetCommandsOptions.ShowStatusBar);

        if (mpiVersion.equals("1-60b")) {
            result = mMpiClient.getSecureCardData(true, false, true, false, false, isCvv, false, options, null, timeOut);
        } else {
            result = mMpiClient.getSecureCardData(true, false, false, isCvv, false, options, timeOut);
        }


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
            EnumSet<GetCommandsOptions> expireOptions;
            expireOptions = GetCommandsOptions.makeOptionsSet(
                    GetCommandsOptions.BacklightOn,
                    GetCommandsOptions.KeyboardBacklightOn,
                    GetCommandsOptions.ShowStatusBar);
            isExpireDate = true;
            Result<String, GetNumericDataError> expireDate;
            if (mpiVersion.equals("1-60b")) {
                expireDate = mMpiClient.getExpirationDate(0, 154, 191, ExpirationDateElementType.DateMMYY, expireOptions, null, 30);
            } else {
                expireDate = mMpiClient.getNumericData(
                        GetNumericDataRequest.GetBuilder(0, 154, 155, 4, 0)
                                .setOption(GetCommandsOptions.KeyboardBacklightOn, true)
                                .setTimeoutInSeconds(30)
                                .build());
            }
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

    public void abortManualTransaction() {
        Log.d(TAG, "AbortTransactionAsync");

        if (!isAbortTransaction) {
            isAbortTransaction = true;
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