package com.onepay.miura.transactions;

import androidx.annotation.AnyThread;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.UiThread;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.transactions.emv.EmvChipInsertStatus;
import com.miurasystems.transactions.emv.EmvTransactionException;
import com.miurasystems.transactions.emv.EmvTransactionSummary;
import com.miurasystems.transactions.emv.EmvTransactionType;

import java.util.Objects;

@WorkerThread
public class EmvTransactionAsync {

    private static final String CLIENT_CHANGED_ERROR_MESSAGE =
            "MiuraManager's MpiClient has changed since "
                    + "this EmvTransactionAsync's construction";

    private final MiuraManager mMiuraManager;
    public final EmvTransaction mEmvTransaction;
    private final MpiClient mMpiClient;

    @AnyThread
    public EmvTransactionAsync(MiuraManager miuraManager, EmvTransactionType emvTransactionType) {
        MpiClient client = miuraManager.getMpiClient();
        if (client == null) {
            throw new IllegalArgumentException("MiuraManager has a null client?");
        }

        mMiuraManager = miuraManager;
        mMpiClient = client;
        mEmvTransaction = new EmvTransaction(mMpiClient, emvTransactionType);
    }

    @UiThread
    public void startTransactionAsync(
            final int amountInPennies,
            final int currencyCode,
            final Callback callback
    ) {
        //noinspection UnnecessaryLocalVariable
        final EmvTransaction transaction = mEmvTransaction;
        //noinspection UnnecessaryLocalVariable
        final MpiClient ourClient = mMpiClient;

        mMiuraManager.executeAsync(new MiuraManager.AsyncRunnable() {
            @Override
            public void runOnAsyncThread(@NonNull MpiClient client) {
                if (!Objects.equals(client, ourClient)) {
                    throw new AssertionError(CLIENT_CHANGED_ERROR_MESSAGE);
                }
                try {
                    EmvTransactionSummary result = transaction.startTransaction(
                            amountInPennies, currencyCode, callback
                    );
                    callback.onSuccess(result);
                } catch (EmvTransactionException exception) {
                    callback.onError(exception);
                }
            }
        });
    }

    @UiThread
    public void continueTransactionAsync() {
        mEmvTransaction.continueTransaction();
    }

    @UiThread
    public void abortTransactionAsync(@Nullable MiuraDefaultListener defaultListener) {
        /*if (!Objects.equals(mMiuraManager.getMpiClient(), mMpiClient)) {
            throw new AssertionError(CLIENT_CHANGED_ERROR_MESSAGE);
        }*/

        boolean ok = mEmvTransaction.abortTransaction();
        if (defaultListener != null) {
            if (ok) {
                defaultListener.onSuccess();
            } else {
                defaultListener.onError();
            }
        }
    }

    @AnyThread
    public static EmvChipInsertStatus canProcessEmvChip(CardData cardData) {
        return EmvTransaction.canProcessEmvChip(cardData);
    }

    @WorkerThread
    public interface Callback extends EmvTransaction.YieldCallback {
        @Deprecated
        void onSuccess(EmvTransactionSummary result);

        void onError(EmvTransactionException exception);
    }

}
