using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='ProceedingJoinPoint']"
	[Register ("org/aspectj/lang/ProceedingJoinPoint", "", "Org.Aspectj.Lang.IProceedingJoinPointInvoker")]
	public partial interface IProceedingJoinPoint : global::Org.Aspectj.Lang.IJoinPoint {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='ProceedingJoinPoint']/method[@name='proceed' and count(parameter)=0]"
		[Register ("proceed", "()Ljava/lang/Object;", "GetProceedHandler:Org.Aspectj.Lang.IProceedingJoinPointInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Object Proceed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='ProceedingJoinPoint']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("proceed", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetProceed_arrayLjava_lang_Object_Handler:Org.Aspectj.Lang.IProceedingJoinPointInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Object Proceed (global::Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/ProceedingJoinPoint", DoNotGenerateAcw=true)]
	internal partial class IProceedingJoinPointInvoker : global::Java.Lang.Object, IProceedingJoinPoint {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/ProceedingJoinPoint", typeof (IProceedingJoinPointInvoker));

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

		public static IProceedingJoinPoint GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProceedingJoinPoint> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.ProceedingJoinPoint"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProceedingJoinPointInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_proceed;
#pragma warning disable 0169
		static Delegate GetProceedHandler ()
		{
			if (cb_proceed == null)
				cb_proceed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Proceed);
			return cb_proceed;
		}

		static IntPtr n_Proceed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Proceed ());
		}
#pragma warning restore 0169

		IntPtr id_proceed;
		public unsafe global::Java.Lang.Object Proceed ()
		{
			if (id_proceed == IntPtr.Zero)
				id_proceed = JNIEnv.GetMethodID (class_ref, "proceed", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proceed), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_proceed_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetProceed_arrayLjava_lang_Object_Handler ()
		{
			if (cb_proceed_arrayLjava_lang_Object_ == null)
				cb_proceed_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Proceed_arrayLjava_lang_Object_);
			return cb_proceed_arrayLjava_lang_Object_;
		}

		static IntPtr n_Proceed_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Proceed (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_proceed_arrayLjava_lang_Object_;
		public unsafe global::Java.Lang.Object Proceed (global::Java.Lang.Object[] p0)
		{
			if (id_proceed_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_proceed_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "proceed", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proceed_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind);
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		public unsafe string Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSignature;
#pragma warning disable 0169
		static Delegate GetGetSignatureHandler ()
		{
			if (cb_getSignature == null)
				cb_getSignature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignature);
			return cb_getSignature;
		}

		static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Signature);
		}
#pragma warning restore 0169

		IntPtr id_getSignature;
		public unsafe global::Org.Aspectj.Lang.ISignature Signature {
			get {
				if (id_getSignature == IntPtr.Zero)
					id_getSignature = JNIEnv.GetMethodID (class_ref, "getSignature", "()Lorg/aspectj/lang/Signature;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.ISignature> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignature), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSourceLocation;
#pragma warning disable 0169
		static Delegate GetGetSourceLocationHandler ()
		{
			if (cb_getSourceLocation == null)
				cb_getSourceLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSourceLocation);
			return cb_getSourceLocation;
		}

		static IntPtr n_GetSourceLocation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceLocation);
		}
#pragma warning restore 0169

		IntPtr id_getSourceLocation;
		public unsafe global::Org.Aspectj.Lang.Reflect.ISourceLocation SourceLocation {
			get {
				if (id_getSourceLocation == IntPtr.Zero)
					id_getSourceLocation = JNIEnv.GetMethodID (class_ref, "getSourceLocation", "()Lorg/aspectj/lang/reflect/SourceLocation;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourceLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStaticPart;
#pragma warning disable 0169
		static Delegate GetGetStaticPartHandler ()
		{
			if (cb_getStaticPart == null)
				cb_getStaticPart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStaticPart);
			return cb_getStaticPart;
		}

		static IntPtr n_GetStaticPart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StaticPart);
		}
#pragma warning restore 0169

		IntPtr id_getStaticPart;
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart StaticPart {
			get {
				if (id_getStaticPart == IntPtr.Zero)
					id_getStaticPart = JNIEnv.GetMethodID (class_ref, "getStaticPart", "()Lorg/aspectj/lang/JoinPoint$StaticPart;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStaticPart), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Target);
		}
#pragma warning restore 0169

		IntPtr id_getTarget;
		public unsafe global::Java.Lang.Object Target {
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThis;
#pragma warning disable 0169
		static Delegate GetGetThisHandler ()
		{
			if (cb_getThis == null)
				cb_getThis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThis);
			return cb_getThis;
		}

		static IntPtr n_GetThis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.This);
		}
#pragma warning restore 0169

		IntPtr id_getThis;
		public unsafe global::Java.Lang.Object This {
			get {
				if (id_getThis == IntPtr.Zero)
					id_getThis = JNIEnv.GetMethodID (class_ref, "getThis", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThis), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getArgs;
#pragma warning disable 0169
		static Delegate GetGetArgsHandler ()
		{
			if (cb_getArgs == null)
				cb_getArgs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArgs);
			return cb_getArgs;
		}

		static IntPtr n_GetArgs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArgs ());
		}
#pragma warning restore 0169

		IntPtr id_getArgs;
		public unsafe global::Java.Lang.Object[] GetArgs ()
		{
			if (id_getArgs == IntPtr.Zero)
				id_getArgs = JNIEnv.GetMethodID (class_ref, "getArgs", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArgs), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_toLongString;
#pragma warning disable 0169
		static Delegate GetToLongStringHandler ()
		{
			if (cb_toLongString == null)
				cb_toLongString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToLongString);
			return cb_toLongString;
		}

		static IntPtr n_ToLongString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToLongString ());
		}
#pragma warning restore 0169

		IntPtr id_toLongString;
		public unsafe string ToLongString ()
		{
			if (id_toLongString == IntPtr.Zero)
				id_toLongString = JNIEnv.GetMethodID (class_ref, "toLongString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toLongString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toShortString;
#pragma warning disable 0169
		static Delegate GetToShortStringHandler ()
		{
			if (cb_toShortString == null)
				cb_toShortString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToShortString);
			return cb_toShortString;
		}

		static IntPtr n_ToShortString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToShortString ());
		}
#pragma warning restore 0169

		IntPtr id_toShortString;
		public unsafe string ToShortString ()
		{
			if (id_toShortString == IntPtr.Zero)
				id_toShortString = JNIEnv.GetMethodID (class_ref, "toShortString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toShortString), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
