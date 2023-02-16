package com.onepay.miura.transactions;

import android.util.Log;

import androidx.annotation.AnyThread;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.CommandUtil;
import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.enums.TransactionResponse;
import com.miurasystems.mpi.enums.TransactionType;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.mpi.tlv.Description;
import com.miurasystems.mpi.tlv.TLVObject;
import com.miurasystems.mpi.tlv.TLVParser;
import com.miurasystems.transactions.emv.EmvChipInsertStatus;
import com.miurasystems.transactions.emv.EmvTransactionException;
import com.miurasystems.transactions.emv.EmvTransactionSummary;
import com.miurasystems.transactions.emv.EmvTransactionType;

import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.atomic.AtomicBoolean;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;
import static com.miurasystems.mpi.tlv.Description.Transaction_Declined;


@WorkerThread
public class EmvTransaction {
    private static final String TAG = EmvTransaction.class.getSimpleName();

    private final CountDownLatch mLatch;

    private final AtomicBoolean mAbortAttempted;

    private final AtomicBoolean mTransactionStarted;

    private final MpiClient mMpiClient;
    private final EmvTransactionType mEmvTransactionType;
    public String tlvData = "";
    public boolean errorEmv = false;

    @AnyThread
    public EmvTransaction(MpiClient mpiClient, EmvTransactionType emvTransactionType) {
        mMpiClient = mpiClient;
        mEmvTransactionType = emvTransactionType;
        mLatch = new CountDownLatch(1);
        mAbortAttempted = new AtomicBoolean(false);
        mTransactionStarted = new AtomicBoolean(false);
    }

    @WorkerThread
    public EmvTransactionSummary startTransaction(
            int amountInPennies,
            int currencyCode
    ) throws EmvTransactionException {
        return startTransaction(amountInPennies, currencyCode, null);
    }

    @WorkerThread
    EmvTransactionSummary startTransaction(
            int amountInPennies,
            int currencyCode,
            @Nullable YieldCallback callback
    ) throws EmvTransactionException {
        Log.d(TAG, "startTransaction: " + amountInPennies + currencyCode);

        if (!mTransactionStarted.compareAndSet(false, true)) {
            throw new EmvTransactionException(
                    "Transaction object already started",
                    TransactionResponse.UNKNOWN
            );
        }

        try {
            return process(amountInPennies, currencyCode, callback);
        } catch (EmvTransactionException exception) {
            Log.e(TAG, "process() exception! msg:{}" + exception.getMessage(), exception);
            Log.d(TAG, exception.mErrCode.toString());
            Log.d(TAG, "mAbortAttempted: {}" + mAbortAttempted.get());

            /*
                abortTransaction and displayText fail here if e.g. the connection
                to the ped is lost. That's ok.
            */
            mMpiClient.abortTransaction(MPI);
            if (mAbortAttempted.get()
                    && (exception.mErrCode == TransactionResponse.USER_CANCELLED)) {
                mMpiClient.displayText(MPI, "Transaction Aborted", false, false, false);
            }

            throw exception;
        }
    }

    @WorkerThread
    private EmvTransactionSummary process(
            int amountInPennies,
            int currencyCode,
            @Nullable YieldCallback callback
    ) throws EmvTransactionException {

        errorEmv = false;
        // showImportantTextOnDevice("Processing\nTransaction");

        Result<byte[], TransactionResponse> startResult;

        if (mEmvTransactionType == EmvTransactionType.Contactless) {
            startResult = mMpiClient.startContactlessTransaction(
                    MPI,
                    TransactionType.Purchase,
                    amountInPennies,
                    currencyCode,
                    null
            );
            callback = null;
        } else {
            startResult = mMpiClient.startTransaction(
                    MPI,
                    TransactionType.Purchase,
                    amountInPennies,
                    currencyCode
            );
        }
        if (startResult.isError()) {
            errorEmv = true;
            throw new EmvTransactionException(startResult.asError().getError());
        }
        if (startResult.isSuccess()) {
            byte[] rawData = startResult.asSuccess().getValue();
            tlvData = bytesToHexString(rawData);
        }
        List<TLVObject> startTlv = TLVParser.decode(startResult.asSuccess().getValue());
        throwIfDeclined(startTlv);
        String startOutput = getTransactionDisplayString(startTlv);
        TLVObject hsmTlv = contactHSM(callback, startOutput);
        if (mAbortAttempted.get()) {
            throw new EmvTransactionException("Aborted");
        }
        Result<byte[], TransactionResponse> continueResult = mMpiClient.continueTransaction(
                MPI,
                hsmTlv
        );
        if (continueResult.isError()) {
            return null;
            //throw new EmvTransactionException(continueResult.asError().getError());
        }

        if (mEmvTransactionType == EmvTransactionType.Chip) {
            showImportantTextOnDevice("Please remove\n your card.");
        }
        List<TLVObject> continueTlv = TLVParser.decode(continueResult.asSuccess().getValue());
        throwIfDeclined(continueTlv);
        String continueOutput = getTransactionDisplayString(continueTlv);

        return new EmvTransactionSummary(startOutput, continueOutput);
    }

    @WorkerThread
    @NonNull
    private TLVObject contactHSM(@Nullable YieldCallback callback, String startOutput)
            throws EmvTransactionException {
        /* ===================================================================
         * This is where the app would contact the P2PE HSM and verify the
         * transaction etc. Here we 'simulate' this delay by simply asking the App
         * to show the expected Online_Authorisation_Required response to the user
         * and have them press 'continue'.
         *
         * In a real app we would also pay more attention to mAbortAttempted
         * and possibly event try to interrupt this thread, if it's blocking,
         * from abortTransaction
         * ===================================================================
         */
        if (callback != null) {
            callback.publishStartTransactionResult(startOutput);
            yieldForContinue();
        }

        /*
            Examples of ARC/8a tag:
                decline : "5A31" aka "Z1"
                accept : "3030" aka "00"
         */
        byte[] value8A = "00".getBytes(StandardCharsets.US_ASCII);
        TLVObject tlv02 = new TLVObject(Description.Authorisation_Response_Code, value8A);

        ArrayList<TLVObject> tlvObjectsContinue = new ArrayList<>(1);
        tlvObjectsContinue.add(tlv02);

        return new TLVObject(Description.Command_Data, tlvObjectsContinue);
    }

    @WorkerThread
    private void yieldForContinue() throws EmvTransactionException {
        try {
            mLatch.await();
        } catch (InterruptedException e) {
            //throw new EmvTransactionException("Transaction thread interrupted whilst yielding", e);
            Log.d(TAG, "yieldForContinue: ");
        }
    }

    @AnyThread
    void continueTransaction() {
        mLatch.countDown();
    }

    @AnyThread
    public boolean abortTransaction() {
        Log.d(TAG, "abortTransaction: ");
        mAbortAttempted.set(true);
        boolean ok = mMpiClient.abortTransaction(MPI);
        if (!ok) {
            Log.e(TAG, "abortTransaction failed");
        }
        mLatch.countDown();
        return ok;
    }

    @WorkerThread
    private static void throwIfDeclined(List<TLVObject> startTlv) throws EmvTransactionException {
        TLVObject startDeclined = CommandUtil.firstMatch(startTlv, Transaction_Declined);
        //noinspection VariableNotUsedInsideIf
        if (startDeclined != null) {
            throw new EmvTransactionException("Transaction declined");
        }
    }

    @WorkerThread
    @NonNull
    private static String getTransactionDisplayString(List<TLVObject> tlvObjects) {
        StringBuilder builder = new StringBuilder(tlvObjects.size() * 32);
        for (TLVObject tlvObject : tlvObjects) {
            builder.append(tlvObject);
            builder.append("\n\n");
        }
        return builder.toString();
    }

    @WorkerThread
    private void showImportantTextOnDevice(String s)
            throws EmvTransactionException {
        String text = DisplayTextUtils.getCenteredText(s);
        boolean ok = mMpiClient.displayText(MPI, text, true, true, true);
        if (!ok) {
            throw new EmvTransactionException("Display text failed");
        }
    }

    @AnyThread
    public static EmvChipInsertStatus canProcessEmvChip(CardData cardData) {
        boolean cardPresent = cardData.getCardStatus().isCardPresent();
        boolean emvCompatible = cardData.getCardStatus().isEMVCompatible();
        if (!cardPresent) {
            return EmvChipInsertStatus.NoCardPresentError;
        } else if (!emvCompatible) {
            return EmvChipInsertStatus.CardIncompatibleError;
        } else {
            return EmvChipInsertStatus.CardInsertedOk;
        }
    }

    private static String bytesToHexString(byte[] src) {
        Log.d("TAG", "###RB#### bytesToHexString: ");
        StringBuilder stringBuilder = new StringBuilder("");
        if (src == null || src.length <= 0) {
            return null;
        }
        char[] buffer = new char[2];
        for (int i = 0; i < src.length; i++) {
            buffer[0] = Character.forDigit((src[i] >>> 4) & 0x0F, 16);
            buffer[1] = Character.forDigit(src[i] & 0x0F, 16);
            stringBuilder.append(buffer);
        }
        return stringBuilder.toString();
    }

    @WorkerThread
    interface YieldCallback {
        @Deprecated
        void publishStartTransactionResult(String response);
    }

}