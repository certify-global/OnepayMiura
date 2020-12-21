using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.EnclosingStaticPart']"
	[Register ("org/aspectj/lang/JoinPoint$EnclosingStaticPart", "", "Org.Aspectj.Lang.IJoinPointEnclosingStaticPartInvoker")]
	public partial interface IJoinPointEnclosingStaticPart : global::Org.Aspectj.Lang.IJoinPointStaticPart {

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/JoinPoint$EnclosingStaticPart", DoNotGenerateAcw=true)]
	internal partial class IJoinPointEnclosingStaticPartInvoker : global::Java.Lang.Object, IJoinPointEnclosingStaticPart {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/JoinPoint$EnclosingStaticPart", typeof (IJoinPointEnclosingStaticPartInvoker));

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

		public static IJoinPointEnclosingStaticPart GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJoinPointEnclosingStaticPart> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.JoinPoint.EnclosingStaticPart"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJoinPointEnclosingStaticPartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe int Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']"
	[Register ("org/aspectj/lang/JoinPoint$StaticPart", "", "Org.Aspectj.Lang.IJoinPointStaticPartInvoker")]
	public partial interface IJoinPointStaticPart : IJavaObject, IJavaPeerable {

		int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Ljava/lang/String;", "GetGetKindHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.ISignature Signature {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='getSignature' and count(parameter)=0]"
			[Register ("getSignature", "()Lorg/aspectj/lang/Signature;", "GetGetSignatureHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.ISourceLocation SourceLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='getSourceLocation' and count(parameter)=0]"
			[Register ("getSourceLocation", "()Lorg/aspectj/lang/reflect/SourceLocation;", "GetGetSourceLocationHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='toLongString' and count(parameter)=0]"
		[Register ("toLongString", "()Ljava/lang/String;", "GetToLongStringHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")]
		string ToLongString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='toShortString' and count(parameter)=0]"
		[Register ("toShortString", "()Ljava/lang/String;", "GetToShortStringHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")]
		string ToShortString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint.StaticPart']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Org.Aspectj.Lang.IJoinPointStaticPartInvoker, OnepayMiuraBindingLibrary")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/JoinPoint$StaticPart", DoNotGenerateAcw=true)]
	internal partial class IJoinPointStaticPartInvoker : global::Java.Lang.Object, IJoinPointStaticPart {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/JoinPoint$StaticPart", typeof (IJoinPointStaticPartInvoker));

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

		public static IJoinPointStaticPart GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJoinPointStaticPart> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.JoinPoint.StaticPart"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJoinPointStaticPartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe int Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


	[Register ("org/aspectj/lang/JoinPoint", DoNotGenerateAcw=true)]
	public abstract class JoinPoint : Java.Lang.Object {

		internal JoinPoint ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='ADVICE_EXECUTION']"
		[Register ("ADVICE_EXECUTION")]
		public const string AdviceExecution = (string) "adviceexecution";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='CONSTRUCTOR_CALL']"
		[Register ("CONSTRUCTOR_CALL")]
		public const string ConstructorCall = (string) "constructor-call";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='CONSTRUCTOR_EXECUTION']"
		[Register ("CONSTRUCTOR_EXECUTION")]
		public const string ConstructorExecution = (string) "constructor-execution";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='EXCEPTION_HANDLER']"
		[Register ("EXCEPTION_HANDLER")]
		public const string ExceptionHandler = (string) "exception-handler";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='FIELD_GET']"
		[Register ("FIELD_GET")]
		public const string FieldGet = (string) "field-get";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='FIELD_SET']"
		[Register ("FIELD_SET")]
		public const string FieldSet = (string) "field-set";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='INITIALIZATION']"
		[Register ("INITIALIZATION")]
		public const string Initialization = (string) "initialization";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='METHOD_CALL']"
		[Register ("METHOD_CALL")]
		public const string MethodCall = (string) "method-call";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='METHOD_EXECUTION']"
		[Register ("METHOD_EXECUTION")]
		public const string MethodExecution = (string) "method-execution";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='PREINITIALIZATION']"
		[Register ("PREINITIALIZATION")]
		public const string Preinitialization = (string) "preinitialization";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='STATICINITIALIZATION']"
		[Register ("STATICINITIALIZATION")]
		public const string Staticinitialization = (string) "staticinitialization";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='SYNCHRONIZATION_LOCK']"
		[Register ("SYNCHRONIZATION_LOCK")]
		public const string SynchronizationLock = (string) "lock";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/field[@name='SYNCHRONIZATION_UNLOCK']"
		[Register ("SYNCHRONIZATION_UNLOCK")]
		public const string SynchronizationUnlock = (string) "unlock";
	}

	[Register ("org/aspectj/lang/JoinPoint", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'JoinPoint' type. This type will be removed in a future release.", error: true)]
	public abstract class JoinPointConsts : JoinPoint {

		private JoinPointConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']"
	[Register ("org/aspectj/lang/JoinPoint", "", "Org.Aspectj.Lang.IJoinPointInvoker")]
	public partial interface IJoinPoint : IJavaObject, IJavaPeerable {

		string Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Ljava/lang/String;", "GetGetKindHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.ISignature Signature {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getSignature' and count(parameter)=0]"
			[Register ("getSignature", "()Lorg/aspectj/lang/Signature;", "GetGetSignatureHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.ISourceLocation SourceLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getSourceLocation' and count(parameter)=0]"
			[Register ("getSourceLocation", "()Lorg/aspectj/lang/reflect/SourceLocation;", "GetGetSourceLocationHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.IJoinPointStaticPart StaticPart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getStaticPart' and count(parameter)=0]"
			[Register ("getStaticPart", "()Lorg/aspectj/lang/JoinPoint$StaticPart;", "GetGetStaticPartHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Object Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/Object;", "GetGetTargetHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Object This {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getThis' and count(parameter)=0]"
			[Register ("getThis", "()Ljava/lang/Object;", "GetGetThisHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='getArgs' and count(parameter)=0]"
		[Register ("getArgs", "()[Ljava/lang/Object;", "GetGetArgsHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Object[] GetArgs ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='toLongString' and count(parameter)=0]"
		[Register ("toLongString", "()Ljava/lang/String;", "GetToLongStringHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")]
		string ToLongString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='toShortString' and count(parameter)=0]"
		[Register ("toShortString", "()Ljava/lang/String;", "GetToShortStringHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")]
		string ToShortString ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/interface[@name='JoinPoint']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Org.Aspectj.Lang.IJoinPointInvoker, OnepayMiuraBindingLibrary")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/JoinPoint", DoNotGenerateAcw=true)]
	internal partial class IJoinPointInvoker : global::Java.Lang.Object, IJoinPoint {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/JoinPoint", typeof (IJoinPointInvoker));

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

		public static IJoinPoint GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJoinPoint> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.JoinPoint"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJoinPointInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
