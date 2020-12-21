using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/SerialPortStopBits", DoNotGenerateAcw=true)]
	public sealed partial class SerialPortStopBits : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']/field[@name='SERIAL_PORT_STOP_BITS_1']"
		[Register ("SERIAL_PORT_STOP_BITS_1")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits SerialPortStopBits1 {
			get {
				const string __id = "SERIAL_PORT_STOP_BITS_1.Lcom/miurasystems/mpi/enums/SerialPortStopBits;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']/field[@name='SERIAL_PORT_STOP_BITS_2']"
		[Register ("SERIAL_PORT_STOP_BITS_2")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits SerialPortStopBits2 {
			get {
				const string __id = "SERIAL_PORT_STOP_BITS_2.Lcom/miurasystems/mpi/enums/SerialPortStopBits;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/SerialPortStopBits", typeof (SerialPortStopBits));
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

		internal SerialPortStopBits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe sbyte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()B", "")]
			get {
				const string __id = "getValue.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SerialPortStopBits;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SerialPortStopBits;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialPortStopBits']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/SerialPortStopBits;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/SerialPortStopBits;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits));
			} finally {
			}
		}

	}
}
