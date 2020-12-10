/*
 * Copyright © 2017 Miura Systems Ltd. All rights reserved.
 */
package com.onepay.miuralibrary.core;

import android.app.Application;

import androidx.annotation.UiThread;

import com.miurasystems.mpi.api.executor.MiuraManager;
import com.onepay.miuralibrary.utils.CurrencyCode;


@UiThread
public class MiuraApplication extends Application {

    public static CurrencyCode currencyCode = CurrencyCode.USD;

    @UiThread
    @Override
    public void onCreate() {
        super.onCreate();

        MiuraManager instance = MiuraManager.getInstance();
        instance.setDeviceType(MiuraManager.DeviceType.PED);
    }
}
