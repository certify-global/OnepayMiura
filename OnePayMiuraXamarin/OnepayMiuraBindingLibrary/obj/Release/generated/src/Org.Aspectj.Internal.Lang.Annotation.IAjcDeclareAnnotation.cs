using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareAnnotation']"
	[Register ("org/aspectj/internal/lang/annotation/ajcDeclareAnnotation", "", "Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotationInvoker")]
	public partial interface IAjcDeclareAnnotation : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareAnnotation']/method[@name='annotation' and count(parameter)=0]"
		[Register ("annotation", "()Ljava/lang/String;", "GetAnnotationHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotationInvoker, OnepayMiuraBindingLibrary")]
		string Annotation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareAnnotation']/method[@name='kind' and count(parameter)=0]"
		[Register ("kind", "()Ljava/lang/String;", "GetKindHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotationInvoker, OnepayMiuraBindingLibrary")]
		string Kind ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareAnnotation']/method[@name='pattern' and count(parameter)=0]"
		[Register ("pattern", "()Ljava/lang/String;", "GetPatternHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotationInvoker, OnepayMiuraBindingLibrary")]
		string Pattern ();

	}

	[global::Android.Runtime.Register ("org/aspectj/internal/lang/annotation/ajcDeclareAnnotation", DoNotGenerateAcw=true)]
	internal partial class IAjcDeclareAnnotationInvoker : global::Java.Lang.Object, IAjcDeclareAnnotation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/annotation/ajcDeclareAnnotation", typeof (IAjcDeclareAnnotationInvoker));

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

		public static IAjcDeclareAnnotation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAjcDeclareAnnotation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.internal.lang.annotation.ajcDeclareAnnotation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAjcDeclareAnnotationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_annotation;
#pragma warning disable 0169
		static Delegate GetAnnotationHandler ()
		{
			if (cb_annotation == null)
				cb_annotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Annotation);
			return cb_annotation;
		}

		static IntPtr n_Annotation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Annotation ());
		}
#pragma warning restore 0169

		IntPtr id_annotation;
		public unsafe string Annotation ()
		{
			if (id_annotation == IntPtr.Zero)
				id_annotation = JNIEnv.GetMethodID (class_ref, "annotation", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotation), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_kind;
#pragma warning disable 0169
		static Delegate GetKindHandler ()
		{
			if (cb_kind == null)
				cb_kind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Kind);
			return cb_kind;
		}

		static IntPtr n_Kind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind ());
		}
#pragma warning restore 0169

		IntPtr id_kind;
		public unsafe string Kind ()
		{
			if (id_kind == IntPtr.Zero)
				id_kind = JNIEnv.GetMethodID (class_ref, "kind", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_kind), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_pattern;
#pragma warning disable 0169
		static Delegate GetPatternHandler ()
		{
			if (cb_pattern == null)
				cb_pattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Pattern);
			return cb_pattern;
		}

		static IntPtr n_Pattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pattern ());
		}
#pragma warning restore 0169

		IntPtr id_pattern;
		public unsafe string Pattern ()
		{
			if (id_pattern == IntPtr.Zero)
				id_pattern = JNIEnv.GetMethodID (class_ref, "pattern", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pattern), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
