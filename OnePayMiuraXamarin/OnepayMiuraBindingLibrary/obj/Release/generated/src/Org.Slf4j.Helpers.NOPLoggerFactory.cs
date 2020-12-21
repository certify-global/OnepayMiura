using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLoggerFactory']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/NOPLoggerFactory", DoNotGenerateAcw=true)]
	public partial class NOPLoggerFactory : global::Java.Lang.Object, global::Org.Slf4j.ILoggerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/NOPLoggerFactory", typeof (NOPLoggerFactory));
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

		protected NOPLoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLoggerFactory']/constructor[@name='NOPLoggerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NOPLoggerFactory ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.NOPLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLogger (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='NOPLoggerFactory']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
