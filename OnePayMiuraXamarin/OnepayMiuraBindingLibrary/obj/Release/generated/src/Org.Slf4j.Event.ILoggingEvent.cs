using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']"
	[Register ("org/slf4j/event/LoggingEvent", "", "Org.Slf4j.Event.ILoggingEventInvoker")]
	public partial interface ILoggingEvent : IJavaObject, IJavaPeerable {

		global::Org.Slf4j.Event.Level Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()Lorg/slf4j/event/Level;", "GetGetLevelHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string LoggerName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getLoggerName' and count(parameter)=0]"
			[Register ("getLoggerName", "()Ljava/lang/String;", "GetGetLoggerNameHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Slf4j.IMarker Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lorg/slf4j/Marker;", "GetGetMarkerHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string ThreadName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getThreadName' and count(parameter)=0]"
			[Register ("getThreadName", "()Ljava/lang/String;", "GetGetThreadNameHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/interface[@name='LoggingEvent']/method[@name='getArgumentArray' and count(parameter)=0]"
		[Register ("getArgumentArray", "()[Ljava/lang/Object;", "GetGetArgumentArrayHandler:Org.Slf4j.Event.ILoggingEventInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Object[] GetArgumentArray ();

	}

	[global::Android.Runtime.Register ("org/slf4j/event/LoggingEvent", DoNotGenerateAcw=true)]
	internal partial class ILoggingEventInvoker : global::Java.Lang.Object, ILoggingEvent {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/event/LoggingEvent", typeof (ILoggingEventInvoker));

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

		public static ILoggingEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggingEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.event.LoggingEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggingEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Level);
		}
#pragma warning restore 0169

		IntPtr id_getLevel;
		public unsafe global::Org.Slf4j.Event.Level Level {
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()Lorg/slf4j/event/Level;");
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLevel), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LoggerName);
		}
#pragma warning restore 0169

		IntPtr id_getLoggerName;
		public unsafe string LoggerName {
			get {
				if (id_getLoggerName == IntPtr.Zero)
					id_getLoggerName = JNIEnv.GetMethodID (class_ref, "getLoggerName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggerName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Marker);
		}
#pragma warning restore 0169

		IntPtr id_getMarker;
		public unsafe global::Org.Slf4j.IMarker Marker {
			get {
				if (id_getMarker == IntPtr.Zero)
					id_getMarker = JNIEnv.GetMethodID (class_ref, "getMarker", "()Lorg/slf4j/Marker;");
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarker), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThreadName);
		}
#pragma warning restore 0169

		IntPtr id_getThreadName;
		public unsafe string ThreadName {
			get {
				if (id_getThreadName == IntPtr.Zero)
					id_getThreadName = JNIEnv.GetMethodID (class_ref, "getThreadName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThreadName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		IntPtr id_getThrowable;
		public unsafe global::Java.Lang.Throwable Throwable {
			get {
				if (id_getThrowable == IntPtr.Zero)
					id_getThrowable = JNIEnv.GetMethodID (class_ref, "getThrowable", "()Ljava/lang/Throwable;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThrowable), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		IntPtr id_getTimeStamp;
		public unsafe long TimeStamp {
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.ILoggingEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArgumentArray ());
		}
#pragma warning restore 0169

		IntPtr id_getArgumentArray;
		public unsafe global::Java.Lang.Object[] GetArgumentArray ()
		{
			if (id_getArgumentArray == IntPtr.Zero)
				id_getArgumentArray = JNIEnv.GetMethodID (class_ref, "getArgumentArray", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArgumentArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

	}

}
