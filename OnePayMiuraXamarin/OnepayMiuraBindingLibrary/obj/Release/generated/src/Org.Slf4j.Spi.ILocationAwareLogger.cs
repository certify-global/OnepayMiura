using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Spi {

	[Register ("org/slf4j/spi/LocationAwareLogger", DoNotGenerateAcw=true)]
	public abstract class LocationAwareLogger : Java.Lang.Object {

		internal LocationAwareLogger ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/field[@name='DEBUG_INT']"
		[Register ("DEBUG_INT")]
		public const int DebugInt = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/field[@name='ERROR_INT']"
		[Register ("ERROR_INT")]
		public const int ErrorInt = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/field[@name='INFO_INT']"
		[Register ("INFO_INT")]
		public const int InfoInt = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/field[@name='TRACE_INT']"
		[Register ("TRACE_INT")]
		public const int TraceInt = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/field[@name='WARN_INT']"
		[Register ("WARN_INT")]
		public const int WarnInt = (int) 30;

		// The following are fields from: org.slf4j.Logger

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Logger']/field[@name='ROOT_LOGGER_NAME']"
		[Register ("ROOT_LOGGER_NAME")]
		public const string RootLoggerName = (string) "ROOT";
	}

	[Register ("org/slf4j/spi/LocationAwareLogger", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LocationAwareLogger' type. This type will be removed in a future release.", error: true)]
	public abstract class LocationAwareLoggerConsts : LocationAwareLogger {

		private LocationAwareLoggerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']"
	[Register ("org/slf4j/spi/LocationAwareLogger", "", "Org.Slf4j.Spi.ILocationAwareLoggerInvoker")]
	public partial interface ILocationAwareLogger : global::Org.Slf4j.ILogger {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LocationAwareLogger']/method[@name='log' and count(parameter)=6 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]'] and parameter[6][@type='java.lang.Throwable']]"
		[Register ("log", "(Lorg/slf4j/Marker;Ljava/lang/String;ILjava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetLog_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Slf4j.Spi.ILocationAwareLoggerInvoker, OnepayMiuraBindingLibrary")]
		void Log (global::Org.Slf4j.IMarker p0, string p1, int p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5);

	}

	[global::Android.Runtime.Register ("org/slf4j/spi/LocationAwareLogger", DoNotGenerateAcw=true)]
	internal partial class ILocationAwareLoggerInvoker : global::Java.Lang.Object, ILocationAwareLogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/spi/LocationAwareLogger", typeof (ILocationAwareLoggerInvoker));

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

		public static ILocationAwareLogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationAwareLogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.spi.LocationAwareLogger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationAwareLoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLILLL_V) n_Log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			var p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Log (global::Org.Slf4j.IMarker p0, string p1, int p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5)
		{
			if (id_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Lorg/slf4j/Marker;Ljava/lang/String;ILjava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Lorg_slf4j_Marker_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_isDebugEnabled;
#pragma warning disable 0169
		static Delegate GetIsDebugEnabledHandler ()
		{
			if (cb_isDebugEnabled == null)
				cb_isDebugEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDebugEnabled);
			return cb_isDebugEnabled;
		}

		static bool n_IsDebugEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDebugEnabled;
		public unsafe bool IsDebugEnabled {
			get {
				if (id_isDebugEnabled == IntPtr.Zero)
					id_isDebugEnabled = JNIEnv.GetMethodID (class_ref, "isDebugEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDebugEnabled);
			}
		}

		static Delegate cb_isErrorEnabled;
#pragma warning disable 0169
		static Delegate GetIsErrorEnabledHandler ()
		{
			if (cb_isErrorEnabled == null)
				cb_isErrorEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsErrorEnabled);
			return cb_isErrorEnabled;
		}

		static bool n_IsErrorEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsErrorEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isErrorEnabled;
		public unsafe bool IsErrorEnabled {
			get {
				if (id_isErrorEnabled == IntPtr.Zero)
					id_isErrorEnabled = JNIEnv.GetMethodID (class_ref, "isErrorEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isErrorEnabled);
			}
		}

		static Delegate cb_isInfoEnabled;
#pragma warning disable 0169
		static Delegate GetIsInfoEnabledHandler ()
		{
			if (cb_isInfoEnabled == null)
				cb_isInfoEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInfoEnabled);
			return cb_isInfoEnabled;
		}

		static bool n_IsInfoEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfoEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isInfoEnabled;
		public unsafe bool IsInfoEnabled {
			get {
				if (id_isInfoEnabled == IntPtr.Zero)
					id_isInfoEnabled = JNIEnv.GetMethodID (class_ref, "isInfoEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInfoEnabled);
			}
		}

		static Delegate cb_isTraceEnabled;
#pragma warning disable 0169
		static Delegate GetIsTraceEnabledHandler ()
		{
			if (cb_isTraceEnabled == null)
				cb_isTraceEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTraceEnabled);
			return cb_isTraceEnabled;
		}

		static bool n_IsTraceEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isTraceEnabled;
		public unsafe bool IsTraceEnabled {
			get {
				if (id_isTraceEnabled == IntPtr.Zero)
					id_isTraceEnabled = JNIEnv.GetMethodID (class_ref, "isTraceEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTraceEnabled);
			}
		}

		static Delegate cb_isWarnEnabled;
#pragma warning disable 0169
		static Delegate GetIsWarnEnabledHandler ()
		{
			if (cb_isWarnEnabled == null)
				cb_isWarnEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsWarnEnabled);
			return cb_isWarnEnabled;
		}

		static bool n_IsWarnEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWarnEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isWarnEnabled;
		public unsafe bool IsWarnEnabled {
			get {
				if (id_isWarnEnabled == IntPtr.Zero)
					id_isWarnEnabled = JNIEnv.GetMethodID (class_ref, "isWarnEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWarnEnabled);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Handler ()
		{
			if (cb_debug_Ljava_lang_String_ == null)
				cb_debug_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Debug_Ljava_lang_String_);
			return cb_debug_Ljava_lang_String_;
		}

		static void n_Debug_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_;
		public unsafe void Debug (string p0)
		{
			if (id_debug_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_debug_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Ljava_lang_String_Ljava_lang_Object_);
			return cb_debug_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Debug (string p0, global::Java.Lang.Object p1)
		{
			if (id_debug_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Debug (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Debug (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Debug (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_debug_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_debug_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_debug_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_debug_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Debug_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Debug (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_debug_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_debug_Lorg_slf4j_Marker_Ljava_lang_String_;
		public unsafe void Debug (global::Org.Slf4j.IMarker p0, string p1)
		{
			if (id_debug_Lorg_slf4j_Marker_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Lorg_slf4j_Marker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "debug", "(Lorg/slf4j/Marker;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Lorg_slf4j_Marker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Debug (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Debug (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Debug (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Debug (global::Org.Slf4j.IMarker p0, string p1, params global::Java.Lang.Object[] p2)
		{
			if (id_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "debug", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Debug (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_error_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Handler ()
		{
			if (cb_error_Ljava_lang_String_ == null)
				cb_error_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Error_Ljava_lang_String_);
			return cb_error_Ljava_lang_String_;
		}

		static void n_Error_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_;
		public unsafe void Error (string p0)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_error_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_Ljava_lang_Object_);
			return cb_error_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Error (string p0, global::Java.Lang.Object p1)
		{
			if (id_error_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_error_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Error (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Error (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_error_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_error_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_error_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_error_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_error_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Error_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Error (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_error_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_error_Lorg_slf4j_Marker_Ljava_lang_String_;
		public unsafe void Error (global::Org.Slf4j.IMarker p0, string p1)
		{
			if (id_error_Lorg_slf4j_Marker_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Lorg_slf4j_Marker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/slf4j/Marker;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Lorg_slf4j_Marker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Error (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Error (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Error (global::Org.Slf4j.IMarker p0, string p1, params global::Java.Lang.Object[] p2)
		{
			if (id_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Error (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_info_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Info_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_;
		public unsafe void Info (string p0)
		{
			if (id_info_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_Ljava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Info (string p0, global::Java.Lang.Object p1)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Info (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Info (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_info_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_info_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Info (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_info_Lorg_slf4j_Marker_Ljava_lang_String_;
		public unsafe void Info (global::Org.Slf4j.IMarker p0, string p1)
		{
			if (id_info_Lorg_slf4j_Marker_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Lorg_slf4j_Marker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "info", "(Lorg/slf4j/Marker;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Lorg_slf4j_Marker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Info (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Info (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Info (global::Org.Slf4j.IMarker p0, string p1, params global::Java.Lang.Object[] p2)
		{
			if (id_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Info (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_isDebugEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsDebugEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isDebugEnabled_Lorg_slf4j_Marker_ == null)
				cb_isDebugEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsDebugEnabled_Lorg_slf4j_Marker_);
			return cb_isDebugEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsDebugEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsDebugEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isDebugEnabled_Lorg_slf4j_Marker_;
		public unsafe bool InvokeIsDebugEnabled (global::Org.Slf4j.IMarker p0)
		{
			if (id_isDebugEnabled_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_isDebugEnabled_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "isDebugEnabled", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDebugEnabled_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_isErrorEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsErrorEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isErrorEnabled_Lorg_slf4j_Marker_ == null)
				cb_isErrorEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsErrorEnabled_Lorg_slf4j_Marker_);
			return cb_isErrorEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsErrorEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsErrorEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isErrorEnabled_Lorg_slf4j_Marker_;
		public unsafe bool InvokeIsErrorEnabled (global::Org.Slf4j.IMarker p0)
		{
			if (id_isErrorEnabled_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_isErrorEnabled_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "isErrorEnabled", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isErrorEnabled_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_isInfoEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsInfoEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isInfoEnabled_Lorg_slf4j_Marker_ == null)
				cb_isInfoEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsInfoEnabled_Lorg_slf4j_Marker_);
			return cb_isInfoEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsInfoEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsInfoEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isInfoEnabled_Lorg_slf4j_Marker_;
		public unsafe bool InvokeIsInfoEnabled (global::Org.Slf4j.IMarker p0)
		{
			if (id_isInfoEnabled_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_isInfoEnabled_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "isInfoEnabled", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInfoEnabled_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_isTraceEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsTraceEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isTraceEnabled_Lorg_slf4j_Marker_ == null)
				cb_isTraceEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsTraceEnabled_Lorg_slf4j_Marker_);
			return cb_isTraceEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsTraceEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsTraceEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isTraceEnabled_Lorg_slf4j_Marker_;
		public unsafe bool InvokeIsTraceEnabled (global::Org.Slf4j.IMarker p0)
		{
			if (id_isTraceEnabled_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_isTraceEnabled_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "isTraceEnabled", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTraceEnabled_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_isWarnEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsWarnEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isWarnEnabled_Lorg_slf4j_Marker_ == null)
				cb_isWarnEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsWarnEnabled_Lorg_slf4j_Marker_);
			return cb_isWarnEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsWarnEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsWarnEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isWarnEnabled_Lorg_slf4j_Marker_;
		public unsafe bool InvokeIsWarnEnabled (global::Org.Slf4j.IMarker p0)
		{
			if (id_isWarnEnabled_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_isWarnEnabled_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "isWarnEnabled", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWarnEnabled_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_trace_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Handler ()
		{
			if (cb_trace_Ljava_lang_String_ == null)
				cb_trace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Trace_Ljava_lang_String_);
			return cb_trace_Ljava_lang_String_;
		}

		static void n_Trace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0);
		}
#pragma warning restore 0169

		IntPtr id_trace_Ljava_lang_String_;
		public unsafe void Trace (string p0)
		{
			if (id_trace_Ljava_lang_String_ == IntPtr.Zero)
				id_trace_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trace", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trace_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Ljava_lang_String_Ljava_lang_Object_);
			return cb_trace_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_trace_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Trace (string p0, global::Java.Lang.Object p1)
		{
			if (id_trace_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_trace_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Trace (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trace_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_trace_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Trace (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_trace_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Trace (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_trace_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_trace_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_trace_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trace_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_trace_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_trace_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Trace_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_trace_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Trace (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_trace_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_trace_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "trace", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_trace_Lorg_slf4j_Marker_Ljava_lang_String_;
		public unsafe void Trace (global::Org.Slf4j.IMarker p0, string p1)
		{
			if (id_trace_Lorg_slf4j_Marker_Ljava_lang_String_ == IntPtr.Zero)
				id_trace_Lorg_slf4j_Marker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trace", "(Lorg/slf4j/Marker;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Lorg_slf4j_Marker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Trace (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Trace (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Trace (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Trace (global::Org.Slf4j.IMarker p0, string p1, params global::Java.Lang.Object[] p2)
		{
			if (id_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "trace", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Trace (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_warn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Handler ()
		{
			if (cb_warn_Ljava_lang_String_ == null)
				cb_warn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Warn_Ljava_lang_String_);
			return cb_warn_Ljava_lang_String_;
		}

		static void n_Warn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_;
		public unsafe void Warn (string p0)
		{
			if (id_warn_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_warn_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Ljava_lang_String_Ljava_lang_Object_);
			return cb_warn_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Warn (string p0, global::Java.Lang.Object p1)
		{
			if (id_warn_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Warn (string p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warn (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Warn (string p0, params global::Java.Lang.Object[] p1)
		{
			if (id_warn_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_warn_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_warn_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_warn_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Warn_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Warn (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_warn_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_warn_Lorg_slf4j_Marker_Ljava_lang_String_;
		public unsafe void Warn (global::Org.Slf4j.IMarker p0, string p1)
		{
			if (id_warn_Lorg_slf4j_Marker_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Lorg_slf4j_Marker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "warn", "(Lorg/slf4j/Marker;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Lorg_slf4j_Marker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Warn (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2)
		{
			if (id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Warn (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3)
		{
			if (id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warn (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Warn (global::Org.Slf4j.IMarker p0, string p1, params global::Java.Lang.Object[] p2)
		{
			if (id_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warn", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILocationAwareLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Warn (global::Org.Slf4j.IMarker p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
