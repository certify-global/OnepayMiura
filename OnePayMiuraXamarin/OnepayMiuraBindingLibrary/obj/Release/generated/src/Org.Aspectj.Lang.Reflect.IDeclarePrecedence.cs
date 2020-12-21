using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclarePrecedence']"
	[Register ("org/aspectj/lang/reflect/DeclarePrecedence", "", "Org.Aspectj.Lang.Reflect.IDeclarePrecedenceInvoker")]
	public partial interface IDeclarePrecedence : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclarePrecedence']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IDeclarePrecedenceInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclarePrecedence']/method[@name='getPrecedenceOrder' and count(parameter)=0]"
		[Register ("getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;", "GetGetPrecedenceOrderHandler:Org.Aspectj.Lang.Reflect.IDeclarePrecedenceInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.ITypePattern[] GetPrecedenceOrder ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/DeclarePrecedence", DoNotGenerateAcw=true)]
	internal partial class IDeclarePrecedenceInvoker : global::Java.Lang.Object, IDeclarePrecedence {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/DeclarePrecedence", typeof (IDeclarePrecedenceInvoker));

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

		public static IDeclarePrecedence GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeclarePrecedence> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.DeclarePrecedence"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeclarePrecedenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrecedenceOrder ());
		}
#pragma warning restore 0169

		IntPtr id_getPrecedenceOrder;
		public unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern[] GetPrecedenceOrder ()
		{
			if (id_getPrecedenceOrder == IntPtr.Zero)
				id_getPrecedenceOrder = JNIEnv.GetMethodID (class_ref, "getPrecedenceOrder", "()[Lorg/aspectj/lang/reflect/TypePattern;");
			return (global::Org.Aspectj.Lang.Reflect.ITypePattern[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrecedenceOrder), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.ITypePattern));
		}

	}

}
