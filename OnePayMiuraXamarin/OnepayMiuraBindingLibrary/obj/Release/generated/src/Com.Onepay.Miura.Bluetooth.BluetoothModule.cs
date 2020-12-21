using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/BluetoothModule", DoNotGenerateAcw=true)]
	public partial class BluetoothModule : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/BluetoothModule", typeof (BluetoothModule));
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

		protected BluetoothModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Onepay.Miura.Bluetooth.BluetoothModule Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/bluetooth/BluetoothModule;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/bluetooth/BluetoothModule;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSessionOpen;
#pragma warning disable 0169
		static Delegate GetIsSessionOpenHandler ()
		{
			if (cb_isSessionOpen == null)
				cb_isSessionOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSessionOpen);
			return cb_isSessionOpen;
		}

		static bool n_IsSessionOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionOpen;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSessionOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='isSessionOpen' and count(parameter)=0]"
			[Register ("isSessionOpen", "()Z", "GetIsSessionOpenHandler")]
			get {
				const string __id = "isSessionOpen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedBluetoothDevice;
#pragma warning disable 0169
		static Delegate GetGetSelectedBluetoothDeviceHandler ()
		{
			if (cb_getSelectedBluetoothDevice == null)
				cb_getSelectedBluetoothDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSelectedBluetoothDevice);
			return cb_getSelectedBluetoothDevice;
		}

		static IntPtr n_GetSelectedBluetoothDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedBluetoothDevice);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetSetSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_setSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_setSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_);
			return cb_setSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_;
		}

		static void n_SetSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultBluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var defaultBluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_defaultBluetoothDevice, JniHandleOwnership.DoNotTransfer);
			__this.SelectedBluetoothDevice = defaultBluetoothDevice;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Bluetooth.BluetoothDevice SelectedBluetoothDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getSelectedBluetoothDevice' and count(parameter)=0]"
			[Register ("getSelectedBluetoothDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetSelectedBluetoothDeviceHandler")]
			get {
				const string __id = "getSelectedBluetoothDevice.()Landroid/bluetooth/BluetoothDevice;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='setSelectedBluetoothDevice' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
			[Register ("setSelectedBluetoothDevice", "(Landroid/bluetooth/BluetoothDevice;)V", "GetSetSelectedBluetoothDevice_Landroid_bluetooth_BluetoothDevice_Handler")]
			set {
				const string __id = "setSelectedBluetoothDevice.(Landroid/bluetooth/BluetoothDevice;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_closeSession;
#pragma warning disable 0169
		static Delegate GetCloseSessionHandler ()
		{
			if (cb_closeSession == null)
				cb_closeSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseSession);
			return cb_closeSession;
		}

		static void n_CloseSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "GetCloseSessionHandler")]
		public virtual unsafe void CloseSession ()
		{
			const string __id = "closeSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_;
#pragma warning disable 0169
		static Delegate GetGetBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_Handler ()
		{
			if (cb_getBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_ == null)
				cb_getBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GetBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_);
			return cb_getBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_;
		}

		static void n_GetBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_mode, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.IDevicesListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.IDevicesListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetBluetoothDevicesWithChecking (context, mode, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getBluetoothDevicesWithChecking' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothDeviceChecking.Mode'] and parameter[3][@type='com.onepay.miura.bluetooth.BluetoothDeviceChecking.DevicesListener']]"
		[Register ("getBluetoothDevicesWithChecking", "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener;)V", "GetGetBluetoothDevicesWithChecking_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_Mode_Lcom_onepay_miura_bluetooth_BluetoothDeviceChecking_DevicesListener_Handler")]
		public virtual unsafe void GetBluetoothDevicesWithChecking (global::Android.Content.Context context, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.Mode mode, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceChecking.IDevicesListener listener)
		{
			const string __id = "getBluetoothDevicesWithChecking.(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$Mode;Lcom/onepay/miura/bluetooth/BluetoothDeviceChecking$DevicesListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_;
#pragma warning disable 0169
		static Delegate GetGetDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_Handler ()
		{
			if (cb_getDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ == null)
				cb_getDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_);
			return cb_getDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_;
		}

		static IntPtr n_GetDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_deviceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var deviceType = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType> (native_deviceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDefaultSelectedDevice (context, deviceType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getDefaultSelectedDevice' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothDeviceType']]"
		[Register ("getDefaultSelectedDevice", "(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Landroid/bluetooth/BluetoothDevice;", "GetGetDefaultSelectedDevice_Landroid_content_Context_Lcom_onepay_miura_bluetooth_BluetoothDeviceType_Handler")]
		public virtual unsafe global::Android.Bluetooth.BluetoothDevice GetDefaultSelectedDevice (global::Android.Content.Context context, global::Com.Onepay.Miura.Bluetooth.BluetoothDeviceType deviceType)
		{
			const string __id = "getDefaultSelectedDevice.(Landroid/content/Context;Lcom/onepay/miura/bluetooth/BluetoothDeviceType;)Landroid/bluetooth/BluetoothDevice;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (deviceType);
			}
		}

		static Delegate cb_getNonPairedDevices_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetNonPairedDevices_Landroid_content_Context_Handler ()
		{
			if (cb_getNonPairedDevices_Landroid_content_Context_ == null)
				cb_getNonPairedDevices_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetNonPairedDevices_Landroid_content_Context_);
			return cb_getNonPairedDevices_Landroid_content_Context_;
		}

		static IntPtr n_GetNonPairedDevices_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (__this.GetNonPairedDevices (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getNonPairedDevices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNonPairedDevices", "(Landroid/content/Context;)Ljava/util/ArrayList;", "GetGetNonPairedDevices_Landroid_content_Context_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> GetNonPairedDevices (global::Android.Content.Context context)
		{
			const string __id = "getNonPairedDevices.(Landroid/content/Context;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getPairedDevices_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPairedDevices_Landroid_content_Context_Handler ()
		{
			if (cb_getPairedDevices_Landroid_content_Context_ == null)
				cb_getPairedDevices_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPairedDevices_Landroid_content_Context_);
			return cb_getPairedDevices_Landroid_content_Context_;
		}

		static IntPtr n_GetPairedDevices_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.ToLocalJniHandle (__this.GetPairedDevices (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='getPairedDevices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPairedDevices", "(Landroid/content/Context;)Ljava/util/ArrayList;", "GetGetPairedDevices_Landroid_content_Context_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothDevice> GetPairedDevices (global::Android.Content.Context context)
		{
			const string __id = "getPairedDevices.(Landroid/content/Context;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_isDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetIsDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_isDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_isDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_IsDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_);
			return cb_isDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
		}

		static bool n_IsDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDefaultDevice (context, bluetoothDevice);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='isDefaultDevice' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("isDefaultDevice", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)Z", "GetIsDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe bool IsDefaultDevice (global::Android.Content.Context context, global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "isDefaultDevice.(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

		static Delegate cb_openSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_;
#pragma warning disable 0169
		static Delegate GetOpenSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_Handler ()
		{
			if (cb_openSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ == null)
				cb_openSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OpenSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_);
			return cb_openSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_;
		}

		static void n_OpenSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceAddress, IntPtr native_btConnectionListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var deviceAddress = JNIEnv.GetString (native_deviceAddress, JniHandleOwnership.DoNotTransfer);
			var btConnectionListener = (global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener> (native_btConnectionListener, JniHandleOwnership.DoNotTransfer);
			__this.OpenSession (deviceAddress, btConnectionListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='openSession' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onepay.miura.bluetooth.BluetoothConnectionListener']]"
		[Register ("openSession", "(Ljava/lang/String;Lcom/onepay/miura/bluetooth/BluetoothConnectionListener;)V", "GetOpenSession_Ljava_lang_String_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_Handler")]
		public virtual unsafe void OpenSession (string deviceAddress, global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener btConnectionListener)
		{
			const string __id = "openSession.(Ljava/lang/String;Lcom/onepay/miura/bluetooth/BluetoothConnectionListener;)V";
			IntPtr native_deviceAddress = JNIEnv.NewString (deviceAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_deviceAddress);
				__args [1] = new JniArgumentValue ((btConnectionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) btConnectionListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceAddress);
				global::System.GC.KeepAlive (btConnectionListener);
			}
		}

		static Delegate cb_openSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_;
#pragma warning disable 0169
		static Delegate GetOpenSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_Handler ()
		{
			if (cb_openSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ == null)
				cb_openSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_);
			return cb_openSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_;
		}

		static void n_OpenSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connectionListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connectionListener = (global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener> (native_connectionListener, JniHandleOwnership.DoNotTransfer);
			__this.OpenSessionDefaultDevice (connectionListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='openSessionDefaultDevice' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.bluetooth.BluetoothConnectionListener']]"
		[Register ("openSessionDefaultDevice", "(Lcom/onepay/miura/bluetooth/BluetoothConnectionListener;)V", "GetOpenSessionDefaultDevice_Lcom_onepay_miura_bluetooth_BluetoothConnectionListener_Handler")]
		public virtual unsafe void OpenSessionDefaultDevice (global::Com.Onepay.Miura.Bluetooth.IBluetoothConnectionListener connectionListener)
		{
			const string __id = "openSessionDefaultDevice.(Lcom/onepay/miura/bluetooth/BluetoothConnectionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((connectionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (connectionListener);
			}
		}

		static Delegate cb_setDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetSetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_setDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_setDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_);
			return cb_setDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
		}

		static void n_SetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultDevice (context, bluetoothDevice);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='setDefaultDevice' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("setDefaultDevice", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)V", "GetSetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe void SetDefaultDevice (global::Android.Content.Context context, global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "setDefaultDevice.(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

		static Delegate cb_setTimeoutEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetTimeoutEnable_ZHandler ()
		{
			if (cb_setTimeoutEnable_Z == null)
				cb_setTimeoutEnable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTimeoutEnable_Z);
			return cb_setTimeoutEnable_Z;
		}

		static void n_SetTimeoutEnable_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeoutEnable (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='setTimeoutEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTimeoutEnable", "(Z)V", "GetSetTimeoutEnable_ZHandler")]
		public virtual unsafe void SetTimeoutEnable (bool enable)
		{
			const string __id = "setTimeoutEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
#pragma warning disable 0169
		static Delegate GetUnsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler ()
		{
			if (cb_unsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ == null)
				cb_unsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_);
			return cb_unsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_;
		}

		static void n_UnsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_bluetoothDevice)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Bluetooth.BluetoothModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var bluetoothDevice = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_bluetoothDevice, JniHandleOwnership.DoNotTransfer);
			__this.UnsetDefaultDevice (context, bluetoothDevice);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='BluetoothModule']/method[@name='unsetDefaultDevice' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothDevice']]"
		[Register ("unsetDefaultDevice", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)V", "GetUnsetDefaultDevice_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Handler")]
		public virtual unsafe void UnsetDefaultDevice (global::Android.Content.Context context, global::Android.Bluetooth.BluetoothDevice bluetoothDevice)
		{
			const string __id = "unsetDefaultDevice.(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((bluetoothDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bluetoothDevice).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (bluetoothDevice);
			}
		}

	}
}
