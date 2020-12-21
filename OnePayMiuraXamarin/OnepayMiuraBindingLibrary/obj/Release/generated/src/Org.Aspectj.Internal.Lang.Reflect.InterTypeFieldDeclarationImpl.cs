using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeFieldDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeFieldDeclarationImpl : global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl, global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/InterTypeFieldDeclarationImpl", typeof (InterTypeFieldDeclarationImpl));
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

		protected InterTypeFieldDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/constructor[@name='InterTypeFieldDeclarationImpl' and count(parameter)=6 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[6][@type='java.lang.reflect.Type']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V", "")]
		public unsafe InterTypeFieldDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods, string name, global::Org.Aspectj.Lang.Reflect.IAjType type, global::Java.Lang.Reflect.IType genericType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;ILjava/lang/String;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Type;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue (native_target);
				__args [2] = new JniArgumentValue (mods);
				__args [3] = new JniArgumentValue (native_name);
				__args [4] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [5] = new JniArgumentValue ((genericType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) genericType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (genericType);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/constructor[@name='InterTypeFieldDeclarationImpl' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Field']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V", "")]
		public unsafe InterTypeFieldDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, global::Org.Aspectj.Lang.Reflect.IAjType targetType, global::Java.Lang.Reflect.Field @base)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;Ljava/lang/reflect/Field;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue ((targetType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetType).Handle);
				__args [2] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (targetType);
				global::System.GC.KeepAlive (@base);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Reflect.IType GenericType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getGenericType' and count(parameter)=0]"
			[Register ("getGenericType", "()Ljava/lang/reflect/Type;", "GetGetGenericTypeHandler")]
			get {
				const string __id = "getGenericType.()Ljava/lang/reflect/Type;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeFieldDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeFieldDeclarationImpl']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
