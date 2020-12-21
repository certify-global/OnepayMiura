using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']"
	[global::Android.Runtime.Register ("org/slf4j/event/EventConstants", DoNotGenerateAcw=true)]
	public partial class EventConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='DEBUG_INT']"
		[Register ("DEBUG_INT")]
		public const int DebugInt = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='ERROR_INT']"
		[Register ("ERROR_INT")]
		public const int ErrorInt = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='INFO_INT']"
		[Register ("INFO_INT")]
		public const int InfoInt = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='NA_SUBST']"
		[Register ("NA_SUBST")]
		public const string NaSubst = (string) "NA/SubstituteLogger";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='TRACE_INT']"
		[Register ("TRACE_INT")]
		public const int TraceInt = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/field[@name='WARN_INT']"
		[Register ("WARN_INT")]
		public const int WarnInt = (int) 30;
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/event/EventConstants", typeof (EventConstants));
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

		protected EventConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventConstants']/constructor[@name='EventConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventConstants ()
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

	}
}
