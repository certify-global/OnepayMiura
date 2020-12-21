using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']"
	[global::Android.Runtime.Register ("org/aspectj/lang/SoftException", DoNotGenerateAcw=true)]
	public partial class SoftException : global::Java.Lang.RuntimeException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/SoftException", typeof (SoftException));
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

		protected SoftException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']/constructor[@name='SoftException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe SoftException (global::Java.Lang.Throwable inner)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inner == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) inner).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (inner);
			}
		}

		static Delegate cb_getWrappedThrowable;
#pragma warning disable 0169
		static Delegate GetGetWrappedThrowableHandler ()
		{
			if (cb_getWrappedThrowable == null)
				cb_getWrappedThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWrappedThrowable);
			return cb_getWrappedThrowable;
		}

		static IntPtr n_GetWrappedThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.SoftException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedThrowable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable WrappedThrowable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='SoftException']/method[@name='getWrappedThrowable' and count(parameter)=0]"
			[Register ("getWrappedThrowable", "()Ljava/lang/Throwable;", "GetGetWrappedThrowableHandler")]
			get {
				const string __id = "getWrappedThrowable.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
