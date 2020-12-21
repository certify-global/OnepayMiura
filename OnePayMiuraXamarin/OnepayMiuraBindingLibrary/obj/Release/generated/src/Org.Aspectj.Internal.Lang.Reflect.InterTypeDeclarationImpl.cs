using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/InterTypeDeclarationImpl", DoNotGenerateAcw=true)]
	public partial class InterTypeDeclarationImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IInterTypeDeclaration {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/field[@name='targetTypeName']"
		[Register ("targetTypeName")]
		protected string TargetTypeName {
			get {
				const string __id = "targetTypeName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "targetTypeName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/InterTypeDeclarationImpl", typeof (InterTypeDeclarationImpl));
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

		protected InterTypeDeclarationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/constructor[@name='InterTypeDeclarationImpl' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;I)V", "")]
		public unsafe InterTypeDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, string target, int mods)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_target = JNIEnv.NewString (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue (native_target);
				__args [2] = new JniArgumentValue (mods);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
				global::System.GC.KeepAlive (decType);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/constructor[@name='InterTypeDeclarationImpl' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;I)V", "")]
		public unsafe InterTypeDeclarationImpl (global::Org.Aspectj.Lang.Reflect.IAjType decType, global::Org.Aspectj.Lang.Reflect.IAjType targetType, int mods)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/AjType;Lorg/aspectj/lang/reflect/AjType;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((decType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decType).Handle);
				__args [1] = new JniArgumentValue ((targetType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetType).Handle);
				__args [2] = new JniArgumentValue (mods);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (decType);
				global::System.GC.KeepAlive (targetType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		public virtual unsafe int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/method[@name='getModifiers' and count(parameter)=0]"
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

		static Delegate cb_getTargetType;
#pragma warning disable 0169
		static Delegate GetGetTargetTypeHandler ()
		{
			if (cb_getTargetType == null)
				cb_getTargetType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetType);
			return cb_getTargetType;
		}

		static IntPtr n_GetTargetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.InterTypeDeclarationImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType TargetType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='InterTypeDeclarationImpl']/method[@name='getTargetType' and count(parameter)=0]"
			[Register ("getTargetType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetTargetTypeHandler")]
			get {
				const string __id = "getTargetType.()Lorg/aspectj/lang/reflect/AjType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
