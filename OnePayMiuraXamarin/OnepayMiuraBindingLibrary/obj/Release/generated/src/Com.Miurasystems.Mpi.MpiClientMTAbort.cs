using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClientMTAbort']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/MpiClientMTAbort", DoNotGenerateAcw=true)]
	public sealed partial class MpiClientMTAbort : global::Com.Miurasystems.Mpi.MpiClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/MpiClientMTAbort", typeof (MpiClientMTAbort));
		internal static new IntPtr class_ref {
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

		internal MpiClientMTAbort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClientMTAbort']/constructor[@name='MpiClientMTAbort' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.comms.Connector'] and parameter[2][@type='com.miurasystems.mpi.events.MpiEvents']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/comms/Connector;Lcom/miurasystems/mpi/events/MpiEvents;)V", "")]
		public unsafe MpiClientMTAbort (global::Com.Miurasystems.Mpi.Comms.Connector connector, global::Com.Miurasystems.Mpi.Events.MpiEvents mpiEvents)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/comms/Connector;Lcom/miurasystems/mpi/events/MpiEvents;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((connector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connector).Handle);
				__args [1] = new JniArgumentValue ((mpiEvents == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiEvents).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (connector);
				global::System.GC.KeepAlive (mpiEvents);
			}
		}

	}
}
