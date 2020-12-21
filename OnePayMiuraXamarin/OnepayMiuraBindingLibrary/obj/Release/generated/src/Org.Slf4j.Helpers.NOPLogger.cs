using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/NOPLogger", DoNotGenerateAcw=true)]
	public partial class NOPLogger : global::Org.Slf4j.Helpers.MarkerIgnoringBase {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/field[@name='NOP_LOGGER']"
		[Register ("NOP_LOGGER")]
		public static global::Org.Slf4j.Helpers.NOPLogger NopLogger {
			get {
				const string __id = "NOP_LOGGER.Lorg/slf4j/helpers/NOPLogger;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.NOPLogger> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/NOPLogger", typeof (NOPLogger));
		internal static new IntPtr class_ref {
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

		protected NOPLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/constructor[@name='NOPLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe NOPLogger ()
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

		public override unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "")]
			get {
				const string __id = "isDebugEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsErrorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='isErrorEnabled' and count(parameter)=0]"
			[Register ("isErrorEnabled", "()Z", "")]
			get {
				const string __id = "isErrorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsInfoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='isInfoEnabled' and count(parameter)=0]"
			[Register ("isInfoEnabled", "()Z", "")]
			get {
				const string __id = "isInfoEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsTraceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='isTraceEnabled' and count(parameter)=0]"
			[Register ("isTraceEnabled", "()Z", "")]
			get {
				const string __id = "isTraceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsWarnEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='isWarnEnabled' and count(parameter)=0]"
			[Register ("isWarnEnabled", "()Z", "")]
			get {
				const string __id = "isWarnEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void Debug (string msg)
		{
			const string __id = "debug.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Debug (string format, global::Java.Lang.Object arg)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='debug' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Debug (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Debug (string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "debug.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='debug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override sealed unsafe void Debug (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "debug.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void Error (string msg)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Error (string format, global::Java.Lang.Object arg1)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='error' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Error (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Error (string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "error.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='error' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("error", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override sealed unsafe void Error (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "error.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void Info (string msg)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Info (string format, global::Java.Lang.Object arg1)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Info (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Info (string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "info.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override sealed unsafe void Info (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "info.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='trace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trace", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void Trace (string msg)
		{
			const string __id = "trace.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Trace (string format, global::Java.Lang.Object arg)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='trace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Trace (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("trace", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Trace (string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "trace.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='trace' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("trace", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override sealed unsafe void Trace (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "trace.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public override sealed unsafe void Warn (string msg)
		{
			const string __id = "warn.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Warn (string format, global::Java.Lang.Object arg1)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='warn' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Warn (string format, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("warn", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public override sealed unsafe void Warn (string format, params global::Java.Lang.Object[] argArray)
		{
			const string __id = "warn.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_argArray);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLogger']/method[@name='warn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public override sealed unsafe void Warn (string msg, global::Java.Lang.Throwable t)
		{
			const string __id = "warn.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
				global::System.GC.KeepAlive (t);
			}
		}

	}
}
