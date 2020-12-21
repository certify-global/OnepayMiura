using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']"
	[global::Android.Runtime.Register ("org/slf4j/event/SubstituteLoggingEvent", DoNotGenerateAcw=true)]
	public partial class SubstituteLoggingEvent : global::Java.Lang.Object, global::Org.Slf4j.Event.ILoggingEvent {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/event/SubstituteLoggingEvent", typeof (SubstituteLoggingEvent));
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

		protected SubstituteLoggingEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/constructor[@name='SubstituteLoggingEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubstituteLoggingEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLevel);
			return cb_getLevel;
		}

		static IntPtr n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Level);
		}
#pragma warning restore 0169

		static Delegate cb_setLevel_Lorg_slf4j_event_Level_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Lorg_slf4j_event_Level_Handler ()
		{
			if (cb_setLevel_Lorg_slf4j_event_Level_ == null)
				cb_setLevel_Lorg_slf4j_event_Level_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLevel_Lorg_slf4j_event_Level_);
			return cb_setLevel_Lorg_slf4j_event_Level_;
		}

		static void n_SetLevel_Lorg_slf4j_event_Level_ (IntPtr jnienv, IntPtr native__this, IntPtr native_level)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var level = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (native_level, JniHandleOwnership.DoNotTransfer);
			__this.Level = level;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Slf4j.Event.Level Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()Lorg/slf4j/event/Level;", "GetGetLevelHandler")]
			get {
				const string __id = "getLevel.()Lorg/slf4j/event/Level;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='org.slf4j.event.Level']]"
			[Register ("setLevel", "(Lorg/slf4j/event/Level;)V", "GetSetLevel_Lorg_slf4j_event_Level_Handler")]
			set {
				const string __id = "setLevel.(Lorg/slf4j/event/Level;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getLogger;
#pragma warning disable 0169
		static Delegate GetGetLoggerHandler ()
		{
			if (cb_getLogger == null)
				cb_getLogger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogger);
			return cb_getLogger;
		}

		static IntPtr n_GetLogger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logger);
		}
#pragma warning restore 0169

		static Delegate cb_setLogger_Lorg_slf4j_helpers_SubstituteLogger_;
#pragma warning disable 0169
		static Delegate GetSetLogger_Lorg_slf4j_helpers_SubstituteLogger_Handler ()
		{
			if (cb_setLogger_Lorg_slf4j_helpers_SubstituteLogger_ == null)
				cb_setLogger_Lorg_slf4j_helpers_SubstituteLogger_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLogger_Lorg_slf4j_helpers_SubstituteLogger_);
			return cb_setLogger_Lorg_slf4j_helpers_SubstituteLogger_;
		}

		static void n_SetLogger_Lorg_slf4j_helpers_SubstituteLogger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logger)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var logger = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLogger> (native_logger, JniHandleOwnership.DoNotTransfer);
			__this.Logger = logger;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Slf4j.Helpers.SubstituteLogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lorg/slf4j/helpers/SubstituteLogger;", "GetGetLoggerHandler")]
			get {
				const string __id = "getLogger.()Lorg/slf4j/helpers/SubstituteLogger;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='org.slf4j.helpers.SubstituteLogger']]"
			[Register ("setLogger", "(Lorg/slf4j/helpers/SubstituteLogger;)V", "GetSetLogger_Lorg_slf4j_helpers_SubstituteLogger_Handler")]
			set {
				const string __id = "setLogger.(Lorg/slf4j/helpers/SubstituteLogger;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getLoggerName;
#pragma warning disable 0169
		static Delegate GetGetLoggerNameHandler ()
		{
			if (cb_getLoggerName == null)
				cb_getLoggerName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggerName);
			return cb_getLoggerName;
		}

		static IntPtr n_GetLoggerName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LoggerName);
		}
#pragma warning restore 0169

		static Delegate cb_setLoggerName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLoggerName_Ljava_lang_String_Handler ()
		{
			if (cb_setLoggerName_Ljava_lang_String_ == null)
				cb_setLoggerName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLoggerName_Ljava_lang_String_);
			return cb_setLoggerName_Ljava_lang_String_;
		}

		static void n_SetLoggerName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loggerName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var loggerName = JNIEnv.GetString (native_loggerName, JniHandleOwnership.DoNotTransfer);
			__this.LoggerName = loggerName;
		}
#pragma warning restore 0169

		public virtual unsafe string LoggerName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getLoggerName' and count(parameter)=0]"
			[Register ("getLoggerName", "()Ljava/lang/String;", "GetGetLoggerNameHandler")]
			get {
				const string __id = "getLoggerName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setLoggerName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLoggerName", "(Ljava/lang/String;)V", "GetSetLoggerName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLoggerName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Marker);
		}
#pragma warning restore 0169

		static Delegate cb_setMarker_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_setMarker_Lorg_slf4j_Marker_ == null)
				cb_setMarker_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMarker_Lorg_slf4j_Marker_);
			return cb_setMarker_Lorg_slf4j_Marker_;
		}

		static void n_SetMarker_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var marker = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.Marker = marker;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Slf4j.IMarker Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lorg/slf4j/Marker;", "GetGetMarkerHandler")]
			get {
				const string __id = "getMarker.()Lorg/slf4j/Marker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
			[Register ("setMarker", "(Lorg/slf4j/Marker;)V", "GetSetMarker_Lorg_slf4j_Marker_Handler")]
			set {
				const string __id = "setMarker.(Lorg/slf4j/Marker;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Message = message;
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMessage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getThreadName;
#pragma warning disable 0169
		static Delegate GetGetThreadNameHandler ()
		{
			if (cb_getThreadName == null)
				cb_getThreadName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThreadName);
			return cb_getThreadName;
		}

		static IntPtr n_GetThreadName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThreadName);
		}
#pragma warning restore 0169

		static Delegate cb_setThreadName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetThreadName_Ljava_lang_String_Handler ()
		{
			if (cb_setThreadName_Ljava_lang_String_ == null)
				cb_setThreadName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetThreadName_Ljava_lang_String_);
			return cb_setThreadName_Ljava_lang_String_;
		}

		static void n_SetThreadName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			__this.ThreadName = threadName;
		}
#pragma warning restore 0169

		public virtual unsafe string ThreadName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getThreadName' and count(parameter)=0]"
			[Register ("getThreadName", "()Ljava/lang/String;", "GetGetThreadNameHandler")]
			get {
				const string __id = "getThreadName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setThreadName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setThreadName", "(Ljava/lang/String;)V", "GetSetThreadName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setThreadName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getThrowable;
#pragma warning disable 0169
		static Delegate GetGetThrowableHandler ()
		{
			if (cb_getThrowable == null)
				cb_getThrowable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThrowable);
			return cb_getThrowable;
		}

		static IntPtr n_GetThrowable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		static Delegate cb_setThrowable_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSetThrowable_Ljava_lang_Throwable_Handler ()
		{
			if (cb_setThrowable_Ljava_lang_Throwable_ == null)
				cb_setThrowable_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetThrowable_Ljava_lang_Throwable_);
			return cb_setThrowable_Ljava_lang_Throwable_;
		}

		static void n_SetThrowable_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.Throwable = throwable;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				const string __id = "getThrowable.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("setThrowable", "(Ljava/lang/Throwable;)V", "GetSetThrowable_Ljava_lang_Throwable_Handler")]
			set {
				const string __id = "setThrowable.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeStamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimeStamp_JHandler ()
		{
			if (cb_setTimeStamp_J == null)
				cb_setTimeStamp_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetTimeStamp_J);
			return cb_setTimeStamp_J;
		}

		static void n_SetTimeStamp_J (IntPtr jnienv, IntPtr native__this, long timeStamp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeStamp = timeStamp;
		}
#pragma warning restore 0169

		public virtual unsafe long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				const string __id = "getTimeStamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setTimeStamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeStamp", "(J)V", "GetSetTimeStamp_JHandler")]
			set {
				const string __id = "setTimeStamp.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getArgumentArray;
#pragma warning disable 0169
		static Delegate GetGetArgumentArrayHandler ()
		{
			if (cb_getArgumentArray == null)
				cb_getArgumentArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArgumentArray);
			return cb_getArgumentArray;
		}

		static IntPtr n_GetArgumentArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArgumentArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='getArgumentArray' and count(parameter)=0]"
		[Register ("getArgumentArray", "()[Ljava/lang/Object;", "GetGetArgumentArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetArgumentArray ()
		{
			const string __id = "getArgumentArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_setArgumentArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetArgumentArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setArgumentArray_arrayLjava_lang_Object_ == null)
				cb_setArgumentArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetArgumentArray_arrayLjava_lang_Object_);
			return cb_setArgumentArray_arrayLjava_lang_Object_;
		}

		static void n_SetArgumentArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_argArray)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.SubstituteLoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var argArray = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_argArray, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetArgumentArray (argArray);
			if (argArray != null)
				JNIEnv.CopyArray (argArray, native_argArray);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='SubstituteLoggingEvent']/method[@name='setArgumentArray' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("setArgumentArray", "([Ljava/lang/Object;)V", "GetSetArgumentArray_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void SetArgumentArray (global::Java.Lang.Object[] argArray)
		{
			const string __id = "setArgumentArray.([Ljava/lang/Object;)V";
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

	}
}
