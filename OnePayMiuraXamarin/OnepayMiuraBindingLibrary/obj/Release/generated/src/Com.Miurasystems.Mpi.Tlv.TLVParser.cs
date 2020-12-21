using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/TLVParser", DoNotGenerateAcw=true)]
	public partial class TLVParser : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/TLVParser", typeof (TLVParser));
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

		protected TLVParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']/constructor[@name='TLVParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TLVParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> Decode (byte[] bytes)
		{
			const string __id = "decode.([B)Ljava/util/List;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.tlv.Description'] and parameter[2][@type='byte[]']]"
		[Register ("encode", "(Lcom/miurasystems/mpi/tlv/Description;[B)[B", "")]
		public static unsafe byte[] Encode (global::Com.Miurasystems.Mpi.Tlv.Description tag, byte[] value)
		{
			const string __id = "encode.(Lcom/miurasystems/mpi/tlv/Description;[B)[B";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (tag);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVParser']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("encode", "(Lcom/miurasystems/mpi/tlv/TLVObject;)[B", "")]
		public static unsafe byte[] Encode (global::Com.Miurasystems.Mpi.Tlv.TLVObject tlv)
		{
			const string __id = "encode.(Lcom/miurasystems/mpi/tlv/TLVObject;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tlv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlv).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (tlv);
			}
		}

	}
}
