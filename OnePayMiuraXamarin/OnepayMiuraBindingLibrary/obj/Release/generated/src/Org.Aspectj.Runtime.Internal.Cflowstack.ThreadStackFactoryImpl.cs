using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactoryImpl", DoNotGenerateAcw=true)]
	public partial class ThreadStackFactoryImpl : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactoryImpl", typeof (ThreadStackFactoryImpl));
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

		protected ThreadStackFactoryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl']/constructor[@name='ThreadStackFactoryImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadStackFactoryImpl ()
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

		static Delegate cb_getNewThreadCounter;
#pragma warning disable 0169
		static Delegate GetGetNewThreadCounterHandler ()
		{
			if (cb_getNewThreadCounter == null)
				cb_getNewThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadCounter);
			return cb_getNewThreadCounter;
		}

		static IntPtr n_GetNewThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackFactoryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadCounter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter NewThreadCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl']/method[@name='getNewThreadCounter' and count(parameter)=0]"
			[Register ("getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;", "GetGetNewThreadCounterHandler")]
			get {
				const string __id = "getNewThreadCounter.()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNewThreadStack;
#pragma warning disable 0169
		static Delegate GetGetNewThreadStackHandler ()
		{
			if (cb_getNewThreadStack == null)
				cb_getNewThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadStack);
			return cb_getNewThreadStack;
		}

		static IntPtr n_GetNewThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackFactoryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadStack);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack NewThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackFactoryImpl']/method[@name='getNewThreadStack' and count(parameter)=0]"
			[Register ("getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;", "GetGetNewThreadStackHandler")]
			get {
				const string __id = "getNewThreadStack.()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
