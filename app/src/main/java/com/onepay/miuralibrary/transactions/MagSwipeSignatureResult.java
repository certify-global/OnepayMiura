package com.onepay.miuralibrary.transactions;

import com.miurasystems.transactions.magswipe.MagSwipeSummary;

public class MagSwipeSignatureResult {
    public final MagSwipeSummary mMagSwipeSummary;
    public final SignatureSummary mSignature;

    public MagSwipeSignatureResult(MagSwipeSummary magSwipeSummary, SignatureSummary signature) {
        mMagSwipeSummary = magSwipeSummary;
        mSignature = signature;
    }
}
