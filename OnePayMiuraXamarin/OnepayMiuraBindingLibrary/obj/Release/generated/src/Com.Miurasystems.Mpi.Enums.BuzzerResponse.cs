using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/BuzzerResponse", DoNotGenerateAcw=true)]
	public sealed partial class BuzzerResponse : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/field[@name='HardwareNotAvailableError']"
		[Register ("HardwareNotAvailableError")]
		public static global::Com.Miurasystems.Mpi.Enums.BuzzerResponse HardwareNotAvailableError {
			get {
				const string __id = "HardwareNotAvailableError.Lcom/miurasystems/mpi/enums/BuzzerResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/field[@name='InternalError']"
		[Register ("InternalError")]
		public static global::Com.Miurasystems.Mpi.Enums.BuzzerResponse InternalError {
			get {
				const string __id = "InternalError.Lcom/miurasystems/mpi/enums/BuzzerResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/field[@name='InvalidDataError']"
		[Register ("InvalidDataError")]
		public static global::Com.Miurasystems.Mpi.Enums.BuzzerResponse InvalidDataError {
			get {
				const string __id = "InvalidDataError.Lcom/miurasystems/mpi/enums/BuzzerResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/field[@name='NotAllowedBySettingError']"
		[Register ("NotAllowedBySettingError")]
		public static global::Com.Miurasystems.Mpi.Enums.BuzzerResponse NotAllowedBySettingError {
			get {
				const string __id = "NotAllowedBySettingError.Lcom/miurasystems/mpi/enums/BuzzerResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/field[@name='Success']"
		[Register ("Success")]
		public static global::Com.Miurasystems.Mpi.Enums.BuzzerResponse Success {
			get {
				const string __id = "Success.Lcom/miurasystems/mpi/enums/BuzzerResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/BuzzerResponse", typeof (BuzzerResponse));
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

		internal BuzzerResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/BuzzerResponse;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.BuzzerResponse ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/BuzzerResponse;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='BuzzerResponse']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/BuzzerResponse;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.BuzzerResponse[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/BuzzerResponse;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.BuzzerResponse[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.BuzzerResponse));
			} finally {
			}
		}

	}
}
