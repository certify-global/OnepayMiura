using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j']/interface[@name='ILoggerFactory']"
	[Register ("org/slf4j/ILoggerFactory", "", "Org.Slf4j.ILoggerFactoryInvoker")]
	public partial interface ILoggerFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='ILoggerFactory']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLogger", "(Ljava/lang/String;)Lorg/slf4j/Logger;", "GetGetLogger_Ljava_lang_String_Handler:Org.Slf4j.ILoggerFactoryInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Slf4j.ILogger GetLogger (string p0);

	}

	[global::Android.Runtime.Register ("org/slf4j/ILoggerFactory", DoNotGenerateAcw=true)]
	internal partial class ILoggerFactoryInvoker : global::Java.Lang.Object, ILoggerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/ILoggerFactory", typeof (ILoggerFactoryInvoker));

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

		public static ILoggerFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.ILoggerFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLogger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLogger_Ljava_lang_String_Handler ()
		{
			if (cb_getLogger_Ljava_lang_String_ == null)
				cb_getLogger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetLogger_Ljava_lang_String_);
			return cb_getLogger_Ljava_lang_String_;
		}

		static IntPtr n_GetLogger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLogger (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLogger_Ljava_lang_String_;
		public unsafe global::Org.Slf4j.ILogger GetLogger (string p0)
		{
			if (id_getLogger_Ljava_lang_String_ == IntPtr.Zero)
				id_getLogger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLogger", "(Ljava/lang/String;)Lorg/slf4j/Logger;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILogger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogger_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
