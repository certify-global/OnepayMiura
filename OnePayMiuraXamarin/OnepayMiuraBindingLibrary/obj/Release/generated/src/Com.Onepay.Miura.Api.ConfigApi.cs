using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/ConfigApi", DoNotGenerateAcw=true)]
	public partial class ConfigApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ConfigApi.ConfigInfoListener']"
		[Register ("com/onepay/miura/api/ConfigApi$ConfigInfoListener", "", "Com.Onepay.Miura.Api.ConfigApi/IConfigInfoListenerInvoker")]
		public partial interface IConfigInfoListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='ConfigApi.ConfigInfoListener']/method[@name='onConfigUpdateComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.ConfigApiData']]"
			[Register ("onConfigUpdateComplete", "(Lcom/onepay/miura/data/ConfigApiData;)V", "GetOnConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_Handler:Com.Onepay.Miura.Api.ConfigApi/IConfigInfoListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnConfigUpdateComplete (global::Com.Onepay.Miura.Data.ConfigApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/ConfigApi$ConfigInfoListener", DoNotGenerateAcw=true)]
		internal partial class IConfigInfoListenerInvoker : global::Java.Lang.Object, IConfigInfoListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ConfigApi$ConfigInfoListener", typeof (IConfigInfoListenerInvoker));

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

			public static IConfigInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConfigInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.ConfigApi.ConfigInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConfigInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_;
#pragma warning disable 0169
			static Delegate GetOnConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_Handler ()
			{
				if (cb_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_ == null)
					cb_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_);
				return cb_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_;
			}

			static void n_OnConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.ConfigApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConfigUpdateComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_;
			public unsafe void OnConfigUpdateComplete (global::Com.Onepay.Miura.Data.ConfigApiData p0)
			{
				if (id_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_ == IntPtr.Zero)
					id_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_ = JNIEnv.GetMethodID (class_ref, "onConfigUpdateComplete", "(Lcom/onepay/miura/data/ConfigApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfigUpdateComplete_Lcom_onepay_miura_data_ConfigApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.ConfigApi.ConfigInfoListener.onConfigUpdateComplete
		public partial class ConfigInfoEventArgs : global::System.EventArgs {

			public ConfigInfoEventArgs (global::Com.Onepay.Miura.Data.ConfigApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.ConfigApiData p0;
			public global::Com.Onepay.Miura.Data.ConfigApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/ConfigApi_ConfigInfoListenerImplementor")]
		internal sealed partial class IConfigInfoListenerImplementor : global::Java.Lang.Object, IConfigInfoListener {

			object sender;

			public IConfigInfoListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/ConfigApi_ConfigInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ConfigInfoEventArgs> Handler;
#pragma warning restore 0649

			public void OnConfigUpdateComplete (global::Com.Onepay.Miura.Data.ConfigApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ConfigInfoEventArgs (p0));
			}

			internal static bool __IsEmpty (IConfigInfoListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/ConfigApi", typeof (ConfigApi));
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

		protected ConfigApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']/constructor[@name='ConfigApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConfigApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.ConfigApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/ConfigApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/ConfigApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_;
#pragma warning disable 0169
		static Delegate GetOnConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_Handler ()
		{
			if (cb_onConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ == null)
				cb_onConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_);
			return cb_onConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_;
		}

		static void n_OnConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigInfo (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']/method[@name='onConfigInfo' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.ConfigApi.ConfigInfoListener']]"
		[Register ("onConfigInfo", "(Lcom/onepay/miura/api/ConfigApi$ConfigInfoListener;)V", "GetOnConfigInfo_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_Handler")]
		public virtual unsafe void OnConfigInfo (global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener listener)
		{
			const string __id = "onConfigInfo.(Lcom/onepay/miura/api/ConfigApi$ConfigInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_performConfig_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPerformConfig_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_performConfig_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_performConfig_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_PerformConfig_Ljava_lang_String_ILjava_lang_String_);
			return cb_performConfig_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_PerformConfig_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_btAddress, int tOut, IntPtr native_filePath)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			var filePath = JNIEnv.GetString (native_filePath, JniHandleOwnership.DoNotTransfer);
			__this.PerformConfig (btAddress, tOut, filePath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']/method[@name='performConfig' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("performConfig", "(Ljava/lang/String;ILjava/lang/String;)V", "GetPerformConfig_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe void PerformConfig (string btAddress, int tOut, string filePath)
		{
			const string __id = "performConfig.(Ljava/lang/String;ILjava/lang/String;)V";
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_btAddress);
				__args [1] = new JniArgumentValue (tOut);
				__args [2] = new JniArgumentValue (native_filePath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_btAddress);
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		static Delegate cb_setConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_Handler ()
		{
			if (cb_setConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ == null)
				cb_setConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_);
			return cb_setConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_;
		}

		static void n_SetConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetConfigListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='ConfigApi']/method[@name='setConfigListener' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.ConfigApi.ConfigInfoListener']]"
		[Register ("setConfigListener", "(Lcom/onepay/miura/api/ConfigApi$ConfigInfoListener;)V", "GetSetConfigListener_Lcom_onepay_miura_api_ConfigApi_ConfigInfoListener_Handler")]
		public virtual unsafe void SetConfigListener (global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener listener)
		{
			const string __id = "setConfigListener.(Lcom/onepay/miura/api/ConfigApi$ConfigInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

#region "Event implementation for Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener"
		public event EventHandler<global::Com.Onepay.Miura.Api.ConfigApi.ConfigInfoEventArgs> Config {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener, global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListenerImplementor>(
						ref weak_implementor_SetConfigListener,
						__CreateIConfigInfoListenerImplementor,
						SetConfigListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListener, global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListenerImplementor>(
						ref weak_implementor_SetConfigListener,
						global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListenerImplementor.__IsEmpty,
						__v => SetConfigListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConfigListener;

		global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListenerImplementor __CreateIConfigInfoListenerImplementor ()
		{
			return new global::Com.Onepay.Miura.Api.ConfigApi.IConfigInfoListenerImplementor (this);
		}
#endregion
	}
}
