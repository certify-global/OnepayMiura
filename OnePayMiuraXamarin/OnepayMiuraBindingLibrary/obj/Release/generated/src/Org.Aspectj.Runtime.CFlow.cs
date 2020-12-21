using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/CFlow", DoNotGenerateAcw=true)]
	public partial class CFlow : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/CFlow", typeof (CFlow));
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

		protected CFlow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/constructor[@name='CFlow' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlow ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/constructor[@name='CFlow' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe CFlow (global::Java.Lang.Object _aspect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_aspect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _aspect).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (_aspect);
			}
		}

		static Delegate cb_getAspect;
#pragma warning disable 0169
		static Delegate GetGetAspectHandler ()
		{
			if (cb_getAspect == null)
				cb_getAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAspect);
			return cb_getAspect;
		}

		static IntPtr n_GetAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Aspect);
		}
#pragma warning restore 0169

		static Delegate cb_setAspect_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetAspect_Ljava_lang_Object_Handler ()
		{
			if (cb_setAspect_Ljava_lang_Object_ == null)
				cb_setAspect_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAspect_Ljava_lang_Object_);
			return cb_setAspect_Ljava_lang_Object_;
		}

		static void n_SetAspect_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__aspect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var _aspect = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__aspect, JniHandleOwnership.DoNotTransfer);
			__this.Aspect = _aspect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Aspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='getAspect' and count(parameter)=0]"
			[Register ("getAspect", "()Ljava/lang/Object;", "GetGetAspectHandler")]
			get {
				const string __id = "getAspect.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='setAspect' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setAspect", "(Ljava/lang/Object;)V", "GetSetAspect_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setAspect.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime']/class[@name='CFlow']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual unsafe global::Java.Lang.Object Get (int index)
		{
			const string __id = "get.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
