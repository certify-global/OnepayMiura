using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/SerialPortProperties", DoNotGenerateAcw=true)]
	public partial class SerialPortProperties : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/SerialPortProperties", typeof (SerialPortProperties));
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

		protected SerialPortProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/constructor[@name='SerialPortProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SerialPortProperties ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/constructor[@name='SerialPortProperties' and count(parameter)=7 and parameter[1][@type='com.miurasystems.mpi.enums.SerialPortBaudRate'] and parameter[2][@type='com.miurasystems.mpi.enums.SerialCharacterSize'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='com.miurasystems.mpi.enums.SerialPortStopBits'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/SerialPortBaudRate;Lcom/miurasystems/mpi/enums/SerialCharacterSize;ZZLcom/miurasystems/mpi/enums/SerialPortStopBits;ZZ)V", "")]
		public unsafe SerialPortProperties (global::Com.Miurasystems.Mpi.Enums.SerialPortBaudRate baudRate, global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize charSize, bool parityEnabled, bool oddParity, global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits stopBits, bool hwFlowControlEnabled, bool swFlowControlEnabled)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/SerialPortBaudRate;Lcom/miurasystems/mpi/enums/SerialCharacterSize;ZZLcom/miurasystems/mpi/enums/SerialPortStopBits;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((baudRate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baudRate).Handle);
				__args [1] = new JniArgumentValue ((charSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) charSize).Handle);
				__args [2] = new JniArgumentValue (parityEnabled);
				__args [3] = new JniArgumentValue (oddParity);
				__args [4] = new JniArgumentValue ((stopBits == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopBits).Handle);
				__args [5] = new JniArgumentValue (hwFlowControlEnabled);
				__args [6] = new JniArgumentValue (swFlowControlEnabled);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (baudRate);
				global::System.GC.KeepAlive (charSize);
				global::System.GC.KeepAlive (stopBits);
			}
		}

		static Delegate cb_getBaudRate;
#pragma warning disable 0169
		static Delegate GetGetBaudRateHandler ()
		{
			if (cb_getBaudRate == null)
				cb_getBaudRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBaudRate);
			return cb_getBaudRate;
		}

		static IntPtr n_GetBaudRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaudRate);
		}
#pragma warning restore 0169

		static Delegate cb_setBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_;
#pragma warning disable 0169
		static Delegate GetSetBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_Handler ()
		{
			if (cb_setBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_ == null)
				cb_setBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_);
			return cb_setBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_;
		}

		static void n_SetBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baudRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var baudRate = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortBaudRate> (native_baudRate, JniHandleOwnership.DoNotTransfer);
			__this.BaudRate = baudRate;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.SerialPortBaudRate BaudRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='getBaudRate' and count(parameter)=0]"
			[Register ("getBaudRate", "()Lcom/miurasystems/mpi/enums/SerialPortBaudRate;", "GetGetBaudRateHandler")]
			get {
				const string __id = "getBaudRate.()Lcom/miurasystems/mpi/enums/SerialPortBaudRate;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortBaudRate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setBaudRate' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.SerialPortBaudRate']]"
			[Register ("setBaudRate", "(Lcom/miurasystems/mpi/enums/SerialPortBaudRate;)V", "GetSetBaudRate_Lcom_miurasystems_mpi_enums_SerialPortBaudRate_Handler")]
			set {
				const string __id = "setBaudRate.(Lcom/miurasystems/mpi/enums/SerialPortBaudRate;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getCharSize;
#pragma warning disable 0169
		static Delegate GetGetCharSizeHandler ()
		{
			if (cb_getCharSize == null)
				cb_getCharSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCharSize);
			return cb_getCharSize;
		}

		static IntPtr n_GetCharSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CharSize);
		}
#pragma warning restore 0169

		static Delegate cb_setCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_;
#pragma warning disable 0169
		static Delegate GetSetCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_Handler ()
		{
			if (cb_setCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_ == null)
				cb_setCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_);
			return cb_setCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_;
		}

		static void n_SetCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_charSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var charSize = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (native_charSize, JniHandleOwnership.DoNotTransfer);
			__this.CharSize = charSize;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize CharSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='getCharSize' and count(parameter)=0]"
			[Register ("getCharSize", "()Lcom/miurasystems/mpi/enums/SerialCharacterSize;", "GetGetCharSizeHandler")]
			get {
				const string __id = "getCharSize.()Lcom/miurasystems/mpi/enums/SerialCharacterSize;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setCharSize' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.SerialCharacterSize']]"
			[Register ("setCharSize", "(Lcom/miurasystems/mpi/enums/SerialCharacterSize;)V", "GetSetCharSize_Lcom_miurasystems_mpi_enums_SerialCharacterSize_Handler")]
			set {
				const string __id = "setCharSize.(Lcom/miurasystems/mpi/enums/SerialCharacterSize;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isHwFlowControlEnabled;
#pragma warning disable 0169
		static Delegate GetIsHwFlowControlEnabledHandler ()
		{
			if (cb_isHwFlowControlEnabled == null)
				cb_isHwFlowControlEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHwFlowControlEnabled);
			return cb_isHwFlowControlEnabled;
		}

		static bool n_IsHwFlowControlEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HwFlowControlEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHwFlowControlEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHwFlowControlEnabled_ZHandler ()
		{
			if (cb_setHwFlowControlEnabled_Z == null)
				cb_setHwFlowControlEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHwFlowControlEnabled_Z);
			return cb_setHwFlowControlEnabled_Z;
		}

		static void n_SetHwFlowControlEnabled_Z (IntPtr jnienv, IntPtr native__this, bool hwFlowControlEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HwFlowControlEnabled = hwFlowControlEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HwFlowControlEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='isHwFlowControlEnabled' and count(parameter)=0]"
			[Register ("isHwFlowControlEnabled", "()Z", "GetIsHwFlowControlEnabledHandler")]
			get {
				const string __id = "isHwFlowControlEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setHwFlowControlEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHwFlowControlEnabled", "(Z)V", "GetSetHwFlowControlEnabled_ZHandler")]
			set {
				const string __id = "setHwFlowControlEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOddParity;
#pragma warning disable 0169
		static Delegate GetIsOddParityHandler ()
		{
			if (cb_isOddParity == null)
				cb_isOddParity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOddParity);
			return cb_isOddParity;
		}

		static bool n_IsOddParity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OddParity;
		}
#pragma warning restore 0169

		static Delegate cb_setOddParity_Z;
#pragma warning disable 0169
		static Delegate GetSetOddParity_ZHandler ()
		{
			if (cb_setOddParity_Z == null)
				cb_setOddParity_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetOddParity_Z);
			return cb_setOddParity_Z;
		}

		static void n_SetOddParity_Z (IntPtr jnienv, IntPtr native__this, bool oddParity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OddParity = oddParity;
		}
#pragma warning restore 0169

		public virtual unsafe bool OddParity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='isOddParity' and count(parameter)=0]"
			[Register ("isOddParity", "()Z", "GetIsOddParityHandler")]
			get {
				const string __id = "isOddParity.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setOddParity' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOddParity", "(Z)V", "GetSetOddParity_ZHandler")]
			set {
				const string __id = "setOddParity.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isParityEnabled;
#pragma warning disable 0169
		static Delegate GetIsParityEnabledHandler ()
		{
			if (cb_isParityEnabled == null)
				cb_isParityEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsParityEnabled);
			return cb_isParityEnabled;
		}

		static bool n_IsParityEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ParityEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setParityEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetParityEnabled_ZHandler ()
		{
			if (cb_setParityEnabled_Z == null)
				cb_setParityEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetParityEnabled_Z);
			return cb_setParityEnabled_Z;
		}

		static void n_SetParityEnabled_Z (IntPtr jnienv, IntPtr native__this, bool parityEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParityEnabled = parityEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool ParityEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='isParityEnabled' and count(parameter)=0]"
			[Register ("isParityEnabled", "()Z", "GetIsParityEnabledHandler")]
			get {
				const string __id = "isParityEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setParityEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setParityEnabled", "(Z)V", "GetSetParityEnabled_ZHandler")]
			set {
				const string __id = "setParityEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStopBits;
#pragma warning disable 0169
		static Delegate GetGetStopBitsHandler ()
		{
			if (cb_getStopBits == null)
				cb_getStopBits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStopBits);
			return cb_getStopBits;
		}

		static IntPtr n_GetStopBits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StopBits);
		}
#pragma warning restore 0169

		static Delegate cb_setStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_;
#pragma warning disable 0169
		static Delegate GetSetStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_Handler ()
		{
			if (cb_setStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_ == null)
				cb_setStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_);
			return cb_setStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_;
		}

		static void n_SetStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stopBits)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var stopBits = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits> (native_stopBits, JniHandleOwnership.DoNotTransfer);
			__this.StopBits = stopBits;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits StopBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='getStopBits' and count(parameter)=0]"
			[Register ("getStopBits", "()Lcom/miurasystems/mpi/enums/SerialPortStopBits;", "GetGetStopBitsHandler")]
			get {
				const string __id = "getStopBits.()Lcom/miurasystems/mpi/enums/SerialPortStopBits;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialPortStopBits> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setStopBits' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.SerialPortStopBits']]"
			[Register ("setStopBits", "(Lcom/miurasystems/mpi/enums/SerialPortStopBits;)V", "GetSetStopBits_Lcom_miurasystems_mpi_enums_SerialPortStopBits_Handler")]
			set {
				const string __id = "setStopBits.(Lcom/miurasystems/mpi/enums/SerialPortStopBits;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isSwFlowControlEnabled;
#pragma warning disable 0169
		static Delegate GetIsSwFlowControlEnabledHandler ()
		{
			if (cb_isSwFlowControlEnabled == null)
				cb_isSwFlowControlEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSwFlowControlEnabled);
			return cb_isSwFlowControlEnabled;
		}

		static bool n_IsSwFlowControlEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwFlowControlEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSwFlowControlEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSwFlowControlEnabled_ZHandler ()
		{
			if (cb_setSwFlowControlEnabled_Z == null)
				cb_setSwFlowControlEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSwFlowControlEnabled_Z);
			return cb_setSwFlowControlEnabled_Z;
		}

		static void n_SetSwFlowControlEnabled_Z (IntPtr jnienv, IntPtr native__this, bool swFlowControlEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwFlowControlEnabled = swFlowControlEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool SwFlowControlEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='isSwFlowControlEnabled' and count(parameter)=0]"
			[Register ("isSwFlowControlEnabled", "()Z", "GetIsSwFlowControlEnabledHandler")]
			get {
				const string __id = "isSwFlowControlEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='SerialPortProperties']/method[@name='setSwFlowControlEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSwFlowControlEnabled", "(Z)V", "GetSetSwFlowControlEnabled_ZHandler")]
			set {
				const string __id = "setSwFlowControlEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
