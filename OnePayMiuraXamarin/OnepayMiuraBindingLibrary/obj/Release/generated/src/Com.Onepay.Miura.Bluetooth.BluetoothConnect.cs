using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothConnect']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothConnect", DoNotGenerateAcw=true)]
	public partial class BluetoothConnect : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnect.DeviceConnectListener']"
		[Register ("com/onepay/miura/bluetooth/BluetoothConnect$DeviceConnectListener", "", "Com.Onepay.Miura.Bluetooth.BluetoothConnect/IDeviceConnectListenerInvoker")]
		public partial interface IDeviceConnectListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnect.DeviceConnectListener']/method[@name='onConnectionError' and count(parameter)=0]"
			[Register ("onConnectionError", "()V", "GetOnConnectionErrorHandler:Com.Onepay.Miura.Bluetooth.BluetoothConnect/IDeviceConnectListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnConnectionError ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnect.DeviceConnectListener']/method[@name='onConnectionSuccess' and count(parameter)=0]"
			[Register ("onConnectionSuccess", "()V", "GetOnConnectionSuccessHandler:Com.Onepay.Miura.Bluetooth.BluetoothConnect/IDeviceConnectListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnConnectionSuccess ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnect.DeviceConnectListener']/method[@name='onDeviceDisconnected' and count(parameter)=0]"
			[Register ("onDeviceDisconnected", "()V", "GetOnDeviceDisconnectedHandler:Com.Onepay.Miura.Bluetooth.BluetoothConnect/IDeviceConnectListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnDeviceDisconnected ();

		}

		[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothConnect$DeviceConnectListener", DoNotGenerateAcw=true)]
		internal partial class IDeviceConnectListenerInvoker : global::Java.Lang.Object, IDeviceConnectListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothConnect$DeviceConnectListener", typeof (IDeviceConnectListenerInvoker));

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

			public static IDeviceConnectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDeviceConnectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.bluetooth.BluetoothConnect.DeviceConnectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeviceConnectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionError;
#pragma warning disable 0169
			static Delegate GetOnConnectionErrorHandler ()
			{
				if (cb_onConnectionError == null)
					cb_onConnectionError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnectionError);
				return cb_onConnectionError;
			}

			static void n_OnConnectionError (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionError ();
			}
#pragma warning restore 0169

			IntPtr id_onConnectionError;
			public unsafe void OnConnectionError ()
			{
				if (id_onConnectionError == IntPtr.Zero)
					id_onConnectionError = JNIEnv.GetMethodID (class_ref, "onConnectionError", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionError);
			}

			static Delegate cb_onConnectionSuccess;
#pragma warning disable 0169
			static Delegate GetOnConnectionSuccessHandler ()
			{
				if (cb_onConnectionSuccess == null)
					cb_onConnectionSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnectionSuccess);
				return cb_onConnectionSuccess;
			}

			static void n_OnConnectionSuccess (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onConnectionSuccess;
			public unsafe void OnConnectionSuccess ()
			{
				if (id_onConnectionSuccess == IntPtr.Zero)
					id_onConnectionSuccess = JNIEnv.GetMethodID (class_ref, "onConnectionSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuccess);
			}

			static Delegate cb_onDeviceDisconnected;
#pragma warning disable 0169
			static Delegate GetOnDeviceDisconnectedHandler ()
			{
				if (cb_onDeviceDisconnected == null)
					cb_onDeviceDisconnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDeviceDisconnected);
				return cb_onDeviceDisconnected;
			}

			static void n_OnDeviceDisconnected (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDeviceDisconnected ();
			}
#pragma warning restore 0169

			IntPtr id_onDeviceDisconnected;
			public unsafe void OnDeviceDisconnected ()
			{
				if (id_onDeviceDisconnected == IntPtr.Zero)
					id_onDeviceDisconnected = JNIEnv.GetMethodID (class_ref, "onDeviceDisconnected", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceDisconnected);
			}

		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/bluetooth/BluetoothConnect_DeviceConnectListenerImplementor")]
		internal sealed partial class IDeviceConnectListenerImplementor : global::Java.Lang.Object, IDeviceConnectListener {

			object sender;

			public IDeviceConnectListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/bluetooth/BluetoothConnect_DeviceConnectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnConnectionErrorHandler;
#pragma warning restore 0649

			public void OnConnectionError ()
			{
				var __h = OnConnectionErrorHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnConnectionSuccessHandler;
#pragma warning restore 0649

			public void OnConnectionSuccess ()
			{
				var __h = OnConnectionSuccessHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnDeviceDisconnectedHandler;
#pragma warning restore 0649

			public void OnDeviceDisconnected ()
			{
				var __h = OnDeviceDisconnectedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IDeviceConnectListenerImplementor value)
			{
				return value.OnConnectionErrorHandler == null && value.OnConnectionSuccessHandler == null && value.OnDeviceDisconnectedHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothConnect", typeof (BluetoothConnect));
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

		protected BluetoothConnect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothConnect']/constructor[@name='BluetoothConnect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothConnect ()
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

		public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothConnect Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothConnect']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/bluetooth/BluetoothConnect;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/bluetooth/BluetoothConnect;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_ == null)
				cb_connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_);
			return cb_connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_;
		}

		static void n_Connect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_btAddress, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Connect (btAddress, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothConnect']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothConnect.DeviceConnectListener']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/onepay/miura/bluetooth/BluetoothConnect$DeviceConnectListener;)V", "GetConnect_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnect_DeviceConnectListener_Handler")]
		public virtual unsafe void Connect (string btAddress, global::Com.Onepay.Miura.Bluetooth.BluetoothConnect.IDeviceConnectListener listener)
		{
			const string __id = "connect.(Ljava/lang/String;Lcom/onepay/miura/bluetooth/BluetoothConnect$DeviceConnectListener;)V";
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_btAddress);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_btAddress);
				global::System.GC.KeepAlive (listener);
			}
		}

	}
}
