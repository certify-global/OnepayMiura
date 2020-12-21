using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.annotation']/interface[@name='AfterThrowing']"
	[Register ("org/aspectj/lang/annotation/AfterThrowing", "", "Org.Aspectj.Lang.Annotation.IAfterThrowingInvoker")]
	public partial interface IAfterThrowing : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.annotation']/interface[@name='AfterThrowing']/method[@name='argNames' and count(parameter)=0]"
		[Register ("argNames", "()Ljava/lang/String;", "GetArgNamesHandler:Org.Aspectj.Lang.Annotation.IAfterThrowingInvoker, OnepayMiuraBindingLibrary")]
		string ArgNames ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.annotation']/interface[@name='AfterThrowing']/method[@name='pointcut' and count(parameter)=0]"
		[Register ("pointcut", "()Ljava/lang/String;", "GetPointcutHandler:Org.Aspectj.Lang.Annotation.IAfterThrowingInvoker, OnepayMiuraBindingLibrary")]
		string Pointcut ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.annotation']/interface[@name='AfterThrowing']/method[@name='throwing' and count(parameter)=0]"
		[Register ("throwing", "()Ljava/lang/String;", "GetThrowingHandler:Org.Aspectj.Lang.Annotation.IAfterThrowingInvoker, OnepayMiuraBindingLibrary")]
		string Throwing ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.annotation']/interface[@name='AfterThrowing']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "GetValueHandler:Org.Aspectj.Lang.Annotation.IAfterThrowingInvoker, OnepayMiuraBindingLibrary")]
		string Value ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/annotation/AfterThrowing", DoNotGenerateAcw=true)]
	internal partial class IAfterThrowingInvoker : global::Java.Lang.Object, IAfterThrowing {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/annotation/AfterThrowing", typeof (IAfterThrowingInvoker));

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

		public static IAfterThrowing GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAfterThrowing> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.annotation.AfterThrowing"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAfterThrowingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_argNames;
#pragma warning disable 0169
		static Delegate GetArgNamesHandler ()
		{
			if (cb_argNames == null)
				cb_argNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ArgNames);
			return cb_argNames;
		}

		static IntPtr n_ArgNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ArgNames ());
		}
#pragma warning restore 0169

		IntPtr id_argNames;
		public unsafe string ArgNames ()
		{
			if (id_argNames == IntPtr.Zero)
				id_argNames = JNIEnv.GetMethodID (class_ref, "argNames", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_argNames), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pointcut;
#pragma warning disable 0169
		static Delegate GetPointcutHandler ()
		{
			if (cb_pointcut == null)
				cb_pointcut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Pointcut);
			return cb_pointcut;
		}

		static IntPtr n_Pointcut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pointcut ());
		}
#pragma warning restore 0169

		IntPtr id_pointcut;
		public unsafe string Pointcut ()
		{
			if (id_pointcut == IntPtr.Zero)
				id_pointcut = JNIEnv.GetMethodID (class_ref, "pointcut", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pointcut), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_throwing;
#pragma warning disable 0169
		static Delegate GetThrowingHandler ()
		{
			if (cb_throwing == null)
				cb_throwing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Throwing);
			return cb_throwing;
		}

		static IntPtr n_Throwing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Throwing ());
		}
#pragma warning restore 0169

		IntPtr id_throwing;
		public unsafe string Throwing ()
		{
			if (id_throwing == IntPtr.Zero)
				id_throwing = JNIEnv.GetMethodID (class_ref, "throwing", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_throwing), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_value;
#pragma warning disable 0169
		static Delegate GetValueHandler ()
		{
			if (cb_value == null)
				cb_value = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Value);
			return cb_value;
		}

		static IntPtr n_Value (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value ());
		}
#pragma warning restore 0169

		IntPtr id_value;
		public unsafe string Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Annotation.IAfterThrowing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
