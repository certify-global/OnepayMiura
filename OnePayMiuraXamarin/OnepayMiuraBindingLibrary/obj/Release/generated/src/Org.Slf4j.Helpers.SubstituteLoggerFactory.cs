using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/SubstituteLoggerFactory", DoNotGenerateAcw=true)]
	public partial class SubstituteLoggerFactory : global::Java.Lang.Object, global::Org.Slf4j.ILoggerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/SubstituteLoggerFactory", typeof (SubstituteLoggerFactory));
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

		protected SubstituteLoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/constructor[@name='SubstituteLoggerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubstituteLoggerFactory ()
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

		static Delegate cb_getEventQueue;
#pragma warning disable 0169
		static Delegate GetGetEventQueueHandler ()
		{
			if (cb_getEventQueue == null)
				cb_getEventQueue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEventQueue);
			return cb_getEventQueue;
		}

		static IntPtr n_GetEventQueue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventQueue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Concurrent.LinkedBlockingQueue EventQueue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='getEventQueue' and count(parameter)=0]"
			[Register ("getEventQueue", "()Ljava/util/concurrent/LinkedBlockingQueue;", "GetGetEventQueueHandler")]
			get {
				const string __id = "getEventQueue.()Ljava/util/concurrent/LinkedBlockingQueue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.LinkedBlockingQueue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoggerNames;
#pragma warning disable 0169
		static Delegate GetGetLoggerNamesHandler ()
		{
			if (cb_getLoggerNames == null)
				cb_getLoggerNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggerNames);
			return cb_getLoggerNames;
		}

		static IntPtr n_GetLoggerNames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.LoggerNames);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> LoggerNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='getLoggerNames' and count(parameter)=0]"
			[Register ("getLoggerNames", "()Ljava/util/List;", "GetGetLoggerNamesHandler")]
			get {
				const string __id = "getLoggerNames.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoggers;
#pragma warning disable 0169
		static Delegate GetGetLoggersHandler ()
		{
			if (cb_getLoggers == null)
				cb_getLoggers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggers);
			return cb_getLoggers;
		}

		static IntPtr n_GetLoggers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Slf4j.Helpers.SubstituteLogger>.ToLocalJniHandle (__this.Loggers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Slf4j.Helpers.SubstituteLogger> Loggers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='getLoggers' and count(parameter)=0]"
			[Register ("getLoggers", "()Ljava/util/List;", "GetGetLoggersHandler")]
			get {
				const string __id = "getLoggers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Slf4j.Helpers.SubstituteLogger>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getLogger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLogger_Ljava_lang_String_Handler ()
		{
			if (cb_getLogger_Ljava_lang_String_ == null)
				cb_getLogger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetLogger_Ljava_lang_String_);
			return cb_getLogger_Ljava_lang_String_;
		}

		static IntPtr n_GetLogger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLogger (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLogger", "(Ljava/lang/String;)Lorg/slf4j/Logger;", "GetGetLogger_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Slf4j.ILogger GetLogger (string name)
		{
			const string __id = "getLogger.(Ljava/lang/String;)Lorg/slf4j/Logger;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_postInitialization;
#pragma warning disable 0169
		static Delegate GetPostInitializationHandler ()
		{
			if (cb_postInitialization == null)
				cb_postInitialization = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PostInitialization);
			return cb_postInitialization;
		}

		static void n_PostInitialization (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.SubstituteLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostInitialization ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='SubstituteLoggerFactory']/method[@name='postInitialization' and count(parameter)=0]"
		[Register ("postInitialization", "()V", "GetPostInitializationHandler")]
		public virtual unsafe void PostInitialization ()
		{
			const string __id = "postInitialization.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
