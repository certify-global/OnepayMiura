using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowPlusState", DoNotGenerateAcw=true)]
	public partial class CFlowPlusState : global::Org.Aspectj.Runtime.CFlow {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/CFlowPlusState", typeof (CFlowPlusState));
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

		protected CFlowPlusState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']/constructor[@name='CFlowPlusState' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe CFlowPlusState (global::Java.Lang.Object[] state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_state);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
				global::System.GC.KeepAlive (state);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']/constructor[@name='CFlowPlusState' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "([Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe CFlowPlusState (global::Java.Lang.Object[] state, global::Java.Lang.Object _aspect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_state);
				__args [1] = new JniArgumentValue ((_aspect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _aspect).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
				global::System.GC.KeepAlive (state);
				global::System.GC.KeepAlive (_aspect);
			}
		}

	}
}
