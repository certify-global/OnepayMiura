using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/ResponseMessage", DoNotGenerateAcw=true)]
	public partial class ResponseMessage : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/ResponseMessage", typeof (ResponseMessage));
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

		protected ResponseMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/constructor[@name='ResponseMessage' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/InterfaceType;Z[B)V", "")]
		public unsafe ResponseMessage (global::Com.Miurasystems.Mpi.Enums.InterfaceType address, bool unsolicited, byte[] bytes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/InterfaceType;Z[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue (unsolicited);
				__args [2] = new JniArgumentValue (native_bytes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (address);
				global::System.GC.KeepAlive (bytes);
			}
		}

		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsUnsolicited {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='isUnsolicited' and count(parameter)=0]"
			[Register ("isUnsolicited", "()Z", "")]
			get {
				const string __id = "isUnsolicited.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Miurasystems.Mpi.Enums.InterfaceType NodeAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='getNodeAddress' and count(parameter)=0]"
			[Register ("getNodeAddress", "()Lcom/miurasystems/mpi/enums/InterfaceType;", "")]
			get {
				const string __id = "getNodeAddress.()Lcom/miurasystems/mpi/enums/InterfaceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe sbyte Sw1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='getSw1' and count(parameter)=0]"
			[Register ("getSw1", "()B", "")]
			get {
				const string __id = "getSw1.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe sbyte Sw2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='getSw2' and count(parameter)=0]"
			[Register ("getSw2", "()B", "")]
			get {
				const string __id = "getSw2.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseMessage']/method[@name='getBody' and count(parameter)=0]"
		[Register ("getBody", "()[B", "")]
		public unsafe byte[] GetBody ()
		{
			const string __id = "getBody.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
