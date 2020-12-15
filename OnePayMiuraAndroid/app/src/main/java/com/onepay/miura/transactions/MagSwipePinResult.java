package com.onepay.miura.transactions;


import com.miurasystems.transactions.magswipe.MagSwipeSummary;
import com.miurasystems.transactions.magswipe.OnlinePinSummary;

public class MagSwipePinResult {

    public final MagSwipeSummary mMagSwipeSummary;
    public final OnlinePinSummary mOnlinePinSummary;

    public MagSwipePinResult(
            MagSwipeSummary magSwipeSummary,
            OnlinePinSummary onlinePinSummary
    ) {
        this.mMagSwipeSummary = magSwipeSummary;
        this.mOnlinePinSummary = onlinePinSummary;
    }
}
