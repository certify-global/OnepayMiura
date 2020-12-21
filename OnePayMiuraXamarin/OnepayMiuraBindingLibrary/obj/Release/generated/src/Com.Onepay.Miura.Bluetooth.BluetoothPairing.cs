using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothPairing", DoNotGenerateAcw=true)]
	public partial class BluetoothPairing : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothPairing", typeof (BluetoothPairing));
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

		protected BluetoothPairing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/constructor[@name='BluetoothPairing' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BluetoothPairing (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getNonPairedDevices;
#pragma warning disable 0169
		static Delegate GetGetNonPairedDevicesHandler ()
		{
			if (cb_getNonPairedDevices == null)
				cb_getNonPairedDevices = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNonPairedDevices);
			return cb_getNonPairedDevices;
		}

		static IntPtr n_GetNonPairedDevices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothPairing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (__this.NonPairedDevices);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> NonPairedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='getNonPairedDevices' and count(parameter)=0]"
			[Register ("getNonPairedDevices", "()Ljava/util/ArrayList;", "GetGetNonPairedDevicesHandler")]
			get {
				const string __id = "getNonPairedDevices.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPairedDevices;
#pragma warning disable 0169
		static Delegate GetGetPairedDevicesHandler ()
		{
			if (cb_getPairedDevices == null)
				cb_getPairedDevices = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPairedDevices);
			return cb_getPairedDevices;
		}

		static IntPtr n_GetPairedDevices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothPairing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (__this.PairedDevices);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> PairedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='getPairedDevices' and count(parameter)=0]"
			[Register ("getPairedDevices", "()Ljava/util/ArrayList;", "GetGetPairedDevicesHandler")]
			get {
				const string __id = "getPairedDevices.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='findByAddress' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;android.bluetooth.BluetoothDevice&gt;']]"
		[Register ("findByAddress", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/bluetooth/BluetoothDevice;", "")]
		public static unsafe global::Android.Bluetooth.BluetoothDevice FindByAddress (string address, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> bluetoothDevices)
		{
			const string __id = "findByAddress.(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/bluetooth/BluetoothDevice;";
			IntPtr native_address = JNIEnv.NewString (address);
			IntPtr native_bluetoothDevices = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (bluetoothDevices);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (native_bluetoothDevices);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
				JNIEnv.DeleteLocalRef (native_bluetoothDevices);
				global::System.GC.KeepAlive (bluetoothDevices);
			}
		}

		static Delegate cb_getDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_;
#pragma warning disable 0169
		static Delegate GetGetDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_Handler ()
		{
			if (cb_getDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ == null)
				cb_getDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_);
			return cb_getDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_;
		}

		static IntPtr n_GetDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothPairing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDefaultByType (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='getDefaultByType' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.bluetooth.BluetoothDeviceType']]"
		[Register ("getDefaultByType", "(Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Landroid/bluetooth/BluetoothDevice;", "GetGetDefaultByType_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothDevice GetDefaultByType (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType type)
		{
			const string __id = "getDefaultByType.(Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Landroid/bluetooth/BluetoothDevice;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='getDefaultDeviceAddress' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothDeviceType']]"
		[Register ("getDefaultDeviceAddress", "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Ljava/lang/String;", "")]
		public static unsafe string GetDefaultDeviceAddress (global::Android.Content.Context context, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType deviceType)
		{
			const string __id = "getDefaultDeviceAddress.(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (deviceType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothPairing']/method[@name='setDefaultDevice' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothDeviceType'] and parameter[3][@type='java.lang.String']]"
		[Register ("setDefaultDevice", "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;Ljava/lang/String;)V", "")]
		public static unsafe void SetDefaultDevice (global::Android.Content.Context context, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType deviceType, string address)
		{
			const string __id = "setDefaultDevice.(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;Ljava/lang/String;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				__args [2] = new JniArgumentValue (native_address);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (deviceType);
			}
		}

	}
}
