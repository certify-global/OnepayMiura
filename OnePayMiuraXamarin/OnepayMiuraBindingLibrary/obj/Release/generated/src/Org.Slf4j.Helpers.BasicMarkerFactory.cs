using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/BasicMarkerFactory", DoNotGenerateAcw=true)]
	public partial class BasicMarkerFactory : global::Java.Lang.Object, global::Org.Slf4j.IMarkerFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/BasicMarkerFactory", typeof (BasicMarkerFactory));
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

		protected BasicMarkerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']/constructor[@name='BasicMarkerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicMarkerFactory ()
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

		static Delegate cb_detachMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDetachMarker_Ljava_lang_String_Handler ()
		{
			if (cb_detachMarker_Ljava_lang_String_ == null)
				cb_detachMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DetachMarker_Ljava_lang_String_);
			return cb_detachMarker_Ljava_lang_String_;
		}

		static bool n_DetachMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DetachMarker (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']/method[@name='detachMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("detachMarker", "(Ljava/lang/String;)Z", "GetDetachMarker_Ljava_lang_String_Handler")]
		public virtual unsafe bool DetachMarker (string name)
		{
			const string __id = "detachMarker.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_exists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExists_Ljava_lang_String_Handler ()
		{
			if (cb_exists_Ljava_lang_String_ == null)
				cb_exists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Exists_Ljava_lang_String_);
			return cb_exists_Ljava_lang_String_;
		}

		static bool n_Exists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Exists (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']/method[@name='exists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("exists", "(Ljava/lang/String;)Z", "GetExists_Ljava_lang_String_Handler")]
		public virtual unsafe bool Exists (string name)
		{
			const string __id = "exists.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDetachedMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDetachedMarker_Ljava_lang_String_Handler ()
		{
			if (cb_getDetachedMarker_Ljava_lang_String_ == null)
				cb_getDetachedMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDetachedMarker_Ljava_lang_String_);
			return cb_getDetachedMarker_Ljava_lang_String_;
		}

		static IntPtr n_GetDetachedMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDetachedMarker (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']/method[@name='getDetachedMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetachedMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "GetGetDetachedMarker_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Slf4j.IMarker GetDetachedMarker (string name)
		{
			const string __id = "getDetachedMarker.(Ljava/lang/String;)Lorg/slf4j/Marker;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMarker_Ljava_lang_String_Handler ()
		{
			if (cb_getMarker_Ljava_lang_String_ == null)
				cb_getMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMarker_Ljava_lang_String_);
			return cb_getMarker_Ljava_lang_String_;
		}

		static IntPtr n_GetMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarkerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMarker (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarkerFactory']/method[@name='getMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "GetGetMarker_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Slf4j.IMarker GetMarker (string name)
		{
			const string __id = "getMarker.(Ljava/lang/String;)Lorg/slf4j/Marker;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
