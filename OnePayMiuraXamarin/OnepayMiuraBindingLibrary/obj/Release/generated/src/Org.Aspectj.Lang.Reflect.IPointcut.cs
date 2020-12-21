using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']"
	[Register ("org/aspectj/lang/reflect/Pointcut", "", "Org.Aspectj.Lang.Reflect.IPointcutInvoker")]
	public partial interface IPointcut : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")] get;
		}

		int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getModifiers' and count(parameter)=0]"
			[Register ("getModifiers", "()I", "GetGetModifiersHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getParameterNames' and count(parameter)=0]"
		[Register ("getParameterNames", "()[Ljava/lang/String;", "GetGetParameterNamesHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")]
		string[] GetParameterNames ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='Pointcut']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler:Org.Aspectj.Lang.Reflect.IPointcutInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/Pointcut", DoNotGenerateAcw=true)]
	internal partial class IPointcutInvoker : global::Java.Lang.Object, IPointcut {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/Pointcut", typeof (IPointcutInvoker));

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

		public static IPointcut GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPointcut> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.Pointcut"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPointcutInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getModifiers;
#pragma warning disable 0169
		static Delegate GetGetModifiersHandler ()
		{
			if (cb_getModifiers == null)
				cb_getModifiers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetModifiers);
			return cb_getModifiers;
		}

		static int n_GetModifiers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		IntPtr id_getModifiers;
		public unsafe int Modifiers {
			get {
				if (id_getModifiers == IntPtr.Zero)
					id_getModifiers = JNIEnv.GetMethodID (class_ref, "getModifiers", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getModifiers);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getParameterNames;
#pragma warning disable 0169
		static Delegate GetGetParameterNamesHandler ()
		{
			if (cb_getParameterNames == null)
				cb_getParameterNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParameterNames);
			return cb_getParameterNames;
		}

		static IntPtr n_GetParameterNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterNames ());
		}
#pragma warning restore 0169

		IntPtr id_getParameterNames;
		public unsafe string[] GetParameterNames ()
		{
			if (id_getParameterNames == IntPtr.Zero)
				id_getParameterNames = JNIEnv.GetMethodID (class_ref, "getParameterNames", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameterNames), JniHandleOwnership.TransferLocalRef, typeof (string));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
