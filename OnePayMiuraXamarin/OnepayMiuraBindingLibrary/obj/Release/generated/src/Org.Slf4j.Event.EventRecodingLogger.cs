using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']"
	[global::Android.Runtime.Register ("org/slf4j/event/EventRecodingLogger", DoNotGenerateAcw=true)]
	public partial class EventRecodingLogger : global::Java.Lang.Object, global::Org.Slf4j.ILogger {


		public static class InterfaceConsts {

			// The following are fields from: org.slf4j.Logger

			// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Logger']/field[@name='ROOT_LOGGER_NAME']"
			[Register ("ROOT_LOGGER_NAME")]
			public const string RootLoggerName = (string) "ROOT";
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/event/EventRecodingLogger", typeof (EventRecodingLogger));
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

		protected EventRecodingLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/constructor[@name='EventRecodingLogger' and count(parameter)=2 and parameter[1][@type='org.slf4j.helpers.SubstituteLogger'] and parameter[2][@type='java.util.Queue&lt;org.slf4j.event.SubstituteLoggingEvent&gt;']]"
		[Register (".ctor", "(Lorg/slf4j/helpers/SubstituteLogger;Ljava/util/Queue;)V", "")]
		public unsafe EventRecodingLogger (global::Org.Slf4j.Helpers.SubstituteLogger logger, global::Java.Util.IQueue eventQueue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/slf4j/helpers/SubstituteLogger;Ljava/util/Queue;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				__args [1] = new JniArgumentValue ((eventQueue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventQueue).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (logger);
				global::System.GC.KeepAlive (eventQueue);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDebugEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "GetIsDebugEnabledHandler")]
			get {
				const string __id = "isDebugEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsErrorEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsErrorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isErrorEnabled' and count(parameter)=0]"
			[Register ("isErrorEnabled", "()Z", "GetIsErrorEnabledHandler")]
			get {
				const string __id = "isErrorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfoEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInfoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isInfoEnabled' and count(parameter)=0]"
			[Register ("isInfoEnabled", "()Z", "GetIsInfoEnabledHandler")]
			get {
				const string __id = "isInfoEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTraceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isTraceEnabled' and count(parameter)=0]"
			[Register ("isTraceEnabled", "()Z", "GetIsTraceEnabledHandler")]
			get {
				const string __id = "isTraceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWarnEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWarnEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isWarnEnabled' and count(parameter)=0]"
			[Register ("isWarnEnabled", "()Z", "GetIsWarnEnabledHandler")]
			get {
				const string __id = "isWarnEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_debug_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Handler ()
		{
			if (cb_debug_Ljava_lang_String_ == null)
				cb_debug_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Debug_Ljava_lang_String_);
			return cb_debug_Ljava_lang_String_;
		}

		static void n_Debug_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Debug (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "GetDebug_Ljava_lang_String_Handler")]
		public virtual unsafe void Debug (string msg)
		{
			const string __id = "debug.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Ljava_lang_String_Ljava_lang_Object_);
			return cb_debug_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Debug (format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetDebug_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Debug (string format, global::Java.Lang.Object arg)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Debug (format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetDebug_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Debug (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_debug_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_debug_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Debug_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Debug (format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetDebug_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Debug (string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "debug.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
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

		static void n_Debug_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Debug (msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDebug_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Debug (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Debug (marker, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String']]"
		[Register ("debug", "(Lorg/slf4j/Marker;Ljava/lang/String;)V", "GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Handler")]
		public virtual unsafe void Debug (global::Org.Slf4j.IMarker marker, string msg)
		{
			const string __id = "debug.(Lorg/slf4j/Marker;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Debug (marker, format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V", "GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Debug (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg)
		{
			const string __id = "debug.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Debug (marker, format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=4 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Debug (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "debug.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [3] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Debug (marker, format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("debug", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V", "GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Debug (global::Org.Slf4j.IMarker marker, string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "debug.(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arguments);
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

		static void n_Debug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Debug (marker, msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("debug", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDebug_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Debug (global::Org.Slf4j.IMarker marker, string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "debug.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_error_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Handler ()
		{
			if (cb_error_Ljava_lang_String_ == null)
				cb_error_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Error_Ljava_lang_String_);
			return cb_error_Ljava_lang_String_;
		}

		static void n_Error_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Error (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "GetError_Ljava_lang_String_Handler")]
		public virtual unsafe void Error (string msg)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_error_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_error_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_Ljava_lang_Object_);
			return cb_error_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Error (format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetError_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Error (string format, global::Java.Lang.Object arg)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Error (format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetError_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Error (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_error_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetError_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Error (string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "error.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
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

		static void n_Error_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Error (msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetError_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Error (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Error (marker, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String']]"
		[Register ("error", "(Lorg/slf4j/Marker;Ljava/lang/String;)V", "GetError_Lorg_slf4j_Marker_Ljava_lang_String_Handler")]
		public virtual unsafe void Error (global::Org.Slf4j.IMarker marker, string msg)
		{
			const string __id = "error.(Lorg/slf4j/Marker;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Error (marker, format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V", "GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Error (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg)
		{
			const string __id = "error.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Error (marker, format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=4 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Error (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "error.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [3] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Error (marker, format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("error", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V", "GetError_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Error (global::Org.Slf4j.IMarker marker, string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "error.(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arguments);
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

		static void n_Error_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Error (marker, msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("error", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetError_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Error (global::Org.Slf4j.IMarker marker, string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "error.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_info_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Info_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Info (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Handler")]
		public virtual unsafe void Info (string msg)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_Ljava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Info (format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Info (string format, global::Java.Lang.Object arg)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Info (format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Info (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Info (string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "info.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
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

		static void n_Info_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Info (msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetInfo_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Info (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Info (marker, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String']]"
		[Register ("info", "(Lorg/slf4j/Marker;Ljava/lang/String;)V", "GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Handler")]
		public virtual unsafe void Info (global::Org.Slf4j.IMarker marker, string msg)
		{
			const string __id = "info.(Lorg/slf4j/Marker;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Info (marker, format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V", "GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Info (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg)
		{
			const string __id = "info.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Info (marker, format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=4 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Info (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "info.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [3] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (marker, format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("info", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Info (global::Org.Slf4j.IMarker marker, string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "info.(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arguments);
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

		static void n_Info_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Info (marker, msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("info", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetInfo_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Info (global::Org.Slf4j.IMarker marker, string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "info.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_isDebugEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsDebugEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isDebugEnabled_Lorg_slf4j_Marker_ == null)
				cb_isDebugEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsDebugEnabled_Lorg_slf4j_Marker_);
			return cb_isDebugEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsDebugEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsDebugEnabled (marker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isDebugEnabled' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("isDebugEnabled", "(Lorg/slf4j/Marker;)Z", "GetInvokeIsDebugEnabled_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool InvokeIsDebugEnabled (global::Org.Slf4j.IMarker marker)
		{
			const string __id = "isDebugEnabled.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_isErrorEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsErrorEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isErrorEnabled_Lorg_slf4j_Marker_ == null)
				cb_isErrorEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsErrorEnabled_Lorg_slf4j_Marker_);
			return cb_isErrorEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsErrorEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsErrorEnabled (marker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isErrorEnabled' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("isErrorEnabled", "(Lorg/slf4j/Marker;)Z", "GetInvokeIsErrorEnabled_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool InvokeIsErrorEnabled (global::Org.Slf4j.IMarker marker)
		{
			const string __id = "isErrorEnabled.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_isInfoEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsInfoEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isInfoEnabled_Lorg_slf4j_Marker_ == null)
				cb_isInfoEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsInfoEnabled_Lorg_slf4j_Marker_);
			return cb_isInfoEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsInfoEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsInfoEnabled (marker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isInfoEnabled' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("isInfoEnabled", "(Lorg/slf4j/Marker;)Z", "GetInvokeIsInfoEnabled_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool InvokeIsInfoEnabled (global::Org.Slf4j.IMarker marker)
		{
			const string __id = "isInfoEnabled.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_isTraceEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsTraceEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isTraceEnabled_Lorg_slf4j_Marker_ == null)
				cb_isTraceEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsTraceEnabled_Lorg_slf4j_Marker_);
			return cb_isTraceEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsTraceEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsTraceEnabled (marker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isTraceEnabled' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("isTraceEnabled", "(Lorg/slf4j/Marker;)Z", "GetInvokeIsTraceEnabled_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool InvokeIsTraceEnabled (global::Org.Slf4j.IMarker marker)
		{
			const string __id = "isTraceEnabled.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_isWarnEnabled_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetInvokeIsWarnEnabled_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_isWarnEnabled_Lorg_slf4j_Marker_ == null)
				cb_isWarnEnabled_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeIsWarnEnabled_Lorg_slf4j_Marker_);
			return cb_isWarnEnabled_Lorg_slf4j_Marker_;
		}

		static bool n_InvokeIsWarnEnabled_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsWarnEnabled (marker);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='isWarnEnabled' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("isWarnEnabled", "(Lorg/slf4j/Marker;)Z", "GetInvokeIsWarnEnabled_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool InvokeIsWarnEnabled (global::Org.Slf4j.IMarker marker)
		{
			const string __id = "isWarnEnabled.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_trace_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Handler ()
		{
			if (cb_trace_Ljava_lang_String_ == null)
				cb_trace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Trace_Ljava_lang_String_);
			return cb_trace_Ljava_lang_String_;
		}

		static void n_Trace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Trace (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trace", "(Ljava/lang/String;)V", "GetTrace_Ljava_lang_String_Handler")]
		public virtual unsafe void Trace (string msg)
		{
			const string __id = "trace.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_trace_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Ljava_lang_String_Ljava_lang_Object_);
			return cb_trace_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Trace (format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetTrace_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Trace (string format, global::Java.Lang.Object arg)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Trace (format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetTrace_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Trace (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_trace_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_trace_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_trace_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_trace_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Trace_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Trace (format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("trace", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetTrace_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Trace (string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "trace.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
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

		static void n_Trace_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Trace (msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetTrace_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Trace (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Trace (marker, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String']]"
		[Register ("trace", "(Lorg/slf4j/Marker;Ljava/lang/String;)V", "GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Handler")]
		public virtual unsafe void Trace (global::Org.Slf4j.IMarker marker, string msg)
		{
			const string __id = "trace.(Lorg/slf4j/Marker;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Trace (marker, format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V", "GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Trace (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg)
		{
			const string __id = "trace.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Trace (marker, format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=4 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Trace (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "trace.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [3] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_argArray)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var argArray = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_argArray, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Trace (marker, format, argArray);
			if (argArray != null)
				JNIEnv.CopyArray (argArray, native_argArray);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("trace", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V", "GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Trace (global::Org.Slf4j.IMarker marker, string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "trace.(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (argArray);
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

		static void n_Trace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Trace (marker, msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("trace", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetTrace_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Trace (global::Org.Slf4j.IMarker marker, string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "trace.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Handler ()
		{
			if (cb_warn_Ljava_lang_String_ == null)
				cb_warn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Warn_Ljava_lang_String_);
			return cb_warn_Ljava_lang_String_;
		}

		static void n_Warn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Warn (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "GetWarn_Ljava_lang_String_Handler")]
		public virtual unsafe void Warn (string msg)
		{
			const string __id = "warn.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Ljava_lang_String_Ljava_lang_Object_);
			return cb_warn_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Warn (format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetWarn_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Warn (string format, global::Java.Lang.Object arg)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Warn (format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetWarn_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Warn (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warn_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warn_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warn_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warn (format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("warn", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarn_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Warn (string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "warn.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
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

		static void n_Warn_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Warn (msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetWarn_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Warn (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.Warn (marker, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String']]"
		[Register ("warn", "(Lorg/slf4j/Marker;Ljava/lang/String;)V", "GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Handler")]
		public virtual unsafe void Warn (global::Org.Slf4j.IMarker marker, string msg)
		{
			const string __id = "warn.(Lorg/slf4j/Marker;Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
			}
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			__this.Warn (marker, format, arg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V", "GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Warn (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg)
		{
			const string __id = "warn.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg);
			}
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arg1, IntPtr native_arg2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arg1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg1, JniHandleOwnership.DoNotTransfer);
			var arg2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Warn (marker, format, arg1, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=4 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Warn (global::Org.Slf4j.IMarker marker, string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "warn.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [3] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		static Delegate cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_format, IntPtr native_arguments)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			var arguments = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_arguments, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warn (marker, format, arguments);
			if (arguments != null)
				JNIEnv.CopyArray (arguments, native_arguments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("warn", "(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Warn (global::Org.Slf4j.IMarker marker, string format, params global::Java.Lang.Object[] arguments)
		{
			const string __id = "warn.(Lorg/slf4j/Marker;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_format);
				__args [2] = new JniArgumentValue (native_arguments);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (arguments);
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

		static void n_Warn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_msg, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.EventRecodingLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Warn (marker, msg, t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='EventRecodingLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='org.slf4j.Marker'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("warn", "(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetWarn_Lorg_slf4j_Marker_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Warn (global::Org.Slf4j.IMarker marker, string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "warn.(Lorg/slf4j/Marker;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) marker).Handle);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (marker);
				global::System.GC.KeepAlive (t);
			}
		}

	}
}
