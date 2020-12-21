using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/MpiPacket", DoNotGenerateAcw=true)]
	public sealed partial class MpiPacket : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/MpiPacket", typeof (MpiPacket));
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

		internal MpiPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/constructor[@name='MpiPacket' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/InterfaceType;[B)V", "")]
		public unsafe MpiPacket (global::Com.Miurasystems.Mpi.Enums.InterfaceType ifType, byte[] apduBytes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/InterfaceType;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_apduBytes = JNIEnv.NewArray (apduBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ifType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ifType).Handle);
				__args [1] = new JniArgumentValue (native_apduBytes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (apduBytes != null) {
					JNIEnv.CopyArray (native_apduBytes, apduBytes);
					JNIEnv.DeleteLocalRef (native_apduBytes);
				}
				global::System.GC.KeepAlive (ifType);
				global::System.GC.KeepAlive (apduBytes);
			}
		}

		public unsafe bool IsChained {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='isChained' and count(parameter)=0]"
			[Register ("isChained", "()Z", "")]
			get {
				const string __id = "isChained.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsUnsolicited {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='isUnsolicited' and count(parameter)=0]"
			[Register ("isUnsolicited", "()Z", "")]
			get {
				const string __id = "isUnsolicited.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Miurasystems.Mpi.Enums.InterfaceType NodeAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='getNodeAddress' and count(parameter)=0]"
			[Register ("getNodeAddress", "()Lcom/miurasystems/mpi/enums/InterfaceType;", "")]
			get {
				const string __id = "getNodeAddress.()Lcom/miurasystems/mpi/enums/InterfaceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='readFromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readFromStream", "(Ljava/io/InputStream;)Lcom/miurasystems/mpi/comms/MpiPacket;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Comms.MpiPacket ReadFromStream (global::System.IO.Stream stream)
		{
			const string __id = "readFromStream.(Ljava/io/InputStream;)Lcom/miurasystems/mpi/comms/MpiPacket;";
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stream);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiPacket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
				global::System.GC.KeepAlive (stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='reconstructApdu' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.comms.MpiPacket&gt;']]"
		[Register ("reconstructApdu", "(Ljava/util/List;)[B", "")]
		public static unsafe byte[] ReconstructApdu (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Comms.MpiPacket> packets)
		{
			const string __id = "reconstructApdu.(Ljava/util/List;)[B";
			IntPtr native_packets = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Comms.MpiPacket>.ToLocalJniHandle (packets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_packets);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_packets);
				global::System.GC.KeepAlive (packets);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiPacket']/method[@name='writeToStream' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("writeToStream", "(Lcom/miurasystems/mpi/enums/InterfaceType;[BLjava/io/OutputStream;)Z", "")]
		public static unsafe bool WriteToStream (global::Com.Miurasystems.Mpi.Enums.InterfaceType nad, byte[] apduBytes, global::System.IO.Stream stream)
		{
			const string __id = "writeToStream.(Lcom/miurasystems/mpi/enums/InterfaceType;[BLjava/io/OutputStream;)Z";
			IntPtr native_apduBytes = JNIEnv.NewArray (apduBytes);
			IntPtr native_stream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((nad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nad).Handle);
				__args [1] = new JniArgumentValue (native_apduBytes);
				__args [2] = new JniArgumentValue (native_stream);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (apduBytes != null) {
					JNIEnv.CopyArray (native_apduBytes, apduBytes);
					JNIEnv.DeleteLocalRef (native_apduBytes);
				}
				JNIEnv.DeleteLocalRef (native_stream);
				global::System.GC.KeepAlive (nad);
				global::System.GC.KeepAlive (apduBytes);
				global::System.GC.KeepAlive (stream);
			}
		}

	}
}
