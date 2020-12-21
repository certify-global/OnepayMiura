using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVTimeMiura']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/TLVTimeMiura", DoNotGenerateAcw=true)]
	public partial class TLVTimeMiura : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/TLVTimeMiura", typeof (TLVTimeMiura));
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

		protected TLVTimeMiura (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVTimeMiura']/constructor[@name='TLVTimeMiura' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TLVTimeMiura ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVTimeMiura']/method[@name='getTLVDateTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("getTLVDateTime", "(Ljava/util/Date;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject GetTLVDateTime (global::Java.Util.Date dateTime)
		{
			const string __id = "getTLVDateTime.(Ljava/util/Date;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dateTime).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dateTime);
			}
		}

	}
}
