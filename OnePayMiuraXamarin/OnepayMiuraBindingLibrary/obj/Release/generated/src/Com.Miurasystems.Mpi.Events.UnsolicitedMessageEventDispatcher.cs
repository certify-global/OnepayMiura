using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='UnsolicitedMessageEventDispatcher']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/UnsolicitedMessageEventDispatcher", DoNotGenerateAcw=true)]
	public sealed partial class UnsolicitedMessageEventDispatcher : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/UnsolicitedMessageEventDispatcher", typeof (UnsolicitedMessageEventDispatcher));
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

		internal UnsolicitedMessageEventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='UnsolicitedMessageEventDispatcher']/constructor[@name='UnsolicitedMessageEventDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnsolicitedMessageEventDispatcher ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='UnsolicitedMessageEventDispatcher']/method[@name='signalEvent' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.comms.ResponseMessage'] and parameter[2][@type='com.miurasystems.mpi.events.MpiEvents']]"
		[Register ("signalEvent", "(Lcom/miurasystems/mpi/comms/ResponseMessage;Lcom/miurasystems/mpi/events/MpiEvents;)V", "")]
		public static unsafe void SignalEvent (global::Com.Miurasystems.Mpi.Comms.ResponseMessage responseMessage, global::Com.Miurasystems.Mpi.Events.MpiEvents events)
		{
			const string __id = "signalEvent.(Lcom/miurasystems/mpi/comms/ResponseMessage;Lcom/miurasystems/mpi/events/MpiEvents;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((responseMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseMessage).Handle);
				__args [1] = new JniArgumentValue ((events == null) ? IntPtr.Zero : ((global::Java.Lang.Object) events).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (responseMessage);
				global::System.GC.KeepAlive (events);
			}
		}

	}
}
