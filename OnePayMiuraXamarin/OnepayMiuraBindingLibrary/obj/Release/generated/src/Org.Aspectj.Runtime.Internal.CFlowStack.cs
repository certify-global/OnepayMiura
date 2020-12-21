using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowStack", DoNotGenerateAcw=true)]
	public partial class CFlowStack : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/CFlowStack", typeof (CFlowStack));
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

		protected CFlowStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/constructor[@name='CFlowStack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CFlowStack ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='isValid' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='getThreadStackFactoryClassName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/Object;", "GetPeekHandler")]
		public virtual unsafe global::Java.Lang.Object Peek ()
		{
			const string __id = "peek.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekCFlow;
#pragma warning disable 0169
		static Delegate GetPeekCFlowHandler ()
		{
			if (cb_peekCFlow == null)
				cb_peekCFlow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekCFlow);
			return cb_peekCFlow;
		}

		static IntPtr n_PeekCFlow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekCFlow ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekCFlow' and count(parameter)=0]"
		[Register ("peekCFlow", "()Lorg/aspectj/runtime/CFlow;", "GetPeekCFlowHandler")]
		public virtual unsafe global::Org.Aspectj.Runtime.CFlow PeekCFlow ()
		{
			const string __id = "peekCFlow.()Lorg/aspectj/runtime/CFlow;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekInstance;
#pragma warning disable 0169
		static Delegate GetPeekInstanceHandler ()
		{
			if (cb_peekInstance == null)
				cb_peekInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekInstance);
			return cb_peekInstance;
		}

		static IntPtr n_PeekInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekInstance' and count(parameter)=0]"
		[Register ("peekInstance", "()Ljava/lang/Object;", "GetPeekInstanceHandler")]
		public virtual unsafe global::Java.Lang.Object PeekInstance ()
		{
			const string __id = "peekInstance.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekTopCFlow;
#pragma warning disable 0169
		static Delegate GetPeekTopCFlowHandler ()
		{
			if (cb_peekTopCFlow == null)
				cb_peekTopCFlow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekTopCFlow);
			return cb_peekTopCFlow;
		}

		static IntPtr n_PeekTopCFlow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekTopCFlow ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='peekTopCFlow' and count(parameter)=0]"
		[Register ("peekTopCFlow", "()Lorg/aspectj/runtime/CFlow;", "GetPeekTopCFlowHandler")]
		public virtual unsafe global::Org.Aspectj.Runtime.CFlow PeekTopCFlow ()
		{
			const string __id = "peekTopCFlow.()Lorg/aspectj/runtime/CFlow;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.CFlow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pop);
			return cb_pop;
		}

		static void n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='pop' and count(parameter)=0]"
		[Register ("pop", "()V", "GetPopHandler")]
		public virtual unsafe void Pop ()
		{
			const string __id = "pop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_push_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_Object_Handler ()
		{
			if (cb_push_Ljava_lang_Object_ == null)
				cb_push_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Push_Ljava_lang_Object_);
			return cb_push_Ljava_lang_Object_;
		}

		static void n_Push_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Push (obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='push' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("push", "(Ljava/lang/Object;)V", "GetPush_Ljava_lang_Object_Handler")]
		public virtual unsafe void Push (global::Java.Lang.Object obj)
		{
			const string __id = "push.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_push_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_arrayLjava_lang_Object_Handler ()
		{
			if (cb_push_arrayLjava_lang_Object_ == null)
				cb_push_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Push_arrayLjava_lang_Object_);
			return cb_push_arrayLjava_lang_Object_;
		}

		static void n_Push_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Push (obj);
			if (obj != null)
				JNIEnv.CopyArray (obj, native_obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='push' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("push", "([Ljava/lang/Object;)V", "GetPush_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Push (global::Java.Lang.Object[] obj)
		{
			const string __id = "push.([Ljava/lang/Object;)V";
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_pushInstance_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPushInstance_Ljava_lang_Object_Handler ()
		{
			if (cb_pushInstance_Ljava_lang_Object_ == null)
				cb_pushInstance_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PushInstance_Ljava_lang_Object_);
			return cb_pushInstance_Ljava_lang_Object_;
		}

		static void n_PushInstance_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.CFlowStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.PushInstance (obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowStack']/method[@name='pushInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("pushInstance", "(Ljava/lang/Object;)V", "GetPushInstance_Ljava_lang_Object_Handler")]
		public virtual unsafe void PushInstance (global::Java.Lang.Object obj)
		{
			const string __id = "pushInstance.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
