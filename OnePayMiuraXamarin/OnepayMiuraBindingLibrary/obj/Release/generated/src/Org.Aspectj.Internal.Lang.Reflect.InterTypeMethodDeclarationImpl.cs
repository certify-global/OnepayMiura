using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeMethodDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeMethodDeclarationImpl : global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl, global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/InterTypeMethodDeclarationImpl", typeof (InterTypeMethodDeclarationImpl));
		internal static new IntPtr class_ref {
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

		protected InterTypeMethodDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/constructor[@name='InterTypeMethodDeclarationImpl' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.reflect.Method']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V", "")]
		public unsafe InterTypeMethodDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods, string name, global::Java.Lang.Reflect.Method itdInterMethod)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Ljava/lang/reflect/Method;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue (native_target);
				__args [2] = new JniArgumentValue (mods);
				__args [3] = new JniArgumentValue (native_name);
				__args [4] = new JniArgumentValue ((itdInterMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itdInterMethod).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (itdInterMethod);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/constructor[@name='InterTypeMethodDeclarationImpl' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Method'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V", "")]
		public unsafe InterTypeMethodDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, global::Org.Aspectj.Lang.Reflect.IAjType targetType, global::Java.Lang.Reflect.Method @base, int modifiers)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Method;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue ((targetType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetType).Handle);
				__args [2] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				__args [3] = new JniArgumentValue (modifiers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (targetType);
				global::System.GC.KeepAlive (@base);
			}
		}

		static Delegate cb_getGenericReturnType;
#pragma warning disable 0169
		static Delegate GetGetGenericReturnTypeHandler ()
		{
			if (cb_getGenericReturnType == null)
				cb_getGenericReturnType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericReturnType);
			return cb_getGenericReturnType;
		}

		static IntPtr n_GetGenericReturnType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericReturnType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.IType GenericReturnType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getGenericReturnType' and count(parameter)=0]"
			[Register ("getGenericReturnType", "()Ljava/lang/reflect/Type;", "GetGetGenericReturnTypeHandler")]
			get {
				const string __id = "getGenericReturnType.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReturnType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType ReturnType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getReturnType' and count(parameter)=0]"
			[Register ("getReturnType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetReturnTypeHandler")]
			get {
				const string __id = "getReturnType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExceptionTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getExceptionTypes' and count(parameter)=0]"
		[Register ("getExceptionTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetExceptionTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetExceptionTypes ()
		{
			const string __id = "getExceptionTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGenericParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getGenericParameterTypes' and count(parameter)=0]"
		[Register ("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", "GetGetGenericParameterTypesHandler")]
		public virtual unsafe global::Java.Lang.Reflect.IType[] GetGenericParameterTypes ()
		{
			const string __id = "getGenericParameterTypes.()[Ljava/lang/reflect/Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParameterTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getParameterTypes' and count(parameter)=0]"
		[Register ("getParameterTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetParameterTypesHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetParameterTypes ()
		{
			const string __id = "getParameterTypes.()[Lorg/aspectj/lang/reflect/AjType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeMethodDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTypeParameters ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeMethodDeclarationImpl']/method[@name='getTypeParameters' and count(parameter)=0]"
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

	}
}
