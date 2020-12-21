using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransactionAsync']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/MagSwipeTransactionAsync", DoNotGenerateAcw=true)]
	public partial class MagSwipeTransactionAsync : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='MagSwipeTransactionAsync.Callback']"
		[Register ("com/onepay/miura/transactions/MagSwipeTransactionAsync$Callback", "", "Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			global::Com.Onepay.Miura.Transactions.SignatureSummary SignatureFromUser {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='MagSwipeTransactionAsync.Callback']/method[@name='getSignatureFromUser' and count(parameter)=0]"
				[Register ("getSignatureFromUser", "()Lcom/onepay/miura/transactions/SignatureSummary;", "GetGetSignatureFromUserHandler:Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='MagSwipeTransactionAsync.Callback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeTransactionException']]"
			[Register ("onError", "(Lcom/miurasystems/transactions/magswipe/MagSwipeTransactionException;)V", "GetOnError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_Handler:Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnError (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeTransactionException p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='MagSwipeTransactionAsync.Callback']/method[@name='onPinSuccess' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='com.miurasystems.transactions.magswipe.OnlinePinSummary']]"
			[Register ("onPinSuccess", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;)V", "GetOnPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_Handler:Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnPinSuccess (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary p0, global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/interface[@name='MagSwipeTransactionAsync.Callback']/method[@name='onSignatureSuccess' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='com.onepay.miura.transactions.SignatureSummary']]"
			[Register ("onSignatureSuccess", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/onepay/miura/transactions/SignatureSummary;)V", "GetOnSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_Handler:Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync/ICallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnSignatureSuccess (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary p0, global::Com.Onepay.Miura.Transactions.SignatureSummary p1);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/transactions/MagSwipeTransactionAsync$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/MagSwipeTransactionAsync$Callback", typeof (ICallbackInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.transactions.MagSwipeTransactionAsync.Callback"));
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

			static Delegate cb_getSignatureFromUser;
#pragma warning disable 0169
			static Delegate GetGetSignatureFromUserHandler ()
			{
				if (cb_getSignatureFromUser == null)
					cb_getSignatureFromUser = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignatureFromUser);
				return cb_getSignatureFromUser;
			}

			static IntPtr n_GetSignatureFromUser (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SignatureFromUser);
			}
#pragma warning restore 0169

			IntPtr id_getSignatureFromUser;
			public unsafe global::Com.Onepay.Miura.Transactions.SignatureSummary SignatureFromUser {
				get {
					if (id_getSignatureFromUser == IntPtr.Zero)
						id_getSignatureFromUser = JNIEnv.GetMethodID (class_ref, "getSignatureFromUser", "()Lcom/onepay/miura/transactions/SignatureSummary;");
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.SignatureSummary> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignatureFromUser), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_Handler ()
			{
				if (cb_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_ == null)
					cb_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_);
				return cb_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_;
			}

			static void n_OnError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeTransactionException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_;
			public unsafe void OnError (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeTransactionException p0)
			{
				if (id_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_ == IntPtr.Zero)
					id_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/transactions/magswipe/MagSwipeTransactionException;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_transactions_magswipe_MagSwipeTransactionException_, __args);
			}

			static Delegate cb_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_;
#pragma warning disable 0169
			static Delegate GetOnPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_Handler ()
			{
				if (cb_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_ == null)
					cb_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_);
				return cb_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_;
			}

			static void n_OnPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPinSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_;
			public unsafe void OnPinSuccess (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary p0, global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary p1)
			{
				if (id_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_ == IntPtr.Zero)
					id_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_ = JNIEnv.GetMethodID (class_ref, "onPinSuccess", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPinSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_miurasystems_transactions_magswipe_OnlinePinSummary_, __args);
			}

			static Delegate cb_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_;
#pragma warning disable 0169
			static Delegate GetOnSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_Handler ()
			{
				if (cb_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ == null)
					cb_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_);
				return cb_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_;
			}

			static void n_OnSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.SignatureSummary> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSignatureSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_;
			public unsafe void OnSignatureSuccess (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary p0, global::Com.Onepay.Miura.Transactions.SignatureSummary p1)
			{
				if (id_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ == IntPtr.Zero)
					id_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ = JNIEnv.GetMethodID (class_ref, "onSignatureSuccess", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/onepay/miura/transactions/SignatureSummary;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignatureSuccess_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/MagSwipeTransactionAsync", typeof (MagSwipeTransactionAsync));
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

		protected MagSwipeTransactionAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransactionAsync']/constructor[@name='MagSwipeTransactionAsync' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.api.executor.MiuraManager'] and parameter[2][@type='com.miurasystems.transactions.magswipe.PaymentMagType']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/api/executor/MiuraManager;Lcom/miurasystems/transactions/magswipe/PaymentMagType;)V", "")]
		public unsafe MagSwipeTransactionAsync (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager miuraManager, global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType magType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/api/executor/MiuraManager;Lcom/miurasystems/transactions/magswipe/PaymentMagType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((miuraManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) miuraManager).Handle);
				__args [1] = new JniArgumentValue ((magType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (miuraManager);
				global::System.GC.KeepAlive (magType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultListener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_defaultListener, JniHandleOwnership.DoNotTransfer);
			__this.AbortTransactionAsync (defaultListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransactionAsync']/method[@name='abortTransactionAsync' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransactionAsync']/method[@name='canProcessMagSwipe' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
		[Register ("canProcessMagSwipe", "(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/mpi/Result;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Result CanProcessMagSwipe (global::Com.Miurasystems.Mpi.Tlv.CardData cardData)
		{
			const string __id = "canProcessMagSwipe.(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cardData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cardData);
			}
		}

		static Delegate cb_startTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_;
#pragma warning disable 0169
		static Delegate GetStartTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_Handler ()
		{
			if (cb_startTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_ == null)
				cb_startTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_StartTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_);
			return cb_startTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_;
		}

		static void n_StartTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_magSwipeSummary, int amountInPennies, int currencyCode, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var magSwipeSummary = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (native_magSwipeSummary, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartTransactionAsync (magSwipeSummary, amountInPennies, currencyCode, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransactionAsync']/method[@name='startTransactionAsync' and count(parameter)=4 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.onepay.miura.transactions.MagSwipeTransactionAsync.Callback']]"
		[Register ("startTransactionAsync", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;IILcom/onepay/miura/transactions/MagSwipeTransactionAsync$Callback;)V", "GetStartTransactionAsync_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IILcom_onepay_miura_transactions_MagSwipeTransactionAsync_Callback_Handler")]
		public virtual unsafe void StartTransactionAsync (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, int amountInPennies, int currencyCode, global::Com.Onepay.Miura.Transactions.MagSwipeTransactionAsync.ICallback @callback)
		{
			const string __id = "startTransactionAsync.(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;IILcom/onepay/miura/transactions/MagSwipeTransactionAsync$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (magSwipeSummary);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
