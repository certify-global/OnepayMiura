using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclareParentsImpl", DoNotGenerateAcw=true)]
	public partial class DeclareParentsImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclareParents {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/DeclareParentsImpl", typeof (DeclareParentsImpl));
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

		protected DeclareParentsImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/constructor[@name='DeclareParentsImpl' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V", "")]
		public unsafe DeclareParentsImpl (string targets, string parentsAsString, bool isExtends, global::Org.Aspectj.Lang.Reflect.IAjType declaring)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;ZLorg/aspectj/lang/reflect/AjType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_targets = JNIEnv.NewString (targets);
			IntPtr native_parentsAsString = JNIEnv.NewString (parentsAsString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_targets);
				__args [1] = new JniArgumentValue (native_parentsAsString);
				__args [2] = new JniArgumentValue (isExtends);
				__args [3] = new JniArgumentValue ((declaring == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaring).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targets);
				JNIEnv.DeleteLocalRef (native_parentsAsString);
				global::System.GC.KeepAlive (declaring);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExtends;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExtends {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='isExtends' and count(parameter)=0]"
			[Register ("isExtends", "()Z", "GetIsExtendsHandler")]
			get {
				const string __id = "isExtends.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isImplements;
#pragma warning disable 0169
		static Delegate GetIsImplementsHandler ()
		{
			if (cb_isImplements == null)
				cb_isImplements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsImplements);
			return cb_isImplements;
		}

		static bool n_IsImplements (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImplements;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsImplements {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='isImplements' and count(parameter)=0]"
			[Register ("isImplements", "()Z", "GetIsImplementsHandler")]
			get {
				const string __id = "isImplements.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTargetTypesPattern;
#pragma warning disable 0169
		static Delegate GetGetTargetTypesPatternHandler ()
		{
			if (cb_getTargetTypesPattern == null)
				cb_getTargetTypesPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetTypesPattern);
			return cb_getTargetTypesPattern;
		}

		static IntPtr n_GetTargetTypesPattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetTypesPattern);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TargetTypesPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getTargetTypesPattern' and count(parameter)=0]"
			[Register ("getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTargetTypesPatternHandler")]
			get {
				const string __id = "getTargetTypesPattern.()Lorg/aspectj/lang/reflect/TypePattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParentTypes;
#pragma warning disable 0169
		static Delegate GetGetParentTypesHandler ()
		{
			if (cb_getParentTypes == null)
				cb_getParentTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParentTypes);
			return cb_getParentTypes;
		}

		static IntPtr n_GetParentTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclareParentsImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParentTypes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclareParentsImpl']/method[@name='getParentTypes' and count(parameter)=0]"
		[Register ("getParentTypes", "()[Ljava/lang/reflect/Type;", "GetGetParentTypesHandler")]
		public virtual unsafe global::Java.Lang.Reflect.IType[] GetParentTypes ()
		{
			const string __id = "getParentTypes.()[Ljava/lang/reflect/Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
			}
		}

	}
}
