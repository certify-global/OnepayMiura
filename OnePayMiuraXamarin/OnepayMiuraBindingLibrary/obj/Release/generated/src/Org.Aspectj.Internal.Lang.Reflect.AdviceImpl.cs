using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/AdviceImpl", DoNotGenerateAcw=true)]
	public partial class AdviceImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IAdvice {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/AdviceImpl", typeof (AdviceImpl));
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

		protected AdviceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/constructor[@name='AdviceImpl' and count(parameter)=3 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.aspectj.lang.reflect.AdviceKind']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;Ljava/lang/String;Lorg/aspectj/lang/reflect/AdviceKind;)V", "")]
		protected unsafe AdviceImpl (global::Java.Lang.Reflect.Method method, string pointcut, global::Org.Aspectj.Lang.Reflect.AdviceKind type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Method;Ljava/lang/String;Lorg/aspectj/lang/reflect/AdviceKind;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pointcut = JNIEnv.NewString (pointcut);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				__args [1] = new JniArgumentValue (native_pointcut);
				__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pointcut);
				global::System.GC.KeepAlive (method);
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/constructor[@name='AdviceImpl' and count(parameter)=4 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.aspectj.lang.reflect.AdviceKind'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;Ljava/lang/String;Lorg/aspectj/lang/reflect/AdviceKind;Ljava/lang/String;)V", "")]
		protected unsafe AdviceImpl (global::Java.Lang.Reflect.Method method, string pointcut, global::Org.Aspectj.Lang.Reflect.AdviceKind type, string extraParamName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Method;Ljava/lang/String;Lorg/aspectj/lang/reflect/AdviceKind;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pointcut = JNIEnv.NewString (pointcut);
			IntPtr native_extraParamName = JNIEnv.NewString (extraParamName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((method == null) ? IntPtr.Zero : ((global::Java.Lang.Object) method).Handle);
				__args [1] = new JniArgumentValue (native_pointcut);
				__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [3] = new JniArgumentValue (native_extraParamName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pointcut);
				JNIEnv.DeleteLocalRef (native_extraParamName);
				global::System.GC.KeepAlive (method);
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_getDeclaringType;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeHandler ()
		{
			if (cb_getDeclaringType == null)
				cb_getDeclaringType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringType);
			return cb_getDeclaringType;
		}

		static IntPtr n_GetDeclaringType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler")]
			get {
				const string __id = "getDeclaringType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKind;
#pragma warning disable 0169
		static Delegate GetGetKindHandler ()
		{
			if (cb_getKind == null)
				cb_getKind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKind);
			return cb_getKind;
		}

		static IntPtr n_GetKind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/AdviceKind;", "GetGetKindHandler")]
			get {
				const string __id = "getKind.()Lorg/aspectj/lang/reflect/AdviceKind;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPointcutExpression;
#pragma warning disable 0169
		static Delegate GetGetPointcutExpressionHandler ()
		{
			if (cb_getPointcutExpression == null)
				cb_getPointcutExpression = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPointcutExpression);
			return cb_getPointcutExpression;
		}

		static IntPtr n_GetPointcutExpression (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler")]
			get {
				const string __id = "getPointcutExpression.()Lorg/aspectj/lang/reflect/PointcutExpression;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutExpression> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getExceptionTypes' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGenericParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AdviceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AdviceImpl']/method[@name='getParameterTypes' and count(parameter)=0]"
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
