using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareErrorOrWarningImpl", DoNotGenerateAcw=true)]
	public partial class DeclareErrorOrWarningImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/DeclareErrorOrWarningImpl", typeof (DeclareErrorOrWarningImpl));
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

		protected DeclareErrorOrWarningImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']/constructor[@name='DeclareErrorOrWarningImpl' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='org.aspectj.lang.reflect.AjType']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V", "")]
		public unsafe DeclareErrorOrWarningImpl (string pointcut, string message, bool isError, global::Org.Aspectj.Lang.Reflect.IAjType decType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pointcut = JNIEnv.NewString (pointcut);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_pointcut);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (isError);
				__args [3] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pointcut);
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (decType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareErrorOrWarningImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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

		static Delegate cb_isError;
#pragma warning disable 0169
		static Delegate GetIsErrorHandler ()
		{
			if (cb_isError == null)
				cb_isError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsError);
			return cb_isError;
		}

		static bool n_IsError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareErrorOrWarningImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsError;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler")]
			get {
				const string __id = "isError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareErrorOrWarningImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareErrorOrWarningImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareErrorOrWarningImpl']/method[@name='getPointcutExpression' and count(parameter)=0]"
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

	}
}
