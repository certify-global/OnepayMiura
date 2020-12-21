using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Spi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']"
	[Register ("org/slf4j/spi/MDCAdapter", "", "Org.Slf4j.Spi.IMDCAdapterInvoker")]
	public partial interface IMDCAdapter : IJavaObject, IJavaPeerable {

		global::System.Collections.Generic.IDictionary<string, string> CopyOfContextMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='getCopyOfContextMap' and count(parameter)=0]"
			[Register ("getCopyOfContextMap", "()Ljava/util/Map;", "GetGetCopyOfContextMapHandler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")]
		string Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")]
		void Put (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")]
		void Remove (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MDCAdapter']/method[@name='setContextMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setContextMap", "(Ljava/util/Map;)V", "GetSetContextMap_Ljava_util_Map_Handler:Org.Slf4j.Spi.IMDCAdapterInvoker, OnepayMiuraBindingLibrary")]
		void SetContextMap (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("org/slf4j/spi/MDCAdapter", DoNotGenerateAcw=true)]
	internal partial class IMDCAdapterInvoker : global::Java.Lang.Object, IMDCAdapter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/spi/MDCAdapter", typeof (IMDCAdapterInvoker));

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

		public static IMDCAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMDCAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.spi.MDCAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMDCAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCopyOfContextMap;
#pragma warning disable 0169
		static Delegate GetGetCopyOfContextMapHandler ()
		{
			if (cb_getCopyOfContextMap == null)
				cb_getCopyOfContextMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCopyOfContextMap);
			return cb_getCopyOfContextMap;
		}

		static IntPtr n_GetCopyOfContextMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CopyOfContextMap);
		}
#pragma warning restore 0169

		IntPtr id_getCopyOfContextMap;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> CopyOfContextMap {
			get {
				if (id_getCopyOfContextMap == IntPtr.Zero)
					id_getCopyOfContextMap = JNIEnv.GetMethodID (class_ref, "getCopyOfContextMap", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCopyOfContextMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setContextMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetContextMap_Ljava_util_Map_Handler ()
		{
			if (cb_setContextMap_Ljava_util_Map_ == null)
				cb_setContextMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContextMap_Ljava_util_Map_);
			return cb_setContextMap_Ljava_util_Map_;
		}

		static void n_SetContextMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContextMap (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContextMap_Ljava_util_Map_;
		public unsafe void SetContextMap (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setContextMap_Ljava_util_Map_ == IntPtr.Zero)
				id_setContextMap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setContextMap", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContextMap_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
