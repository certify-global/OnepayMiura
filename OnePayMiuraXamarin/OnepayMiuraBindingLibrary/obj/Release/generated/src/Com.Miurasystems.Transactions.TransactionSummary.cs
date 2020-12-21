using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/TransactionSummary", DoNotGenerateAcw=true)]
	public partial class TransactionSummary : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/TransactionSummary", typeof (TransactionSummary));
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

		protected TransactionSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/constructor[@name='TransactionSummary' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Currency'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/TransactionType;Ljava/lang/String;IILjava/util/Currency;Ljava/lang/String;)V", "")]
		public unsafe TransactionSummary (global::Com.Miurasystems.Mpi.Enums.TransactionType type, string transactionId, int preTipAmountExpN, int tipAmountExpN, global::Java.Util.Currency currency, string deviceSerial)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/TransactionType;Ljava/lang/String;IILjava/util/Currency;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_transactionId = JNIEnv.NewString (transactionId);
			IntPtr native_deviceSerial = JNIEnv.NewString (deviceSerial);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_transactionId);
				__args [2] = new JniArgumentValue (preTipAmountExpN);
				__args [3] = new JniArgumentValue (tipAmountExpN);
				__args [4] = new JniArgumentValue ((currency == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currency).Handle);
				__args [5] = new JniArgumentValue (native_deviceSerial);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_transactionId);
				JNIEnv.DeleteLocalRef (native_deviceSerial);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (currency);
			}
		}

		static Delegate cb_getChargeableAmountExpN;
#pragma warning disable 0169
		static Delegate GetGetChargeableAmountExpNHandler ()
		{
			if (cb_getChargeableAmountExpN == null)
				cb_getChargeableAmountExpN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetChargeableAmountExpN);
			return cb_getChargeableAmountExpN;
		}

		static int n_GetChargeableAmountExpN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChargeableAmountExpN;
		}
#pragma warning restore 0169

		public virtual unsafe int ChargeableAmountExpN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getChargeableAmountExpN' and count(parameter)=0]"
			[Register ("getChargeableAmountExpN", "()I", "GetGetChargeableAmountExpNHandler")]
			get {
				const string __id = "getChargeableAmountExpN.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrency;
#pragma warning disable 0169
		static Delegate GetGetCurrencyHandler ()
		{
			if (cb_getCurrency == null)
				cb_getCurrency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCurrency);
			return cb_getCurrency;
		}

		static IntPtr n_GetCurrency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Currency);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Currency Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/util/Currency;", "GetGetCurrencyHandler")]
			get {
				const string __id = "getCurrency.()Ljava/util/Currency;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Currency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceSerial;
#pragma warning disable 0169
		static Delegate GetGetDeviceSerialHandler ()
		{
			if (cb_getDeviceSerial == null)
				cb_getDeviceSerial = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceSerial);
			return cb_getDeviceSerial;
		}

		static IntPtr n_GetDeviceSerial (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSerial);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceSerial {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getDeviceSerial' and count(parameter)=0]"
			[Register ("getDeviceSerial", "()Ljava/lang/String;", "GetGetDeviceSerialHandler")]
			get {
				const string __id = "getDeviceSerial.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPreTipAmountExpN;
#pragma warning disable 0169
		static Delegate GetGetPreTipAmountExpNHandler ()
		{
			if (cb_getPreTipAmountExpN == null)
				cb_getPreTipAmountExpN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPreTipAmountExpN);
			return cb_getPreTipAmountExpN;
		}

		static int n_GetPreTipAmountExpN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreTipAmountExpN;
		}
#pragma warning restore 0169

		public virtual unsafe int PreTipAmountExpN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getPreTipAmountExpN' and count(parameter)=0]"
			[Register ("getPreTipAmountExpN", "()I", "GetGetPreTipAmountExpNHandler")]
			get {
				const string __id = "getPreTipAmountExpN.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTipAmountExpN;
#pragma warning disable 0169
		static Delegate GetGetTipAmountExpNHandler ()
		{
			if (cb_getTipAmountExpN == null)
				cb_getTipAmountExpN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTipAmountExpN);
			return cb_getTipAmountExpN;
		}

		static int n_GetTipAmountExpN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TipAmountExpN;
		}
#pragma warning restore 0169

		public virtual unsafe int TipAmountExpN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getTipAmountExpN' and count(parameter)=0]"
			[Register ("getTipAmountExpN", "()I", "GetGetTipAmountExpNHandler")]
			get {
				const string __id = "getTipAmountExpN.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				const string __id = "getTransactionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionType;
#pragma warning disable 0169
		static Delegate GetGetTransactionTypeHandler ()
		{
			if (cb_getTransactionType == null)
				cb_getTransactionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransactionType);
			return cb_getTransactionType;
		}

		static IntPtr n_GetTransactionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.TransactionSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransactionType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.TransactionType TransactionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions']/class[@name='TransactionSummary']/method[@name='getTransactionType' and count(parameter)=0]"
			[Register ("getTransactionType", "()Lcom/miurasystems/mpi/enums/TransactionType;", "GetGetTransactionTypeHandler")]
			get {
				const string __id = "getTransactionType.()Lcom/miurasystems/mpi/enums/TransactionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
