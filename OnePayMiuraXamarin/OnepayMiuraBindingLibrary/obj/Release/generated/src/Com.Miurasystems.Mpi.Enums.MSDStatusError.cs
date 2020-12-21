using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/MSDStatusError", DoNotGenerateAcw=true)]
	public sealed partial class MSDStatusError : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/field[@name='InternalError']"
		[Register ("InternalError")]
		public static global::Com.Miurasystems.Mpi.Enums.MSDStatusError InternalError {
			get {
				const string __id = "InternalError.Lcom/miurasystems/mpi/enums/MSDStatusError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/field[@name='OperationDisallowed']"
		[Register ("OperationDisallowed")]
		public static global::Com.Miurasystems.Mpi.Enums.MSDStatusError OperationDisallowed {
			get {
				const string __id = "OperationDisallowed.Lcom/miurasystems/mpi/enums/MSDStatusError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/field[@name='StartWithoutUSBConnected']"
		[Register ("StartWithoutUSBConnected")]
		public static global::Com.Miurasystems.Mpi.Enums.MSDStatusError StartWithoutUSBConnected {
			get {
				const string __id = "StartWithoutUSBConnected.Lcom/miurasystems/mpi/enums/MSDStatusError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/field[@name='StopWithUSBConnected']"
		[Register ("StopWithUSBConnected")]
		public static global::Com.Miurasystems.Mpi.Enums.MSDStatusError StopWithUSBConnected {
			get {
				const string __id = "StopWithUSBConnected.Lcom/miurasystems/mpi/enums/MSDStatusError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/MSDStatusError", typeof (MSDStatusError));
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

		internal MSDStatusError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("valueOf", "(B)Lcom/miurasystems/mpi/enums/MSDStatusError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.MSDStatusError ValueOf (sbyte value)
		{
			const string __id = "valueOf.(B)Lcom/miurasystems/mpi/enums/MSDStatusError;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/MSDStatusError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.MSDStatusError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/MSDStatusError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='MSDStatusError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/MSDStatusError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.MSDStatusError[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/MSDStatusError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.MSDStatusError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.MSDStatusError));
			} finally {
			}
		}

	}
}
