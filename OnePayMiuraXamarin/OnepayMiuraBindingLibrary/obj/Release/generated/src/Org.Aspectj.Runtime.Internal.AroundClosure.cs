using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/AroundClosure", DoNotGenerateAcw=true)]
	public abstract partial class AroundClosure : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='bitflags']"
		[Register ("bitflags")]
		protected int Bitflags {
			get {
				const string __id = "bitflags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitflags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='preInitializationState']"
		[Register ("preInitializationState")]
		protected IList<Java.Lang.Object> PreInitializationState {
			get {
				const string __id = "preInitializationState.[Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "preInitializationState.[Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/field[@name='state']"
		[Register ("state")]
		protected IList<Java.Lang.Object> State {
			get {
				const string __id = "state.[Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::Java.Lang.Object>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "state.[Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/AroundClosure", typeof (AroundClosure));
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

		protected AroundClosure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/constructor[@name='AroundClosure' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AroundClosure ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/constructor[@name='AroundClosure' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AroundClosure (global::Java.Lang.Object[] state)
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

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreInitializationState;
#pragma warning disable 0169
		static Delegate GetGetPreInitializationStateHandler ()
		{
			if (cb_getPreInitializationState == null)
				cb_getPreInitializationState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreInitializationState);
			return cb_getPreInitializationState;
		}

		static IntPtr n_GetPreInitializationState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPreInitializationState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getPreInitializationState' and count(parameter)=0]"
		[Register ("getPreInitializationState", "()[Ljava/lang/Object;", "GetGetPreInitializationStateHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetPreInitializationState ()
		{
			const string __id = "getPreInitializationState.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()[Ljava/lang/Object;", "GetGetStateHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetState ()
		{
			const string __id = "getState.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_linkClosureAndJoinPoint;
#pragma warning disable 0169
		static Delegate GetLinkClosureAndJoinPointHandler ()
		{
			if (cb_linkClosureAndJoinPoint == null)
				cb_linkClosureAndJoinPoint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_LinkClosureAndJoinPoint);
			return cb_linkClosureAndJoinPoint;
		}

		static IntPtr n_LinkClosureAndJoinPoint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkClosureAndJoinPoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='linkClosureAndJoinPoint' and count(parameter)=0]"
		[Register ("linkClosureAndJoinPoint", "()Lorg/aspectj/lang/ProceedingJoinPoint;", "GetLinkClosureAndJoinPointHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.IProceedingJoinPoint LinkClosureAndJoinPoint ()
		{
			const string __id = "linkClosureAndJoinPoint.()Lorg/aspectj/lang/ProceedingJoinPoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_linkClosureAndJoinPoint_I;
#pragma warning disable 0169
		static Delegate GetLinkClosureAndJoinPoint_IHandler ()
		{
			if (cb_linkClosureAndJoinPoint_I == null)
				cb_linkClosureAndJoinPoint_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_LinkClosureAndJoinPoint_I);
			return cb_linkClosureAndJoinPoint_I;
		}

		static IntPtr n_LinkClosureAndJoinPoint_I (IntPtr jnienv, IntPtr native__this, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkClosureAndJoinPoint (flags));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='linkClosureAndJoinPoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("linkClosureAndJoinPoint", "(I)Lorg/aspectj/lang/ProceedingJoinPoint;", "GetLinkClosureAndJoinPoint_IHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.IProceedingJoinPoint LinkClosureAndJoinPoint (int flags)
		{
			const string __id = "linkClosureAndJoinPoint.(I)Lorg/aspectj/lang/ProceedingJoinPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_linkStackClosureAndJoinPoint_I;
#pragma warning disable 0169
		static Delegate GetLinkStackClosureAndJoinPoint_IHandler ()
		{
			if (cb_linkStackClosureAndJoinPoint_I == null)
				cb_linkStackClosureAndJoinPoint_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_LinkStackClosureAndJoinPoint_I);
			return cb_linkStackClosureAndJoinPoint_I;
		}

		static IntPtr n_LinkStackClosureAndJoinPoint_I (IntPtr jnienv, IntPtr native__this, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkStackClosureAndJoinPoint (flags));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='linkStackClosureAndJoinPoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("linkStackClosureAndJoinPoint", "(I)Lorg/aspectj/lang/ProceedingJoinPoint;", "GetLinkStackClosureAndJoinPoint_IHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.IProceedingJoinPoint LinkStackClosureAndJoinPoint (int flags)
		{
			const string __id = "linkStackClosureAndJoinPoint.(I)Lorg/aspectj/lang/ProceedingJoinPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_run_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRun_arrayLjava_lang_Object_Handler ()
		{
			if (cb_run_arrayLjava_lang_Object_ == null)
				cb_run_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Run_arrayLjava_lang_Object_);
			return cb_run_arrayLjava_lang_Object_;
		}

		static IntPtr n_Run_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Run (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("run", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetRun_arrayLjava_lang_Object_Handler")]
		public abstract global::Java.Lang.Object Run (global::Java.Lang.Object[] p0);

		static Delegate cb_unlink;
#pragma warning disable 0169
		static Delegate GetUnlinkHandler ()
		{
			if (cb_unlink == null)
				cb_unlink = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unlink);
			return cb_unlink;
		}

		static void n_Unlink (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.AroundClosure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='unlink' and count(parameter)=0]"
		[Register ("unlink", "()V", "GetUnlinkHandler")]
		public virtual unsafe void Unlink ()
		{
			const string __id = "unlink.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/AroundClosure", DoNotGenerateAcw=true)]
	internal partial class AroundClosureInvoker : AroundClosure {

		public AroundClosureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/AroundClosure", typeof (AroundClosureInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='AroundClosure']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("run", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetRun_arrayLjava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Run (global::Java.Lang.Object[] p0)
		{
			const string __id = "run.([Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
