using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareParents']"
	[Register ("org/aspectj/internal/lang/annotation/ajcDeclareParents", "", "Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParentsInvoker")]
	public partial interface IAjcDeclareParents : global::Java.Lang.Annotation.IAnnotation {

		bool IsExtends {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareParents']/method[@name='isExtends' and count(parameter)=0]"
			[Register ("isExtends", "()Z", "GetIsExtendsHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParentsInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareParents']/method[@name='parentTypes' and count(parameter)=0]"
		[Register ("parentTypes", "()Ljava/lang/String;", "GetParentTypesHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParentsInvoker, OnepayMiuraBindingLibrary")]
		string ParentTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcDeclareParents']/method[@name='targetTypePattern' and count(parameter)=0]"
		[Register ("targetTypePattern", "()Ljava/lang/String;", "GetTargetTypePatternHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParentsInvoker, OnepayMiuraBindingLibrary")]
		string TargetTypePattern ();

	}

	[global::Android.Runtime.Register ("org/aspectj/internal/lang/annotation/ajcDeclareParents", DoNotGenerateAcw=true)]
	internal partial class IAjcDeclareParentsInvoker : global::Java.Lang.Object, IAjcDeclareParents {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/annotation/ajcDeclareParents", typeof (IAjcDeclareParentsInvoker));

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

		public static IAjcDeclareParents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAjcDeclareParents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.internal.lang.annotation.ajcDeclareParents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAjcDeclareParentsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isExtends;
#pragma warning disable 0169
		static Delegate GetIsExtendsHandler ()
		{
			if (cb_isExtends == null)
				cb_isExtends = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExtends);
			return cb_isExtends;
		}

		static bool n_IsExtends (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExtends;
		}
#pragma warning restore 0169

		IntPtr id_isExtends;
		public unsafe bool IsExtends {
			get {
				if (id_isExtends == IntPtr.Zero)
					id_isExtends = JNIEnv.GetMethodID (class_ref, "isExtends", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExtends);
			}
		}

		static Delegate cb_parentTypes;
#pragma warning disable 0169
		static Delegate GetParentTypesHandler ()
		{
			if (cb_parentTypes == null)
				cb_parentTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ParentTypes);
			return cb_parentTypes;
		}

		static IntPtr n_ParentTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParentTypes ());
		}
#pragma warning restore 0169

		IntPtr id_parentTypes;
		public unsafe string ParentTypes ()
		{
			if (id_parentTypes == IntPtr.Zero)
				id_parentTypes = JNIEnv.GetMethodID (class_ref, "parentTypes", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parentTypes), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_targetTypePattern;
#pragma warning disable 0169
		static Delegate GetTargetTypePatternHandler ()
		{
			if (cb_targetTypePattern == null)
				cb_targetTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TargetTypePattern);
			return cb_targetTypePattern;
		}

		static IntPtr n_TargetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetTypePattern ());
		}
#pragma warning restore 0169

		IntPtr id_targetTypePattern;
		public unsafe string TargetTypePattern ()
		{
			if (id_targetTypePattern == IntPtr.Zero)
				id_targetTypePattern = JNIEnv.GetMethodID (class_ref, "targetTypePattern", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_targetTypePattern), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
