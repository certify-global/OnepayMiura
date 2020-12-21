using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/USBStatus", DoNotGenerateAcw=true)]
	public sealed partial class USBStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/field[@name='Connected']"
		[Register ("Connected")]
		public static global::Com.Miurasystems.Mpi.Enums.USBStatus Connected {
			get {
				const string __id = "Connected.Lcom/miurasystems/mpi/enums/USBStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/field[@name='NotConnected']"
		[Register ("NotConnected")]
		public static global::Com.Miurasystems.Mpi.Enums.USBStatus NotConnected {
			get {
				const string __id = "NotConnected.Lcom/miurasystems/mpi/enums/USBStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/USBStatus", typeof (USBStatus));
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

		internal USBStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("valueOf", "(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/enums/USBStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.USBStatus ValueOf (global::Com.Miurasystems.Mpi.Tlv.TLVObject tlvMSDStatus)
		{
			const string __id = "valueOf.(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/enums/USBStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tlvMSDStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlvMSDStatus).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tlvMSDStatus);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/miurasystems/mpi/enums/USBStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.USBStatus ValueOf (int value)
		{
			const string __id = "valueOf.(I)Lcom/miurasystems/mpi/enums/USBStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/USBStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.USBStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/USBStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='USBStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/USBStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.USBStatus[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/USBStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.USBStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.USBStatus));
			} finally {
			}
		}

	}
}
