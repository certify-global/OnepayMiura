using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/InterfaceType", DoNotGenerateAcw=true)]
	public sealed partial class InterfaceType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/field[@name='MPI']"
		[Register ("MPI")]
		public static global::Com.Miurasystems.Mpi.Enums.InterfaceType Mpi {
			get {
				const string __id = "MPI.Lcom/miurasystems/mpi/enums/InterfaceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/field[@name='RPI']"
		[Register ("RPI")]
		public static global::Com.Miurasystems.Mpi.Enums.InterfaceType Rpi {
			get {
				const string __id = "RPI.Lcom/miurasystems/mpi/enums/InterfaceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/InterfaceType", typeof (InterfaceType));
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

		internal InterfaceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/method[@name='getInterfaceType' and count(parameter)=0]"
		[Register ("getInterfaceType", "()B", "")]
		public unsafe sbyte GetInterfaceType ()
		{
			const string __id = "getInterfaceType.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("valueOf", "(B)Lcom/miurasystems/mpi/enums/InterfaceType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.InterfaceType ValueOf (sbyte interfaceByteCode)
		{
			const string __id = "valueOf.(B)Lcom/miurasystems/mpi/enums/InterfaceType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (interfaceByteCode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/InterfaceType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.InterfaceType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/InterfaceType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InterfaceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/InterfaceType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.InterfaceType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/InterfaceType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.InterfaceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.InterfaceType));
			} finally {
			}
		}

	}
}
