using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/EmvTransactionAsync", DoNotGenerateAcw=true)]
	public partial class EmvTransactionAsync : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='EmvTransactionAsync.Callback']"
		[Register ("com/onepay/miura/transactions/EmvTransactionAsync$Callback", "", "Com.Onepay.Miura.Transactions.EmvTransactionAsync/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='EmvTransactionAsync.Callback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.transactions.emv.EmvTransactionException']]"
			[Register ("onError", "(Lcom/miurasystems/transactions/emv/EmvTransactionException;)V", "GetOnError_Lcom_miurasystems_transactions_emv_EmvTransactionException_Handler:Com.Onepay.Miura.Transactions.EmvTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnError (global::Com.Miurasystems.Transactions.Emv.EmvTransactionException p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='EmvTransactionAsync.Callback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.miurasystems.transactions.emv.EmvTransactionSummary']]"
[Obsolete (@"deprecated")]
			[Register ("onSuccess", "(Lcom/miurasystems/transactions/emv/EmvTransactionSummary;)V", "GetOnSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_Handler:Com.Onepay.Miura.Transactions.EmvTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnSuccess (global::Com.Miurasystems.Transactions.Emv.EmvTransactionSummary p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='EmvTransaction.YieldCallback']/method[@name='publishStartTransactionResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
			[Register ("publishStartTransactionResult", "(Ljava/lang/String;)V", "GetPublishStartTransactionResult_Ljava_lang_String_Handler:Com.Onepay.Miura.Transactions.EmvTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void PublishStartTransactionResult (string p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/transactions/EmvTransactionAsync$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/EmvTransactionAsync$Callback", typeof (ICallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.transactions.EmvTransactionAsync.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_miurasystems_transactions_emv_EmvTransactionException_Handler ()
			{
				if (cb_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_ == null)
					cb_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_transactions_emv_EmvTransactionException_);
				return cb_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_;
			}

			static void n_OnError_Lcom_miurasystems_transactions_emv_EmvTransactionException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_;
			public unsafe void OnError (global::Com.Miurasystems.Transactions.Emv.EmvTransactionException p0)
			{
				if (id_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_ == IntPtr.Zero)
					id_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/transactions/emv/EmvTransactionException;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_transactions_emv_EmvTransactionException_, __args);
			}

			static Delegate cb_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetOnSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_Handler ()
			{
				if (cb_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_ == null)
					cb_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_);
				return cb_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_;
			}

			[Obsolete]
			static void n_OnSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_;
			public unsafe void OnSuccess (global::Com.Miurasystems.Transactions.Emv.EmvTransactionSummary p0)
			{
				if (id_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_ == IntPtr.Zero)
					id_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/miurasystems/transactions/emv/EmvTransactionSummary;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_miurasystems_transactions_emv_EmvTransactionSummary_, __args);
			}

			static Delegate cb_publishStartTransactionResult_Ljava_lang_String_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetPublishStartTransactionResult_Ljava_lang_String_Handler ()
			{
				if (cb_publishStartTransactionResult_Ljava_lang_String_ == null)
					cb_publishStartTransactionResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PublishStartTransactionResult_Ljava_lang_String_);
				return cb_publishStartTransactionResult_Ljava_lang_String_;
			}

			[Obsolete]
			static void n_PublishStartTransactionResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PublishStartTransactionResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_publishStartTransactionResult_Ljava_lang_String_;
			public unsafe void PublishStartTransactionResult (string p0)
			{
				if (id_publishStartTransactionResult_Ljava_lang_String_ == IntPtr.Zero)
					id_publishStartTransactionResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "publishStartTransactionResult", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishStartTransactionResult_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/EmvTransactionAsync", typeof (EmvTransactionAsync));
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

		protected EmvTransactionAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']/constructor[@name='EmvTransactionAsync' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.api.executor.MiuraManager'] and parameter[2][@type='com.miurasystems.transactions.emv.EmvTransactionType']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/api/executor/MiuraManager;Lcom/miurasystems/transactions/emv/EmvTransactionType;)V", "")]
		public unsafe EmvTransactionAsync (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager miuraManager, global::Com.Miurasystems.Transactions.Emv.EmvTransactionType emvTransactionType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/api/executor/MiuraManager;Lcom/miurasystems/transactions/emv/EmvTransactionType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((miuraManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) miuraManager).Handle);
				__args [1] = new JniArgumentValue ((emvTransactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emvTransactionType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (miuraManager);
				global::System.GC.KeepAlive (emvTransactionType);
			}
		}

		static Delegate cb_abortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetAbortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_abortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_abortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AbortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_abortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_AbortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultListener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_defaultListener, JniHandleOwnership.DoNotTransfer);
			__this.AbortTransactionAsync (defaultListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']/method[@name='abortTransactionAsync' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("abortTransactionAsync", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetAbortTransactionAsync_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void AbortTransactionAsync (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener defaultListener)
		{
			const string __id = "abortTransactionAsync.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (defaultListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']/method[@name='canProcessEmvChip' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
		[Register ("canProcessEmvChip", "(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus CanProcessEmvChip (global::Com.Miurasystems.Mpi.Tlv.CardData cardData)
		{
			const string __id = "canProcessEmvChip.(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cardData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cardData);
			}
		}

		static Delegate cb_continueTransactionAsync;
#pragma warning disable 0169
		static Delegate GetContinueTransactionAsyncHandler ()
		{
			if (cb_continueTransactionAsync == null)
				cb_continueTransactionAsync = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ContinueTransactionAsync);
			return cb_continueTransactionAsync;
		}

		static void n_ContinueTransactionAsync (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContinueTransactionAsync ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']/method[@name='continueTransactionAsync' and count(parameter)=0]"
		[Register ("continueTransactionAsync", "()V", "GetContinueTransactionAsyncHandler")]
		public virtual unsafe void ContinueTransactionAsync ()
		{
			const string __id = "continueTransactionAsync.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_;
#pragma warning disable 0169
		static Delegate GetStartTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_Handler ()
		{
			if (cb_startTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_ == null)
				cb_startTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_StartTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_);
			return cb_startTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_;
		}

		static void n_StartTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_ (IntPtr jnienv, IntPtr native__this, int amountInPennies, int currencyCode, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartTransactionAsync (amountInPennies, currencyCode, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransactionAsync']/method[@name='startTransactionAsync' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.onepay.miura.transactions.EmvTransactionAsync.Callback']]"
		[Register ("startTransactionAsync", "(IILcom/onepay/miura/transactions/EmvTransactionAsync$Callback;)V", "GetStartTransactionAsync_IILcom_onepay_miura_transactions_EmvTransactionAsync_Callback_Handler")]
		public virtual unsafe void StartTransactionAsync (int amountInPennies, int currencyCode, global::Com.Onepay.Miura.Transactions.EmvTransactionAsync.ICallback @callback)
		{
			const string __id = "startTransactionAsync.(IILcom/onepay/miura/transactions/EmvTransactionAsync$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (amountInPennies);
				__args [1] = new JniArgumentValue (currencyCode);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
