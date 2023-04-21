package com.onepay.miura.api;

import android.bluetooth.BluetoothDevice;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;

import androidx.annotation.MainThread;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.annotation.UiThread;
import androidx.annotation.WorkerThread;

import com.miurasystems.mpi.MpiClient;
import com.miurasystems.mpi.Result;
import com.miurasystems.mpi.api.executor.MiuraManager;
import com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener;
import com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener;
import com.miurasystems.mpi.api.listener.MiuraDefaultListener;
import com.miurasystems.mpi.api.objects.Capability;
import com.miurasystems.mpi.api.objects.SoftwareInfo;
import com.miurasystems.mpi.api.utils.DisplayTextUtils;
import com.miurasystems.mpi.enums.DeviceStatus;
import com.miurasystems.mpi.enums.TransactionResponse;
import com.miurasystems.mpi.events.DeviceStatusChange;
import com.miurasystems.mpi.events.MpiEventHandler;
import com.miurasystems.mpi.events.MpiEvents;
import com.miurasystems.mpi.tlv.CardData;
import com.miurasystems.transactions.emv.EmvChipInsertStatus;
import com.miurasystems.transactions.emv.EmvTransactionException;
import com.miurasystems.transactions.emv.EmvTransactionSummary;
import com.miurasystems.transactions.emv.EmvTransactionType;
import com.miurasystems.transactions.magswipe.MagSwipeError;
import com.miurasystems.transactions.magswipe.MagSwipeSummary;
import com.miurasystems.transactions.magswipe.MagSwipeTransactionException;
import com.miurasystems.transactions.magswipe.OnlinePinSummary;
import com.miurasystems.transactions.magswipe.PaymentMagType;
import com.onepay.miura.bluetooth.BluetoothConnect;
import com.onepay.miura.bluetooth.BluetoothModule;
import com.onepay.miura.common.Constants;
import com.onepay.miura.core.MiuraApplication;
import com.onepay.miura.data.TransactionApiData;
import com.onepay.miura.transactions.EmvTransactionAsync;
import com.onepay.miura.transactions.MagSwipeTransaction;
import com.onepay.miura.transactions.MagSwipeTransactionAsync;
import com.onepay.miura.transactions.SignatureSummary;
import com.onepay.miura.utils.Utils;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Locale;
import java.util.Timer;
import java.util.TimerTask;
import java.util.concurrent.TimeUnit;

import static com.miurasystems.mpi.enums.InterfaceType.MPI;

public class TransactionApi {
    private static final String TAG = TransactionApi.class.getSimpleName();
    private static TransactionApi instance = null;
    private double amount = 0.00d;
    private String description = "";
    private String bluetoothAddress = "";
    private String returnReason = "";
    private int returnStatus = 0;
    private String entryMode = Constants.Swipe;
    private Timer mTimer;
    private int mTransactionTime = 60;
    private TransactionListener transactionListener;
    private String pedDeviceId = "";
    private CardData cardData = null;
    private boolean isTimerTimedOut = false;
    private boolean isTransactionTimeOut = false;
    private boolean isCancelTransaction = false;
    private boolean isTransactionComplete = false;
    private boolean isTransactionInProcess = false;
    private BluetoothConnect.DeviceConnectListener deviceConnectListener;
    private static final MpiEvents MPI_EVENTS = MiuraManager.getInstance().getMpiEvents();
    private static final MiuraManager MIURA_MANAGER = MiuraManager.getInstance();
    private TransactionApiData transactionData = null;
    private static DecimalFormat decimalFormat = new DecimalFormat("#.##");
    private boolean isPinRequired = false;
    private String pinKsn = "";
    private String pinData = "";
    private double displayAmount = 0.00d;
    private boolean isEmv = false;
    private boolean mFirstTry = false;
    private String cardHolderName = "";
    private String maskedCreditCardNumber = "";
    private String expireDate = "";
    private boolean isEbt = false;
    private boolean isFallBack = false;
    private int count = 1;
    private boolean isDebitTransaction = false;
    private String sRedKsn = "";
    private String sRedData = "";
    private String sPinKsn = "";
    private String applicationLabel = "";
    private String aid = "";

    @Nullable
    private EmvTransactionAsync mEmvTransactionAsync;
    @Nullable
    private MagSwipeTransactionAsync mMagSwipeTransaction;


    public interface TransactionListener {
        void onTransactionComplete(TransactionApiData data);
    }

    public static TransactionApi getInstance() {
        if (instance == null) {
            instance = new TransactionApi();
        }
        return instance;
    }

    /**
     * Method that sets the transaction parameters
     *
     * @param amt       Payment amount for the transaction
     * @param desc      Description for the transaction
     * @param btAddress Miura bluetooth device address
     * @param tOut      Timeout for the transaction
     */
    public void setTransactionParams(double amt, String desc, String btAddress, boolean isPinRequired, boolean isEBT, int tOut) {
        if (amt < 0) {
            amt *= -1;
        }
        Log.d(TAG, "###RB#### set transaction parameters ");
        clearData();
        isEmv = false;
        mFirstTry = false;
        isTransactionTimeOut = false;
        isCancelTransaction = false;
        isTransactionComplete = false;
        isTransactionInProcess = false;
        isFallBack = false;
        count = 1;
        entryMode = Constants.Swipe;
        amt = Double.parseDouble(decimalFormat.format(amt));
        this.amount = amt;
        displayAmount = amt * 100;
        this.isPinRequired = isPinRequired;
        if (description != null)
            this.description = desc;
        if (btAddress != null)
            this.bluetoothAddress = btAddress;
        this.mTransactionTime = tOut;
        this.isEbt = isEBT;
        transactionData = new TransactionApiData();
    }

    /**
     * Method that initiates the transaction
     *
     * @param listener callback listener for the transaction
     */
    public void performTransaction(final TransactionListener listener) {
        Log.d(TAG, "Perform transaction count : " + count);
        Log.d(TAG, "###RB#### perform transaction: ");
        startTransactionTimer();
        this.transactionListener = listener;
        if (bluetoothAddress.isEmpty() || amount == 0) {
            if (transactionListener != null) {
                returnReason = Constants.InvalidParametersReason;
                returnStatus = Constants.InvalidParametersStatus;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
            return;
        }

        if (BluetoothModule.getInstance().isSessionOpen()) {
            getDeviceInfo();
        } else {
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    @UiThread
    public void restartConnection() {
        try {
            TimeUnit.SECONDS.sleep(1);
        } catch (Exception e) {
            Log.d(TAG, "restartConnection: " + e.getMessage());
        }
        if (BluetoothModule.getInstance().isSessionOpen()) {
            getDeviceInfo();
        } else {
            Log.d(TAG, "RestartConnection: ");
            setDeviceReconnectListener();
            BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
        }
    }

    private void reConnectDevice() {
        Log.d(TAG, "###RB#### reconnecting the device: ");
        BluetoothConnect.getInstance().connect(this.bluetoothAddress, deviceConnectListener);
    }

    private void setDeviceReconnectListener() {
        deviceConnectListener = new BluetoothConnect.DeviceConnectListener() {
            @Override
            public void onConnectionSuccess() {
                Log.d(TAG, "###RB#### onConnection Success ");
                getDeviceInfo();
            }

            @Override
            public void onConnectionError() {
                Log.d(TAG, "###RB#### on Connection Error: ");
                if (!isTimerTimedOut) {
                    reConnectDevice();
                    return;
                }
                if (transactionListener != null) {
                    returnReason = Constants.BluetoothConnectionErrorReason;
                    returnStatus = Constants.BluetoothConnectionErrorStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }

            @Override
            public void onDeviceDisconnected() {
                Log.d(TAG, "onDeviceDisconnected: ");

                if (transactionListener != null) {
                    returnReason = Constants.BluetoothDisconnectedReason;
                    returnStatus = Constants.BluetoothDisconnectedStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        };
    }

    /**
     * Method that initiate for canceling transaction
     */
    public void cancelTransaction() {
        Log.d(TAG, "###RB#### cancelTransaction: ");
        if (!isTransactionInProcess) {
            try {
                isCancelTransaction = true;
                deregisterEventHandlers();
                boolean isChip = mEmvTransactionAsync != null;
                boolean isSwipe = mMagSwipeTransaction != null;

                if (!isChip && !isSwipe) {
                    closeBtSession();

                    if (transactionListener != null) {
                        if (isTransactionTimeOut) {
                            returnReason = Constants.TimeoutReason;
                            returnStatus = Constants.TimeoutStatus;
                        } else {
                            returnReason = Constants.CancelReason;
                            returnStatus = Constants.CancelStatus;
                        }

                        transactionListener.onTransactionComplete(createTransactionData(cardData));
                    }
                    return;
                }

                MiuraDefaultListener listener = new MiuraDefaultListener() {
                    @Override
                    public void onSuccess() {
                        Log.d(TAG, "Abort Success");
                        closeBtSession();

                        if (transactionListener != null) {
                            if (isTransactionTimeOut) {
                                returnReason = Constants.TimeoutReason;
                                returnStatus = Constants.TimeoutStatus;
                            } else {
                                returnReason = Constants.CancelReason;
                                returnStatus = Constants.CancelStatus;
                            }
                            transactionListener.onTransactionComplete(createTransactionData(cardData));
                        }
                    }

                    @Override
                    public void onError() {
                        Log.d(TAG, "Abort Failed");
                        closeBtSession();

                        if (transactionListener != null) {
                            returnReason = Constants.CancelReason;
                            returnStatus = Constants.CancelStatus;
                            transactionListener.onTransactionComplete(createTransactionData(cardData));
                        }
                    }
                };
                if (isChip) {
                    abortEmvTransactionAsync(listener);
                } else {
                    abortSwipeTransactionAsync(listener);
                }
                clearData();
            } catch (Exception e) {
            /*if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.AbortException;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }*/
            }
        }
    }

    private void getDeviceInfo() {
        startTransactionTimer();
        MiuraManager.getInstance().getDeviceInfo(new ApiGetDeviceInfoListener() {
            @WorkerThread
            @Override
            public void onSuccess(final ArrayList<Capability> capabilities) {
                getDeviceCapabilities(capabilities);
            }

            @WorkerThread
            @Override
            public void onError() {
                Log.d(TAG, "###RB#### get Device Info ");
            }
        });
    }

    /**
     * Method that gets the miura device payment capabilities
     *
     * @param capabilities list of capabilities supported
     */
    private void getDeviceCapabilities(ArrayList<Capability> capabilities) {
        Log.d(TAG, "###RB#### getDeviceCapabilities: ");
        try {
            ArrayList<String> keys = new ArrayList<>();

            for (Capability capability : capabilities) {
                String key = capability.getName();
                if (capability.getName() != null) {
                    if (key.equals("Contactless")) {
                        startPayment();
                    }
                    keys.add(key);
                }
            }
            if (!(keys.contains("Contactless"))) {
                Log.d(TAG, "PED device doesn't support ContactLess");
                if (transactionListener != null) {
                    returnReason = Constants.ErrorReason;
                    returnStatus = Constants.ErrorStatus;
                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                }
            }
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void startPayment() {
        Log.d(TAG, "###RB#### startPayment: ");
        try {
            BluetoothModule.getInstance().setTimeoutEnable(true);
            BluetoothDevice device = BluetoothModule.getInstance().getSelectedBluetoothDevice();

            final boolean isPosDevice;
            if (device != null) {
                if (device.getName().toLowerCase().contains("pos")) {
                    MiuraManager.getInstance().setDeviceType(MiuraManager.DeviceType.POS);
                    isPosDevice = true;
                } else {
                    MiuraManager.getInstance().setDeviceType(MiuraManager.DeviceType.PED);
                    isPosDevice = false;
                }
                loadTransactionData(isPosDevice);
            }
        } catch (Exception e) {
            Log.d(TAG, "###RB#### startPayment: " + e.toString());
        }
    }

    private void loadTransactionData(final boolean isPosDevice) {
        Log.d(TAG, "###RB#### loadTransactionData: ");
        try {
            MiuraManager.getInstance().getSoftwareInfo(new ApiGetSoftwareInfoListener() {

                @WorkerThread
                @Override
                public void onSuccess(SoftwareInfo softwareInfo) {
                    pedDeviceId = softwareInfo.getSerialNumber();
                }

                @WorkerThread
                @Override
                public void onError() {
                    //TODO check error
                }
            });

            MiuraManager.getInstance().executeAsync(new MiuraManager.AsyncRunnable() {
                @Override
                public void runOnAsyncThread(@NonNull MpiClient client) {
                    performTransaction();
                }
            });
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void performTransaction() {
        Log.d(TAG, "###RB#### performTransaction: ");
        try {
            Log.d(TAG, "Starting Transaction");

            if (!isEbt) {
                registerEventHandlers();
                MpiClient client = MiuraManager.getInstance().getMpiClient();
                if (client != null) {
                    client.cardStatus(MPI, true, false, true, true, false, true);
                }
            } else {
                String deviceText = amount + "\n Swipe card";

                MiuraManager.getInstance().displayText(
                        deviceText,
                        new MiuraDefaultListener() {
                            @Override
                            public void onSuccess() {
                                registerEventHandlers();
                                MpiClient client = MiuraManager.getInstance().getMpiClient();
                                if (client != null) {
                                    client.cardStatus(MPI, true, false, true, true, false, true);
                                }
                            }

                            @Override
                            public void onError() {
                            }
                        });
            }

        } catch (Exception e) {
            Log.d(TAG, "performTransaction: " + e.toString());
        }
    }

    private final MpiEventHandler<CardData> mCardEventHandler = new MpiEventHandler<CardData>() {

        @Override
        public void handle(@NonNull CardData cardData) {
            Log.d(TAG, "###RB#### MpiEventhandler: ");
            Log.d(TAG, "cardData " + cardData);
            handleTransactionEvent(cardData);
        }
    };

    private final MpiEventHandler<DeviceStatusChange> mDeviceStatusHandler =
            new MpiEventHandler<DeviceStatusChange>() {
                @Override
                public void handle(DeviceStatusChange arg) {
                    DeviceStatus status = arg.deviceStatus;
                    final String text = arg.statusText;
                    Log.d(TAG, String.format(Locale.ENGLISH,
                            "Device status: '%s'. Text status %s", status.name(), text)
                    );
                }
            };

    private void registerEventHandlers() {
        Log.d(TAG, "###RB#### registerEventHandlers: ");
        MPI_EVENTS.CardStatusChanged.register(mCardEventHandler);
        MPI_EVENTS.DeviceStatusChanged.register(mDeviceStatusHandler);
    }

    private void deregisterEventHandlers() {
        Log.d(TAG, "###RB#### deregisterEventHandlers: ");
        try {
            MPI_EVENTS.CardStatusChanged.deregister(mCardEventHandler);
            MPI_EVENTS.DeviceStatusChanged.deregister(mDeviceStatusHandler);
        } catch (Exception e) {
            Log.d(TAG, "deregisterEventHandlers: " + e.toString());
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void abortEmvTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "###RB#### abortEmvTransactionAsync: ");
        try {
            Log.d(TAG, "abortEmvTransactionAsync");
            if (mEmvTransactionAsync == null) {
                Log.d(TAG, "abortEmvTransactionAsync: mEmvTransactionAsync == null");
                return;
            }
            mEmvTransactionAsync.abortTransactionAsync(listener);
            //mEmvTransactionAsync = null;
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    private void abortSwipeTransactionAsync(@Nullable MiuraDefaultListener listener) {
        Log.d(TAG, "###RB#### abortSwipeTransactionAsync: ");
        try {
            Log.d(TAG, "abortSwipeTransactionAsync");

            if (mMagSwipeTransaction == null) {
                Log.d(TAG, "abortSwipeTransaction: mMagSwipeTransaction == null");
                return;
            }
            mMagSwipeTransaction.abortTransactionAsync(listener);
        } catch (Exception e) {
            if (transactionListener != null) {
                returnReason = e.toString();
                returnStatus = Constants.Exception;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
        }
    }

    protected void handleTransactionEvent(CardData cardData) {
        Log.d(TAG, "###RB#### handleTransactionEvent: ");
        try {
            if (!BluetoothModule.getInstance().isSessionOpen()) {
                return;
            }
            if (!isEbt) {
                if (cardData.getSredData() == null) {
                    EmvChipInsertStatus insertStatus = EmvTransactionAsync.canProcessEmvChip(cardData);
                    if (insertStatus == EmvChipInsertStatus.CardInsertedOk) {
                        isTransactionInProcess = true;
                        isEmv = true;
                        entryMode = Constants.Chip;
                        showTextOnDevice("\nProcessing...");
                        startEmvTransaction(EmvTransactionType.Chip);
                        return;
                    }
                    isTransactionInProcess = false;
                    if (insertStatus == EmvChipInsertStatus.CardIncompatibleError) {
                        count++;
                        Log.d(TAG, "HandleTransaction count : " + count);
                        if (count > 3) {
                            isFallBack = true;
                            entryMode = Constants.EmvFallback;
                        }
                    }

                    if (!isFallBack) {
                        entryMode = Constants.NFC;
                        startEmvTransaction(EmvTransactionType.Contactless);
                        return;
                    }
                }

                Result<MagSwipeSummary, MagSwipeError> result =
                        MagSwipeTransaction.canProcessMagSwipe(cardData);

                if (result.isError()) {
                    showTextOnDevice("Transaction Error\nPlease try again");
                    return;
                }


                if (isPinRequired) {
                    PaymentMagType paymentMagType = PaymentMagType.Auto;
                    MagSwipeSummary magSwipeSummary = result.asSuccess().getValue();
                    startSwipeTransaction(magSwipeSummary, paymentMagType, cardData);
                } else {
                    this.cardData = cardData;
                    if (transactionListener != null) {
                        returnReason = Constants.SuccessReason;
                        returnStatus = Constants.SuccessStatus;
                        transactionListener.onTransactionComplete(createTransactionData(cardData));
                    }
                    closeBtSession();
                    clearTransactionData();
                    clearData();
                }
            } else {
                swipeTransaction(cardData);
            }
        } catch (Exception e) {
            Log.d(TAG, "handleTransactionEvent: ");
        }
    }

    protected void startSwipeTransaction(
            MagSwipeSummary magSwipeSummary,
            PaymentMagType paymentMagType,
            final CardData cardData
    ) {

        abortEmvTransactionAsync(null);
        abortSwipeTransactionAsync(null);

        mMagSwipeTransaction = new MagSwipeTransactionAsync(MiuraManager.getInstance(), paymentMagType);
        mMagSwipeTransaction.startTransactionAsync(
                magSwipeSummary,
                amount * 100,
                MiuraApplication.currencyCode.getValue(),
                new MagSwipeTransactionAsync.Callback() {

                    @Override
                    public void onPinSuccess(@NonNull MagSwipeSummary magSwipeSummary, @NonNull OnlinePinSummary onlinePinSummary) {

                        pinKsn = onlinePinSummary.mPinKSN;
                        pinData = onlinePinSummary.mPinData;

                        if (transactionListener != null) {
                            returnReason = Constants.SuccessReason;
                            returnStatus = Constants.SuccessStatus;
                            TransactionApiData data = createTransactionData(cardData);
                            data.setDebit(true);
                            transactionListener.onTransactionComplete(data);
                        }

                        closeBtSession();
                        clearTransactionData();
                        clearData();
                    }

                    @NonNull
                    @Override
                    public SignatureSummary getSignatureFromUser() {
                        Log.d(TAG, "getSignatureFromUser: ");
                        return null;
                    }

                    @Override
                    public void onSignatureSuccess(@NonNull MagSwipeSummary magSwipeSummary, @NonNull SignatureSummary signature) {
                        Log.d(TAG, "onSignatureSuccess: ");
                    }

                    @Override
                    public void onError(@NonNull MagSwipeTransactionException exception) {
                        Log.d(TAG, "onError: ");
                    }
                });
    }

    @UiThread
    private void startEmvTransaction(final EmvTransactionType emvTransactionType) {
        startTransactionTimer();
        if (mEmvTransactionAsync != null) {
            if (!mEmvTransactionAsync.mEmvTransaction.errorEmv) {
                abortEmvTransactionAsync(null);
                abortSwipeTransactionAsync(null);
            }
        } else {
            abortEmvTransactionAsync(null);
            abortSwipeTransactionAsync(null);
        }

        EmvTransactionAsync emvTransactionAsync = new EmvTransactionAsync(
                MIURA_MANAGER, emvTransactionType
        );
        mEmvTransactionAsync = emvTransactionAsync;

        emvTransactionAsync.startTransactionAsync(
                (int) this.displayAmount,
                MiuraApplication.currencyCode.getValue(),
                new EmvTransactionAsync.Callback() {

                    @Override
                    public void publishStartTransactionResult(@NonNull final String response) {
                        isTransactionInProcess = true;
                        Log.d(TAG, " isTransactionInProcess : " + isTransactionInProcess);

                        Log.d(TAG, "###RB#### response: " + response);
                        if (!mEmvTransactionAsync.mEmvTransaction.errorEmv) {
                            if (!isEmv) {
                                entryMode = Constants.NFC;
                            }
                            getTransactionDetails(response);

                            if (transactionListener != null) {
                                returnReason = Constants.SuccessReason;
                                returnStatus = Constants.SuccessStatus;
                                transactionListener.onTransactionComplete(createTransactionData(cardData));
                            }
                            if (BluetoothModule.getInstance().isSessionOpen()) {
                                deregisterEventHandlers();
                                BluetoothModule.getInstance().closeSession();
                            }
                        } else {
                            if (transactionListener != null) {
                                returnReason = Constants.ErrorReason;
                                returnStatus = Constants.ErrorStatus;
                                transactionListener.onTransactionComplete(createTransactionData(cardData));
                            }
                            if (BluetoothModule.getInstance().isSessionOpen()) {
                                deregisterEventHandlers();
                                BluetoothModule.getInstance().closeSession();
                            }
                        }
                    }

                    @Override
                    public void onSuccess(@NonNull final EmvTransactionSummary result) {
                        Log.d(TAG, "onSuccess: continue transaction success");
                        if ((emvTransactionType == EmvTransactionType.Contactless ||
                                emvTransactionType == EmvTransactionType.Chip)
                                && result.mStartTransactionResponse != null) {
                            getTransactionDetails(result.mStartTransactionResponse);

                            if (transactionListener != null) {
                                returnReason = Constants.SuccessReason;
                                returnStatus = Constants.SuccessStatus;
                                transactionListener.onTransactionComplete(createTransactionData(cardData));
                            }
                            if (BluetoothModule.getInstance().isSessionOpen()) {
                                deregisterEventHandlers();
                                BluetoothModule.getInstance().closeSession();
                            }
                        }
                    }

                    @Override
                    public void onError(@NonNull EmvTransactionException exception) {

                        if (!isTransactionTimeOut && !isCancelTransaction) {
                            TransactionResponse response = exception.mErrCode;
                            if (response.name().equals("CONTACTLESS_ABORT_BY_CARD_INSERT")) {
                                Log.d(TAG, "onError: Contactless ");
                                /*if (BluetoothModule.getInstance().isSessionOpen()) {
                                    deregisterEventHandlers();
                                    BluetoothModule.getInstance().closeSession();
                                }
                                new Handler(Looper.getMainLooper()).post(new Runnable() {
                                    public void run() {
                                        restartConnection();
                                    }
                                });
                                return;*/
                            }
                            if (response.name().equals("USER_CANCELLED")) {
                                Log.d(TAG, "Cancel through PED onError: ");
                                if (transactionListener != null && !isTransactionComplete) {
                                    returnReason = Constants.CanceledThroughPEDReason;
                                    returnStatus = Constants.CanceledThroughPEDStatus;
                                    transactionListener.onTransactionComplete(createTransactionData(cardData));
                                }
                                if (BluetoothModule.getInstance().isSessionOpen()) {
                                    deregisterEventHandlers();
                                    BluetoothModule.getInstance().closeSession();
                                }

                            } else {
                                String explanation = String.valueOf(exception.mErrCode);
                                Log.d(TAG, String.format("onError(%s, %s)", response, explanation));
                            }

                        }
                    }
                });
    }

    private void swipeTransaction(CardData cardData) {
        entryMode = Constants.Swipe;
        EmvChipInsertStatus insertStatus = EmvTransactionAsync.canProcessEmvChip(cardData);
        if (insertStatus == EmvChipInsertStatus.CardInsertedOk) {
            return;
        }

        Result<MagSwipeSummary, MagSwipeError> result =
                MagSwipeTransaction.canProcessMagSwipe(cardData);
        if (result.isError()) {
            Log.d(TAG, "SWIPE ERROR Please try again");
            return;
        }

        if (isPinRequired) {
            PaymentMagType paymentMagType = PaymentMagType.Pin;
            MagSwipeSummary magSwipeSummary = result.asSuccess().getValue();
            startSwipeTransaction(magSwipeSummary, paymentMagType, cardData);
        } else {
            this.cardData = cardData;
            if (transactionListener != null) {
                returnReason = Constants.SuccessReason;
                returnStatus = Constants.SuccessStatus;
                transactionListener.onTransactionComplete(createTransactionData(cardData));
            }
            closeBtSession();
            clearTransactionData();
            clearData();
        }
    }

    protected static void showTextOnDevice(String text) {
        if (BluetoothModule.getInstance().isSessionOpen()) {
            MiuraManager.getInstance().displayText(DisplayTextUtils.getCenteredText(text), null);
        }
    }

    private TransactionApiData createTransactionData(CardData cardData) {
        isTransactionComplete = true;
        if (pedDeviceId != null) {
            transactionData.setDeviceId(pedDeviceId);
            transactionData.setAmount(this.amount);
            transactionData.setReturnReason(returnReason);
            transactionData.setReturnStatus(returnStatus);
            transactionData.setDeviceCode("41");
            transactionData.setEntryMode(entryMode);
            if (mEmvTransactionAsync != null)
                transactionData.setTLVData(mEmvTransactionAsync.mEmvTransaction.tlvData);

            if (cardData != null) {
                transactionData.setCardHolderName(cardData.getCardholderName());
                if (cardData.getMaskedTrack2Data() != null) {
                    if (cardData.getMaskedTrack2Data().getExpirationDate() == null) {
                    } else {
                        String expireDate = convertExpireDateToMMYY(cardData.getMaskedTrack2Data().getExpirationDate());
                        transactionData.setExpiryDate(expireDate);
                    }
                    transactionData.setCardNumber(cardData.getMaskedTrack2Data().mPan);
                    String number = cardData.getMaskedTrack2Data().mPan;

                    if (!number.isEmpty() && number.length() > 4) {
                        transactionData.setAccountFirstFour(number.substring(0, 4));
                        transactionData.setAccountLastFour(number.substring(number.length() - 4));
                    }
                }
                transactionData.setMaskedTrack2Data(cardData.getMaskedTrack2Data().toString());
                if (isDebitTransaction) {
                    transactionData.setKSN(sRedKsn);
                    transactionData.setEncryptedCardData(sRedData);
                } else {
                    transactionData.setKSN(cardData.getSredKSN().toUpperCase());
                    transactionData.setEncryptedCardData(cardData.getSredData().toUpperCase());
                }
                transactionData.setAid(aid);
                transactionData.setApplicationLabel(applicationLabel);
                transactionData.setPinData(pinData);
                transactionData.setPinKsn(pinKsn);
            } else {
                if (mEmvTransactionAsync != null) {
                    if (!mEmvTransactionAsync.mEmvTransaction.errorEmv) {
                        Log.d(TAG, "###RB####  createTransactionData");
                        maskedCreditCardNumber = maskedCreditCardNumber.replace("f", "*");
                        if (!maskedCreditCardNumber.isEmpty()) {
                            transactionData.setCardNumber(maskedCreditCardNumber);
                            if (maskedCreditCardNumber.length() > 4) ;
                            {
                                transactionData.setAccountFirstFour(maskedCreditCardNumber.substring(0, 4));
                                transactionData.setAccountLastFour(maskedCreditCardNumber.substring(maskedCreditCardNumber.length() - 4));
                            }
                            if (expireDate.length() > 4) {
                                String convertExpireDate = convertExpireDateToMMYY(expireDate.substring(0, 4));
                                transactionData.setExpiryDate(convertExpireDate);
                            }
                            if (cardHolderName != null && cardHolderName.length() > 0)
                                transactionData.setCardHolderName(cardHolderName);
                            if (sRedKsn != null && sRedKsn.length() > 0)
                                transactionData.setKSN(sRedKsn.toUpperCase());
                            transactionData.setEncryptedCardData(sRedData);
                            transactionData.setAid(aid);
                            transactionData.setApplicationLabel(applicationLabel);
                            transactionData.setPinData(pinData);
                            transactionData.setPinKsn(sPinKsn);
                        }
                    }
                }
            }
        }
        cancelTransactionTimer();
        return transactionData;
    }

    private String convertExpireDateToMMYY(String expireNumber) {
        int number = Integer.parseInt(expireNumber);
        String firstTwo = Integer.toString(number / 100);
        if (firstTwo.length() < 2) {
            firstTwo = "0" + firstTwo;
        }
        String lastTwo = Integer.toString(number % 100);
        if (lastTwo.length() < 2) {
            lastTwo = "0" + lastTwo;
        }

        expireNumber = lastTwo + firstTwo;
        return expireNumber;
    }

    private void getTransactionDetails(String transactionResponse) {
        getCardNumber(transactionResponse);
        getCardApplicationLabel(transactionResponse);
        if (isDebitTransaction(getCardVerificationMethod(transactionResponse), transactionResponse)) {
            transactionData.setDebit(true);
        }
        getExpireCardNumber(transactionResponse);
        getCardHolderName(transactionResponse);
        getApplicationID(transactionResponse);
        getSREDKSN(transactionResponse);
        getSREDData(transactionResponse);
        getPinKSN(transactionResponse);
    }

    private String getCardNumber(String response) {
        try {
            String[] splitAfterMaskedTrackData = response.split("ICC_Masked_Track_2");
            String splitResponse = splitAfterMaskedTrackData[1].trim();

            String lines[] = splitResponse.split("\\r?\\n");
            for (int i = 0; i < lines.length; i++) {
                if (lines[i].contains("data")) {
                    String[] part = lines[i].split("\\[");
                    String part2 = part[1].trim();
                    String[] split = part2.split("\\]");
                    String maskedTrackData = split[0].trim();
                    String[] splitCreditCardNumber = maskedTrackData.split("d");

                    maskedCreditCardNumber = splitCreditCardNumber[0];
                    return maskedCreditCardNumber;
                }
            }
            return maskedCreditCardNumber;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at maskedCreditCardNumber: " + ex.toString());
            return maskedCreditCardNumber;
        }
    }

    private String getExpireCardNumber(String response) {
        try {
            String[] splitAfterMaskedTrackData = response.split("ICC_Masked_Track_2");
            String splitResponse = splitAfterMaskedTrackData[1].trim();

            String lines[] = splitResponse.split("\\r?\\n");
            for (int i = 0; i < lines.length; i++) {
                if (lines[i].contains("data")) {
                    String[] part = lines[i].split("\\[");
                    String part2 = part[1].trim();
                    String[] split = part2.split("\\]");
                    String maskedTrackData = split[0].trim();
                    String[] splitCreditCardNumber = maskedTrackData.split("d");

                    expireDate = splitCreditCardNumber[1];
                    return expireDate;
                }
            }
            return expireDate;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at expireDate: " + ex.toString());
            return expireDate;
        }
    }

    private String getCardHolderName(String response) {
        try {
            String[] splitAfterMaskedTrackData = response.split("Cardholder_Name");
            String splitResponse = splitAfterMaskedTrackData[1].trim();

            String lines[] = splitResponse.split("\\r?\\n");
            for (int i = 0; i < lines.length; i++) {
                if (lines[i].contains("text")) {
                    String[] part = lines[i].split("text");
                    String split1 = part[1];
                    String[] part1 = split1.split("\\[");
                    String part2 = part1[1].trim();
                    String[] split = part2.split("\\]");
                    cardHolderName = split[0].trim();
                    return cardHolderName;
                }
            }
            return cardHolderName;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at cardHolderName: " + ex.toString());
            return cardHolderName;
        }
    }

    private String getCardApplicationLabel(String response) {
        try {
            String[] splitAfterMaskedTrackData = response.split("Application_Label");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            applicationLabel = getData(splitResponse, "text");
            return applicationLabel;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at cardHolderName: " + ex.toString());
            return applicationLabel;
        }
    }

    private String getApplicationID(String response) {
        String aid = "";
        try {
            String[] splitAfterMaskedTrackData = response.split("Application_Identifier_AID_terminal");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            aid = getData(splitResponse, "data");
            this.aid = aid.toUpperCase();
            return this.aid;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at cardHolderName: " + ex.toString());
            return this.aid;
        }
    }

    private String getCardVerificationMethod(String response) {
        String cvmData = "";
        try {
            String[] splitAfterMaskedTrackData = response.split("Cardholder_Verification_Method_CVM_Results");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            cvmData = getData(splitResponse, "data");
            return cvmData;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at cardHolderName: " + ex.toString());
            return cvmData;
        }
    }

    private String getPinData(String response) {
        String pinData = "";
        try {
            String[] splitAfterMaskedTrackData = response.split("Online_PIN_Data");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            pinData = getData(splitResponse, "data");
            return pinData;
        } catch (Exception ex) {
            Log.d(TAG, "###RB#### exception at cardHolderName: " + ex.toString());
            return pinData;
        }
    }

    private String getSREDKSN(String response) {
        if (response.contains("SRED_KSN")) {
            String[] splitAfterMaskedTrackData = response.split("SRED_KSN");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            sRedKsn = getData(splitResponse, "data");
        }
        return sRedKsn;
    }

    private String getSREDData(String response) {
        if (response.contains("SRED_Data")) {
            String[] splitAfterMaskedTrackData = response.split("SRED_Data");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            sRedData = getData(splitResponse, "data");
        }
        return sRedData;
    }

    private String getPinKSN(String response) {
        if (response.contains("Online_PIN_KSN")) {
            String[] splitAfterMaskedTrackData = response.split("Online_PIN_KSN");
            String splitResponse = splitAfterMaskedTrackData[1].trim();
            sPinKsn = getData(splitResponse, "data");
        }
        return sPinKsn;
    }

    private String getData(String value, String tag) {
        String data = "";
        String lines[] = value.split("\\r?\\n");
        for (int i = 0; i < lines.length; i++) {
            if (lines[i].contains(tag)) {
                String[] part = lines[i].split(tag);
                String split1 = part[1];
                String[] part1 = split1.split("\\[");
                String part2 = part1[1].trim();
                String[] split = part2.split("\\]");
                data = split[0].trim();
                return data;
            }
        }
        return data;
    }

    private boolean isDebitTransaction(String cvmValue, String transactionResponse) {
        boolean result = false;
        pinData = getPinData(transactionResponse);
        if (!pinData.isEmpty()) {
            int data = Utils.getByteData(cvmValue);
            int firstByte = Utils.getByteData(String.valueOf(data));
            if (cvmValue.isEmpty() || (Utils.isNumeric(cvmValue) &&
                    ((firstByte == 2) || (firstByte == 42)))) {
                result = true;
            }
        }
        return result;
    }

    /**
     * Transaction Timer
     */
    private void startTransactionTimer() {
        isTimerTimedOut = false;
        cancelTransactionTimer();
        mTimer = new Timer();
        mTimer.schedule(new TimerTask() {
            public void run() {
                isTransactionTimeOut = true;
                isTimerTimedOut = true;
                cancelTransaction();
                this.cancel();
            }
        }, mTransactionTime * 1000);
    }

    private void closeBtSession() {
        mEmvTransactionAsync = null;
        new Handler(Looper.getMainLooper()).post(new Runnable() {
            public void run() {
                if (BluetoothModule.getInstance().isSessionOpen()) {
                    deregisterEventHandlers();
                    BluetoothModule.getInstance().closeSession();
                }
            }
        });

    }

    private void cancelTransactionTimer() {
        if (mTimer != null) {
            mTimer.cancel();
            mTimer = null;
        }
    }

    /**
     * Method that reset the transaction parameters
     */
    private void clearTransactionData() {
        mEmvTransactionAsync = null;
        mMagSwipeTransaction = null;
        cancelTransactionTimer();
    }

    /**
     * Method that reset the transaction status
     */
    private void clearData() {
        cancelTransactionTimer();
        entryMode = Constants.Swipe;
        mFirstTry = false;
        count = 1;
        transactionData = null;
        isEmv = false;
        isFallBack = false;
        isTransactionTimeOut = false;
        isCancelTransaction = false;
        isTransactionComplete = false;
        isTransactionInProcess = false;
        this.pedDeviceId = "";
        this.amount = 0.0d;
        this.description = "";
        this.cardData = null;
        this.returnReason = "";
        this.returnStatus = 0;
        cardHolderName = "";
        maskedCreditCardNumber = "";
        expireDate = "";
        transactionListener = null;
        isDebitTransaction = false;
        pinData = "";
        applicationLabel = "";
        aid = "";
    }
}