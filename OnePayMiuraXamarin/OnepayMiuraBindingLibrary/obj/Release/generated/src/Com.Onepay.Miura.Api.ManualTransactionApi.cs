using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/ManualTransactionApi", DoNotGenerateAcw=true)]
	public partial class ManualTransactionApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ManualTransactionApi.ManualTransactionListener']"
		[Register ("com/onepay/miura/api/ManualTransactionApi$ManualTransactionListener", "", "Com.Onepay.Miura.Api.ManualTransactionApi/IManualTransactionListenerInvoker")]
		public partial interface IManualTransactionListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ManualTransactionApi.ManualTransactionListener']/method[@name='onManualTransactionComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.TransactionApiData']]"
			[Register ("onManualTransactionComplete", "(Lcom/onepay/miura/data/TransactionApiData;)V", "GetOnManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_Handler:Com.Onepay.Miura.Api.ManualTransactionApi/IManualTransactionListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnManualTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/ManualTransactionApi$ManualTransactionListener", DoNotGenerateAcw=true)]
		internal partial class IManualTransactionListenerInvoker : global::Java.Lang.Object, IManualTransactionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ManualTransactionApi$ManualTransactionListener", typeof (IManualTransactionListenerInvoker));

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

			public static IManualTransactionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IManualTransactionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.ManualTransactionApi.ManualTransactionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IManualTransactionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
#pragma warning disable 0169
			static Delegate GetOnManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_Handler ()
			{
				if (cb_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ == null)
					cb_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_);
				return cb_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
			}

			static void n_OnManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi.IManualTransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.TransactionApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnManualTransactionComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_;
			public unsafe void OnManualTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				if (id_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ == IntPtr.Zero)
					id_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_ = JNIEnv.GetMethodID (class_ref, "onManualTransactionComplete", "(Lcom/onepay/miura/data/TransactionApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onManualTransactionComplete_Lcom_onepay_miura_data_TransactionApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.ManualTransactionApi.ManualTransactionListener.onManualTransactionComplete
		public partial class ManualTransactionEventArgs : global::System.EventArgs {

			public ManualTransactionEventArgs (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.TransactionApiData p0;
			public global::Com.Onepay.Miura.Data.TransactionApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/ManualTransactionApi_ManualTransactionListenerImplementor")]
		internal sealed partial class IManualTransactionListenerImplementor : global::Java.Lang.Object, IManualTransactionListener {

			object sender;

			public IManualTransactionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/ManualTransactionApi_ManualTransactionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ManualTransactionEventArgs> Handler;
#pragma warning restore 0649

			public void OnManualTransactionComplete (global::Com.Onepay.Miura.Data.TransactionApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ManualTransactionEventArgs (p0));
			}

			internal static bool __IsEmpty (IManualTransactionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ManualTransactionApi", typeof (ManualTransactionApi));
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

		protected ManualTransactionApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/constructor[@name='ManualTransactionApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ManualTransactionApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.ManualTransactionApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/ManualTransactionApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/ManualTransactionApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelTransaction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/method[@name='cancelTransaction' and count(parameter)=0]"
		[Register ("cancelTransaction", "()V", "GetCancelTransactionHandler")]
		public virtual unsafe void CancelTransaction ()
		{
			const string __id = "cancelTransaction.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_handleTransactionEvent;
#pragma warning disable 0169
		static Delegate GetHandleTransactionEventHandler ()
		{
			if (cb_handleTransactionEvent == null)
				cb_handleTransactionEvent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_HandleTransactionEvent);
			return cb_handleTransactionEvent;
		}

		static void n_HandleTransactionEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleTransactionEvent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/method[@name='handleTransactionEvent' and count(parameter)=0]"
		[Register ("handleTransactionEvent", "()V", "GetHandleTransactionEventHandler")]
		protected virtual unsafe void HandleTransactionEvent ()
		{
			const string __id = "handleTransactionEvent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_performManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_;
#pragma warning disable 0169
		static Delegate GetPerformManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_Handler ()
		{
			if (cb_performManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_ == null)
				cb_performManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PerformManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_);
			return cb_performManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_;
		}

		static void n_PerformManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.ManualTransactionApi.IManualTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi.IManualTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.PerformManualTransaction (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/method[@name='performManualTransaction' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.ManualTransactionApi.ManualTransactionListener']]"
		[Register ("performManualTransaction", "(Lcom/onepay/miura/api/ManualTransactionApi$ManualTransactionListener;)V", "GetPerformManualTransaction_Lcom_onepay_miura_api_ManualTransactionApi_ManualTransactionListener_Handler")]
		public virtual unsafe void PerformManualTransaction (global::Com.Onepay.Miura.Api.ManualTransactionApi.IManualTransactionListener listener)
		{
			const string __id = "performManualTransaction.(Lcom/onepay/miura/api/ManualTransactionApi$ManualTransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetSetManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZHandler ()
		{
			if (cb_setManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ == null)
				cb_setManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDLLIZ_V) n_SetManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ);
			return cb_setManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ;
		}

		static void n_SetManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, double amt, IntPtr native_desc, IntPtr native_btAddress, int tOut, bool isCvvRequired)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ManualTransactionApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var desc = JNIEnv.GetString (native_desc, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			__this.SetManualTransactionParams (amt, desc, btAddress, tOut, isCvvRequired);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ManualTransactionApi']/method[@name='setManualTransactionParams' and count(parameter)=5 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("setManualTransactionParams", "(DLjava/lang/String;Ljava/lang/String;IZ)V", "GetSetManualTransactionParams_DLjava_lang_String_Ljava_lang_String_IZHandler")]
		public virtual unsafe void SetManualTransactionParams (double amt, string desc, string btAddress, int tOut, bool isCvvRequired)
		{
			const string __id = "setManualTransactionParams.(DLjava/lang/String;Ljava/lang/String;IZ)V";
			IntPtr native_desc = JNIEnv.NewString (desc);
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (amt);
				__args [1] = new JniArgumentValue (native_desc);
				__args [2] = new JniArgumentValue (native_btAddress);
				__args [3] = new JniArgumentValue (tOut);
				__args [4] = new JniArgumentValue (isCvvRequired);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_desc);
				JNIEnv.DeleteLocalRef (native_btAddress);
			}
		}

	}
}
