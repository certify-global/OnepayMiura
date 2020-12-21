using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j']/interface[@name='IMarkerFactory']"
	[Register ("org/slf4j/IMarkerFactory", "", "Org.Slf4j.IMarkerFactoryInvoker")]
	public partial interface IMarkerFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='IMarkerFactory']/method[@name='detachMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("detachMarker", "(Ljava/lang/String;)Z", "GetDetachMarker_Ljava_lang_String_Handler:Org.Slf4j.IMarkerFactoryInvoker, OnepayMiuraBindingLibrary")]
		bool DetachMarker (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='IMarkerFactory']/method[@name='exists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("exists", "(Ljava/lang/String;)Z", "GetExists_Ljava_lang_String_Handler:Org.Slf4j.IMarkerFactoryInvoker, OnepayMiuraBindingLibrary")]
		bool Exists (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='IMarkerFactory']/method[@name='getDetachedMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetachedMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "GetGetDetachedMarker_Ljava_lang_String_Handler:Org.Slf4j.IMarkerFactoryInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Slf4j.IMarker GetDetachedMarker (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='IMarkerFactory']/method[@name='getMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "GetGetMarker_Ljava_lang_String_Handler:Org.Slf4j.IMarkerFactoryInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Slf4j.IMarker GetMarker (string p0);

	}

	[global::Android.Runtime.Register ("org/slf4j/IMarkerFactory", DoNotGenerateAcw=true)]
	internal partial class IMarkerFactoryInvoker : global::Java.Lang.Object, IMarkerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/IMarkerFactory", typeof (IMarkerFactoryInvoker));

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

		public static IMarkerFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMarkerFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.IMarkerFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMarkerFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_detachMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDetachMarker_Ljava_lang_String_Handler ()
		{
			if (cb_detachMarker_Ljava_lang_String_ == null)
				cb_detachMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DetachMarker_Ljava_lang_String_);
			return cb_detachMarker_Ljava_lang_String_;
		}

		static bool n_DetachMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DetachMarker (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_detachMarker_Ljava_lang_String_;
		public unsafe bool DetachMarker (string p0)
		{
			if (id_detachMarker_Ljava_lang_String_ == IntPtr.Zero)
				id_detachMarker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "detachMarker", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_detachMarker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_exists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExists_Ljava_lang_String_Handler ()
		{
			if (cb_exists_Ljava_lang_String_ == null)
				cb_exists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Exists_Ljava_lang_String_);
			return cb_exists_Ljava_lang_String_;
		}

		static bool n_Exists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Exists (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exists_Ljava_lang_String_;
		public unsafe bool Exists (string p0)
		{
			if (id_exists_Ljava_lang_String_ == IntPtr.Zero)
				id_exists_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_exists_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDetachedMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDetachedMarker_Ljava_lang_String_Handler ()
		{
			if (cb_getDetachedMarker_Ljava_lang_String_ == null)
				cb_getDetachedMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDetachedMarker_Ljava_lang_String_);
			return cb_getDetachedMarker_Ljava_lang_String_;
		}

		static IntPtr n_GetDetachedMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDetachedMarker (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDetachedMarker_Ljava_lang_String_;
		public unsafe global::Org.Slf4j.IMarker GetDetachedMarker (string p0)
		{
			if (id_getDetachedMarker_Ljava_lang_String_ == IntPtr.Zero)
				id_getDetachedMarker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDetachedMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDetachedMarker_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMarker_Ljava_lang_String_Handler ()
		{
			if (cb_getMarker_Ljava_lang_String_ == null)
				cb_getMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMarker_Ljava_lang_String_);
			return cb_getMarker_Ljava_lang_String_;
		}

		static IntPtr n_GetMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMarker (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMarker_Ljava_lang_String_;
		public unsafe global::Org.Slf4j.IMarker GetMarker (string p0)
		{
			if (id_getMarker_Ljava_lang_String_ == IntPtr.Zero)
				id_getMarker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarker_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
