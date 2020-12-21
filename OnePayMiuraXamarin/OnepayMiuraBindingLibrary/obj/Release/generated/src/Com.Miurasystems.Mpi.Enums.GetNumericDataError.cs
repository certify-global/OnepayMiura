using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/GetNumericDataError", DoNotGenerateAcw=true)]
	public sealed partial class GetNumericDataError : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='CommandFormattingError']"
		[Register ("CommandFormattingError")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError CommandFormattingError {
			get {
				const string __id = "CommandFormattingError.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='InternalError']"
		[Register ("InternalError")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError InternalError {
			get {
				const string __id = "InternalError.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='InvalidParameter']"
		[Register ("InvalidParameter")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError InvalidParameter {
			get {
				const string __id = "InvalidParameter.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='PromptsFileError']"
		[Register ("PromptsFileError")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError PromptsFileError {
			get {
				const string __id = "PromptsFileError.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='Timeout']"
		[Register ("Timeout")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError Timeout {
			get {
				const string __id = "Timeout.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/field[@name='UserCancelled']"
		[Register ("UserCancelled")]
		public static global::Com.Miurasystems.Mpi.Enums.GetNumericDataError UserCancelled {
			get {
				const string __id = "UserCancelled.Lcom/miurasystems/mpi/enums/GetNumericDataError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/GetNumericDataError", typeof (GetNumericDataError));
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

		internal GetNumericDataError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/method[@name='valueOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("valueOf", "(BB)Lcom/miurasystems/mpi/enums/GetNumericDataError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetNumericDataError ValueOf (sbyte bySw1, sbyte bySw2)
		{
			const string __id = "valueOf.(BB)Lcom/miurasystems/mpi/enums/GetNumericDataError;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bySw1);
				__args [1] = new JniArgumentValue (bySw2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetNumericDataError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetNumericDataError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetNumericDataError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetNumericDataError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/GetNumericDataError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetNumericDataError[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/GetNumericDataError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError));
			} finally {
			}
		}

	}
}
