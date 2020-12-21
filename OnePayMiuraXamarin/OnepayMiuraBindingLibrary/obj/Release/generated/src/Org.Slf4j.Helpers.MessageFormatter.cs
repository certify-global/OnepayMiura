using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/MessageFormatter", DoNotGenerateAcw=true)]
	public sealed partial class MessageFormatter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/MessageFormatter", typeof (MessageFormatter));
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

		internal MessageFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/constructor[@name='MessageFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageFormatter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='arrayFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("arrayFormat", "(Ljava/lang/String;[Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;", "")]
		public static unsafe global::Org.Slf4j.Helpers.FormattingTuple ArrayFormat (string messagePattern, global::Java.Lang.Object[] argArray)
		{
			const string __id = "arrayFormat.(Ljava/lang/String;[Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;";
			IntPtr native_messagePattern = JNIEnv.NewString (messagePattern);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_messagePattern);
				__args [1] = new JniArgumentValue (native_argArray);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messagePattern);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='arrayFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("arrayFormat", "(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)Lorg/slf4j/helpers/FormattingTuple;", "")]
		public static unsafe global::Org.Slf4j.Helpers.FormattingTuple ArrayFormat (string messagePattern, global::Java.Lang.Object[] argArray, global::Java.Lang.Throwable throwable)
		{
			const string __id = "arrayFormat.(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)Lorg/slf4j/helpers/FormattingTuple;";
			IntPtr native_messagePattern = JNIEnv.NewString (messagePattern);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_messagePattern);
				__args [1] = new JniArgumentValue (native_argArray);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messagePattern);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("format", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;", "")]
		public static unsafe global::Org.Slf4j.Helpers.FormattingTuple Format (string messagePattern, global::Java.Lang.Object arg)
		{
			const string __id = "format.(Ljava/lang/String;Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;";
			IntPtr native_messagePattern = JNIEnv.NewString (messagePattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_messagePattern);
				__args [1] = new JniArgumentValue ((arg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messagePattern);
				global::System.GC.KeepAlive (arg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='format' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("format", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;", "")]
		public static unsafe global::Org.Slf4j.Helpers.FormattingTuple Format (string messagePattern, global::Java.Lang.Object arg1, global::Java.Lang.Object arg2)
		{
			const string __id = "format.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Lorg/slf4j/helpers/FormattingTuple;";
			IntPtr native_messagePattern = JNIEnv.NewString (messagePattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_messagePattern);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messagePattern);
				global::System.GC.KeepAlive (arg1);
				global::System.GC.KeepAlive (arg2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='getThrowableCandidate' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("getThrowableCandidate", "([Ljava/lang/Object;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable GetThrowableCandidate (global::Java.Lang.Object[] argArray)
		{
			const string __id = "getThrowableCandidate.([Ljava/lang/Object;)Ljava/lang/Throwable;";
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argArray);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='MessageFormatter']/method[@name='trimmedCopy' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("trimmedCopy", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object[] TrimmedCopy (global::Java.Lang.Object[] argArray)
		{
			const string __id = "trimmedCopy.([Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_argArray);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
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
