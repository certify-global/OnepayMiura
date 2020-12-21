using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/reflect/FieldSignatureImpl", DoNotGenerateAcw=true)]
	public partial class FieldSignatureImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IFieldSignature {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/reflect/FieldSignatureImpl", typeof (FieldSignatureImpl));
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

		protected FieldSignatureImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Ljava/lang/Class;", "GetGetDeclaringTypeHandler")]
			get {
				const string __id = "getDeclaringType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeclaringTypeName);
		}
#pragma warning restore 0169

		public virtual unsafe string DeclaringTypeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getDeclaringTypeName' and count(parameter)=0]"
			[Register ("getDeclaringTypeName", "()Ljava/lang/String;", "GetGetDeclaringTypeNameHandler")]
			get {
				const string __id = "getDeclaringTypeName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getField;
#pragma warning disable 0169
		static Delegate GetGetFieldHandler ()
		{
			if (cb_getField == null)
				cb_getField = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetField);
			return cb_getField;
		}

		static IntPtr n_GetField (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Field);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.Field Field {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getField' and count(parameter)=0]"
			[Register ("getField", "()Ljava/lang/reflect/Field;", "GetGetFieldHandler")]
			get {
				const string __id = "getField.()Ljava/lang/reflect/Field;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFieldType;
#pragma warning disable 0169
		static Delegate GetGetFieldTypeHandler ()
		{
			if (cb_getFieldType == null)
				cb_getFieldType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFieldType);
			return cb_getFieldType;
		}

		static IntPtr n_GetFieldType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FieldType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class FieldType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getFieldType' and count(parameter)=0]"
			[Register ("getFieldType", "()Ljava/lang/Class;", "GetGetFieldTypeHandler")]
			get {
				const string __id = "getFieldType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		public virtual unsafe int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getModifiers' and count(parameter)=0]"
			[Register ("getModifiers", "()I", "GetGetModifiersHandler")]
			get {
				const string __id = "getModifiers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setLookupClassLoader_Ljava_lang_ClassLoader_;
#pragma warning disable 0169
		static Delegate GetSetLookupClassLoader_Ljava_lang_ClassLoader_Handler ()
		{
			if (cb_setLookupClassLoader_Ljava_lang_ClassLoader_ == null)
				cb_setLookupClassLoader_Ljava_lang_ClassLoader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLookupClassLoader_Ljava_lang_ClassLoader_);
			return cb_setLookupClassLoader_Ljava_lang_ClassLoader_;
		}

		static void n_SetLookupClassLoader_Ljava_lang_ClassLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Reflect.FieldSignatureImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLookupClassLoader (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='FieldSignatureImpl']/method[@name='setLookupClassLoader' and count(parameter)=1 and parameter[1][@type='java.lang.ClassLoader']]"
		[Register ("setLookupClassLoader", "(Ljava/lang/ClassLoader;)V", "GetSetLookupClassLoader_Ljava_lang_ClassLoader_Handler")]
		public virtual unsafe void SetLookupClassLoader (global::Java.Lang.ClassLoader p0)
		{
			const string __id = "setLookupClassLoader.(Ljava/lang/ClassLoader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toLongString' and count(parameter)=0]"
		[Register ("toLongString", "()Ljava/lang/String;", "")]
		public unsafe string ToLongString ()
		{
			const string __id = "toLongString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toShortString' and count(parameter)=0]"
		[Register ("toShortString", "()Ljava/lang/String;", "")]
		public unsafe string ToShortString ()
		{
			const string __id = "toShortString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='SignatureImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
