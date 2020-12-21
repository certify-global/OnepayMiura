using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']"
	[Register ("org/aspectj/lang/reflect/Advice", "", "Org.Aspectj.Lang.Reflect.IAdviceInvoker")]
	public partial interface IAdvice : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.AdviceKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/AdviceKind;", "GetGetKindHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getExceptionTypes' and count(parameter)=0]"
		[Register ("getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetExceptionTypesHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
		[Register ("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", "GetGetGenericParameterTypesHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Advice']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler:Org.Aspectj.Lang.Reflect.IAdviceInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/Advice", DoNotGenerateAcw=true)]
	internal partial class IAdviceInvoker : global::Java.Lang.Object, IAdvice {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/Advice", typeof (IAdviceInvoker));

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

		public static IAdvice GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvice> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.Advice"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdviceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		public unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Lorg/aspectj/lang/reflect/AdviceKind;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getExceptionTypes;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ()
		{
			if (id_getExceptionTypes == IntPtr.Zero)
				id_getExceptionTypes = JNIEnv.GetMethodID (class_ref, "getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExceptionTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGenericParameterTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getGenericParameterTypes;
		public unsafe global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ()
		{
			if (id_getGenericParameterTypes == IntPtr.Zero)
				id_getGenericParameterTypes = JNIEnv.GetMethodID (class_ref, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericParameterTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getParameterTypes;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ()
		{
			if (id_getParameterTypes == IntPtr.Zero)
				id_getParameterTypes = JNIEnv.GetMethodID (class_ref, "getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameterTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
		}

	}

}
