using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothDeviceChecking", DoNotGenerateAcw=true)]
	public partial class BluetoothDeviceChecking : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothDeviceChecking.DevicesListener']"
		[Register ("com/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener", "", "Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking/IDevicesListenerInvoker")]
		public partial interface IDevicesListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/interface[@name='BluetoothDeviceChecking.DevicesListener']/method[@name='onDevicesFound' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;android.bluetooth.BluetoothDevice&gt;'] and parameter[2][@type='java.util.ArrayList&lt;android.bluetooth.BluetoothDevice&gt;']]"
			[Register ("onDevicesFound", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V", "GetOnDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler:Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking/IDevicesListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnDevicesFound (global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p0, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p1);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener", DoNotGenerateAcw=true)]
		internal partial class IDevicesListenerInvoker : global::Java.Lang.Object, IDevicesListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener", typeof (IDevicesListenerInvoker));

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

			public static IDevicesListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDevicesListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.bluetooth.BluetoothDeviceChecking.DevicesListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDevicesListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetOnDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
			{
				if (cb_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
					cb_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_);
				return cb_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			}

			static void n_OnDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.IDevicesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDevicesFound (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_;
			public unsafe void OnDevicesFound (global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p0, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p1)
			{
				if (id_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onDevicesFound", "(Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDevicesFound_Ljava_util_ArrayList_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		// event args for com.onepay.miura.bluetooth.BluetoothDeviceChecking.DevicesListener.onDevicesFound
		public partial class DevicesEventArgs : global::System.EventArgs {

			public DevicesEventArgs (global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p0, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p0;
			public global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> P0 {
				get { return p0; }
			}

			global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p1;
			public global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/bluetooth/BluetoothDeviceChecking_DevicesListenerImplementor")]
		internal sealed partial class IDevicesListenerImplementor : global::Java.Lang.Object, IDevicesListener {

			object sender;

			public IDevicesListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/bluetooth/BluetoothDeviceChecking_DevicesListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DevicesEventArgs> Handler;
#pragma warning restore 0649

			public void OnDevicesFound (global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p0, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DevicesEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDevicesListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']"
		[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']/field[@name='checkAll']"
			[Register ("checkAll")]
			public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode CheckAll {
				get {
					const string __id = "checkAll.Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']/field[@name='checkOnlySelected']"
			[Register ("checkOnlySelected")]
			public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode CheckOnlySelected {
				get {
					const string __id = "checkOnlySelected.Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']/field[@name='noChecking']"
			[Register ("noChecking")]
			public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode NoChecking {
				get {
					const string __id = "noChecking.Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode", typeof (Mode));
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

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;", "")]
			public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;", "")]
			public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode[] Values ()
			{
				const string __id = "values.()[Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothDeviceChecking", typeof (BluetoothDeviceChecking));
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

		protected BluetoothDeviceChecking (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking']/constructor[@name='BluetoothDeviceChecking' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothDeviceChecking.Mode'] and parameter[3][@type='com.onepay.miura.bluetooth.BluetoothDeviceChecking.DevicesListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener;)V", "")]
		public unsafe BluetoothDeviceChecking (global::Android.Content.Context context, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode mode, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.IDevicesListener devicesListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue ((devicesListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) devicesListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (devicesListener);
			}
		}

		static Delegate cb_findDevices;
#pragma warning disable 0169
		static Delegate GetFindDevicesHandler ()
		{
			if (cb_findDevices == null)
				cb_findDevices = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FindDevices);
			return cb_findDevices;
		}

		static void n_FindDevices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindDevices ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceChecking']/method[@name='findDevices' and count(parameter)=0]"
		[Register ("findDevices", "()V", "GetFindDevicesHandler")]
		public virtual unsafe void FindDevices ()
		{
			const string __id = "findDevices.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
