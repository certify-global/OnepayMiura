using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']"
	[global::Android.Runtime.Register ("com/onepay/miura/data/DeviceApiData", DoNotGenerateAcw=true)]
	public partial class DeviceApiData : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/data/DeviceApiData", typeof (DeviceApiData));
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

		protected DeviceApiData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/constructor[@name='DeviceApiData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceApiData ()
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

		static Delegate cb_address;
#pragma warning disable 0169
		static Delegate GetAddressHandler ()
		{
			if (cb_address == null)
				cb_address = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Address);
			return cb_address;
		}

		static IntPtr n_Address (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='address' and count(parameter)=0]"
		[Register ("address", "()Ljava/lang/String;", "GetAddressHandler")]
		public virtual unsafe string Address ()
		{
			const string __id = "address.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_batteryLevel;
#pragma warning disable 0169
		static Delegate GetBatteryLevelHandler ()
		{
			if (cb_batteryLevel == null)
				cb_batteryLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_BatteryLevel);
			return cb_batteryLevel;
		}

		static IntPtr n_BatteryLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BatteryLevel ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='batteryLevel' and count(parameter)=0]"
		[Register ("batteryLevel", "()Ljava/lang/String;", "GetBatteryLevelHandler")]
		public virtual unsafe string BatteryLevel ()
		{
			const string __id = "batteryLevel.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_chargingStatus;
#pragma warning disable 0169
		static Delegate GetChargingStatusHandler ()
		{
			if (cb_chargingStatus == null)
				cb_chargingStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ChargingStatus);
			return cb_chargingStatus;
		}

		static IntPtr n_ChargingStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChargingStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='chargingStatus' and count(parameter)=0]"
		[Register ("chargingStatus", "()Ljava/lang/String;", "GetChargingStatusHandler")]
		public virtual unsafe string ChargingStatus ()
		{
			const string __id = "chargingStatus.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dateTime;
#pragma warning disable 0169
		static Delegate GetDateTimeHandler ()
		{
			if (cb_dateTime == null)
				cb_dateTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DateTime);
			return cb_dateTime;
		}

		static IntPtr n_DateTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateTime ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='dateTime' and count(parameter)=0]"
		[Register ("dateTime", "()Ljava/lang/String;", "GetDateTimeHandler")]
		public virtual unsafe string DateTime ()
		{
			const string __id = "dateTime.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mpiType;
#pragma warning disable 0169
		static Delegate GetMpiTypeHandler ()
		{
			if (cb_mpiType == null)
				cb_mpiType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MpiType);
			return cb_mpiType;
		}

		static IntPtr n_MpiType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MpiType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='mpiType' and count(parameter)=0]"
		[Register ("mpiType", "()Ljava/lang/String;", "GetMpiTypeHandler")]
		public virtual unsafe string MpiType ()
		{
			const string __id = "mpiType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mpiVersion;
#pragma warning disable 0169
		static Delegate GetMpiVersionHandler ()
		{
			if (cb_mpiVersion == null)
				cb_mpiVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MpiVersion);
			return cb_mpiVersion;
		}

		static IntPtr n_MpiVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MpiVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='mpiVersion' and count(parameter)=0]"
		[Register ("mpiVersion", "()Ljava/lang/String;", "GetMpiVersionHandler")]
		public virtual unsafe string MpiVersion ()
		{
			const string __id = "mpiVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_osType;
#pragma warning disable 0169
		static Delegate GetOsTypeHandler ()
		{
			if (cb_osType == null)
				cb_osType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OsType);
			return cb_osType;
		}

		static IntPtr n_OsType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OsType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='osType' and count(parameter)=0]"
		[Register ("osType", "()Ljava/lang/String;", "GetOsTypeHandler")]
		public virtual unsafe string OsType ()
		{
			const string __id = "osType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_osVersion;
#pragma warning disable 0169
		static Delegate GetOsVersionHandler ()
		{
			if (cb_osVersion == null)
				cb_osVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OsVersion);
			return cb_osVersion;
		}

		static IntPtr n_OsVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OsVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='osVersion' and count(parameter)=0]"
		[Register ("osVersion", "()Ljava/lang/String;", "GetOsVersionHandler")]
		public virtual unsafe string OsVersion ()
		{
			const string __id = "osVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pinKeyStatus;
#pragma warning disable 0169
		static Delegate GetPinKeyStatusHandler ()
		{
			if (cb_pinKeyStatus == null)
				cb_pinKeyStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PinKeyStatus);
			return cb_pinKeyStatus;
		}

		static IntPtr n_PinKeyStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PinKeyStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='pinKeyStatus' and count(parameter)=0]"
		[Register ("pinKeyStatus", "()Ljava/lang/String;", "GetPinKeyStatusHandler")]
		public virtual unsafe string PinKeyStatus ()
		{
			const string __id = "pinKeyStatus.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_returnReason;
#pragma warning disable 0169
		static Delegate GetReturnReasonHandler ()
		{
			if (cb_returnReason == null)
				cb_returnReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReturnReason);
			return cb_returnReason;
		}

		static IntPtr n_ReturnReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReturnReason ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='returnReason' and count(parameter)=0]"
		[Register ("returnReason", "()Ljava/lang/String;", "GetReturnReasonHandler")]
		public virtual unsafe string ReturnReason ()
		{
			const string __id = "returnReason.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_returnStatus;
#pragma warning disable 0169
		static Delegate GetReturnStatusHandler ()
		{
			if (cb_returnStatus == null)
				cb_returnStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ReturnStatus);
			return cb_returnStatus;
		}

		static int n_ReturnStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReturnStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='returnStatus' and count(parameter)=0]"
		[Register ("returnStatus", "()I", "GetReturnStatusHandler")]
		public virtual unsafe int ReturnStatus ()
		{
			const string __id = "returnStatus.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sREDStatus;
#pragma warning disable 0169
		static Delegate GetSREDStatusHandler ()
		{
			if (cb_sREDStatus == null)
				cb_sREDStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SREDStatus);
			return cb_sREDStatus;
		}

		static IntPtr n_SREDStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SREDStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='sREDStatus' and count(parameter)=0]"
		[Register ("sREDStatus", "()Ljava/lang/String;", "GetSREDStatusHandler")]
		public virtual unsafe string SREDStatus ()
		{
			const string __id = "sREDStatus.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_serialNumber;
#pragma warning disable 0169
		static Delegate GetSerialNumberHandler ()
		{
			if (cb_serialNumber == null)
				cb_serialNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SerialNumber);
			return cb_serialNumber;
		}

		static IntPtr n_SerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='serialNumber' and count(parameter)=0]"
		[Register ("serialNumber", "()Ljava/lang/String;", "GetSerialNumberHandler")]
		public virtual unsafe string SerialNumber ()
		{
			const string __id = "serialNumber.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.SetAddress (address);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAddress (string address)
		{
			const string __id = "setAddress.(Ljava/lang/String;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_address);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_setBatteryLevel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBatteryLevel_Ljava_lang_String_Handler ()
		{
			if (cb_setBatteryLevel_Ljava_lang_String_ == null)
				cb_setBatteryLevel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBatteryLevel_Ljava_lang_String_);
			return cb_setBatteryLevel_Ljava_lang_String_;
		}

		static void n_SetBatteryLevel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_batteryLevel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var batteryLevel = JNIEnv.GetString (native_batteryLevel, JniHandleOwnership.DoNotTransfer);
			__this.SetBatteryLevel (batteryLevel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setBatteryLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBatteryLevel", "(Ljava/lang/String;)V", "GetSetBatteryLevel_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBatteryLevel (string batteryLevel)
		{
			const string __id = "setBatteryLevel.(Ljava/lang/String;)V";
			IntPtr native_batteryLevel = JNIEnv.NewString (batteryLevel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_batteryLevel);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_batteryLevel);
			}
		}

		static Delegate cb_setChargingStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChargingStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setChargingStatus_Ljava_lang_String_ == null)
				cb_setChargingStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetChargingStatus_Ljava_lang_String_);
			return cb_setChargingStatus_Ljava_lang_String_;
		}

		static void n_SetChargingStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chargingStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chargingStatus = JNIEnv.GetString (native_chargingStatus, JniHandleOwnership.DoNotTransfer);
			__this.SetChargingStatus (chargingStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setChargingStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChargingStatus", "(Ljava/lang/String;)V", "GetSetChargingStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void SetChargingStatus (string chargingStatus)
		{
			const string __id = "setChargingStatus.(Ljava/lang/String;)V";
			IntPtr native_chargingStatus = JNIEnv.NewString (chargingStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_chargingStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_chargingStatus);
			}
		}

		static Delegate cb_setDateTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateTime_Ljava_lang_String_Handler ()
		{
			if (cb_setDateTime_Ljava_lang_String_ == null)
				cb_setDateTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateTime_Ljava_lang_String_);
			return cb_setDateTime_Ljava_lang_String_;
		}

		static void n_SetDateTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dateTime = JNIEnv.GetString (native_dateTime, JniHandleOwnership.DoNotTransfer);
			__this.SetDateTime (dateTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setDateTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDateTime", "(Ljava/lang/String;)V", "GetSetDateTime_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDateTime (string dateTime)
		{
			const string __id = "setDateTime.(Ljava/lang/String;)V";
			IntPtr native_dateTime = JNIEnv.NewString (dateTime);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dateTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateTime);
			}
		}

		static Delegate cb_setMpiType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMpiType_Ljava_lang_String_Handler ()
		{
			if (cb_setMpiType_Ljava_lang_String_ == null)
				cb_setMpiType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMpiType_Ljava_lang_String_);
			return cb_setMpiType_Ljava_lang_String_;
		}

		static void n_SetMpiType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mpiType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mpiType = JNIEnv.GetString (native_mpiType, JniHandleOwnership.DoNotTransfer);
			__this.SetMpiType (mpiType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setMpiType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMpiType", "(Ljava/lang/String;)V", "GetSetMpiType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMpiType (string mpiType)
		{
			const string __id = "setMpiType.(Ljava/lang/String;)V";
			IntPtr native_mpiType = JNIEnv.NewString (mpiType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mpiType);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mpiType);
			}
		}

		static Delegate cb_setMpiVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMpiVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setMpiVersion_Ljava_lang_String_ == null)
				cb_setMpiVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMpiVersion_Ljava_lang_String_);
			return cb_setMpiVersion_Ljava_lang_String_;
		}

		static void n_SetMpiVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mpiVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mpiVersion = JNIEnv.GetString (native_mpiVersion, JniHandleOwnership.DoNotTransfer);
			__this.SetMpiVersion (mpiVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setMpiVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMpiVersion", "(Ljava/lang/String;)V", "GetSetMpiVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMpiVersion (string mpiVersion)
		{
			const string __id = "setMpiVersion.(Ljava/lang/String;)V";
			IntPtr native_mpiVersion = JNIEnv.NewString (mpiVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mpiVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mpiVersion);
			}
		}

		static Delegate cb_setOsType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOsType_Ljava_lang_String_Handler ()
		{
			if (cb_setOsType_Ljava_lang_String_ == null)
				cb_setOsType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOsType_Ljava_lang_String_);
			return cb_setOsType_Ljava_lang_String_;
		}

		static void n_SetOsType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_osType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var osType = JNIEnv.GetString (native_osType, JniHandleOwnership.DoNotTransfer);
			__this.SetOsType (osType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setOsType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOsType", "(Ljava/lang/String;)V", "GetSetOsType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOsType (string osType)
		{
			const string __id = "setOsType.(Ljava/lang/String;)V";
			IntPtr native_osType = JNIEnv.NewString (osType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_osType);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_osType);
			}
		}

		static Delegate cb_setOsVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOsVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setOsVersion_Ljava_lang_String_ == null)
				cb_setOsVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOsVersion_Ljava_lang_String_);
			return cb_setOsVersion_Ljava_lang_String_;
		}

		static void n_SetOsVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_osVersion)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var osVersion = JNIEnv.GetString (native_osVersion, JniHandleOwnership.DoNotTransfer);
			__this.SetOsVersion (osVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setOsVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOsVersion", "(Ljava/lang/String;)V", "GetSetOsVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOsVersion (string osVersion)
		{
			const string __id = "setOsVersion.(Ljava/lang/String;)V";
			IntPtr native_osVersion = JNIEnv.NewString (osVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_osVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_osVersion);
			}
		}

		static Delegate cb_setPinKeyStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPinKeyStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setPinKeyStatus_Ljava_lang_String_ == null)
				cb_setPinKeyStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPinKeyStatus_Ljava_lang_String_);
			return cb_setPinKeyStatus_Ljava_lang_String_;
		}

		static void n_SetPinKeyStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pinKeyStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pinKeyStatus = JNIEnv.GetString (native_pinKeyStatus, JniHandleOwnership.DoNotTransfer);
			__this.SetPinKeyStatus (pinKeyStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setPinKeyStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPinKeyStatus", "(Ljava/lang/String;)V", "GetSetPinKeyStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void SetPinKeyStatus (string pinKeyStatus)
		{
			const string __id = "setPinKeyStatus.(Ljava/lang/String;)V";
			IntPtr native_pinKeyStatus = JNIEnv.NewString (pinKeyStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pinKeyStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pinKeyStatus);
			}
		}

		static Delegate cb_setReturnReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReturnReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReturnReason_Ljava_lang_String_ == null)
				cb_setReturnReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReturnReason_Ljava_lang_String_);
			return cb_setReturnReason_Ljava_lang_String_;
		}

		static void n_SetReturnReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_returnReason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var returnReason = JNIEnv.GetString (native_returnReason, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnReason (returnReason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setReturnReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReturnReason", "(Ljava/lang/String;)V", "GetSetReturnReason_Ljava_lang_String_Handler")]
		public virtual unsafe void SetReturnReason (string returnReason)
		{
			const string __id = "setReturnReason.(Ljava/lang/String;)V";
			IntPtr native_returnReason = JNIEnv.NewString (returnReason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_returnReason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_returnReason);
			}
		}

		static Delegate cb_setReturnStatus_I;
#pragma warning disable 0169
		static Delegate GetSetReturnStatus_IHandler ()
		{
			if (cb_setReturnStatus_I == null)
				cb_setReturnStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetReturnStatus_I);
			return cb_setReturnStatus_I;
		}

		static void n_SetReturnStatus_I (IntPtr jnienv, IntPtr native__this, int returnStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnStatus (returnStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setReturnStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReturnStatus", "(I)V", "GetSetReturnStatus_IHandler")]
		public virtual unsafe void SetReturnStatus (int returnStatus)
		{
			const string __id = "setReturnStatus.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (returnStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSerialNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSerialNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setSerialNumber_Ljava_lang_String_ == null)
				cb_setSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSerialNumber_Ljava_lang_String_);
			return cb_setSerialNumber_Ljava_lang_String_;
		}

		static void n_SetSerialNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serialNumber)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serialNumber = JNIEnv.GetString (native_serialNumber, JniHandleOwnership.DoNotTransfer);
			__this.SetSerialNumber (serialNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setSerialNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSerialNumber (string serialNumber)
		{
			const string __id = "setSerialNumber.(Ljava/lang/String;)V";
			IntPtr native_serialNumber = JNIEnv.NewString (serialNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serialNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serialNumber);
			}
		}

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetType (string type)
		{
			const string __id = "setType.(Ljava/lang/String;)V";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		static Delegate cb_setsREDStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetsREDStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setsREDStatus_Ljava_lang_String_ == null)
				cb_setsREDStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetsREDStatus_Ljava_lang_String_);
			return cb_setsREDStatus_Ljava_lang_String_;
		}

		static void n_SetsREDStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sREDStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sREDStatus = JNIEnv.GetString (native_sREDStatus, JniHandleOwnership.DoNotTransfer);
			__this.SetsREDStatus (sREDStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='setsREDStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setsREDStatus", "(Ljava/lang/String;)V", "GetSetsREDStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void SetsREDStatus (string sREDStatus)
		{
			const string __id = "setsREDStatus.(Ljava/lang/String;)V";
			IntPtr native_sREDStatus = JNIEnv.NewString (sREDStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sREDStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sREDStatus);
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.DeviceApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='DeviceApiData']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Ljava/lang/String;", "GetTypeHandler")]
		public virtual unsafe string Type ()
		{
			const string __id = "type.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
