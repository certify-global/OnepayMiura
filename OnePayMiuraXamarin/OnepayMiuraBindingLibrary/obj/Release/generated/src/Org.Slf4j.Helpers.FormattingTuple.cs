using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/FormattingTuple", DoNotGenerateAcw=true)]
	public partial class FormattingTuple : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Org.Slf4j.Helpers.FormattingTuple Null {
			get {
				const string __id = "NULL.Lorg/slf4j/helpers/FormattingTuple;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "NULL.Lorg/slf4j/helpers/FormattingTuple;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/FormattingTuple", typeof (FormattingTuple));
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

		protected FormattingTuple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/constructor[@name='FormattingTuple' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FormattingTuple (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/constructor[@name='FormattingTuple' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "")]
		public unsafe FormattingTuple (string message, global::Java.Lang.Object[] argArray, global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_argArray = JNIEnv.NewArray (argArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_argArray);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (argArray != null) {
					JNIEnv.CopyArray (native_argArray, argArray);
					JNIEnv.DeleteLocalRef (native_argArray);
				}
				global::System.GC.KeepAlive (argArray);
				global::System.GC.KeepAlive (throwable);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				const string __id = "getThrowable.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getArgArray;
#pragma warning disable 0169
		static Delegate GetGetArgArrayHandler ()
		{
			if (cb_getArgArray == null)
				cb_getArgArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArgArray);
			return cb_getArgArray;
		}

		static IntPtr n_GetArgArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.FormattingTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArgArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='FormattingTuple']/method[@name='getArgArray' and count(parameter)=0]"
		[Register ("getArgArray", "()[Ljava/lang/Object;", "GetGetArgArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetArgArray ()
		{
			const string __id = "getArgArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

	}
}
