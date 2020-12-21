using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareErrorOrWarning']"
	[Register ("org/aspectj/lang/reflect/DeclareErrorOrWarning", "", "Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarningInvoker")]
	public partial interface IDeclareErrorOrWarning : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareErrorOrWarning']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarningInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareErrorOrWarning']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler:Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarningInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareErrorOrWarning']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarningInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareErrorOrWarning']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler:Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarningInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/DeclareErrorOrWarning", DoNotGenerateAcw=true)]
	internal partial class IDeclareErrorOrWarningInvoker : global::Java.Lang.Object, IDeclareErrorOrWarning {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/DeclareErrorOrWarning", typeof (IDeclareErrorOrWarningInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDeclareErrorOrWarning GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeclareErrorOrWarning> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.DeclareErrorOrWarning"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeclareErrorOrWarningInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsError;
		}
#pragma warning restore 0169

		IntPtr id_isError;
		public unsafe bool IsError {
			get {
				if (id_isError == IntPtr.Zero)
					id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isError);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		IntPtr id_getPointcutExpression;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			get {
				if (id_getPointcutExpression == IntPtr.Zero)
					id_getPointcutExpression = JNIEnv.GetMethodID (class_ref, "getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutExpression> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointcutExpression), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
