using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeConstructorDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeConstructorDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeConstructorDeclarationImpl : global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl, global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/InterTypeConstructorDeclarationImpl", typeof (InterTypeConstructorDeclarationImpl));
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

		protected InterTypeConstructorDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeConstructorDeclarationImpl']/constructor[@name='InterTypeConstructorDeclarationImpl' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.reflect.Method']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/reflect/Method;)V", "")]
		public unsafe InterTypeConstructorDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods, global::Java.Lang.Reflect.Method baseMethod)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/reflect/Method;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue (native_target);
				__args [2] = new JniArgumentValue (mods);
				__args [3] = new JniArgumentValue ((baseMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseMethod).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (baseMethod);
			}
		}

		static Delegate cb_getExceptionTypes;
#pragma warning disable 0169
		static Delegate GetGetExceptionTypesHandler ()
		{
			if (cb_getExceptionTypes == null)
				cb_getExceptionTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExceptionTypes);
			return cb_getExceptionTypes;
		}

		static IntPtr n_GetExceptionTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeConstructorDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeConstructorDeclarationImpl']/method[@name='getExceptionTypes' and count(parameter)=0]"
		[Register ("getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetExceptionTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ()
		{
			const string __id = "getExceptionTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getGenericParameterTypes;
#pragma warning disable 0169
		static Delegate GetGetGenericParameterTypesHandler ()
		{
			if (cb_getGenericParameterTypes == null)
				cb_getGenericParameterTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericParameterTypes);
			return cb_getGenericParameterTypes;
		}

		static IntPtr n_GetGenericParameterTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeConstructorDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGenericParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeConstructorDeclarationImpl']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
		[Register ("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", "GetGetGenericParameterTypesHandler")]
		public virtual unsafe global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ()
		{
			const string __id = "getGenericParameterTypes.()[Ljava/lang/reflect/Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
			}
		}

		static Delegate cb_getParameterTypes;
#pragma warning disable 0169
		static Delegate GetGetParameterTypesHandler ()
		{
			if (cb_getParameterTypes == null)
				cb_getParameterTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParameterTypes);
			return cb_getParameterTypes;
		}

		static IntPtr n_GetParameterTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeConstructorDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeConstructorDeclarationImpl']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ()
		{
			const string __id = "getParameterTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

	}
}
