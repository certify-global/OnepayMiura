using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/DeviceApi", DoNotGenerateAcw=true)]
	public partial class DeviceApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='DeviceApi.DeviceInfoListener']"
		[Register ("com/onepay/miura/api/DeviceApi$DeviceInfoListener", "", "Com.Onepay.Miura.Api.DeviceApi/IDeviceInfoListenerInvoker")]
		public partial interface IDeviceInfoListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='DeviceApi.DeviceInfoListener']/method[@name='onGetDeviceInfoComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.DeviceApiData']]"
			[Register ("onGetDeviceInfoComplete", "(Lcom/onepay/miura/data/DeviceApiData;)V", "GetOnGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_Handler:Com.Onepay.Miura.Api.DeviceApi/IDeviceInfoListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnGetDeviceInfoComplete (global::Com.Onepay.Miura.Data.DeviceApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/DeviceApi$DeviceInfoListener", DoNotGenerateAcw=true)]
		internal partial class IDeviceInfoListenerInvoker : global::Java.Lang.Object, IDeviceInfoListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/DeviceApi$DeviceInfoListener", typeof (IDeviceInfoListenerInvoker));

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

			public static IDeviceInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDeviceInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.DeviceApi.DeviceInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeviceInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_;
#pragma warning disable 0169
			static Delegate GetOnGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_Handler ()
			{
				if (cb_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_ == null)
					cb_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_);
				return cb_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_;
			}

			static void n_OnGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi.IDeviceInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnGetDeviceInfoComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_;
			public unsafe void OnGetDeviceInfoComplete (global::Com.Onepay.Miura.Data.DeviceApiData p0)
			{
				if (id_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_ == IntPtr.Zero)
					id_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_ = JNIEnv.GetMethodID (class_ref, "onGetDeviceInfoComplete", "(Lcom/onepay/miura/data/DeviceApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetDeviceInfoComplete_Lcom_onepay_miura_data_DeviceApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.DeviceApi.DeviceInfoListener.onGetDeviceInfoComplete
		public partial class DeviceInfoEventArgs : global::System.EventArgs {

			public DeviceInfoEventArgs (global::Com.Onepay.Miura.Data.DeviceApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.DeviceApiData p0;
			public global::Com.Onepay.Miura.Data.DeviceApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/DeviceApi_DeviceInfoListenerImplementor")]
		internal sealed partial class IDeviceInfoListenerImplementor : global::Java.Lang.Object, IDeviceInfoListener {

			object sender;

			public IDeviceInfoListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/DeviceApi_DeviceInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DeviceInfoEventArgs> Handler;
#pragma warning restore 0649

			public void OnGetDeviceInfoComplete (global::Com.Onepay.Miura.Data.DeviceApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DeviceInfoEventArgs (p0));
			}

			internal static bool __IsEmpty (IDeviceInfoListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/DeviceApi", typeof (DeviceApi));
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

		protected DeviceApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']/constructor[@name='DeviceApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.DeviceApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/DeviceApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/DeviceApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_closeSession_Z;
#pragma warning disable 0169
		static Delegate GetCloseSession_ZHandler ()
		{
			if (cb_closeSession_Z == null)
				cb_closeSession_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_CloseSession_Z);
			return cb_closeSession_Z;
		}

		static void n_CloseSession_Z (IntPtr jnienv, IntPtr native__this, bool interrupted)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession (interrupted);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']/method[@name='closeSession' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("closeSession", "(Z)V", "GetCloseSession_ZHandler")]
		public virtual unsafe void CloseSession (bool interrupted)
		{
			const string __id = "closeSession.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (interrupted);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getDeviceInfo_Ljava_lang_String_ == null)
				cb_getDeviceInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetDeviceInfo_Ljava_lang_String_);
			return cb_getDeviceInfo_Ljava_lang_String_;
		}

		static void n_GetDeviceInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_btAddress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			__this.GetDeviceInfo (btAddress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']/method[@name='getDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeviceInfo", "(Ljava/lang/String;)V", "GetGetDeviceInfo_Ljava_lang_String_Handler")]
		public virtual unsafe void GetDeviceInfo (string btAddress)
		{
			const string __id = "getDeviceInfo.(Ljava/lang/String;)V";
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_btAddress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_btAddress);
			}
		}

		static Delegate cb_onDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_;
#pragma warning disable 0169
		static Delegate GetOnDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_Handler ()
		{
			if (cb_onDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_ == null)
				cb_onDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_);
			return cb_onDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_;
		}

		static void n_OnDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.DeviceApi.IDeviceInfoListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.DeviceApi.IDeviceInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceInfo (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='DeviceApi']/method[@name='onDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.DeviceApi.DeviceInfoListener']]"
		[Register ("onDeviceInfo", "(Lcom/onepay/miura/api/DeviceApi$DeviceInfoListener;)V", "GetOnDeviceInfo_Lcom_onepay_miura_api_DeviceApi_DeviceInfoListener_Handler")]
		public virtual unsafe void OnDeviceInfo (global::Com.Onepay.Miura.Api.DeviceApi.IDeviceInfoListener listener)
		{
			const string __id = "onDeviceInfo.(Lcom/onepay/miura/api/DeviceApi$DeviceInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

	}
}
