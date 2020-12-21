using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/AjTypeImpl", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class AjTypeImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IAjType {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/AjTypeImpl", typeof (AjTypeImpl));
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

		protected AjTypeImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/constructor[@name='AjTypeImpl' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe AjTypeImpl (global::Java.Lang.Class fromClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fromClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fromClass);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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

		static Delegate cb_getEnclosingConstructor;
#pragma warning disable 0169
		static Delegate GetGetEnclosingConstructorHandler ()
		{
			if (cb_getEnclosingConstructor == null)
				cb_getEnclosingConstructor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingConstructor);
			return cb_getEnclosingConstructor;
		}

		static IntPtr n_GetEnclosingConstructor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingConstructor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.Constructor EnclosingConstructor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getEnclosingConstructor' and count(parameter)=0]"
			[Register ("getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", "GetGetEnclosingConstructorHandler")]
			get {
				const string __id = "getEnclosingConstructor.()Ljava/lang/reflect/Constructor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnclosingMethod;
#pragma warning disable 0169
		static Delegate GetGetEnclosingMethodHandler ()
		{
			if (cb_getEnclosingMethod == null)
				cb_getEnclosingMethod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingMethod);
			return cb_getEnclosingMethod;
		}

		static IntPtr n_GetEnclosingMethod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingMethod);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.Method EnclosingMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getEnclosingMethod' and count(parameter)=0]"
			[Register ("getEnclosingMethod", "()Ljava/lang/reflect/Method;", "GetGetEnclosingMethodHandler")]
			get {
				const string __id = "getEnclosingMethod.()Ljava/lang/reflect/Method;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnclosingType;
#pragma warning disable 0169
		static Delegate GetGetEnclosingTypeHandler ()
		{
			if (cb_getEnclosingType == null)
				cb_getEnclosingType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingType);
			return cb_getEnclosingType;
		}

		static IntPtr n_GetEnclosingType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType EnclosingType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getEnclosingType' and count(parameter)=0]"
			[Register ("getEnclosingType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetEnclosingTypeHandler")]
			get {
				const string __id = "getEnclosingType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGenericSupertype;
#pragma warning disable 0169
		static Delegate GetGetGenericSupertypeHandler ()
		{
			if (cb_getGenericSupertype == null)
				cb_getGenericSupertype = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericSupertype);
			return cb_getGenericSupertype;
		}

		static IntPtr n_GetGenericSupertype (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericSupertype);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.IType GenericSupertype {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getGenericSupertype' and count(parameter)=0]"
			[Register ("getGenericSupertype", "()Ljava/lang/reflect/Type;", "GetGetGenericSupertypeHandler")]
			get {
				const string __id = "getGenericSupertype.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isArray;
#pragma warning disable 0169
		static Delegate GetIsArrayHandler ()
		{
			if (cb_isArray == null)
				cb_isArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsArray);
			return cb_isArray;
		}

		static bool n_IsArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsArray;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isArray' and count(parameter)=0]"
			[Register ("isArray", "()Z", "GetIsArrayHandler")]
			get {
				const string __id = "isArray.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAspect;
#pragma warning disable 0169
		static Delegate GetIsAspectHandler ()
		{
			if (cb_isAspect == null)
				cb_isAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAspect);
			return cb_isAspect;
		}

		static bool n_IsAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAspect;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isAspect' and count(parameter)=0]"
			[Register ("isAspect", "()Z", "GetIsAspectHandler")]
			get {
				const string __id = "isAspect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnum;
#pragma warning disable 0169
		static Delegate GetIsEnumHandler ()
		{
			if (cb_isEnum == null)
				cb_isEnum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnum);
			return cb_isEnum;
		}

		static bool n_IsEnum (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnum;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isEnum' and count(parameter)=0]"
			[Register ("isEnum", "()Z", "GetIsEnumHandler")]
			get {
				const string __id = "isEnum.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInterface;
#pragma warning disable 0169
		static Delegate GetIsInterfaceHandler ()
		{
			if (cb_isInterface == null)
				cb_isInterface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInterface);
			return cb_isInterface;
		}

		static bool n_IsInterface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInterface;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInterface {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isInterface' and count(parameter)=0]"
			[Register ("isInterface", "()Z", "GetIsInterfaceHandler")]
			get {
				const string __id = "isInterface.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLocalClass;
#pragma warning disable 0169
		static Delegate GetIsLocalClassHandler ()
		{
			if (cb_isLocalClass == null)
				cb_isLocalClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLocalClass);
			return cb_isLocalClass;
		}

		static bool n_IsLocalClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocalClass;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLocalClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isLocalClass' and count(parameter)=0]"
			[Register ("isLocalClass", "()Z", "GetIsLocalClassHandler")]
			get {
				const string __id = "isLocalClass.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMemberAspect;
#pragma warning disable 0169
		static Delegate GetIsMemberAspectHandler ()
		{
			if (cb_isMemberAspect == null)
				cb_isMemberAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMemberAspect);
			return cb_isMemberAspect;
		}

		static bool n_IsMemberAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMemberAspect;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMemberAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isMemberAspect' and count(parameter)=0]"
			[Register ("isMemberAspect", "()Z", "GetIsMemberAspectHandler")]
			get {
				const string __id = "isMemberAspect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMemberClass;
#pragma warning disable 0169
		static Delegate GetIsMemberClassHandler ()
		{
			if (cb_isMemberClass == null)
				cb_isMemberClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMemberClass);
			return cb_isMemberClass;
		}

		static bool n_IsMemberClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMemberClass;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMemberClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isMemberClass' and count(parameter)=0]"
			[Register ("isMemberClass", "()Z", "GetIsMemberClassHandler")]
			get {
				const string __id = "isMemberClass.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrimitive;
#pragma warning disable 0169
		static Delegate GetIsPrimitiveHandler ()
		{
			if (cb_isPrimitive == null)
				cb_isPrimitive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrimitive);
			return cb_isPrimitive;
		}

		static bool n_IsPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimitive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isPrimitive' and count(parameter)=0]"
			[Register ("isPrimitive", "()Z", "GetIsPrimitiveHandler")]
			get {
				const string __id = "isPrimitive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrivileged;
#pragma warning disable 0169
		static Delegate GetIsPrivilegedHandler ()
		{
			if (cb_isPrivileged == null)
				cb_isPrivileged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrivileged);
			return cb_isPrivileged;
		}

		static bool n_IsPrivileged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrivileged;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrivileged {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isPrivileged' and count(parameter)=0]"
			[Register ("isPrivileged", "()Z", "GetIsPrivilegedHandler")]
			get {
				const string __id = "isPrivileged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getJavaClass;
#pragma warning disable 0169
		static Delegate GetGetJavaClassHandler ()
		{
			if (cb_getJavaClass == null)
				cb_getJavaClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJavaClass);
			return cb_getJavaClass;
		}

		static IntPtr n_GetJavaClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JavaClass);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Class JavaClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getJavaClass' and count(parameter)=0]"
			[Register ("getJavaClass", "()Ljava/lang/Class;", "GetGetJavaClassHandler")]
			get {
				const string __id = "getJavaClass.()Ljava/lang/Class;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		public virtual unsafe int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getModifiers' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getPackage;
#pragma warning disable 0169
		static Delegate GetGetPackageHandler ()
		{
			if (cb_getPackage == null)
				cb_getPackage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackage);
			return cb_getPackage;
		}

		static IntPtr n_GetPackage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Package);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Package Package {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getPackage' and count(parameter)=0]"
			[Register ("getPackage", "()Ljava/lang/Package;", "GetGetPackageHandler")]
			get {
				const string __id = "getPackage.()Ljava/lang/Package;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Package> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPerClause;
#pragma warning disable 0169
		static Delegate GetGetPerClauseHandler ()
		{
			if (cb_getPerClause == null)
				cb_getPerClause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPerClause);
			return cb_getPerClause;
		}

		static IntPtr n_GetPerClause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PerClause);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPerClause PerClause {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getPerClause' and count(parameter)=0]"
			[Register ("getPerClause", "()Lorg/aspectj/lang/reflect/PerClause;", "GetGetPerClauseHandler")]
			get {
				const string __id = "getPerClause.()Lorg/aspectj/lang/reflect/PerClause;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPerClause> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupertype;
#pragma warning disable 0169
		static Delegate GetGetSupertypeHandler ()
		{
			if (cb_getSupertype == null)
				cb_getSupertype = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupertype);
			return cb_getSupertype;
		}

		static IntPtr n_GetSupertype (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Supertype);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType Supertype {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getSupertype' and count(parameter)=0]"
			[Register ("getSupertype", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetSupertypeHandler")]
			get {
				const string __id = "getSupertype.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdvice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAdvice_Ljava_lang_String_Handler ()
		{
			if (cb_getAdvice_Ljava_lang_String_ == null)
				cb_getAdvice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdvice_Ljava_lang_String_);
			return cb_getAdvice_Ljava_lang_String_;
		}

		static IntPtr n_GetAdvice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAdvice (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getAdvice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;", "GetGetAdvice_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAdvice GetAdvice (string name)
		{
			const string __id = "getAdvice.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
#pragma warning disable 0169
		static Delegate GetGetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler ()
		{
			if (cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == null)
				cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_);
			return cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		}

		static IntPtr n_GetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ofType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ofType = (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (native_ofType, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			IntPtr __ret = JNIEnv.NewArray (__this.GetAdvice (ofType));
			if (ofType != null)
				JNIEnv.CopyArray (ofType, native_ofType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getAdvice' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AdviceKind...']]"
		[Register ("getAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;", "GetGetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAdvice[] GetAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] ofType)
		{
			const string __id = "getAdvice.([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;";
			IntPtr native_ofType = JNIEnv.NewArray (ofType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ofType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Org.Aspectj.Lang.Reflect.IAdvice[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAdvice));
			} finally {
				if (ofType != null) {
					JNIEnv.CopyArray (native_ofType, ofType);
					JNIEnv.DeleteLocalRef (native_ofType);
				}
				global::System.GC.KeepAlive (ofType);
			}
		}

		static Delegate cb_getAjTypes;
#pragma warning disable 0169
		static Delegate GetGetAjTypesHandler ()
		{
			if (cb_getAjTypes == null)
				cb_getAjTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAjTypes);
			return cb_getAjTypes;
		}

		static IntPtr n_GetAjTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAjTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getAjTypes' and count(parameter)=0]"
		[Register ("getAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetAjTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetAjTypes ()
		{
			const string __id = "getAjTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getAnnotation_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAnnotation_Ljava_lang_Class_Handler ()
		{
			if (cb_getAnnotation_Ljava_lang_Class_ == null)
				cb_getAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAnnotation_Ljava_lang_Class_);
			return cb_getAnnotation_Ljava_lang_Class_;
		}

		static IntPtr n_GetAnnotation_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnnotation (annotationType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;A&gt;']]"
		[Register ("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "GetGetAnnotation_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A extends java.lang.annotation.Annotation"})]
		public virtual unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Class annotationType)
		{
			const string __id = "getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotationType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (annotationType);
			}
		}

		static Delegate cb_getAnnotations;
#pragma warning disable 0169
		static Delegate GetGetAnnotationsHandler ()
		{
			if (cb_getAnnotations == null)
				cb_getAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotations);
			return cb_getAnnotations;
		}

		static IntPtr n_GetAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAnnotations ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getAnnotations' and count(parameter)=0]"
		[Register ("getAnnotations", "()[Ljava/lang/annotation/Annotation;", "GetGetAnnotationsHandler")]
		public virtual unsafe global::Java.Lang.Annotation.IAnnotation[] GetAnnotations ()
		{
			const string __id = "getAnnotations.()[Ljava/lang/annotation/Annotation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Annotation.IAnnotation));
			} finally {
			}
		}

		static Delegate cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConstructor_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetConstructor_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConstructor (parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getConstructor' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;", "GetGetConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Constructor GetConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getConstructor.([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getConstructors;
#pragma warning disable 0169
		static Delegate GetGetConstructorsHandler ()
		{
			if (cb_getConstructors == null)
				cb_getConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConstructors);
			return cb_getConstructors;
		}

		static IntPtr n_GetConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConstructors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getConstructors' and count(parameter)=0]"
		[Register ("getConstructors", "()[Ljava/lang/reflect/Constructor;", "GetGetConstructorsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Constructor[] GetConstructors ()
		{
			const string __id = "getConstructors.()[Ljava/lang/reflect/Constructor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Constructor[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Constructor));
			} finally {
			}
		}

		static Delegate cb_getDeclareAnnotations;
#pragma warning disable 0169
		static Delegate GetGetDeclareAnnotationsHandler ()
		{
			if (cb_getDeclareAnnotations == null)
				cb_getDeclareAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareAnnotations);
			return cb_getDeclareAnnotations;
		}

		static IntPtr n_GetDeclareAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareAnnotations ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclareAnnotations' and count(parameter)=0]"
		[Register ("getDeclareAnnotations", "()[Lorg/aspectj/lang/reflect/DeclareAnnotation;", "GetGetDeclareAnnotationsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation[] GetDeclareAnnotations ()
		{
			const string __id = "getDeclareAnnotations.()[Lorg/aspectj/lang/reflect/DeclareAnnotation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation));
			} finally {
			}
		}

		static Delegate cb_getDeclareErrorOrWarnings;
#pragma warning disable 0169
		static Delegate GetGetDeclareErrorOrWarningsHandler ()
		{
			if (cb_getDeclareErrorOrWarnings == null)
				cb_getDeclareErrorOrWarnings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareErrorOrWarnings);
			return cb_getDeclareErrorOrWarnings;
		}

		static IntPtr n_GetDeclareErrorOrWarnings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareErrorOrWarnings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclareErrorOrWarnings' and count(parameter)=0]"
		[Register ("getDeclareErrorOrWarnings", "()[Lorg/aspectj/lang/reflect/DeclareErrorOrWarning;", "GetGetDeclareErrorOrWarningsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning[] GetDeclareErrorOrWarnings ()
		{
			const string __id = "getDeclareErrorOrWarnings.()[Lorg/aspectj/lang/reflect/DeclareErrorOrWarning;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning));
			} finally {
			}
		}

		static Delegate cb_getDeclareParents;
#pragma warning disable 0169
		static Delegate GetGetDeclareParentsHandler ()
		{
			if (cb_getDeclareParents == null)
				cb_getDeclareParents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareParents);
			return cb_getDeclareParents;
		}

		static IntPtr n_GetDeclareParents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareParents ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclareParents' and count(parameter)=0]"
		[Register ("getDeclareParents", "()[Lorg/aspectj/lang/reflect/DeclareParents;", "GetGetDeclareParentsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IDeclareParents[] GetDeclareParents ()
		{
			const string __id = "getDeclareParents.()[Lorg/aspectj/lang/reflect/DeclareParents;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IDeclareParents[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareParents));
			} finally {
			}
		}

		static Delegate cb_getDeclarePrecedence;
#pragma warning disable 0169
		static Delegate GetGetDeclarePrecedenceHandler ()
		{
			if (cb_getDeclarePrecedence == null)
				cb_getDeclarePrecedence = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclarePrecedence);
			return cb_getDeclarePrecedence;
		}

		static IntPtr n_GetDeclarePrecedence (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclarePrecedence ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclarePrecedence' and count(parameter)=0]"
		[Register ("getDeclarePrecedence", "()[Lorg/aspectj/lang/reflect/DeclarePrecedence;", "GetGetDeclarePrecedenceHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence[] GetDeclarePrecedence ()
		{
			const string __id = "getDeclarePrecedence.()[Lorg/aspectj/lang/reflect/DeclarePrecedence;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence));
			} finally {
			}
		}

		static Delegate cb_getDeclareSofts;
#pragma warning disable 0169
		static Delegate GetGetDeclareSoftsHandler ()
		{
			if (cb_getDeclareSofts == null)
				cb_getDeclareSofts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareSofts);
			return cb_getDeclareSofts;
		}

		static IntPtr n_GetDeclareSofts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareSofts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclareSofts' and count(parameter)=0]"
		[Register ("getDeclareSofts", "()[Lorg/aspectj/lang/reflect/DeclareSoft;", "GetGetDeclareSoftsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IDeclareSoft[] GetDeclareSofts ()
		{
			const string __id = "getDeclareSofts.()[Lorg/aspectj/lang/reflect/DeclareSoft;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IDeclareSoft[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareSoft));
			} finally {
			}
		}

		static Delegate cb_getDeclaredAdvice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAdvice_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredAdvice_Ljava_lang_String_ == null)
				cb_getDeclaredAdvice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredAdvice_Ljava_lang_String_);
			return cb_getDeclaredAdvice_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredAdvice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredAdvice (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredAdvice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;", "GetGetDeclaredAdvice_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAdvice GetDeclaredAdvice (string name)
		{
			const string __id = "getDeclaredAdvice.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler ()
		{
			if (cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == null)
				cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_);
			return cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		}

		static IntPtr n_GetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ofType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ofType = (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (native_ofType, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			IntPtr __ret = JNIEnv.NewArray (__this.GetDeclaredAdvice (ofType));
			if (ofType != null)
				JNIEnv.CopyArray (ofType, native_ofType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredAdvice' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AdviceKind...']]"
		[Register ("getDeclaredAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;", "GetGetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAdvice[] GetDeclaredAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] ofType)
		{
			const string __id = "getDeclaredAdvice.([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;";
			IntPtr native_ofType = JNIEnv.NewArray (ofType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ofType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Org.Aspectj.Lang.Reflect.IAdvice[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAdvice));
			} finally {
				if (ofType != null) {
					JNIEnv.CopyArray (native_ofType, ofType);
					JNIEnv.DeleteLocalRef (native_ofType);
				}
				global::System.GC.KeepAlive (ofType);
			}
		}

		static Delegate cb_getDeclaredAjTypes;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAjTypesHandler ()
		{
			if (cb_getDeclaredAjTypes == null)
				cb_getDeclaredAjTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredAjTypes);
			return cb_getDeclaredAjTypes;
		}

		static IntPtr n_GetDeclaredAjTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredAjTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredAjTypes' and count(parameter)=0]"
		[Register ("getDeclaredAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaredAjTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetDeclaredAjTypes ()
		{
			const string __id = "getDeclaredAjTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getDeclaredAnnotations;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAnnotationsHandler ()
		{
			if (cb_getDeclaredAnnotations == null)
				cb_getDeclaredAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredAnnotations);
			return cb_getDeclaredAnnotations;
		}

		static IntPtr n_GetDeclaredAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredAnnotations ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredAnnotations' and count(parameter)=0]"
		[Register ("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", "GetGetDeclaredAnnotationsHandler")]
		public virtual unsafe global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations ()
		{
			const string __id = "getDeclaredAnnotations.()[Ljava/lang/annotation/Annotation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Annotation.IAnnotation));
			} finally {
			}
		}

		static Delegate cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredConstructor (parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredConstructor' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;", "GetGetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Constructor GetDeclaredConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getDeclaredConstructor.([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getDeclaredConstructors;
#pragma warning disable 0169
		static Delegate GetGetDeclaredConstructorsHandler ()
		{
			if (cb_getDeclaredConstructors == null)
				cb_getDeclaredConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredConstructors);
			return cb_getDeclaredConstructors;
		}

		static IntPtr n_GetDeclaredConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredConstructors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredConstructors' and count(parameter)=0]"
		[Register ("getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", "GetGetDeclaredConstructorsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Constructor[] GetDeclaredConstructors ()
		{
			const string __id = "getDeclaredConstructors.()[Ljava/lang/reflect/Constructor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Constructor[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Constructor));
			} finally {
			}
		}

		static Delegate cb_getDeclaredField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredField_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredField_Ljava_lang_String_ == null)
				cb_getDeclaredField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredField_Ljava_lang_String_);
			return cb_getDeclaredField_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredField (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", "GetGetDeclaredField_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Field GetDeclaredField (string name)
		{
			const string __id = "getDeclaredField.(Ljava/lang/String;)Ljava/lang/reflect/Field;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDeclaredFields;
#pragma warning disable 0169
		static Delegate GetGetDeclaredFieldsHandler ()
		{
			if (cb_getDeclaredFields == null)
				cb_getDeclaredFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredFields);
			return cb_getDeclaredFields;
		}

		static IntPtr n_GetDeclaredFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredFields ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredFields' and count(parameter)=0]"
		[Register ("getDeclaredFields", "()[Ljava/lang/reflect/Field;", "GetGetDeclaredFieldsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Field[] GetDeclaredFields ()
		{
			const string __id = "getDeclaredFields.()[Ljava/lang/reflect/Field;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
			} finally {
			}
		}

		static Delegate cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDConstructor (target, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDConstructor' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetDeclaredITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType target, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getDeclaredITDConstructor.(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getDeclaredITDConstructors;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDConstructorsHandler ()
		{
			if (cb_getDeclaredITDConstructors == null)
				cb_getDeclaredITDConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDConstructors);
			return cb_getDeclaredITDConstructors;
		}

		static IntPtr n_GetDeclaredITDConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDConstructors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDConstructors' and count(parameter)=0]"
		[Register ("getDeclaredITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetDeclaredITDConstructorsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetDeclaredITDConstructors ()
		{
			const string __id = "getDeclaredITDConstructors.()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration));
			} finally {
			}
		}

		static Delegate cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDField (name, target));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register ("getDeclaredITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetDeclaredITDField (string name, global::Org.Aspectj.Lang.Reflect.IAjType target)
		{
			const string __id = "getDeclaredITDField.(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_getDeclaredITDFields;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDFieldsHandler ()
		{
			if (cb_getDeclaredITDFields == null)
				cb_getDeclaredITDFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDFields);
			return cb_getDeclaredITDFields;
		}

		static IntPtr n_GetDeclaredITDFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDFields ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDFields' and count(parameter)=0]"
		[Register ("getDeclaredITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetDeclaredITDFieldsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetDeclaredITDFields ()
		{
			const string __id = "getDeclaredITDFields.()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration));
			} finally {
			}
		}

		static Delegate cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_target, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDMethod (name, target, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetDeclaredITDMethod (string name, global::Org.Aspectj.Lang.Reflect.IAjType target, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getDeclaredITDMethod.(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getDeclaredITDMethods;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDMethodsHandler ()
		{
			if (cb_getDeclaredITDMethods == null)
				cb_getDeclaredITDMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDMethods);
			return cb_getDeclaredITDMethods;
		}

		static IntPtr n_GetDeclaredITDMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredITDMethods' and count(parameter)=0]"
		[Register ("getDeclaredITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetDeclaredITDMethodsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetDeclaredITDMethods ()
		{
			const string __id = "getDeclaredITDMethods.()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration));
			} finally {
			}
		}

		static Delegate cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredMethod (name, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;", "GetGetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Method GetDeclaredMethod (string name, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getDeclaredMethod.(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getDeclaredMethods;
#pragma warning disable 0169
		static Delegate GetGetDeclaredMethodsHandler ()
		{
			if (cb_getDeclaredMethods == null)
				cb_getDeclaredMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredMethods);
			return cb_getDeclaredMethods;
		}

		static IntPtr n_GetDeclaredMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredMethods' and count(parameter)=0]"
		[Register ("getDeclaredMethods", "()[Ljava/lang/reflect/Method;", "GetGetDeclaredMethodsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Method[] GetDeclaredMethods ()
		{
			const string __id = "getDeclaredMethods.()[Ljava/lang/reflect/Method;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
			} finally {
			}
		}

		static Delegate cb_getDeclaredPointcut_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredPointcut_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredPointcut_Ljava_lang_String_ == null)
				cb_getDeclaredPointcut_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredPointcut_Ljava_lang_String_);
			return cb_getDeclaredPointcut_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredPointcut_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredPointcut (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredPointcut' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;", "GetGetDeclaredPointcut_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcut GetDeclaredPointcut (string name)
		{
			const string __id = "getDeclaredPointcut.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDeclaredPointcuts;
#pragma warning disable 0169
		static Delegate GetGetDeclaredPointcutsHandler ()
		{
			if (cb_getDeclaredPointcuts == null)
				cb_getDeclaredPointcuts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredPointcuts);
			return cb_getDeclaredPointcuts;
		}

		static IntPtr n_GetDeclaredPointcuts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredPointcuts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getDeclaredPointcuts' and count(parameter)=0]"
		[Register ("getDeclaredPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;", "GetGetDeclaredPointcutsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcut[] GetDeclaredPointcuts ()
		{
			const string __id = "getDeclaredPointcuts.()[Lorg/aspectj/lang/reflect/Pointcut;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IPointcut[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IPointcut));
			} finally {
			}
		}

		static Delegate cb_getEnumConstants;
#pragma warning disable 0169
		static Delegate GetGetEnumConstantsHandler ()
		{
			if (cb_getEnumConstants == null)
				cb_getEnumConstants = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnumConstants);
			return cb_getEnumConstants;
		}

		static IntPtr n_GetEnumConstants (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnumConstants ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getEnumConstants' and count(parameter)=0]"
		[Register ("getEnumConstants", "()[Ljava/lang/Object;", "GetGetEnumConstantsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetEnumConstants ()
		{
			const string __id = "getEnumConstants.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_getField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetField_Ljava_lang_String_Handler ()
		{
			if (cb_getField_Ljava_lang_String_ == null)
				cb_getField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetField_Ljava_lang_String_);
			return cb_getField_Ljava_lang_String_;
		}

		static IntPtr n_GetField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetField (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", "GetGetField_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Field GetField (string name)
		{
			const string __id = "getField.(Ljava/lang/String;)Ljava/lang/reflect/Field;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getFields;
#pragma warning disable 0169
		static Delegate GetGetFieldsHandler ()
		{
			if (cb_getFields == null)
				cb_getFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFields);
			return cb_getFields;
		}

		static IntPtr n_GetFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFields ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getFields' and count(parameter)=0]"
		[Register ("getFields", "()[Ljava/lang/reflect/Field;", "GetGetFieldsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Field[] GetFields ()
		{
			const string __id = "getFields.()[Ljava/lang/reflect/Field;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
			} finally {
			}
		}

		static Delegate cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDConstructor (target, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDConstructor' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType target, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getITDConstructor.(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getITDConstructors;
#pragma warning disable 0169
		static Delegate GetGetITDConstructorsHandler ()
		{
			if (cb_getITDConstructors == null)
				cb_getITDConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDConstructors);
			return cb_getITDConstructors;
		}

		static IntPtr n_GetITDConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDConstructors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDConstructors' and count(parameter)=0]"
		[Register ("getITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetITDConstructorsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetITDConstructors ()
		{
			const string __id = "getITDConstructors.()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration));
			} finally {
			}
		}

		static Delegate cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_);
			return cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDField (name, target));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register ("getITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetITDField (string name, global::Org.Aspectj.Lang.Reflect.IAjType target)
		{
			const string __id = "getITDField.(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_getITDFields;
#pragma warning disable 0169
		static Delegate GetGetITDFieldsHandler ()
		{
			if (cb_getITDFields == null)
				cb_getITDFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDFields);
			return cb_getITDFields;
		}

		static IntPtr n_GetITDFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDFields ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDFields' and count(parameter)=0]"
		[Register ("getITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetITDFieldsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetITDFields ()
		{
			const string __id = "getITDFields.()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration));
			} finally {
			}
		}

		static Delegate cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_target, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var target = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_target, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDMethod (name, target, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetITDMethod (string name, global::Org.Aspectj.Lang.Reflect.IAjType target, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getITDMethod.(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getITDMethods;
#pragma warning disable 0169
		static Delegate GetGetITDMethodsHandler ()
		{
			if (cb_getITDMethods == null)
				cb_getITDMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDMethods);
			return cb_getITDMethods;
		}

		static IntPtr n_GetITDMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getITDMethods' and count(parameter)=0]"
		[Register ("getITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetITDMethodsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetITDMethods ()
		{
			const string __id = "getITDMethods.()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration));
			} finally {
			}
		}

		static Delegate cb_getInterfaces;
#pragma warning disable 0169
		static Delegate GetGetInterfacesHandler ()
		{
			if (cb_getInterfaces == null)
				cb_getInterfaces = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInterfaces);
			return cb_getInterfaces;
		}

		static IntPtr n_GetInterfaces (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInterfaces ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getInterfaces' and count(parameter)=0]"
		[Register ("getInterfaces", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetInterfacesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetInterfaces ()
		{
			const string __id = "getInterfaces.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
		}

		static Delegate cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_parameterTypes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var parameterTypes = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_parameterTypes, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMethod (name, parameterTypes));
			if (parameterTypes != null)
				JNIEnv.CopyArray (parameterTypes, native_parameterTypes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;", "GetGetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler")]
		public virtual unsafe global::Java.Lang.Reflect.Method GetMethod (string name, params global::Org.Aspectj.Lang.Reflect.IAjType[] parameterTypes)
		{
			const string __id = "getMethod.(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_parameterTypes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				global::System.GC.KeepAlive (parameterTypes);
			}
		}

		static Delegate cb_getMethods;
#pragma warning disable 0169
		static Delegate GetGetMethodsHandler ()
		{
			if (cb_getMethods == null)
				cb_getMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMethods);
			return cb_getMethods;
		}

		static IntPtr n_GetMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMethods ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getMethods' and count(parameter)=0]"
		[Register ("getMethods", "()[Ljava/lang/reflect/Method;", "GetGetMethodsHandler")]
		public virtual unsafe global::Java.Lang.Reflect.Method[] GetMethods ()
		{
			const string __id = "getMethods.()[Ljava/lang/reflect/Method;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
			} finally {
			}
		}

		static Delegate cb_getPointcut_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPointcut_Ljava_lang_String_Handler ()
		{
			if (cb_getPointcut_Ljava_lang_String_ == null)
				cb_getPointcut_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPointcut_Ljava_lang_String_);
			return cb_getPointcut_Ljava_lang_String_;
		}

		static IntPtr n_GetPointcut_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPointcut (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getPointcut' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;", "GetGetPointcut_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcut GetPointcut (string name)
		{
			const string __id = "getPointcut.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getPointcuts;
#pragma warning disable 0169
		static Delegate GetGetPointcutsHandler ()
		{
			if (cb_getPointcuts == null)
				cb_getPointcuts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPointcuts);
			return cb_getPointcuts;
		}

		static IntPtr n_GetPointcuts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPointcuts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getPointcuts' and count(parameter)=0]"
		[Register ("getPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;", "GetGetPointcutsHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcut[] GetPointcuts ()
		{
			const string __id = "getPointcuts.()[Lorg/aspectj/lang/reflect/Pointcut;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IPointcut[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IPointcut));
			} finally {
			}
		}

		static Delegate cb_getTypeParameters;
#pragma warning disable 0169
		static Delegate GetGetTypeParametersHandler ()
		{
			if (cb_getTypeParameters == null)
				cb_getTypeParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeParameters);
			return cb_getTypeParameters;
		}

		static IntPtr n_GetTypeParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTypeParameters ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='getTypeParameters' and count(parameter)=0]"
		[Register ("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", "GetGetTypeParametersHandler")]
		public virtual unsafe global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters ()
		{
			const string __id = "getTypeParameters.()[Ljava/lang/reflect/TypeVariable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.ITypeVariable[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.ITypeVariable));
			} finally {
			}
		}

		static Delegate cb_isAnnotationPresent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetIsAnnotationPresent_Ljava_lang_Class_Handler ()
		{
			if (cb_isAnnotationPresent_Ljava_lang_Class_ == null)
				cb_isAnnotationPresent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsAnnotationPresent_Ljava_lang_Class_);
			return cb_isAnnotationPresent_Ljava_lang_Class_;
		}

		static bool n_IsAnnotationPresent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAnnotationPresent (annotationType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isAnnotationPresent' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.annotation.Annotation&gt;']]"
		[Register ("isAnnotationPresent", "(Ljava/lang/Class;)Z", "GetIsAnnotationPresent_Ljava_lang_Class_Handler")]
		public virtual unsafe bool IsAnnotationPresent (global::Java.Lang.Class annotationType)
		{
			const string __id = "isAnnotationPresent.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotationType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (annotationType);
			}
		}

		static Delegate cb_isInstance_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsInstance_Ljava_lang_Object_Handler ()
		{
			if (cb_isInstance_Ljava_lang_Object_ == null)
				cb_isInstance_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsInstance_Ljava_lang_Object_);
			return cb_isInstance_Ljava_lang_Object_;
		}

		static bool n_IsInstance_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.AjTypeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInstance (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='AjTypeImpl']/method[@name='isInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isInstance", "(Ljava/lang/Object;)Z", "GetIsInstance_Ljava_lang_Object_Handler")]
		public virtual unsafe bool IsInstance (global::Java.Lang.Object o)
		{
			const string __id = "isInstance.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

	}
}
