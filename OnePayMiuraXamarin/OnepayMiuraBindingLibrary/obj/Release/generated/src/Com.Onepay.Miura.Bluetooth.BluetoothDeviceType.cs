using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothDeviceType", DoNotGenerateAcw=true)]
	public sealed partial class BluetoothDeviceType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/field[@name='ITP']"
		[Register ("ITP")]
		public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType Itp {
			get {
				const string __id = "ITP.Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/field[@name='PED']"
		[Register ("PED")]
		public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType Ped {
			get {
				const string __id = "PED.Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/field[@name='POS']"
		[Register ("POS")]
		public static global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType Pos {
			get {
				const string __id = "POS.Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothDeviceType", typeof (BluetoothDeviceType));
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

		internal BluetoothDeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string DeviceTypeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/method[@name='getDeviceTypeName' and count(parameter)=0]"
			[Register ("getDeviceTypeName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceTypeName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/method[@name='getByDeviceTypeByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getByDeviceTypeByName", "(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceType;", "")]
		public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType GetByDeviceTypeByName (string deviceName)
		{
			const string __id = "getByDeviceTypeByName.(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceType;", "")]
		public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothDeviceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/onepay/miura/bluetooth/BluetoothDeviceType;", "")]
		public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType[] Values ()
		{
			const string __id = "values.()[Lcom/onepay/miura/bluetooth/BluetoothDeviceType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType));
			} finally {
			}
		}

	}
}
