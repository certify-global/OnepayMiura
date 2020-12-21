using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeFieldDeclaration']"
	[Register ("org/aspectj/lang/reflect/InterTypeFieldDeclaration", "", "Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclarationInvoker")]
	public partial interface IInterTypeFieldDeclaration : global::Org.Aspectj.Lang.Reflect.IInterTypeDeclaration {

		global::Java.Lang.Reflect.IType GenericType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeFieldDeclaration']/method[@name='getGenericType' and count(parameter)=0]"
			[Register ("getGenericType", "()Ljava/lang/reflect/Type;", "GetGetGenericTypeHandler:Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclarationInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeFieldDeclaration']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclarationInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IAjType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='InterTypeFieldDeclaration']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetTypeHandler:Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclarationInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/InterTypeFieldDeclaration", DoNotGenerateAcw=true)]
	internal partial class IInterTypeFieldDeclarationInvoker : global::Java.Lang.Object, IInterTypeFieldDeclaration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/InterTypeFieldDeclaration", typeof (IInterTypeFieldDeclarationInvoker));

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

		public static IInterTypeFieldDeclaration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterTypeFieldDeclaration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.InterTypeFieldDeclaration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterTypeFieldDeclarationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getGenericType;
#pragma warning disable 0169
		static Delegate GetGetGenericTypeHandler ()
		{
			if (cb_getGenericType == null)
				cb_getGenericType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericType);
			return cb_getGenericType;
		}

		static IntPtr n_GetGenericType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericType);
		}
#pragma warning restore 0169

		IntPtr id_getGenericType;
		public unsafe global::Java.Lang.Reflect.IType GenericType {
			get {
				if (id_getGenericType == IntPtr.Zero)
					id_getGenericType = JNIEnv.GetMethodID (class_ref, "getGenericType", "()Ljava/lang/reflect/Type;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
