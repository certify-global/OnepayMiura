using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AdviceSignature']"
	[Register ("org/aspectj/lang/reflect/AdviceSignature", "", "Org.Aspectj.Lang.Reflect.IAdviceSignatureInvoker")]
	public partial interface IAdviceSignature : global::Org.Aspectj.Lang.Reflect.ICodeSignature {

		global::Java.Lang.Reflect.Method Advice {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AdviceSignature']/method[@name='getAdvice' and count(parameter)=0]"
			[Register ("getAdvice", "()Ljava/lang/reflect/Method;", "GetGetAdviceHandler:Org.Aspectj.Lang.Reflect.IAdviceSignatureInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Class ReturnType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AdviceSignature']/method[@name='getReturnType' and count(parameter)=0]"
			[Register ("getReturnType", "()Ljava/lang/Class;", "GetGetReturnTypeHandler:Org.Aspectj.Lang.Reflect.IAdviceSignatureInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AdviceSignature", DoNotGenerateAcw=true)]
	internal partial class IAdviceSignatureInvoker : global::Java.Lang.Object, IAdviceSignature {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/AdviceSignature", typeof (IAdviceSignatureInvoker));

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

		public static IAdviceSignature GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdviceSignature> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.AdviceSignature"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdviceSignatureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdvice;
#pragma warning disable 0169
		static Delegate GetGetAdviceHandler ()
		{
			if (cb_getAdvice == null)
				cb_getAdvice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdvice);
			return cb_getAdvice;
		}

		static IntPtr n_GetAdvice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Advice);
		}
#pragma warning restore 0169

		IntPtr id_getAdvice;
		public unsafe global::Java.Lang.Reflect.Method Advice {
			get {
				if (id_getAdvice == IntPtr.Zero)
					id_getAdvice = JNIEnv.GetMethodID (class_ref, "getAdvice", "()Ljava/lang/reflect/Method;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdvice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReturnType;
#pragma warning disable 0169
		static Delegate GetGetReturnTypeHandler ()
		{
			if (cb_getReturnType == null)
				cb_getReturnType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReturnType);
			return cb_getReturnType;
		}

		static IntPtr n_GetReturnType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReturnType);
		}
#pragma warning restore 0169

		IntPtr id_getReturnType;
		public unsafe global::Java.Lang.Class ReturnType {
			get {
				if (id_getReturnType == IntPtr.Zero)
					id_getReturnType = JNIEnv.GetMethodID (class_ref, "getReturnType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReturnType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getExceptionTypes;
		public unsafe global::Java.Lang.Class[] GetExceptionTypes ()
		{
			if (id_getExceptionTypes == IntPtr.Zero)
				id_getExceptionTypes = JNIEnv.GetMethodID (class_ref, "getExceptionTypes", "()[Ljava/lang/Class;");
			return (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExceptionTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getParameterTypes;
		public unsafe global::Java.Lang.Class[] GetParameterTypes ()
		{
			if (id_getParameterTypes == IntPtr.Zero)
				id_getParameterTypes = JNIEnv.GetMethodID (class_ref, "getParameterTypes", "()[Ljava/lang/Class;");
			return (global::Java.Lang.Class[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameterTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Class));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Java.Lang.Class DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeclaringTypeName;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeNameHandler ()
		{
			if (cb_getDeclaringTypeName == null)
				cb_getDeclaringTypeName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringTypeName);
			return cb_getDeclaringTypeName;
		}

		static IntPtr n_GetDeclaringTypeName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeclaringTypeName);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringTypeName;
		public unsafe string DeclaringTypeName {
			get {
				if (id_getDeclaringTypeName == IntPtr.Zero)
					id_getDeclaringTypeName = JNIEnv.GetMethodID (class_ref, "getDeclaringTypeName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringTypeName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_toLongString;
#pragma warning disable 0169
		static Delegate GetToLongStringHandler ()
		{
			if (cb_toLongString == null)
				cb_toLongString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToLongString);
			return cb_toLongString;
		}

		static IntPtr n_ToLongString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToLongString ());
		}
#pragma warning restore 0169

		IntPtr id_toLongString;
		public unsafe string ToLongString ()
		{
			if (id_toLongString == IntPtr.Zero)
				id_toLongString = JNIEnv.GetMethodID (class_ref, "toLongString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toLongString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toShortString;
#pragma warning disable 0169
		static Delegate GetToShortStringHandler ()
		{
			if (cb_toShortString == null)
				cb_toShortString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToShortString);
			return cb_toShortString;
		}

		static IntPtr n_ToShortString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToShortString ());
		}
#pragma warning restore 0169

		IntPtr id_toShortString;
		public unsafe string ToShortString ()
		{
			if (id_toShortString == IntPtr.Zero)
				id_toShortString = JNIEnv.GetMethodID (class_ref, "toShortString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toShortString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
