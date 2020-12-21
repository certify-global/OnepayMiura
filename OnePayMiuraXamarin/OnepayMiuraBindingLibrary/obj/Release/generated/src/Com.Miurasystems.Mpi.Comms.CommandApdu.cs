using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/CommandApdu", DoNotGenerateAcw=true)]
	public partial class CommandApdu : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/field[@name='MAX_DATA_SIZE']"
		[Register ("MAX_DATA_SIZE")]
		public const int MaxDataSize = (int) 249;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/CommandApdu", typeof (CommandApdu));
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

		protected CommandApdu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.CommandType']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/CommandType;)V", "")]
		public unsafe CommandApdu (global::Com.Miurasystems.Mpi.CommandType type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/CommandType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.CommandType'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/CommandType;[B)V", "")]
		public unsafe CommandApdu (global::Com.Miurasystems.Mpi.CommandType type, byte[] dataField)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/CommandType;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataField = JNIEnv.NewArray (dataField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_dataField);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataField != null) {
					JNIEnv.CopyArray (native_dataField, dataField);
					JNIEnv.DeleteLocalRef (native_dataField);
				}
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (dataField);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.CommandType'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/CommandType;II)V", "")]
		public unsafe CommandApdu (global::Com.Miurasystems.Mpi.CommandType type, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/CommandType;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.CommandType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/CommandType;II[B)V", "")]
		public unsafe CommandApdu (global::Com.Miurasystems.Mpi.CommandType type, int p1, int p2, byte[] dataField)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/CommandType;II[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataField = JNIEnv.NewArray (dataField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_dataField);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataField != null) {
					JNIEnv.CopyArray (native_dataField, dataField);
					JNIEnv.DeleteLocalRef (native_dataField);
				}
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (dataField);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.CommandType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.Integer']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/CommandType;II[BLjava/lang/Integer;)V", "")]
		public unsafe CommandApdu (global::Com.Miurasystems.Mpi.CommandType type, int p1, int p2, byte[] dataField, global::Java.Lang.Integer le)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/CommandType;II[BLjava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataField = JNIEnv.NewArray (dataField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_dataField);
				__args [4] = new JniArgumentValue ((le == null) ? IntPtr.Zero : ((global::Java.Lang.Object) le).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataField != null) {
					JNIEnv.CopyArray (native_dataField, dataField);
					JNIEnv.DeleteLocalRef (native_dataField);
				}
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (dataField);
				global::System.GC.KeepAlive (le);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe CommandApdu (int cla, int ins, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (cla);
				__args [1] = new JniArgumentValue (ins);
				__args [2] = new JniArgumentValue (p1);
				__args [3] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(IIII[B)V", "")]
		public unsafe CommandApdu (int cla, int ins, int p1, int p2, byte[] dataField)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataField = JNIEnv.NewArray (dataField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (cla);
				__args [1] = new JniArgumentValue (ins);
				__args [2] = new JniArgumentValue (p1);
				__args [3] = new JniArgumentValue (p2);
				__args [4] = new JniArgumentValue (native_dataField);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataField != null) {
					JNIEnv.CopyArray (native_dataField, dataField);
					JNIEnv.DeleteLocalRef (native_dataField);
				}
				global::System.GC.KeepAlive (dataField);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]'] and parameter[6][@type='java.lang.Integer']]"
		[Register (".ctor", "(IIII[BLjava/lang/Integer;)V", "")]
		public unsafe CommandApdu (int cla, int ins, int p1, int p2, byte[] dataField, global::Java.Lang.Integer le)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII[BLjava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataField = JNIEnv.NewArray (dataField);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (cla);
				__args [1] = new JniArgumentValue (ins);
				__args [2] = new JniArgumentValue (p1);
				__args [3] = new JniArgumentValue (p2);
				__args [4] = new JniArgumentValue (native_dataField);
				__args [5] = new JniArgumentValue ((le == null) ? IntPtr.Zero : ((global::Java.Lang.Object) le).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataField != null) {
					JNIEnv.CopyArray (native_dataField, dataField);
					JNIEnv.DeleteLocalRef (native_dataField);
				}
				global::System.GC.KeepAlive (dataField);
				global::System.GC.KeepAlive (le);
			}
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.CommandApdu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='CommandApdu']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual unsafe byte[] GetBytes ()
		{
			const string __id = "getBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
