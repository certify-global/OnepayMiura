using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/PortType", DoNotGenerateAcw=true)]
	public sealed partial class PortType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']/field[@name='Tcp']"
		[Register ("Tcp")]
		public static global::Com.Miurasystems.Mpi.Enums.PortType Tcp {
			get {
				const string __id = "Tcp.Lcom/miurasystems/mpi/enums/PortType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PortType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']/field[@name='Udp']"
		[Register ("Udp")]
		public static global::Com.Miurasystems.Mpi.Enums.PortType Udp {
			get {
				const string __id = "Udp.Lcom/miurasystems/mpi/enums/PortType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PortType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/PortType", typeof (PortType));
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

		internal PortType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/PortType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.PortType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/PortType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PortType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PortType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/PortType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.PortType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/PortType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.PortType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.PortType));
			} finally {
			}
		}

	}
}
