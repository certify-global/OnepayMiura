using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/BasicMDCAdapter", DoNotGenerateAcw=true)]
	public partial class BasicMDCAdapter : global::Java.Lang.Object, global::Org.Slf4j.Spi.IMDCAdapter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/BasicMDCAdapter", typeof (BasicMDCAdapter));
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

		protected BasicMDCAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/constructor[@name='BasicMDCAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicMDCAdapter ()
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

		static Delegate cb_getCopyOfContextMap;
#pragma warning disable 0169
		static Delegate GetGetCopyOfContextMapHandler ()
		{
			if (cb_getCopyOfContextMap == null)
				cb_getCopyOfContextMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCopyOfContextMap);
			return cb_getCopyOfContextMap;
		}

		static IntPtr n_GetCopyOfContextMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CopyOfContextMap);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CopyOfContextMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='getCopyOfContextMap' and count(parameter)=0]"
			[Register ("getCopyOfContextMap", "()Ljava/util/Map;", "GetGetCopyOfContextMapHandler")]
			get {
				const string __id = "getCopyOfContextMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Keys);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get {
				const string __id = "getKeys.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe string Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string key, string val)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string key)
		{
			const string __id = "remove.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setContextMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetContextMap_Ljava_util_Map_Handler ()
		{
			if (cb_setContextMap_Ljava_util_Map_ == null)
				cb_setContextMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContextMap_Ljava_util_Map_);
			return cb_setContextMap_Ljava_util_Map_;
		}

		static void n_SetContextMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contextMap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMDCAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contextMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_contextMap, JniHandleOwnership.DoNotTransfer);
			__this.SetContextMap (contextMap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMDCAdapter']/method[@name='setContextMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setContextMap", "(Ljava/util/Map;)V", "GetSetContextMap_Ljava_util_Map_Handler")]
		public virtual unsafe void SetContextMap (global::System.Collections.Generic.IDictionary<string, string> contextMap)
		{
			const string __id = "setContextMap.(Ljava/util/Map;)V";
			IntPtr native_contextMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (contextMap);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_contextMap);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contextMap);
				global::System.GC.KeepAlive (contextMap);
			}
		}

	}
}
