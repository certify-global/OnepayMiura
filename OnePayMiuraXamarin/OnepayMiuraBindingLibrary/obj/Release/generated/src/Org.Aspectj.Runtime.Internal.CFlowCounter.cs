using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowCounter", DoNotGenerateAcw=true)]
	public partial class CFlowCounter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/CFlowCounter", typeof (CFlowCounter));
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

		protected CFlowCounter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/constructor[@name='CFlowCounter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlowCounter ()
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

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string ThreadStackFactoryClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='getThreadStackFactoryClassName' and count(parameter)=0]"
			[Register ("getThreadStackFactoryClassName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getThreadStackFactoryClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='dec' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowCounter']/method[@name='inc' and count(parameter)=0]"
		[Register ("inc", "()V", "GetIncHandler")]
		public virtual unsafe void Inc ()
		{
			const string __id = "inc.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
