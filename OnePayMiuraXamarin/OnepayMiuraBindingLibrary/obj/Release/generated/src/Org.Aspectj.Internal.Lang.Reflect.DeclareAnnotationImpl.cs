using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareAnnotationImpl", DoNotGenerateAcw=true)]
	public partial class DeclareAnnotationImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/DeclareAnnotationImpl", typeof (DeclareAnnotationImpl));
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

		protected DeclareAnnotationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/constructor[@name='DeclareAnnotationImpl' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.annotation.Annotation'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V", "")]
		public unsafe DeclareAnnotationImpl (global::Org.Aspectj.Lang.Reflect.IAjType declaring, string kindString, string pattern, global::Java.Lang.Annotation.IAnnotation ann, string annText)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/annotation/Annotation;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_kindString = JNIEnv.NewString (kindString);
			IntPtr native_pattern = JNIEnv.NewString (pattern);
			IntPtr native_annText = JNIEnv.NewString (annText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((declaring == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaring).Handle);
				__args [1] = new JniArgumentValue (native_kindString);
				__args [2] = new JniArgumentValue (native_pattern);
				__args [3] = new JniArgumentValue ((ann == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ann).Handle);
				__args [4] = new JniArgumentValue (native_annText);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_kindString);
				JNIEnv.DeleteLocalRef (native_pattern);
				JNIEnv.DeleteLocalRef (native_annText);
				global::System.GC.KeepAlive (declaring);
				global::System.GC.KeepAlive (ann);
			}
		}

		static Delegate cb_getAnnotation;
#pragma warning disable 0169
		static Delegate GetGetAnnotationHandler ()
		{
			if (cb_getAnnotation == null)
				cb_getAnnotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotation);
			return cb_getAnnotation;
		}

		static IntPtr n_GetAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Annotation);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Annotation.IAnnotation Annotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getAnnotation' and count(parameter)=0]"
			[Register ("getAnnotation", "()Ljava/lang/annotation/Annotation;", "GetGetAnnotationHandler")]
			get {
				const string __id = "getAnnotation.()Ljava/lang/annotation/Annotation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Annotation.IAnnotation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAnnotationAsText;
#pragma warning disable 0169
		static Delegate GetGetAnnotationAsTextHandler ()
		{
			if (cb_getAnnotationAsText == null)
				cb_getAnnotationAsText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotationAsText);
			return cb_getAnnotationAsText;
		}

		static IntPtr n_GetAnnotationAsText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AnnotationAsText);
		}
#pragma warning restore 0169

		public virtual unsafe string AnnotationAsText {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getAnnotationAsText' and count(parameter)=0]"
			[Register ("getAnnotationAsText", "()Ljava/lang/String;", "GetGetAnnotationAsTextHandler")]
			get {
				const string __id = "getAnnotationAsText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;", "GetGetKindHandler")]
			get {
				const string __id = "getKind.()Lorg/aspectj/lang/reflect/DeclareAnnotation$Kind;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.DeclareAnnotationKind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSignaturePattern;
#pragma warning disable 0169
		static Delegate GetGetSignaturePatternHandler ()
		{
			if (cb_getSignaturePattern == null)
				cb_getSignaturePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignaturePattern);
			return cb_getSignaturePattern;
		}

		static IntPtr n_GetSignaturePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SignaturePattern);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ISignaturePattern SignaturePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getSignaturePattern' and count(parameter)=0]"
			[Register ("getSignaturePattern", "()Lorg/aspectj/lang/reflect/SignaturePattern;", "GetGetSignaturePatternHandler")]
			get {
				const string __id = "getSignaturePattern.()Lorg/aspectj/lang/reflect/SignaturePattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISignaturePattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTypePattern;
#pragma warning disable 0169
		static Delegate GetGetTypePatternHandler ()
		{
			if (cb_getTypePattern == null)
				cb_getTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypePattern);
			return cb_getTypePattern;
		}

		static IntPtr n_GetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareAnnotationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareAnnotationImpl']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler")]
			get {
				const string __id = "getTypePattern.()Lorg/aspectj/lang/reflect/TypePattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
