using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeConstructorDeclaration']"
	[Register ("org/aspectj/lang/reflect/InterTypeConstructorDeclaration", "", "Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclarationInvoker")]
	public partial interface IInterTypeConstructorDeclaration : global::Org.Aspectj.Lang.Reflect.IInterTypeDeclaration {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeConstructorDeclaration']/method[@name='getExceptionTypes' and count(parameter)=0]"
		[Register ("getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetExceptionTypesHandler:Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclarationInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeConstructorDeclaration']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
		[Register ("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", "GetGetGenericParameterTypesHandler:Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclarationInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeConstructorDeclaration']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler:Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclarationInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/InterTypeConstructorDeclaration", DoNotGenerateAcw=true)]
	internal partial class IInterTypeConstructorDeclarationInvoker : global::Java.Lang.Object, IInterTypeConstructorDeclaration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/InterTypeConstructorDeclaration", typeof (IInterTypeConstructorDeclarationInvoker));

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

		public static IInterTypeConstructorDeclaration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterTypeConstructorDeclaration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.InterTypeConstructorDeclaration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterTypeConstructorDeclarationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getTargetType;
#pragma warning disable 0169
		static Delegate GetGetTargetTypeHandler ()
		{
			if (cb_getTargetType == null)
				cb_getTargetType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetType);
			return cb_getTargetType;
		}

		static IntPtr n_GetTargetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetType);
		}
#pragma warning restore 0169

		IntPtr id_getTargetType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType TargetType {
			get {
				if (id_getTargetType == IntPtr.Zero)
					id_getTargetType = JNIEnv.GetMethodID (class_ref, "getTargetType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
