using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConnectApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/ConnectApi", DoNotGenerateAcw=true)]
	public partial class ConnectApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ConnectApi.ConnectListener']"
		[Register ("com/onepay/miura/api/ConnectApi$ConnectListener", "", "Com.Onepay.Miura.Api.ConnectApi/IConnectListenerInvoker")]
		public partial interface IConnectListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ConnectApi.ConnectListener']/method[@name='onConnectionComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.ConnectApiData']]"
			[Register ("onConnectionComplete", "(Lcom/onepay/miura/data/ConnectApiData;)V", "GetOnConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_Handler:Com.Onepay.Miura.Api.ConnectApi/IConnectListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnConnectionComplete (global::Com.Onepay.Miura.Data.ConnectApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/ConnectApi$ConnectListener", DoNotGenerateAcw=true)]
		internal partial class IConnectListenerInvoker : global::Java.Lang.Object, IConnectListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ConnectApi$ConnectListener", typeof (IConnectListenerInvoker));

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

			public static IConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.ConnectApi.ConnectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_;
#pragma warning disable 0169
			static Delegate GetOnConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_Handler ()
			{
				if (cb_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_ == null)
					cb_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_);
				return cb_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_;
			}

			static void n_OnConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.ConnectApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_;
			public unsafe void OnConnectionComplete (global::Com.Onepay.Miura.Data.ConnectApiData p0)
			{
				if (id_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_ == IntPtr.Zero)
					id_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_ = JNIEnv.GetMethodID (class_ref, "onConnectionComplete", "(Lcom/onepay/miura/data/ConnectApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionComplete_Lcom_onepay_miura_data_ConnectApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.ConnectApi.ConnectListener.onConnectionComplete
		public partial class ConnectEventArgs : global::System.EventArgs {

			public ConnectEventArgs (global::Com.Onepay.Miura.Data.ConnectApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.ConnectApiData p0;
			public global::Com.Onepay.Miura.Data.ConnectApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/ConnectApi_ConnectListenerImplementor")]
		internal sealed partial class IConnectListenerImplementor : global::Java.Lang.Object, IConnectListener {

			object sender;

			public IConnectListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/ConnectApi_ConnectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ConnectEventArgs> Handler;
#pragma warning restore 0649

			public void OnConnectionComplete (global::Com.Onepay.Miura.Data.ConnectApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ConnectEventArgs (p0));
			}

			internal static bool __IsEmpty (IConnectListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ConnectApi", typeof (ConnectApi));
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

		protected ConnectApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConnectApi']/constructor[@name='ConnectApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.ConnectApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConnectApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/ConnectApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/ConnectApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConnectApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_connect_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_IHandler ()
		{
			if (cb_connect_Ljava_lang_String_I == null)
				cb_connect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_Connect_Ljava_lang_String_I);
			return cb_connect_Ljava_lang_String_I;
		}

		static void n_Connect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_btAddress, int tOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConnectApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			__this.Connect (btAddress, tOut);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConnectApi']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("connect", "(Ljava/lang/String;I)V", "GetConnect_Ljava_lang_String_IHandler")]
		public virtual unsafe void Connect (string btAddress, int tOut)
		{
			const string __id = "connect.(Ljava/lang/String;I)V";
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_btAddress);
				__args [1] = new JniArgumentValue (tOut);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_btAddress);
			}
		}

		static Delegate cb_setConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_;
#pragma warning disable 0169
		static Delegate GetSetConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_Handler ()
		{
			if (cb_setConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_ == null)
				cb_setConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_);
			return cb_setConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_;
		}

		static void n_SetConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConnectApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConnectApi']/method[@name='setConnectListener' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.ConnectApi.ConnectListener']]"
		[Register ("setConnectListener", "(Lcom/onepay/miura/api/ConnectApi$ConnectListener;)V", "GetSetConnectListener_Lcom_onepay_miura_api_ConnectApi_ConnectListener_Handler")]
		public virtual unsafe void SetConnectListener (global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener listener)
		{
			const string __id = "setConnectListener.(Lcom/onepay/miura/api/ConnectApi$ConnectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

#region "Event implementation for Com.Onepay.Miura.Api.ConnectApi.IConnectListener"
		public event EventHandler<global::Com.Onepay.Miura.Api.ConnectApi.ConnectEventArgs> ConnectEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener, global::Com.Onepay.Miura.Api.ConnectApi.IConnectListenerImplementor>(
						ref weak_implementor_SetConnectListener,
						__CreateIConnectListenerImplementor,
						SetConnectListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Onepay.Miura.Api.ConnectApi.IConnectListener, global::Com.Onepay.Miura.Api.ConnectApi.IConnectListenerImplementor>(
						ref weak_implementor_SetConnectListener,
						global::Com.Onepay.Miura.Api.ConnectApi.IConnectListenerImplementor.__IsEmpty,
						__v => SetConnectListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConnectListener;

		global::Com.Onepay.Miura.Api.ConnectApi.IConnectListenerImplementor __CreateIConnectListenerImplementor ()
		{
			return new global::Com.Onepay.Miura.Api.ConnectApi.IConnectListenerImplementor (this);
		}
#endregion
	}
}
