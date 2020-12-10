package com.onepay.miura.transactions;


import androidx.annotation.NonNull;

import java.io.Serializable;

@SuppressWarnings("serial")
public class SignatureSummary implements Serializable {
    @NonNull
    public final String mSignatureBase64;

    public SignatureSummary(@NonNull String signatureBase64) {
        mSignatureBase64 = signatureBase64;
    }
}
