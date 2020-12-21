using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j']/class[@name='LoggerFactory']"
	[global::Android.Runtime.Register ("org/slf4j/LoggerFactory", DoNotGenerateAcw=true)]
	public sealed partial class LoggerFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/LoggerFactory", typeof (LoggerFactory));
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

		internal LoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Org.Slf4j.ILoggerFactory ILoggerFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='LoggerFactory']/method[@name='getILoggerFactory' and count(parameter)=0]"
			[Register ("getILoggerFactory", "()Lorg/slf4j/ILoggerFactory;", "")]
			get {
				const string __id = "getILoggerFactory.()Lorg/slf4j/ILoggerFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILoggerFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='LoggerFactory']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getLogger", "(Ljava/lang/Class;)Lorg/slf4j/Logger;", "")]
		public static unsafe global::Org.Slf4j.ILogger GetLogger (global::Java.Lang.Class clazz)
		{
			const string __id = "getLogger.(Ljava/lang/Class;)Lorg/slf4j/Logger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='LoggerFactory']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLogger", "(Ljava/lang/String;)Lorg/slf4j/Logger;", "")]
		public static unsafe global::Org.Slf4j.ILogger GetLogger (string name)
		{
			const string __id = "getLogger.(Ljava/lang/String;)Lorg/slf4j/Logger;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
