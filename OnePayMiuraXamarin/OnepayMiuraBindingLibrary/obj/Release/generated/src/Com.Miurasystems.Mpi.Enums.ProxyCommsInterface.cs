using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ProxyCommsInterface", DoNotGenerateAcw=true)]
	public sealed partial class ProxyCommsInterface : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/field[@name='Bluetooth']"
		[Register ("Bluetooth")]
		public static global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface Bluetooth {
			get {
				const string __id = "Bluetooth.Lcom/miurasystems/mpi/enums/ProxyCommsInterface;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/field[@name='UsbSerial']"
		[Register ("UsbSerial")]
		public static global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface UsbSerial {
			get {
				const string __id = "UsbSerial.Lcom/miurasystems/mpi/enums/ProxyCommsInterface;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/field[@name='Wifi']"
		[Register ("Wifi")]
		public static global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface Wifi {
			get {
				const string __id = "Wifi.Lcom/miurasystems/mpi/enums/ProxyCommsInterface;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ProxyCommsInterface", typeof (ProxyCommsInterface));
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

		internal ProxyCommsInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/method[@name='fromBitMask' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromBitMask", "(I)Ljava/util/EnumSet;", "")]
		public static unsafe global::Java.Util.EnumSet FromBitMask (int bitMask)
		{
			const string __id = "fromBitMask.(I)Ljava/util/EnumSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitMask);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/method[@name='toBitMask' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.ProxyCommsInterface&gt;']]"
		[Register ("toBitMask", "(Ljava/util/EnumSet;)I", "")]
		public static unsafe int ToBitMask (global::Java.Util.EnumSet enums)
		{
			const string __id = "toBitMask.(Ljava/util/EnumSet;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((enums == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enums).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (enums);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ProxyCommsInterface;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ProxyCommsInterface;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ProxyCommsInterface']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/ProxyCommsInterface;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/ProxyCommsInterface;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ProxyCommsInterface));
			} finally {
			}
		}

	}
}
