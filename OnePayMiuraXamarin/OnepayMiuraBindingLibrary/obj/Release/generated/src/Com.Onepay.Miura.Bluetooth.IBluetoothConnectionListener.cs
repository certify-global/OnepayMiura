using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnectionListener']"
	[Register ("com/onepay/miura/bluetooth/BluetoothConnectionListener", "", "Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListenerInvoker")]
	public partial interface IBluetoothConnectionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnectionListener']/method[@name='onConnected' and count(parameter)=0]"
		[Register ("onConnected", "()V", "GetOnConnectedHandler:Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnConnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnectionListener']/method[@name='onConnectionAttemptFailed' and count(parameter)=0]"
		[Register ("onConnectionAttemptFailed", "()V", "GetOnConnectionAttemptFailedHandler:Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnConnectionAttemptFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothConnectionListener']/method[@name='onDisconnected' and count(parameter)=0]"
		[Register ("onDisconnected", "()V", "GetOnDisconnectedHandler:Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnDisconnected ();

	}

	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothConnectionListener", DoNotGenerateAcw=true)]
	internal partial class IBluetoothConnectionListenerInvoker : global::Java.Lang.Object, IBluetoothConnectionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothConnectionListener", typeof (IBluetoothConnectionListenerInvoker));

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

		public static IBluetoothConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBluetoothConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.bluetooth.BluetoothConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBluetoothConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnected;
#pragma warning disable 0169
		static Delegate GetOnConnectedHandler ()
		{
			if (cb_onConnected == null)
				cb_onConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnected);
			return cb_onConnected;
		}

		static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected ();
		}
#pragma warning restore 0169

		IntPtr id_onConnected;
		public unsafe void OnConnected ()
		{
			if (id_onConnected == IntPtr.Zero)
				id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
		}

		static Delegate cb_onConnectionAttemptFailed;
#pragma warning disable 0169
		static Delegate GetOnConnectionAttemptFailedHandler ()
		{
			if (cb_onConnectionAttemptFailed == null)
				cb_onConnectionAttemptFailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnectionAttemptFailed);
			return cb_onConnectionAttemptFailed;
		}

		static void n_OnConnectionAttemptFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionAttemptFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onConnectionAttemptFailed;
		public unsafe void OnConnectionAttemptFailed ()
		{
			if (id_onConnectionAttemptFailed == IntPtr.Zero)
				id_onConnectionAttemptFailed = JNIEnv.GetMethodID (class_ref, "onConnectionAttemptFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionAttemptFailed);
		}

		static Delegate cb_onDisconnected;
#pragma warning disable 0169
		static Delegate GetOnDisconnectedHandler ()
		{
			if (cb_onDisconnected == null)
				cb_onDisconnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDisconnected);
			return cb_onDisconnected;
		}

		static void n_OnDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected;
		public unsafe void OnDisconnected ()
		{
			if (id_onDisconnected == IntPtr.Zero)
				id_onDisconnected = JNIEnv.GetMethodID (class_ref, "onDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected);
		}

	}

	[global::Android.Runtime.Register ("mono/com/onepay/miura/bluetooth/BluetoothConnectionListenerImplementor")]
	internal sealed partial class IBluetoothConnectionListenerImplementor : global::Java.Lang.Object, IBluetoothConnectionListener {

		object sender;

		public IBluetoothConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/bluetooth/BluetoothConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected ()
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnConnectionAttemptFailedHandler;
#pragma warning restore 0649

		public void OnConnectionAttemptFailed ()
		{
			var __h = OnConnectionAttemptFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnDisconnectedHandler;
#pragma warning restore 0649

		public void OnDisconnected ()
		{
			var __h = OnDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IBluetoothConnectionListenerImplementor value)
		{
			return value.OnConnectedHandler == null && value.OnConnectionAttemptFailedHandler == null && value.OnDisconnectedHandler == null;
		}
	}

}
