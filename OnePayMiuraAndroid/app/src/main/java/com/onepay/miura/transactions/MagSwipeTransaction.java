package com.onepay.miura.transactions;


import android.util.Log;

import androidx.annotation.AnyThread;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.UiThread;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.enums.OnlinePINError;
import com.miurasystems.mpi.enums.ServiceCode;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.mpi.tlv.HexUtil;
import com.miurasystems.mpi.tlv.Track2Data;
import com.miurasystems.transactions.magswipe.MagSwipeError;
import com.miurasystems.transactions.magswipe.MagSwipeSummary;
import com.miurasystems.transactions.magswipe.MagSwipeTransactionException;
import com.miurasystems.transactions.magswipe.OnlinePinSummary;

import java.util.concurrent.atomic.AtomicBoolean;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

@WorkerThread
public class MagSwipeTransaction {

    private static final String TAG = MagSwipeTransaction.class.getSimpleName();

    private final AtomicBoolean mAbortAttempted;

    private final MpiClient mMpiClient;

    @AnyThread
    public MagSwipeTransaction(MpiClient mpiClient) {
        mMpiClient = mpiClient;
        mAbortAttempted = new AtomicBoolean(false);
    }

    @UiThread
    public boolean abortTransaction() {
        // todo
        // fixme We can't abort if the app is blocking in its callbacks
        Log.d(TAG, "abortTransactionAsync");
        mAbortAttempted.set(true);
        boolean ok = mMpiClient.abortTransaction(MPI);
        if (!ok) {
            Log.e(TAG, "abortTransaction failed");
        }
        return ok;
    }

    public MagSwipePinResult processPinTransaction(
            MagSwipeSummary magSwipeSummary,
            double amountInPennies,
            int currencyCode
    ) throws MagSwipeTransactionException {
        Result<MpiClient.OnlinePinResult, OnlinePINError> response = mMpiClient.onlinePin(
                MPI,
                (int) amountInPennies,
                currencyCode,
                magSwipeSummary.mMaskedTrack2Data,
                "Amount "
        );
        if (response.isError()) {
            OnlinePINError error = response.asError().getError();
            if (OnlinePINError.NO_PIN_KEY == error) {
                showImportantTextOnDevice("Online PIN error:\nNo PIN key");
            } else {
                showImportantTextOnDevice("Online PIN error.");
            }
            throw new MagSwipeTransactionException("OnlinePin failed", error);
        }

        MpiClient.OnlinePinResult onlinePinResult = response.asSuccess().getValue();
        switch (onlinePinResult.mType) {
            case CancelOrTimeout:
                //showImportantTextOnDevice("Payment cancelled");
                Log.d(TAG, "Nagarj................CancelOrTimeout: ");
                return null;
            // throw new MagSwipeTransactionException("Online PIN error: Payment cancelled");
            case BypassedPinEntry:
                Log.d(TAG, "Nagarj................BypassedPinEntry: ");
                //showImportantTextOnDevice("Online PIN error: Payment PIN bypassed");
                return null;
            case PinEnteredOk:
                boolean ok = contactHSM(magSwipeSummary, onlinePinResult, null);
                if (ok) {
                    Log.d(TAG, "Nagarj................PinEnteredOk: ");
                    //showImportantTextOnDevice("PIN Ok");

                    Log.d(TAG, "Nagarj................PinEnteredOk: 1");
                    if ((onlinePinResult.PinData == null) || (onlinePinResult.PinKsn == null)) {
                        Log.d(TAG, "Nagarj................PinEnteredOk: 2 null" );
                        return  null;
                    }

                    Log.d(TAG, "Nagarj................PinEnteredOk: 3");
                    String pinData = HexUtil.bytesToHexStrings(onlinePinResult.PinData);
                    String pinKsn = HexUtil.bytesToHexStrings(onlinePinResult.PinKsn);
                    OnlinePinSummary onlinePinSummary = new OnlinePinSummary(pinData, pinKsn);

                    Log.d(TAG, "Nagarj................PinEnteredOk: 4");
                    return new MagSwipePinResult(magSwipeSummary, onlinePinSummary);
                } else {
                    Log.d(TAG, "Nagarj................Failed PinEnteredOk: ");

                    //showImportantTextOnDevice("Transaction Declined");
                    return null;
                }
            default:
                Log.d(TAG, "Nagarj................default: ");
                return null;
        }
    }

    public MagSwipeSignatureResult processSignatureTransaction(
            MagSwipeSummary magSwipeSummary,
            SignatureSummary signature
    ) throws MagSwipeTransactionException {
        boolean ok = contactHSM(magSwipeSummary, null, signature);
        if (ok) {
            showImportantTextOnDevice("Signature OK\nTransaction Success");

            return new MagSwipeSignatureResult(magSwipeSummary, signature);
        } else {
            throw new MagSwipeTransactionException("Signature error\nPayment failed");
        }
    }

    private boolean contactHSM(
            @NonNull MagSwipeSummary magSwipeSummary,
            @Nullable MpiClient.OnlinePinResult onlinePinResult,
            @Nullable SignatureSummary signature
    ) {
        /* ===================================================================
         * This is where the app would contact the P2PE HSM and verify the
         * mag-swipe data, and the signature or PIN provided by the user.
         *
         * Here we 'simulate' this by doing nothing at all.
         *
         * In a real app we would also pay more attention to mAbortAttempted
         * and possibly event try to interrupt this thread, if it's blocking,
         * from abortTransactionAsync
         * ===================================================================
         */
        return !mAbortAttempted.get();
    }

    @AnyThread
    private static boolean isPinRequired(ServiceCode serviceCode) {
        switch (serviceCode.getThirdDigit()) {
            case NoRestrictions_PINRequired:
            case ATMOnly_PINRequired:
            case GoodsAndServicesOnly_NoCash_PINRequired:
                return true;
            default:
                return false;
        }
    }

    @AnyThread
    public static Result<MagSwipeSummary, MagSwipeError> canProcessMagSwipe(CardData cardData) {

        if (!cardData.getCardStatus().isMSRDataAvailable()) {
            return new Result.Error<>(MagSwipeError.ErrNoMsrData);
        }

        Track2Data maskedTrack2Data = cardData.getMaskedTrack2Data();
        if (maskedTrack2Data == null) {
            return new Result.Error<>(MagSwipeError.ErrNoMaskedTrack2Data);
        }

        ServiceCode serviceCode = maskedTrack2Data.getServiceCode();
        if (serviceCode == null) {
            return new Result.Error<>(MagSwipeError.ErrNoServiceCode);
        }

        MagSwipeSummary data = new MagSwipeSummary(
                cardData.getMaskedTrack2Data(),
                cardData.getSredData(),
                cardData.getSredKSN(),
                isPinRequired(serviceCode),
                cardData.getPlainTrack1Data(),
                cardData.getPlainTrack2Data()
        );
        return new Result.Success<>(data);
    }

    @WorkerThread
    void showImportantTextOnDevice(String s)
            throws MagSwipeTransactionException {
        String text = DisplayTextUtils.getCenteredText(s);
        Log.d(TAG, "Nagarj................text " +text);
        boolean ok = mMpiClient.displayText(MPI, text, true, true, true);
        if (!ok) {
            Log.d(TAG, "Nagarj................PinEnteredOk 0000000000: ");
        }
    }
}