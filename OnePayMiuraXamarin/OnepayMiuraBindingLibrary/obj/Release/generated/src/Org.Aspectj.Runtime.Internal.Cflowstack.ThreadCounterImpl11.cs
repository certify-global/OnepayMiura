using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadCounterImpl11", DoNotGenerateAcw=true)]
	public partial class ThreadCounterImpl11 : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadCounterImpl11", typeof (ThreadCounterImpl11));
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

		protected ThreadCounterImpl11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/constructor[@name='ThreadCounterImpl11' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadCounterImpl11 ()
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

		static Delegate cb_isNotZero;
#pragma warning disable 0169
		static Delegate GetIsNotZeroHandler ()
		{
			if (cb_isNotZero == null)
				cb_isNotZero = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNotZero);
			return cb_isNotZero;
		}

		static bool n_IsNotZero (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotZero;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNotZero {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='isNotZero' and count(parameter)=0]"
			[Register ("isNotZero", "()Z", "GetIsNotZeroHandler")]
			get {
				const string __id = "isNotZero.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_dec;
#pragma warning disable 0169
		static Delegate GetDecHandler ()
		{
			if (cb_dec == null)
				cb_dec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dec);
			return cb_dec;
		}

		static void n_Dec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='dec' and count(parameter)=0]"
		[Register ("dec", "()V", "GetDecHandler")]
		public virtual unsafe void Dec ()
		{
			const string __id = "dec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_inc;
#pragma warning disable 0169
		static Delegate GetIncHandler ()
		{
			if (cb_inc == null)
				cb_inc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Inc);
			return cb_inc;
		}

		static void n_Inc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='inc' and count(parameter)=0]"
		[Register ("inc", "()V", "GetIncHandler")]
		public virtual unsafe void Inc ()
		{
			const string __id = "inc.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeThreadCounter;
#pragma warning disable 0169
		static Delegate GetRemoveThreadCounterHandler ()
		{
			if (cb_removeThreadCounter == null)
				cb_removeThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadCounter);
			return cb_removeThreadCounter;
		}

		static void n_RemoveThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadCounterImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadCounter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadCounterImpl11']/method[@name='removeThreadCounter' and count(parameter)=0]"
		[Register ("removeThreadCounter", "()V", "GetRemoveThreadCounterHandler")]
		public virtual unsafe void RemoveThreadCounter ()
		{
			const string __id = "removeThreadCounter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
