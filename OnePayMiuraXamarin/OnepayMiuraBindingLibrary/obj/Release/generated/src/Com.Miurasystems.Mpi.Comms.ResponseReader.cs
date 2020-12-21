using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseReader']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/ResponseReader", DoNotGenerateAcw=true)]
	public partial class ResponseReader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/ResponseReader", typeof (ResponseReader));
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

		protected ResponseReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseReader']/constructor[@name='ResponseReader' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe ResponseReader (global::System.IO.Stream stream)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stream);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
				global::System.GC.KeepAlive (stream);
			}
		}

		static Delegate cb_nextResponse;
#pragma warning disable 0169
		static Delegate GetNextResponseHandler ()
		{
			if (cb_nextResponse == null)
				cb_nextResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NextResponse);
			return cb_nextResponse;
		}

		static IntPtr n_NextResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextResponse ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='ResponseReader']/method[@name='nextResponse' and count(parameter)=0]"
		[Register ("nextResponse", "()Lcom/miurasystems/mpi/comms/ResponseMessage;", "GetNextResponseHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.ResponseMessage NextResponse ()
		{
			const string __id = "nextResponse.()Lcom/miurasystems/mpi/comms/ResponseMessage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
