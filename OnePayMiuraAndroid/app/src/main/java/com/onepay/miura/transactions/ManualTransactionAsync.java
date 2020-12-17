package com.onepay.miura.transactions;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.objects.EncryptedPan;
import com.miurasystems.mpi.enums.GetCommandsOptions;
import com.miurasystems.mpi.enums.GetEncryptedPanError;

import java.util.EnumSet;

public class ManualTransactionAsync {
    private final MiuraManager mMiuraManager;
    private final MpiClient mMpiClient;
    public Result<EncryptedPan, GetEncryptedPanError> result = null;

    public ManualTransactionAsync(MiuraManager miuraManager) {
        MpiClient client = miuraManager.getMpiClient();
        if (client == null) {
            throw new IllegalArgumentException("MiuraManager has a null client?");
        }
        mMiuraManager = miuraManager;
        mMpiClient = client;
    }

    public void manualTransaction(boolean isCvv) {
        EnumSet<GetCommandsOptions> options;
        options = GetCommandsOptions.makeOptionsSet(
                GetCommandsOptions.BacklightOn,
                GetCommandsOptions.KeyboardBacklightOn,
                GetCommandsOptions.ShowStatusBar);

        result = mMpiClient.getSecureCardData(true, false, true, isCvv, true, options, 60);
    }
}
