using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='NoAspectBoundException']"
	[global::Android.Runtime.Register ("org/aspectj/lang/NoAspectBoundException", DoNotGenerateAcw=true)]
	public partial class NoAspectBoundException : global::Java.Lang.RuntimeException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/NoAspectBoundException", typeof (NoAspectBoundException));
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

		protected NoAspectBoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='NoAspectBoundException']/constructor[@name='NoAspectBoundException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NoAspectBoundException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='NoAspectBoundException']/constructor[@name='NoAspectBoundException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe NoAspectBoundException (string aspectName, global::Java.Lang.Throwable inner)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_aspectName = JNIEnv.NewString (aspectName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_aspectName);
				__args [1] = new JniArgumentValue ((inner == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) inner).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aspectName);
				global::System.GC.KeepAlive (inner);
			}
		}

	}
}
