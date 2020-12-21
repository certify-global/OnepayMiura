using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/OnlinePINError", DoNotGenerateAcw=true)]
	public sealed partial class OnlinePINError : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Miurasystems.Mpi.Enums.OnlinePINError InternalError {
			get {
				const string __id = "INTERNAL_ERROR.Lcom/miurasystems/mpi/enums/OnlinePINError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.OnlinePINError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']/field[@name='INVALID_PARAM']"
		[Register ("INVALID_PARAM")]
		public static global::Com.Miurasystems.Mpi.Enums.OnlinePINError InvalidParam {
			get {
				const string __id = "INVALID_PARAM.Lcom/miurasystems/mpi/enums/OnlinePINError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.OnlinePINError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']/field[@name='NO_PIN_KEY']"
		[Register ("NO_PIN_KEY")]
		public static global::Com.Miurasystems.Mpi.Enums.OnlinePINError NoPinKey {
			get {
				const string __id = "NO_PIN_KEY.Lcom/miurasystems/mpi/enums/OnlinePINError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.OnlinePINError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/OnlinePINError", typeof (OnlinePINError));
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

		internal OnlinePINError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/OnlinePINError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.OnlinePINError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/OnlinePINError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.OnlinePINError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='OnlinePINError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/OnlinePINError;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.OnlinePINError[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/OnlinePINError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.OnlinePINError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.OnlinePINError));
			} finally {
			}
		}

	}
}
