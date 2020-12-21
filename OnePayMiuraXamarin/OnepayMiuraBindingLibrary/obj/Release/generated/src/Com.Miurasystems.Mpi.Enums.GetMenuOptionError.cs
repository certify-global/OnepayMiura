using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/GetMenuOptionError", DoNotGenerateAcw=true)]
	public sealed partial class GetMenuOptionError : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='CommandFormattingError']"
		[Register ("CommandFormattingError")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError CommandFormattingError {
			get {
				const string __id = "CommandFormattingError.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='InternalError']"
		[Register ("InternalError")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError InternalError {
			get {
				const string __id = "InternalError.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='InternalErrorString']"
		[Register ("InternalErrorString")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError InternalErrorString {
			get {
				const string __id = "InternalErrorString.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='Timeout']"
		[Register ("Timeout")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError Timeout {
			get {
				const string __id = "Timeout.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='UserCancelled']"
		[Register ("UserCancelled")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError UserCancelled {
			get {
				const string __id = "UserCancelled.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/field[@name='Utf8Error']"
		[Register ("Utf8Error")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError Utf8Error {
			get {
				const string __id = "Utf8Error.Lcom/miurasystems/mpi/enums/GetMenuOptionError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/GetMenuOptionError", typeof (GetMenuOptionError));
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

		internal GetMenuOptionError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/method[@name='valueOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("valueOf", "(BB)Lcom/miurasystems/mpi/enums/GetMenuOptionError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError ValueOf (sbyte sw1, sbyte sw2)
		{
			const string __id = "valueOf.(BB)Lcom/miurasystems/mpi/enums/GetMenuOptionError;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sw1);
				__args [1] = new JniArgumentValue (sw2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetMenuOptionError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetMenuOptionError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptionError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/GetMenuOptionError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/GetMenuOptionError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError));
			} finally {
			}
		}

	}
}
