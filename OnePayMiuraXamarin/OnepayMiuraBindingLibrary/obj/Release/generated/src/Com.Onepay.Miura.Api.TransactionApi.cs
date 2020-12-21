using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/TransactionApi", DoNotGenerateAcw=true)]
	public partial class TransactionApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='TransactionApi.TransactionListener']"
		[Register ("com/onepay/miura/api/TransactionApi$TransactionListener", "", "Com.Onepay.Miura.Api.TransactionApi/ITransactionListenerInvoker")]
		public partial interface ITransactionListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='TransactionApi.TransactionListener']/method[@name='onTransactionComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.TransactionApiData']]"
			[Register ("onTransactionComplete", "(Lcom/onepay/miura/data/TransactionApiData;)V", "GetOnTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_Handler:Com.Onepay.Miura.Api.TransactionApi/ITransactionListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/TransactionApi$TransactionListener", DoNotGenerateAcw=true)]
		internal partial class ITransactionListenerInvoker : global::Java.Lang.Object, ITransactionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/TransactionApi$TransactionListener", typeof (ITransactionListenerInvoker));

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

			public static ITransactionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITransactionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.TransactionApi.TransactionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITransactionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
#pragma warning disable 0169
			static Delegate GetOnTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_Handler ()
			{
				if (cb_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ == null)
					cb_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_);
				return cb_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
			}

			static void n_OnTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi.ITransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTransactionComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
			public unsafe void OnTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				if (id_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ == IntPtr.Zero)
					id_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ = JNIEnv.GetMethodID (class_ref, "onTransactionComplete", "(Lcom/onepay/miura/data/TransactionApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.TransactionApi.TransactionListener.onTransactionComplete
		public partial class TransactionEventArgs : global::System.EventArgs {

			public TransactionEventArgs (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.TransactionApiData p0;
			public global::Com.Onepay.Miura.Data.TransactionApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/TransactionApi_TransactionListenerImplementor")]
		internal sealed partial class ITransactionListenerImplementor : global::Java.Lang.Object, ITransactionListener {

			object sender;

			public ITransactionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/TransactionApi_TransactionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TransactionEventArgs> Handler;
#pragma warning restore 0649

			public void OnTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TransactionEventArgs (p0));
			}

			internal static bool __IsEmpty (ITransactionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/TransactionApi", typeof (TransactionApi));
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

		protected TransactionApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/constructor[@name='TransactionApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TransactionApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.TransactionApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/TransactionApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/TransactionApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelTransaction;
#pragma warning disable 0169
		static Delegate GetCancelTransactionHandler ()
		{
			if (cb_cancelTransaction == null)
				cb_cancelTransaction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelTransaction);
			return cb_cancelTransaction;
		}

		static void n_CancelTransaction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelTransaction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/method[@name='cancelTransaction' and count(parameter)=0]"
		[Register ("cancelTransaction", "()V", "GetCancelTransactionHandler")]
		public virtual unsafe void CancelTransaction ()
		{
			const string __id = "cancelTransaction.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_handleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_;
#pragma warning disable 0169
		static Delegate GetHandleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_Handler ()
		{
			if (cb_handleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_ == null)
				cb_handleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_HandleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_);
			return cb_handleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_;
		}

		static void n_HandleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardData = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (native_cardData, JniHandleOwnership.DoNotTransfer);
			__this.HandleTransactionEvent (cardData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/method[@name='handleTransactionEvent' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
		[Register ("handleTransactionEvent", "(Lcom/miurasystems/mpi/tlv/CardData;)V", "GetHandleTransactionEvent_Lcom_miurasystems_mpi_tlv_CardData_Handler")]
		protected virtual unsafe void HandleTransactionEvent (global::Com.Miurasystems.Mpi.Tlv.CardData cardData)
		{
			const string __id = "handleTransactionEvent.(Lcom/miurasystems/mpi/tlv/CardData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cardData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cardData);
			}
		}

		static Delegate cb_performTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_;
#pragma warning disable 0169
		static Delegate GetPerformTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_Handler ()
		{
			if (cb_performTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_ == null)
				cb_performTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PerformTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_);
			return cb_performTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_;
		}

		static void n_PerformTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.TransactionApi.ITransactionListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi.ITransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.PerformTransaction (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/method[@name='performTransaction' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.TransactionApi.TransactionListener']]"
		[Register ("performTransaction", "(Lcom/onepay/miura/api/TransactionApi$TransactionListener;)V", "GetPerformTransaction_Lcom_onepay_miura_api_TransactionApi_TransactionListener_Handler")]
		public virtual unsafe void PerformTransaction (global::Com.Onepay.Miura.Api.TransactionApi.ITransactionListener listener)
		{
			const string __id = "performTransaction.(Lcom/onepay/miura/api/TransactionApi$TransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setTransactionParams_DLjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetTransactionParams_DLjava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_setTransactionParams_DLjava_lang_String_Ljava_lang_String_I == null)
				cb_setTransactionParams_DLjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDLLI_V) n_SetTransactionParams_DLjava_lang_String_Ljava_lang_String_I);
			return cb_setTransactionParams_DLjava_lang_String_Ljava_lang_String_I;
		}

		static void n_SetTransactionParams_DLjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, double amt, IntPtr native_desc, IntPtr native_btAddress, int tOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.TransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = JNIEnv.GetString (native_desc, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			__this.SetTransactionParams (amt, desc, btAddress, tOut);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='TransactionApi']/method[@name='setTransactionParams' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("setTransactionParams", "(DLjava/lang/String;Ljava/lang/String;I)V", "GetSetTransactionParams_DLjava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetTransactionParams (double amt, string desc, string btAddress, int tOut)
		{
			const string __id = "setTransactionParams.(DLjava/lang/String;Ljava/lang/String;I)V";
			IntPtr native_desc = JNIEnv.NewString (desc);
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (amt);
				__args [1] = new JniArgumentValue (native_desc);
				__args [2] = new JniArgumentValue (native_btAddress);
				__args [3] = new JniArgumentValue (tOut);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_desc);
				JNIEnv.DeleteLocalRef (native_btAddress);
			}
		}

	}
}
