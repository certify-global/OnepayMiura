using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ResetDeviceType", DoNotGenerateAcw=true)]
	public sealed partial class ResetDeviceType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/field[@name='Clear_Files']"
		[Register ("Clear_Files")]
		public static global::Com.Miurasystems.Mpi.Enums.ResetDeviceType ClearFiles {
			get {
				const string __id = "Clear_Files.Lcom/miurasystems/mpi/enums/ResetDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/field[@name='Clear_Files_And_Reinitialise_MSD']"
		[Register ("Clear_Files_And_Reinitialise_MSD")]
		public static global::Com.Miurasystems.Mpi.Enums.ResetDeviceType ClearFilesAndReinitialiseMSD {
			get {
				const string __id = "Clear_Files_And_Reinitialise_MSD.Lcom/miurasystems/mpi/enums/ResetDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/field[@name='Hard_Reset']"
		[Register ("Hard_Reset")]
		public static global::Com.Miurasystems.Mpi.Enums.ResetDeviceType HardReset {
			get {
				const string __id = "Hard_Reset.Lcom/miurasystems/mpi/enums/ResetDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/field[@name='Soft_Reset']"
		[Register ("Soft_Reset")]
		public static global::Com.Miurasystems.Mpi.Enums.ResetDeviceType SoftReset {
			get {
				const string __id = "Soft_Reset.Lcom/miurasystems/mpi/enums/ResetDeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ResetDeviceType", typeof (ResetDeviceType));
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

		internal ResetDeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ResetDeviceType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ResetDeviceType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ResetDeviceType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ResetDeviceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/ResetDeviceType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ResetDeviceType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/ResetDeviceType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.ResetDeviceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ResetDeviceType));
			} finally {
			}
		}

	}
}
