using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackImpl11", DoNotGenerateAcw=true)]
	public partial class ThreadStackImpl11 : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadStackImpl11", typeof (ThreadStackImpl11));
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

		protected ThreadStackImpl11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/constructor[@name='ThreadStackImpl11' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadStackImpl11 ()
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

		static Delegate cb_getThreadStack;
#pragma warning disable 0169
		static Delegate GetGetThreadStackHandler ()
		{
			if (cb_getThreadStack == null)
				cb_getThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThreadStack);
			return cb_getThreadStack;
		}

		static IntPtr n_GetThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadStack);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Stack ThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/method[@name='getThreadStack' and count(parameter)=0]"
			[Register ("getThreadStack", "()Ljava/util/Stack;", "GetGetThreadStackHandler")]
			get {
				const string __id = "getThreadStack.()Ljava/util/Stack;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Stack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_removeThreadStack;
#pragma warning disable 0169
		static Delegate GetRemoveThreadStackHandler ()
		{
			if (cb_removeThreadStack == null)
				cb_removeThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadStack);
			return cb_removeThreadStack;
		}

		static void n_RemoveThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadStack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/method[@name='removeThreadStack' and count(parameter)=0]"
		[Register ("removeThreadStack", "()V", "GetRemoveThreadStackHandler")]
		public virtual unsafe void RemoveThreadStack ()
		{
			const string __id = "removeThreadStack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
