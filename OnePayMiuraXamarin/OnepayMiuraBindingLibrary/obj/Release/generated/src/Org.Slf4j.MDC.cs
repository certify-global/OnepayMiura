using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']"
	[global::Android.Runtime.Register ("org/slf4j/MDC", DoNotGenerateAcw=true)]
	public partial class MDC : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j']/class[@name='MDC.MDCCloseable']"
		[global::Android.Runtime.Register ("org/slf4j/MDC$MDCCloseable", DoNotGenerateAcw=true)]
		public partial class MDCCloseable : global::Java.Lang.Object, global::Java.IO.ICloseable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/MDC$MDCCloseable", typeof (MDCCloseable));
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

			protected MDCCloseable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.MDC.MDCCloseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC.MDCCloseable']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				const string __id = "close.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/MDC", typeof (MDC));
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

		protected MDC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::System.Collections.Generic.IDictionary<string, string> CopyOfContextMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='getCopyOfContextMap' and count(parameter)=0]"
			[Register ("getCopyOfContextMap", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getCopyOfContextMap.()Ljava/util/Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Org.Slf4j.Spi.IMDCAdapter MDCAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='getMDCAdapter' and count(parameter)=0]"
			[Register ("getMDCAdapter", "()Lorg/slf4j/spi/MDCAdapter;", "")]
			get {
				const string __id = "getMDCAdapter.()Lorg/slf4j/spi/MDCAdapter;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMDCAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public static unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Put (string key, string val)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_val);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='putCloseable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putCloseable", "(Ljava/lang/String;Ljava/lang/String;)Lorg/slf4j/MDC$MDCCloseable;", "")]
		public static unsafe global::Org.Slf4j.MDC.MDCCloseable PutCloseable (string key, string val)
		{
			const string __id = "putCloseable.(Ljava/lang/String;Ljava/lang/String;)Lorg/slf4j/MDC$MDCCloseable;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_val);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.MDC.MDCCloseable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "")]
		public static unsafe void Remove (string key)
		{
			const string __id = "remove.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MDC']/method[@name='setContextMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setContextMap", "(Ljava/util/Map;)V", "")]
		public static unsafe void SetContextMap (global::System.Collections.Generic.IDictionary<string, string> contextMap)
		{
			const string __id = "setContextMap.(Ljava/util/Map;)V";
			IntPtr native_contextMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (contextMap);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_contextMap);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contextMap);
				global::System.GC.KeepAlive (contextMap);
			}
		}

	}
}
