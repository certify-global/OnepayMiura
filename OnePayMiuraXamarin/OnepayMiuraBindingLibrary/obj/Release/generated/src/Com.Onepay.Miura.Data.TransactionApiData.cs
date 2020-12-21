using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']"
	[global::Android.Runtime.Register ("com/onepay/miura/data/TransactionApiData", DoNotGenerateAcw=true)]
	public partial class TransactionApiData : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/data/TransactionApiData", typeof (TransactionApiData));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected TransactionApiData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/constructor[@name='TransactionApiData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransactionApiData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_KSN;
#pragma warning disable 0169
		static Delegate GetKSNHandler ()
		{
			if (cb_KSN == null)
				cb_KSN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_KSN);
			return cb_KSN;
		}

		static IntPtr n_KSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KSN ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='KSN' and count(parameter)=0]"
		[Register ("KSN", "()Ljava/lang/String;", "GetKSNHandler")]
		public virtual unsafe string KSN ()
		{
			const string __id = "KSN.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_accountFirstFour;
#pragma warning disable 0169
		static Delegate GetAccountFirstFourHandler ()
		{
			if (cb_accountFirstFour == null)
				cb_accountFirstFour = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AccountFirstFour);
			return cb_accountFirstFour;
		}

		static IntPtr n_AccountFirstFour (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountFirstFour ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='accountFirstFour' and count(parameter)=0]"
		[Register ("accountFirstFour", "()Ljava/lang/String;", "GetAccountFirstFourHandler")]
		public virtual unsafe string AccountFirstFour ()
		{
			const string __id = "accountFirstFour.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_accountLastFour;
#pragma warning disable 0169
		static Delegate GetAccountLastFourHandler ()
		{
			if (cb_accountLastFour == null)
				cb_accountLastFour = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AccountLastFour);
			return cb_accountLastFour;
		}

		static IntPtr n_AccountLastFour (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountLastFour ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='accountLastFour' and count(parameter)=0]"
		[Register ("accountLastFour", "()Ljava/lang/String;", "GetAccountLastFourHandler")]
		public virtual unsafe string AccountLastFour ()
		{
			const string __id = "accountLastFour.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_amount;
#pragma warning disable 0169
		static Delegate GetAmountHandler ()
		{
			if (cb_amount == null)
				cb_amount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_Amount);
			return cb_amount;
		}

		static double n_Amount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Amount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='amount' and count(parameter)=0]"
		[Register ("amount", "()D", "GetAmountHandler")]
		public virtual unsafe double Amount ()
		{
			const string __id = "amount.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_cardHolderName;
#pragma warning disable 0169
		static Delegate GetCardHolderNameHandler ()
		{
			if (cb_cardHolderName == null)
				cb_cardHolderName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CardHolderName);
			return cb_cardHolderName;
		}

		static IntPtr n_CardHolderName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardHolderName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='cardHolderName' and count(parameter)=0]"
		[Register ("cardHolderName", "()Ljava/lang/String;", "GetCardHolderNameHandler")]
		public virtual unsafe string CardHolderName ()
		{
			const string __id = "cardHolderName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cardNumber;
#pragma warning disable 0169
		static Delegate GetCardNumberHandler ()
		{
			if (cb_cardNumber == null)
				cb_cardNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CardNumber);
			return cb_cardNumber;
		}

		static IntPtr n_CardNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardNumber ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='cardNumber' and count(parameter)=0]"
		[Register ("cardNumber", "()Ljava/lang/String;", "GetCardNumberHandler")]
		public virtual unsafe string CardNumber ()
		{
			const string __id = "cardNumber.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deviceCode;
#pragma warning disable 0169
		static Delegate GetDeviceCodeHandler ()
		{
			if (cb_deviceCode == null)
				cb_deviceCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DeviceCode);
			return cb_deviceCode;
		}

		static IntPtr n_DeviceCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='deviceCode' and count(parameter)=0]"
		[Register ("deviceCode", "()Ljava/lang/String;", "GetDeviceCodeHandler")]
		public virtual unsafe string DeviceCode ()
		{
			const string __id = "deviceCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deviceId;
#pragma warning disable 0169
		static Delegate GetDeviceIdHandler ()
		{
			if (cb_deviceId == null)
				cb_deviceId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DeviceId);
			return cb_deviceId;
		}

		static IntPtr n_DeviceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='deviceId' and count(parameter)=0]"
		[Register ("deviceId", "()Ljava/lang/String;", "GetDeviceIdHandler")]
		public virtual unsafe string DeviceId ()
		{
			const string __id = "deviceId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_encryptedCardData;
#pragma warning disable 0169
		static Delegate GetEncryptedCardDataHandler ()
		{
			if (cb_encryptedCardData == null)
				cb_encryptedCardData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EncryptedCardData);
			return cb_encryptedCardData;
		}

		static IntPtr n_EncryptedCardData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptedCardData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='encryptedCardData' and count(parameter)=0]"
		[Register ("encryptedCardData", "()Ljava/lang/String;", "GetEncryptedCardDataHandler")]
		public virtual unsafe string EncryptedCardData ()
		{
			const string __id = "encryptedCardData.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_entryMode;
#pragma warning disable 0169
		static Delegate GetEntryModeHandler ()
		{
			if (cb_entryMode == null)
				cb_entryMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EntryMode);
			return cb_entryMode;
		}

		static IntPtr n_EntryMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='entryMode' and count(parameter)=0]"
		[Register ("entryMode", "()Ljava/lang/String;", "GetEntryModeHandler")]
		public virtual unsafe string EntryMode ()
		{
			const string __id = "entryMode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_expiryDate;
#pragma warning disable 0169
		static Delegate GetExpiryDateHandler ()
		{
			if (cb_expiryDate == null)
				cb_expiryDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ExpiryDate);
			return cb_expiryDate;
		}

		static IntPtr n_ExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpiryDate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='expiryDate' and count(parameter)=0]"
		[Register ("expiryDate", "()Ljava/lang/String;", "GetExpiryDateHandler")]
		public virtual unsafe string ExpiryDate ()
		{
			const string __id = "expiryDate.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maskedTrack2Data;
#pragma warning disable 0169
		static Delegate GetMaskedTrack2DataHandler ()
		{
			if (cb_maskedTrack2Data == null)
				cb_maskedTrack2Data = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MaskedTrack2Data);
			return cb_maskedTrack2Data;
		}

		static IntPtr n_MaskedTrack2Data (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaskedTrack2Data ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='maskedTrack2Data' and count(parameter)=0]"
		[Register ("maskedTrack2Data", "()Ljava/lang/String;", "GetMaskedTrack2DataHandler")]
		public virtual unsafe string MaskedTrack2Data ()
		{
			const string __id = "maskedTrack2Data.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_returnReason;
#pragma warning disable 0169
		static Delegate GetReturnReasonHandler ()
		{
			if (cb_returnReason == null)
				cb_returnReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReturnReason);
			return cb_returnReason;
		}

		static IntPtr n_ReturnReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReturnReason ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='returnReason' and count(parameter)=0]"
		[Register ("returnReason", "()Ljava/lang/String;", "GetReturnReasonHandler")]
		public virtual unsafe string ReturnReason ()
		{
			const string __id = "returnReason.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_returnStatus;
#pragma warning disable 0169
		static Delegate GetReturnStatusHandler ()
		{
			if (cb_returnStatus == null)
				cb_returnStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ReturnStatus);
			return cb_returnStatus;
		}

		static int n_ReturnStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReturnStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='returnStatus' and count(parameter)=0]"
		[Register ("returnStatus", "()I", "GetReturnStatusHandler")]
		public virtual unsafe int ReturnStatus ()
		{
			const string __id = "returnStatus.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAccountFirstFour_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountFirstFour_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountFirstFour_Ljava_lang_String_ == null)
				cb_setAccountFirstFour_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccountFirstFour_Ljava_lang_String_);
			return cb_setAccountFirstFour_Ljava_lang_String_;
		}

		static void n_SetAccountFirstFour_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountFirstFour)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountFirstFour = JNIEnv.GetString (native_accountFirstFour, JniHandleOwnership.DoNotTransfer);
			__this.SetAccountFirstFour (accountFirstFour);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setAccountFirstFour' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccountFirstFour", "(Ljava/lang/String;)V", "GetSetAccountFirstFour_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAccountFirstFour (string accountFirstFour)
		{
			const string __id = "setAccountFirstFour.(Ljava/lang/String;)V";
			IntPtr native_accountFirstFour = JNIEnv.NewString (accountFirstFour);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accountFirstFour);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountFirstFour);
			}
		}

		static Delegate cb_setAccountLastFour_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountLastFour_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountLastFour_Ljava_lang_String_ == null)
				cb_setAccountLastFour_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAccountLastFour_Ljava_lang_String_);
			return cb_setAccountLastFour_Ljava_lang_String_;
		}

		static void n_SetAccountLastFour_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountLastFour)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accountLastFour = JNIEnv.GetString (native_accountLastFour, JniHandleOwnership.DoNotTransfer);
			__this.SetAccountLastFour (accountLastFour);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setAccountLastFour' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccountLastFour", "(Ljava/lang/String;)V", "GetSetAccountLastFour_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAccountLastFour (string accountLastFour)
		{
			const string __id = "setAccountLastFour.(Ljava/lang/String;)V";
			IntPtr native_accountLastFour = JNIEnv.NewString (accountLastFour);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_accountLastFour);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountLastFour);
			}
		}

		static Delegate cb_setAmount_D;
#pragma warning disable 0169
		static Delegate GetSetAmount_DHandler ()
		{
			if (cb_setAmount_D == null)
				cb_setAmount_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetAmount_D);
			return cb_setAmount_D;
		}

		static void n_SetAmount_D (IntPtr jnienv, IntPtr native__this, double amount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAmount (amount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setAmount", "(D)V", "GetSetAmount_DHandler")]
		public virtual unsafe void SetAmount (double amount)
		{
			const string __id = "setAmount.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (amount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCardHolderName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardHolderName_Ljava_lang_String_Handler ()
		{
			if (cb_setCardHolderName_Ljava_lang_String_ == null)
				cb_setCardHolderName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCardHolderName_Ljava_lang_String_);
			return cb_setCardHolderName_Ljava_lang_String_;
		}

		static void n_SetCardHolderName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardHolderName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardHolderName = JNIEnv.GetString (native_cardHolderName, JniHandleOwnership.DoNotTransfer);
			__this.SetCardHolderName (cardHolderName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setCardHolderName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardHolderName", "(Ljava/lang/String;)V", "GetSetCardHolderName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCardHolderName (string cardHolderName)
		{
			const string __id = "setCardHolderName.(Ljava/lang/String;)V";
			IntPtr native_cardHolderName = JNIEnv.NewString (cardHolderName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cardHolderName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cardHolderName);
			}
		}

		static Delegate cb_setCardNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setCardNumber_Ljava_lang_String_ == null)
				cb_setCardNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCardNumber_Ljava_lang_String_);
			return cb_setCardNumber_Ljava_lang_String_;
		}

		static void n_SetCardNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardNumber = JNIEnv.GetString (native_cardNumber, JniHandleOwnership.DoNotTransfer);
			__this.SetCardNumber (cardNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setCardNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardNumber", "(Ljava/lang/String;)V", "GetSetCardNumber_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCardNumber (string cardNumber)
		{
			const string __id = "setCardNumber.(Ljava/lang/String;)V";
			IntPtr native_cardNumber = JNIEnv.NewString (cardNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cardNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cardNumber);
			}
		}

		static Delegate cb_setDeviceCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceCode_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceCode_Ljava_lang_String_ == null)
				cb_setDeviceCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceCode_Ljava_lang_String_);
			return cb_setDeviceCode_Ljava_lang_String_;
		}

		static void n_SetDeviceCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var deviceCode = JNIEnv.GetString (native_deviceCode, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceCode (deviceCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setDeviceCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDeviceCode", "(Ljava/lang/String;)V", "GetSetDeviceCode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDeviceCode (string deviceCode)
		{
			const string __id = "setDeviceCode.(Ljava/lang/String;)V";
			IntPtr native_deviceCode = JNIEnv.NewString (deviceCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceCode);
			}
		}

		static Delegate cb_setDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceId_Ljava_lang_String_ == null)
				cb_setDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceId_Ljava_lang_String_);
			return cb_setDeviceId_Ljava_lang_String_;
		}

		static void n_SetDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var deviceId = JNIEnv.GetString (native_deviceId, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceId (deviceId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDeviceId", "(Ljava/lang/String;)V", "GetSetDeviceId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDeviceId (string deviceId)
		{
			const string __id = "setDeviceId.(Ljava/lang/String;)V";
			IntPtr native_deviceId = JNIEnv.NewString (deviceId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceId);
			}
		}

		static Delegate cb_setEncryptedCardData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncryptedCardData_Ljava_lang_String_Handler ()
		{
			if (cb_setEncryptedCardData_Ljava_lang_String_ == null)
				cb_setEncryptedCardData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEncryptedCardData_Ljava_lang_String_);
			return cb_setEncryptedCardData_Ljava_lang_String_;
		}

		static void n_SetEncryptedCardData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardData = JNIEnv.GetString (native_cardData, JniHandleOwnership.DoNotTransfer);
			__this.SetEncryptedCardData (cardData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setEncryptedCardData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEncryptedCardData", "(Ljava/lang/String;)V", "GetSetEncryptedCardData_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEncryptedCardData (string cardData)
		{
			const string __id = "setEncryptedCardData.(Ljava/lang/String;)V";
			IntPtr native_cardData = JNIEnv.NewString (cardData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cardData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cardData);
			}
		}

		static Delegate cb_setEntryMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryMode_Ljava_lang_String_ == null)
				cb_setEntryMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEntryMode_Ljava_lang_String_);
			return cb_setEntryMode_Ljava_lang_String_;
		}

		static void n_SetEntryMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entryMode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entryMode = JNIEnv.GetString (native_entryMode, JniHandleOwnership.DoNotTransfer);
			__this.SetEntryMode (entryMode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEntryMode", "(Ljava/lang/String;)V", "GetSetEntryMode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEntryMode (string entryMode)
		{
			const string __id = "setEntryMode.(Ljava/lang/String;)V";
			IntPtr native_entryMode = JNIEnv.NewString (entryMode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entryMode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entryMode);
			}
		}

		static Delegate cb_setExpiryDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpiryDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpiryDate_Ljava_lang_String_ == null)
				cb_setExpiryDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExpiryDate_Ljava_lang_String_);
			return cb_setExpiryDate_Ljava_lang_String_;
		}

		static void n_SetExpiryDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expiryDate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var expiryDate = JNIEnv.GetString (native_expiryDate, JniHandleOwnership.DoNotTransfer);
			__this.SetExpiryDate (expiryDate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setExpiryDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExpiryDate", "(Ljava/lang/String;)V", "GetSetExpiryDate_Ljava_lang_String_Handler")]
		public virtual unsafe void SetExpiryDate (string expiryDate)
		{
			const string __id = "setExpiryDate.(Ljava/lang/String;)V";
			IntPtr native_expiryDate = JNIEnv.NewString (expiryDate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_expiryDate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_expiryDate);
			}
		}

		static Delegate cb_setKSN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKSN_Ljava_lang_String_Handler ()
		{
			if (cb_setKSN_Ljava_lang_String_ == null)
				cb_setKSN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetKSN_Ljava_lang_String_);
			return cb_setKSN_Ljava_lang_String_;
		}

		static void n_SetKSN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_kSN)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var kSN = JNIEnv.GetString (native_kSN, JniHandleOwnership.DoNotTransfer);
			__this.SetKSN (kSN);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setKSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKSN", "(Ljava/lang/String;)V", "GetSetKSN_Ljava_lang_String_Handler")]
		public virtual unsafe void SetKSN (string kSN)
		{
			const string __id = "setKSN.(Ljava/lang/String;)V";
			IntPtr native_kSN = JNIEnv.NewString (kSN);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_kSN);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_kSN);
			}
		}

		static Delegate cb_setMaskedTrack2Data_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaskedTrack2Data_Ljava_lang_String_Handler ()
		{
			if (cb_setMaskedTrack2Data_Ljava_lang_String_ == null)
				cb_setMaskedTrack2Data_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMaskedTrack2Data_Ljava_lang_String_);
			return cb_setMaskedTrack2Data_Ljava_lang_String_;
		}

		static void n_SetMaskedTrack2Data_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maskedTrack2Data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var maskedTrack2Data = JNIEnv.GetString (native_maskedTrack2Data, JniHandleOwnership.DoNotTransfer);
			__this.SetMaskedTrack2Data (maskedTrack2Data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setMaskedTrack2Data' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMaskedTrack2Data", "(Ljava/lang/String;)V", "GetSetMaskedTrack2Data_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMaskedTrack2Data (string maskedTrack2Data)
		{
			const string __id = "setMaskedTrack2Data.(Ljava/lang/String;)V";
			IntPtr native_maskedTrack2Data = JNIEnv.NewString (maskedTrack2Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_maskedTrack2Data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_maskedTrack2Data);
			}
		}

		static Delegate cb_setReturnReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReturnReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReturnReason_Ljava_lang_String_ == null)
				cb_setReturnReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReturnReason_Ljava_lang_String_);
			return cb_setReturnReason_Ljava_lang_String_;
		}

		static void n_SetReturnReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_returnReason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var returnReason = JNIEnv.GetString (native_returnReason, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnReason (returnReason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setReturnReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReturnReason", "(Ljava/lang/String;)V", "GetSetReturnReason_Ljava_lang_String_Handler")]
		public virtual unsafe void SetReturnReason (string returnReason)
		{
			const string __id = "setReturnReason.(Ljava/lang/String;)V";
			IntPtr native_returnReason = JNIEnv.NewString (returnReason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_returnReason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_returnReason);
			}
		}

		static Delegate cb_setReturnStatus_I;
#pragma warning disable 0169
		static Delegate GetSetReturnStatus_IHandler ()
		{
			if (cb_setReturnStatus_I == null)
				cb_setReturnStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetReturnStatus_I);
			return cb_setReturnStatus_I;
		}

		static void n_SetReturnStatus_I (IntPtr jnienv, IntPtr native__this, int returnStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnStatus (returnStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='TransactionApiData']/method[@name='setReturnStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReturnStatus", "(I)V", "GetSetReturnStatus_IHandler")]
		public virtual unsafe void SetReturnStatus (int returnStatus)
		{
			const string __id = "setReturnStatus.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (returnStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
