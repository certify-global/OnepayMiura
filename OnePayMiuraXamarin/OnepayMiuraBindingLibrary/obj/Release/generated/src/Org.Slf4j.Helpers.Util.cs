using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/Util", typeof (Util));
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

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Java.Lang.Class CallingClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']/method[@name='getCallingClass' and count(parameter)=0]"
			[Register ("getCallingClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getCallingClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']/method[@name='report' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("report", "(Ljava/lang/String;)V", "")]
		public static unsafe void Report (string msg)
		{
			const string __id = "report.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']/method[@name='report' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("report", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Report (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "report.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']/method[@name='safeGetBooleanSystemProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("safeGetBooleanSystemProperty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool SafeGetBooleanSystemProperty (string key)
		{
			const string __id = "safeGetBooleanSystemProperty.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='Util']/method[@name='safeGetSystemProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("safeGetSystemProperty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SafeGetSystemProperty (string key)
		{
			const string __id = "safeGetSystemProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
