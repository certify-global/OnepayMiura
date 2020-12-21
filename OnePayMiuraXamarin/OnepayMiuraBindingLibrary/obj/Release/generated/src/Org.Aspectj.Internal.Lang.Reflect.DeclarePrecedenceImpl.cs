using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/DeclarePrecedenceImpl", DoNotGenerateAcw=true)]
	public partial class DeclarePrecedenceImpl : global::Java.Lang.Object, global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/DeclarePrecedenceImpl", typeof (DeclarePrecedenceImpl));
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

		protected DeclarePrecedenceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/constructor[@name='DeclarePrecedenceImpl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V", "")]
		public unsafe DeclarePrecedenceImpl (string precedenceList, global::Org.Aspectj.Lang.Reflect.IAjType declaring)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_precedenceList = JNIEnv.NewString (precedenceList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_precedenceList);
				__args [1] = new JniArgumentValue ((declaring == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaring).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_precedenceList);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclarePrecedenceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/method[@name='getDeclaringType' and count(parameter)=0]"
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

		static Delegate cb_getPrecedenceOrder;
#pragma warning disable 0169
		static Delegate GetGetPrecedenceOrderHandler ()
		{
			if (cb_getPrecedenceOrder == null)
				cb_getPrecedenceOrder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrecedenceOrder);
			return cb_getPrecedenceOrder;
		}

		static IntPtr n_GetPrecedenceOrder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.DeclarePrecedenceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrecedenceOrder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='DeclarePrecedenceImpl']/method[@name='getPrecedenceOrder' and count(parameter)=0]"
		[Register ("getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;", "GetGetPrecedenceOrderHandler")]
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern[] GetPrecedenceOrder ()
		{
			const string __id = "getPrecedenceOrder.()[Lorg/aspectj/lang/reflect/TypePattern;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Aspectj.Lang.Reflect.ITypePattern[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.ITypePattern));
			} finally {
			}
		}

	}
}
