using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareSoftImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareSoftImpl", DoNotGenerateAcw=true)]
	public partial class DeclareSoftImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareSoft {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/DeclareSoftImpl", typeof (DeclareSoftImpl));
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

		protected DeclareSoftImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareSoftImpl']/constructor[@name='DeclareSoftImpl' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DeclareSoftImpl (global::Org.Aspectj.Lang.Reflect.IAjType declaringType, string pcut, string exceptionTypeName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pcut = JNIEnv.NewString (pcut);
			IntPtr native_exceptionTypeName = JNIEnv.NewString (exceptionTypeName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [1] = new JniArgumentValue (native_pcut);
				__args [2] = new JniArgumentValue (native_exceptionTypeName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pcut);
				JNIEnv.DeleteLocalRef (native_exceptionTypeName);
				global::System.GC.KeepAlive (declaringType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareSoftImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareSoftImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareSoftImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareSoftImpl']/method[@name='getPointcutExpression' and count(parameter)=0]"
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

		static Delegate cb_getSoftenedExceptionType;
#pragma warning disable 0169
		static Delegate GetGetSoftenedExceptionTypeHandler ()
		{
			if (cb_getSoftenedExceptionType == null)
				cb_getSoftenedExceptionType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSoftenedExceptionType);
			return cb_getSoftenedExceptionType;
		}

		static IntPtr n_GetSoftenedExceptionType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareSoftImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SoftenedExceptionType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType SoftenedExceptionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareSoftImpl']/method[@name='getSoftenedExceptionType' and count(parameter)=0]"
			[Register ("getSoftenedExceptionType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetSoftenedExceptionTypeHandler")]
			get {
				const string __id = "getSoftenedExceptionType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
