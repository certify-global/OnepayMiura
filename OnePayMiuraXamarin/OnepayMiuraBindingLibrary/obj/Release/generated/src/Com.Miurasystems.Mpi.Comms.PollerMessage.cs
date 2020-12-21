using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='PollerMessage']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/PollerMessage", DoNotGenerateAcw=true)]
	public partial class PollerMessage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='PollerMessage']/field[@name='response']"
		[Register ("response")]
		public global::Com.Miurasystems.Mpi.Comms.ResponseMessage Response {
			get {
				const string __id = "response.Lcom/miurasystems/mpi/comms/ResponseMessage;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseMessage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "response.Lcom/miurasystems/mpi/comms/ResponseMessage;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/PollerMessage", typeof (PollerMessage));
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

		protected PollerMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
