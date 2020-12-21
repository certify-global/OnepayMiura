using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/MpiClient", DoNotGenerateAcw=true)]
	public partial class MpiClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResult']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/MpiClient$OnlinePinResult", DoNotGenerateAcw=true)]
		public partial class OnlinePinResult : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResult']/field[@name='PinData']"
			[Register ("PinData")]
			public IList<byte> PinData {
				get {
					const string __id = "PinData.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "PinData.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResult']/field[@name='PinKsn']"
			[Register ("PinKsn")]
			public IList<byte> PinKsn {
				get {
					const string __id = "PinKsn.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "PinKsn.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResult']/field[@name='mType']"
			[Register ("mType")]
			public global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType MType {
				get {
					const string __id = "mType.Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "mType.Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/MpiClient$OnlinePinResult", typeof (OnlinePinResult));
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

			protected OnlinePinResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/MpiClient$OnlinePinResultType", DoNotGenerateAcw=true)]
		public sealed partial class OnlinePinResultType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']/field[@name='BypassedPinEntry']"
			[Register ("BypassedPinEntry")]
			public static global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType BypassedPinEntry {
				get {
					const string __id = "BypassedPinEntry.Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']/field[@name='CancelOrTimeout']"
			[Register ("CancelOrTimeout")]
			public static global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType CancelOrTimeout {
				get {
					const string __id = "CancelOrTimeout.Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']/field[@name='PinEnteredOk']"
			[Register ("PinEnteredOk")]
			public static global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType PinEnteredOk {
				get {
					const string __id = "PinEnteredOk.Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/MpiClient$OnlinePinResultType", typeof (OnlinePinResultType));
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

			internal OnlinePinResultType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient.OnlinePinResultType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType[] Values ()
			{
				const string __id = "values.()[Lcom/miurasystems/mpi/MpiClient$OnlinePinResultType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.MpiClient.OnlinePinResultType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/MpiClient", typeof (MpiClient));
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

		protected MpiClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/constructor[@name='MpiClient' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.comms.Connector'] and parameter[2][@type='com.miurasystems.mpi.events.MpiEvents']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/comms/Connector;Lcom/miurasystems/mpi/events/MpiEvents;)V", "")]
		public unsafe MpiClient (global::Com.Miurasystems.Mpi.Comms.Connector connector, global::Com.Miurasystems.Mpi.Events.MpiEvents mpiEvents)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/comms/Connector;Lcom/miurasystems/mpi/events/MpiEvents;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((connector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connector).Handle);
				__args [1] = new JniArgumentValue ((mpiEvents == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiEvents).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (connector);
				global::System.GC.KeepAlive (mpiEvents);
			}
		}

		static Delegate cb_getBatteryStatus;
#pragma warning disable 0169
		static Delegate GetGetBatteryStatusHandler ()
		{
			if (cb_getBatteryStatus == null)
				cb_getBatteryStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBatteryStatus);
			return cb_getBatteryStatus;
		}

		static IntPtr n_GetBatteryStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatteryStatus);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.BatteryData BatteryStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getBatteryStatus' and count(parameter)=0]"
			[Register ("getBatteryStatus", "()Lcom/miurasystems/mpi/api/objects/BatteryData;", "GetGetBatteryStatusHandler")]
			get {
				const string __id = "getBatteryStatus.()Lcom/miurasystems/mpi/api/objects/BatteryData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothInfo;
#pragma warning disable 0169
		static Delegate GetGetBluetoothInfoHandler ()
		{
			if (cb_getBluetoothInfo == null)
				cb_getBluetoothInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBluetoothInfo);
			return cb_getBluetoothInfo;
		}

		static IntPtr n_GetBluetoothInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.BluetoothInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> BluetoothInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getBluetoothInfo' and count(parameter)=0]"
			[Register ("getBluetoothInfo", "()Ljava/util/HashMap;", "GetGetBluetoothInfoHandler")]
			get {
				const string __id = "getBluetoothInfo.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfiguration);
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Ljava/util/HashMap;", "GetGetConfigurationHandler")]
			get {
				const string __id = "getConfiguration.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContactlessKernelVersions;
#pragma warning disable 0169
		static Delegate GetGetContactlessKernelVersionsHandler ()
		{
			if (cb_getContactlessKernelVersions == null)
				cb_getContactlessKernelVersions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContactlessKernelVersions);
			return cb_getContactlessKernelVersions;
		}

		static IntPtr n_GetContactlessKernelVersions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ContactlessKernelVersions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ContactlessKernelVersions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getContactlessKernelVersions' and count(parameter)=0]"
			[Register ("getContactlessKernelVersions", "()Ljava/util/Map;", "GetGetContactlessKernelVersionsHandler")]
			get {
				const string __id = "getContactlessKernelVersions.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMSDStatus;
#pragma warning disable 0169
		static Delegate GetGetMSDStatusHandler ()
		{
			if (cb_getMSDStatus == null)
				cb_getMSDStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMSDStatus);
			return cb_getMSDStatus;
		}

		static IntPtr n_GetMSDStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MSDStatus);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus MSDStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getMSDStatus' and count(parameter)=0]"
			[Register ("getMSDStatus", "()Lcom/miurasystems/mpi/api/objects/MSDStatus;", "GetGetMSDStatusHandler")]
			get {
				const string __id = "getMSDStatus.()Lcom/miurasystems/mpi/api/objects/MSDStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMpiEvents;
#pragma warning disable 0169
		static Delegate GetGetMpiEventsHandler ()
		{
			if (cb_getMpiEvents == null)
				cb_getMpiEvents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMpiEvents);
			return cb_getMpiEvents;
		}

		static IntPtr n_GetMpiEvents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MpiEvents);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Events.MpiEvents MpiEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getMpiEvents' and count(parameter)=0]"
			[Register ("getMpiEvents", "()Lcom/miurasystems/mpi/events/MpiEvents;", "GetGetMpiEventsHandler")]
			get {
				const string __id = "getMpiEvents.()Lcom/miurasystems/mpi/events/MpiEvents;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEvents> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWiFiStatus;
#pragma warning disable 0169
		static Delegate GetGetWiFiStatusHandler ()
		{
			if (cb_getWiFiStatus == null)
				cb_getWiFiStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWiFiStatus);
			return cb_getWiFiStatus;
		}

		static IntPtr n_GetWiFiStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WiFiStatus);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.WiFiStatus WiFiStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getWiFiStatus' and count(parameter)=0]"
			[Register ("getWiFiStatus", "()Lcom/miurasystems/mpi/api/objects/WiFiStatus;", "GetGetWiFiStatusHandler")]
			get {
				const string __id = "getWiFiStatus.()Lcom/miurasystems/mpi/api/objects/WiFiStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.WiFiStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
#pragma warning disable 0169
		static Delegate GetAbort_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler ()
		{
			if (cb_abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z == null)
				cb_abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_Abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z);
			return cb_abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
		}

		static bool n_Abort_Lcom_miurasystems_mpi_enums_InterfaceType_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool waitForDeclined)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Abort (interfaceType, waitForDeclined);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='abort' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean']]"
		[Register ("abort", "(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Z", "GetAbort_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler")]
		public virtual unsafe bool Abort (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool waitForDeclined)
		{
			const string __id = "abort.(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (waitForDeclined);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_abortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetAbortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_abortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_abortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AbortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_abortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static bool n_AbortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AbortTransaction (interfaceType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='abortTransaction' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("abortTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Z", "GetAbortTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe bool AbortTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "abortTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_abortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetAbortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_abortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_abortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AbortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_abortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static int n_AbortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AbortTransactionEx (interfaceType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='abortTransactionEx' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("abortTransactionEx", "(Lcom/miurasystems/mpi/enums/InterfaceType;)I", "GetAbortTransactionEx_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe int AbortTransactionEx (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "abortTransactionEx.(Lcom/miurasystems/mpi/enums/InterfaceType;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_barcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
#pragma warning disable 0169
		static Delegate GetBarcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler ()
		{
			if (cb_barcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z == null)
				cb_barcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_BarcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z);
			return cb_barcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
		}

		static bool n_BarcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool codeReporting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BarcodeStatus (interfaceType, codeReporting);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='barcodeStatus' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean']]"
		[Register ("barcodeStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Z", "GetBarcodeStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler")]
		public virtual unsafe bool BarcodeStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool codeReporting)
		{
			const string __id = "barcodeStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (codeReporting);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_buzzer_Z;
#pragma warning disable 0169
		static Delegate GetBuzzer_ZHandler ()
		{
			if (cb_buzzer_Z == null)
				cb_buzzer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Buzzer_Z);
			return cb_buzzer_Z;
		}

		static IntPtr n_Buzzer_Z (IntPtr jnienv, IntPtr native__this, bool synchronousSound)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buzzer (synchronousSound));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='buzzer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buzzer", "(Z)Lcom/miurasystems/mpi/enums/BuzzerResponse;", "GetBuzzer_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.BuzzerResponse Buzzer (bool synchronousSound)
		{
			const string __id = "buzzer.(Z)Lcom/miurasystems/mpi/enums/BuzzerResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (synchronousSound);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetBuzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
		{
			if (cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
				cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLLL_L) n_Buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_);
			return cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		}

		static IntPtr n_Buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, bool synchronousSound, IntPtr native_duration, IntPtr native_volume, IntPtr native_frequency)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var duration = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_duration, JniHandleOwnership.DoNotTransfer);
			var volume = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_volume, JniHandleOwnership.DoNotTransfer);
			var frequency = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_frequency, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Buzzer (synchronousSound, duration, volume, frequency));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='buzzer' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer']]"
		[Register ("buzzer", "(ZLjava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Lcom/miurasystems/mpi/enums/BuzzerResponse;", "GetBuzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.BuzzerResponse Buzzer (bool synchronousSound, global::Java.Lang.Integer duration, global::Java.Lang.Integer volume, global::Java.Lang.Integer frequency)
		{
			const string __id = "buzzer.(ZLjava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Lcom/miurasystems/mpi/enums/BuzzerResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (synchronousSound);
				__args [1] = new JniArgumentValue ((duration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) duration).Handle);
				__args [2] = new JniArgumentValue ((volume == null) ? IntPtr.Zero : ((global::Java.Lang.Object) volume).Handle);
				__args [3] = new JniArgumentValue ((frequency == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frequency).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BuzzerResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (duration);
				global::System.GC.KeepAlive (volume);
				global::System.GC.KeepAlive (frequency);
			}
		}

		static Delegate cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ;
#pragma warning disable 0169
		static Delegate GetCardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZHandler ()
		{
			if (cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ == null)
				cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZZZZ_V) n_CardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ);
			return cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ;
		}

		static void n_CardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			__this.CardStatus (interfaceType, enableUnsolicited, enableAtr, enableTrack1, enableTrack2, enableTrack3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='cardStatus' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("cardStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZ)V", "GetCardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZHandler")]
		public virtual unsafe void CardStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3)
		{
			const string __id = "cardStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (enableUnsolicited);
				__args [2] = new JniArgumentValue (enableAtr);
				__args [3] = new JniArgumentValue (enableTrack1);
				__args [4] = new JniArgumentValue (enableTrack2);
				__args [5] = new JniArgumentValue (enableTrack3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ;
#pragma warning disable 0169
		static Delegate GetCardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZHandler ()
		{
			if (cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ == null)
				cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZZZZZ_V) n_CardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ);
			return cb_cardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ;
		}

		static void n_CardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3, bool enableCardholderName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			__this.CardStatus (interfaceType, enableUnsolicited, enableAtr, enableTrack1, enableTrack2, enableTrack3, enableCardholderName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='cardStatus' and count(parameter)=7 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("cardStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZZ)V", "GetCardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZHandler")]
		public virtual unsafe void CardStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3, bool enableCardholderName)
		{
			const string __id = "cardStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (enableUnsolicited);
				__args [2] = new JniArgumentValue (enableAtr);
				__args [3] = new JniArgumentValue (enableTrack1);
				__args [4] = new JniArgumentValue (enableTrack2);
				__args [5] = new JniArgumentValue (enableTrack3);
				__args [6] = new JniArgumentValue (enableCardholderName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ;
#pragma warning disable 0169
		static Delegate GetCardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZHandler ()
		{
			if (cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ == null)
				cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZZZZ_L) n_CardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ);
			return cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ;
		}

		static IntPtr n_CardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CardStatusSolicited (interfaceType, enableUnsolicited, enableAtr, enableTrack1, enableTrack2, enableTrack3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='cardStatusSolicited' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("cardStatusSolicited", "(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZ)Lcom/miurasystems/mpi/tlv/CardData;", "GetCardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.CardData CardStatusSolicited (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3)
		{
			const string __id = "cardStatusSolicited.(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZ)Lcom/miurasystems/mpi/tlv/CardData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (enableUnsolicited);
				__args [2] = new JniArgumentValue (enableAtr);
				__args [3] = new JniArgumentValue (enableTrack1);
				__args [4] = new JniArgumentValue (enableTrack2);
				__args [5] = new JniArgumentValue (enableTrack3);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ;
#pragma warning disable 0169
		static Delegate GetCardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZHandler ()
		{
			if (cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ == null)
				cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZZZZZ_L) n_CardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ);
			return cb_cardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ;
		}

		static IntPtr n_CardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3, bool enableCardholderName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CardStatusSolicited (interfaceType, enableUnsolicited, enableAtr, enableTrack1, enableTrack2, enableTrack3, enableCardholderName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='cardStatusSolicited' and count(parameter)=7 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("cardStatusSolicited", "(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZZ)Lcom/miurasystems/mpi/tlv/CardData;", "GetCardStatusSolicited_Lcom_miurasystems_mpi_enums_InterfaceType_ZZZZZZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.CardData CardStatusSolicited (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool enableUnsolicited, bool enableAtr, bool enableTrack1, bool enableTrack2, bool enableTrack3, bool enableCardholderName)
		{
			const string __id = "cardStatusSolicited.(Lcom/miurasystems/mpi/enums/InterfaceType;ZZZZZZ)Lcom/miurasystems/mpi/tlv/CardData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (enableUnsolicited);
				__args [2] = new JniArgumentValue (enableAtr);
				__args [3] = new JniArgumentValue (enableTrack1);
				__args [4] = new JniArgumentValue (enableTrack2);
				__args [5] = new JniArgumentValue (enableTrack3);
				__args [6] = new JniArgumentValue (enableCardholderName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_cashDrawer_Z;
#pragma warning disable 0169
		static Delegate GetCashDrawer_ZHandler ()
		{
			if (cb_cashDrawer_Z == null)
				cb_cashDrawer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_CashDrawer_Z);
			return cb_cashDrawer_Z;
		}

		static IntPtr n_CashDrawer_Z (IntPtr jnienv, IntPtr native__this, bool openDrawer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CashDrawer (openDrawer));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='cashDrawer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cashDrawer", "(Z)Lcom/miurasystems/mpi/enums/CashDrawer;", "GetCashDrawer_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.CashDrawer CashDrawer (bool openDrawer)
		{
			const string __id = "cashDrawer.(Z)Lcom/miurasystems/mpi/enums/CashDrawer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (openDrawer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.CashDrawer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearContactlessLeds;
#pragma warning disable 0169
		static Delegate GetClearContactlessLedsHandler ()
		{
			if (cb_clearContactlessLeds == null)
				cb_clearContactlessLeds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ClearContactlessLeds);
			return cb_clearContactlessLeds;
		}

		static bool n_ClearContactlessLeds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearContactlessLeds ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='clearContactlessLeds' and count(parameter)=0]"
		[Register ("clearContactlessLeds", "()Z", "GetClearContactlessLedsHandler")]
		public virtual unsafe bool ClearContactlessLeds ()
		{
			const string __id = "clearContactlessLeds.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_;
#pragma warning disable 0169
		static Delegate GetClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler ()
		{
			if (cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_ == null)
				cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_);
			return cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_;
		}

		static bool n_ClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ClearFolder (folder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='clearFolder' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.DeviceFolder']]"
		[Register ("clearFolder", "(Lcom/miurasystems/mpi/enums/DeviceFolder;)Z", "GetClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler")]
		public virtual unsafe bool ClearFolder (global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder)
		{
			const string __id = "clearFolder.(Lcom/miurasystems/mpi/enums/DeviceFolder;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (folder);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "GetCloseSessionHandler")]
		public virtual unsafe void CloseSession ()
		{
			const string __id = "closeSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_continueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_;
#pragma warning disable 0169
		static Delegate GetContinueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_Handler ()
		{
			if (cb_continueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_ == null)
				cb_continueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ContinueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_);
			return cb_continueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_;
		}

		static IntPtr n_ContinueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_transactionInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var transactionInfo = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (native_transactionInfo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ContinueTransaction (interfaceType, transactionInfo));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='continueTransaction' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("continueTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/Result;", "GetContinueTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_tlv_TLVObject_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result ContinueTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Tlv.TLVObject transactionInfo)
		{
			const string __id = "continueTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((transactionInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionInfo).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (transactionInfo);
			}
		}

		static Delegate cb_deleteFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_ == null)
				cb_deleteFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DeleteFile_Ljava_lang_String_);
			return cb_deleteFile_Ljava_lang_String_;
		}

		static bool n_DeleteFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (fileName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public virtual unsafe bool DeleteFile (string fileName)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ == null)
				cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_);
			return cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_;
		}

		static bool n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_folder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (fileName, folder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='deleteFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.enums.DeviceFolder']]"
		[Register ("deleteFile", "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;)Z", "GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler")]
		public virtual unsafe bool DeleteFile (string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder)
		{
			const string __id = "deleteFile.(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (folder);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_ZZHandler ()
		{
			if (cb_displayImage_Ljava_lang_String_ZZ == null)
				cb_displayImage_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_Z) n_DisplayImage_Ljava_lang_String_ZZ);
			return cb_displayImage_Ljava_lang_String_ZZ;
		}

		static bool n_DisplayImage_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageFilename, bool isFullScreen, bool isBacklightOn)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageFilename = JNIEnv.GetString (native_imageFilename, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DisplayImage (imageFilename, isFullScreen, isBacklightOn);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='displayImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("displayImage", "(Ljava/lang/String;ZZ)Z", "GetDisplayImage_Ljava_lang_String_ZZHandler")]
		public virtual unsafe bool DisplayImage (string imageFilename, bool isFullScreen, bool isBacklightOn)
		{
			const string __id = "displayImage.(Ljava/lang/String;ZZ)Z";
			IntPtr native_imageFilename = JNIEnv.NewString (imageFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_imageFilename);
				__args [1] = new JniArgumentValue (isFullScreen);
				__args [2] = new JniArgumentValue (isBacklightOn);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_imageFilename);
			}
		}

		static Delegate cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_;
#pragma warning disable 0169
		static Delegate GetDisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Handler ()
		{
			if (cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_ == null)
				cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_DisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_);
			return cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_;
		}

		static bool n_DisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_displayMediaData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var displayMediaData = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (native_displayMediaData, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DisplayMedia (displayMediaData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='displayMedia' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.DisplayMediaData']]"
		[Register ("displayMedia", "(Lcom/miurasystems/mpi/api/objects/DisplayMediaData;)Z", "GetDisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Handler")]
		public virtual unsafe bool DisplayMedia (global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData displayMediaData)
		{
			const string __id = "displayMedia.(Lcom/miurasystems/mpi/api/objects/DisplayMediaData;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((displayMediaData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) displayMediaData).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (displayMediaData);
			}
		}

		static Delegate cb_displayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ;
#pragma warning disable 0169
		static Delegate GetDisplayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZHandler ()
		{
			if (cb_displayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ == null)
				cb_displayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZZZ_Z) n_DisplayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ);
			return cb_displayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ;
		}

		static bool n_DisplayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_text, bool isFourRow, bool isBacklightOn, bool isUTF8Encoding)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DisplayText (interfaceType, text, isFourRow, isBacklightOn, isUTF8Encoding);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='displayText' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("displayText", "(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;ZZZ)Z", "GetDisplayText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ZZZHandler")]
		public virtual unsafe bool DisplayText (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string text, bool isFourRow, bool isBacklightOn, bool isUTF8Encoding)
		{
			const string __id = "displayText.(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;ZZZ)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue (isFourRow);
				__args [3] = new JniArgumentValue (isBacklightOn);
				__args [4] = new JniArgumentValue (isUTF8Encoding);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_enableWiFiEvents_Z;
#pragma warning disable 0169
		static Delegate GetEnableWiFiEvents_ZHandler ()
		{
			if (cb_enableWiFiEvents_Z == null)
				cb_enableWiFiEvents_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_EnableWiFiEvents_Z);
			return cb_enableWiFiEvents_Z;
		}

		static bool n_EnableWiFiEvents_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableWiFiEvents (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='enableWiFiEvents' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableWiFiEvents", "(Z)Z", "GetEnableWiFiEvents_ZHandler")]
		public virtual unsafe bool EnableWiFiEvents (bool enable)
		{
			const string __id = "enableWiFiEvents.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_getDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_getDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_getDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static IntPtr n_GetDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.Capability>.ToLocalJniHandle (__this.GetDeviceInfo (interfaceType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("getDeviceInfo", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Ljava/util/ArrayList;", "GetGetDeviceInfo_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Api.Objects.Capability> GetDeviceInfo (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "getDeviceInfo.(Lcom/miurasystems/mpi/enums/InterfaceType;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.Capability>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Handler ()
		{
			if (cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_ == null)
				cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLIIIILL_L) n_GetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_);
			return cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_;
		}

		static IntPtr n_GetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, bool displayedAmountIncludesTotal, IntPtr native_percentages, int tipTemplate, int amountInPennies, int currencyCode, int currencyExponent, IntPtr native_options, IntPtr native_timeoutInSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var percentages = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_percentages, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDynamicTip (displayedAmountIncludesTotal, percentages, tipTemplate, amountInPennies, currencyCode, currencyExponent, options, timeoutInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getDynamicTip' and count(parameter)=8 and parameter[1][@type='boolean'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[8][@type='java.lang.Integer']]"
		[Register ("getDynamicTip", "(ZLjava/util/List;IIIILjava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;", "GetGetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result GetDynamicTip (bool displayedAmountIncludesTotal, global::System.Collections.Generic.IList<global::Java.Lang.Integer> percentages, int tipTemplate, int amountInPennies, int currencyCode, int currencyExponent, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "getDynamicTip.(ZLjava/util/List;IIIILjava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;";
			IntPtr native_percentages = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (percentages);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (displayedAmountIncludesTotal);
				__args [1] = new JniArgumentValue (native_percentages);
				__args [2] = new JniArgumentValue (tipTemplate);
				__args [3] = new JniArgumentValue (amountInPennies);
				__args [4] = new JniArgumentValue (currencyCode);
				__args [5] = new JniArgumentValue (currencyExponent);
				__args [6] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [7] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_percentages);
				global::System.GC.KeepAlive (percentages);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		static Delegate cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Handler ()
		{
			if (cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_ == null)
				cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_GetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_);
			return cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_;
		}

		static IntPtr n_GetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_menuTitle, IntPtr native_options, IntPtr native_timeoutInSeconds, IntPtr native_menuOptions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var menuTitle = JNIEnv.GetString (native_menuTitle, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var menuOptions = global::Android.Runtime.JavaList<string>.FromJniHandle (native_menuOptions, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMenuOption (menuTitle, options, timeoutInSeconds, menuOptions));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getMenuOption' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetMenuOptions&gt;'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getMenuOption", "(Ljava/lang/String;Ljava/util/EnumSet;Ljava/lang/Integer;Ljava/util/List;)Lcom/miurasystems/mpi/Result;", "GetGetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result GetMenuOption (string menuTitle, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds, global::System.Collections.Generic.IList<string> menuOptions)
		{
			const string __id = "getMenuOption.(Ljava/lang/String;Ljava/util/EnumSet;Ljava/lang/Integer;Ljava/util/List;)Lcom/miurasystems/mpi/Result;";
			IntPtr native_menuTitle = JNIEnv.NewString (menuTitle);
			IntPtr native_menuOptions = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (menuOptions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_menuTitle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [3] = new JniArgumentValue (native_menuOptions);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_menuTitle);
				JNIEnv.DeleteLocalRef (native_menuOptions);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (menuOptions);
			}
		}

		static Delegate cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_;
#pragma warning disable 0169
		static Delegate GetGetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Handler ()
		{
			if (cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_ == null)
				cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_);
			return cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_;
		}

		static IntPtr n_GetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumericData (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getNumericData' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.GetNumericDataRequest']]"
		[Register ("getNumericData", "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;)Lcom/miurasystems/mpi/Result;", "GetGetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result GetNumericData (global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest request)
		{
			const string __id = "getNumericData.(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (request);
			}
		}

		static Delegate cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Handler ()
		{
			if (cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_ == null)
				cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZZZZLL_L) n_GetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_);
			return cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_;
		}

		static IntPtr n_GetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, bool getPan, bool getStartDate, bool getExpiryDate, bool getCVV, bool yyMm, IntPtr native_options, IntPtr native_timeoutInSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSecureCardData (getPan, getStartDate, getExpiryDate, getCVV, yyMm, options, timeoutInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getSecureCardData' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[7][@type='java.lang.Integer']]"
		[Register ("getSecureCardData", "(ZZZZZLjava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;", "GetGetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result GetSecureCardData (bool getPan, bool getStartDate, bool getExpiryDate, bool getCVV, bool yyMm, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "getSecureCardData.(ZZZZZLjava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (getPan);
				__args [1] = new JniArgumentValue (getStartDate);
				__args [2] = new JniArgumentValue (getExpiryDate);
				__args [3] = new JniArgumentValue (getCVV);
				__args [4] = new JniArgumentValue (yyMm);
				__args [5] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [6] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		static Delegate cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Handler ()
		{
			if (cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_ == null)
				cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_);
			return cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_;
		}

		static IntPtr n_GetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_timeoutInSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSecurePan (options, timeoutInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getSecurePan' and count(parameter)=2 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("getSecurePan", "(Ljava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;", "GetGetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result GetSecurePan (global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "getSecurePan.(Ljava/util/EnumSet;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		static Delegate cb_getUSBStatus_Z;
#pragma warning disable 0169
		static Delegate GetGetUSBStatus_ZHandler ()
		{
			if (cb_getUSBStatus_Z == null)
				cb_getUSBStatus_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_GetUSBStatus_Z);
			return cb_getUSBStatus_Z;
		}

		static IntPtr n_GetUSBStatus_Z (IntPtr jnienv, IntPtr native__this, bool onStatusChange)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUSBStatus (onStatusChange));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='getUSBStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getUSBStatus", "(Z)Lcom/miurasystems/mpi/enums/USBStatus;", "GetGetUSBStatus_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.USBStatus GetUSBStatus (bool onStatusChange)
		{
			const string __id = "getUSBStatus.(Z)Lcom/miurasystems/mpi/enums/USBStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (onStatusChange);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.USBStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_keyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_;
#pragma warning disable 0169
		static Delegate GetKeyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Handler ()
		{
			if (cb_keyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_ == null)
				cb_keyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_KeyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_);
			return cb_keyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_;
		}

		static bool n_KeyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_statusSetting, IntPtr native_backlightSetting)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var statusSetting = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.StatusSettings> (native_statusSetting, JniHandleOwnership.DoNotTransfer);
			var backlightSetting = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BacklightSettings> (native_backlightSetting, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.KeyboardStatus (interfaceType, statusSetting, backlightSetting);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='keyboardStatus' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.StatusSettings'] and parameter[3][@type='com.miurasystems.mpi.enums.BacklightSettings']]"
		[Register ("keyboardStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/StatusSettings;Lcom/miurasystems/mpi/enums/BacklightSettings;)Z", "GetKeyboardStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Handler")]
		public virtual unsafe bool KeyboardStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.StatusSettings statusSetting, global::Com.Miurasystems.Mpi.Enums.BacklightSettings backlightSetting)
		{
			const string __id = "keyboardStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/StatusSettings;Lcom/miurasystems/mpi/enums/BacklightSettings;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((statusSetting == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusSetting).Handle);
				__args [2] = new JniArgumentValue ((backlightSetting == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backlightSetting).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (statusSetting);
				global::System.GC.KeepAlive (backlightSetting);
			}
		}

		static Delegate cb_listFiles;
#pragma warning disable 0169
		static Delegate GetListFilesHandler ()
		{
			if (cb_listFiles == null)
				cb_listFiles = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ListFiles);
			return cb_listFiles;
		}

		static IntPtr n_ListFiles (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ListFiles ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='listFiles' and count(parameter)=0]"
		[Register ("listFiles", "()Ljava/util/List;", "GetListFilesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> ListFiles ()
		{
			const string __id = "listFiles.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_;
#pragma warning disable 0169
		static Delegate GetListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler ()
		{
			if (cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_ == null)
				cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_);
			return cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_;
		}

		static IntPtr n_ListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ListFiles (folder));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='listFiles' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.DeviceFolder']]"
		[Register ("listFiles", "(Lcom/miurasystems/mpi/enums/DeviceFolder;)Ljava/util/List;", "GetListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> ListFiles (global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder)
		{
			const string __id = "listFiles.(Lcom/miurasystems/mpi/enums/DeviceFolder;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (folder);
			}
		}

		static Delegate cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Handler ()
		{
			if (cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ == null)
				cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILL_L) n_OnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_);
			return cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_;
		}

		static IntPtr n_OnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, int amountInPennies, int currencyCode, IntPtr native_maskedTrack2Data, IntPtr native_applicationLabel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var maskedTrack2Data = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (native_maskedTrack2Data, JniHandleOwnership.DoNotTransfer);
			var applicationLabel = JNIEnv.GetString (native_applicationLabel, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnlinePin (interfaceType, amountInPennies, currencyCode, maskedTrack2Data, applicationLabel));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='onlinePin' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[5][@type='java.lang.String']]"
		[Register ("onlinePin", "(Lcom/miurasystems/mpi/enums/InterfaceType;IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;)Lcom/miurasystems/mpi/Result;", "GetOnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result OnlinePin (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string applicationLabel)
		{
			const string __id = "onlinePin.(Lcom/miurasystems/mpi/enums/InterfaceType;IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;)Lcom/miurasystems/mpi/Result;";
			IntPtr native_applicationLabel = JNIEnv.NewString (applicationLabel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [4] = new JniArgumentValue (native_applicationLabel);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationLabel);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (maskedTrack2Data);
			}
		}

		static Delegate cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetOnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZHandler ()
		{
			if (cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ == null)
				cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILLZZ_L) n_OnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ);
			return cb_onlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ;
		}

		static IntPtr n_OnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, int amountInPennies, int currencyCode, IntPtr native_maskedTrack2Data, IntPtr native_applicationLabel, bool encryptedPINData, bool enablePinByPass)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var maskedTrack2Data = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (native_maskedTrack2Data, JniHandleOwnership.DoNotTransfer);
			var applicationLabel = JNIEnv.GetString (native_applicationLabel, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnlinePin (interfaceType, amountInPennies, currencyCode, maskedTrack2Data, applicationLabel, encryptedPINData, enablePinByPass));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='onlinePin' and count(parameter)=7 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("onlinePin", "(Lcom/miurasystems/mpi/enums/InterfaceType;IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;ZZ)Lcom/miurasystems/mpi/Result;", "GetOnlinePin_Lcom_miurasystems_mpi_enums_InterfaceType_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result OnlinePin (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string applicationLabel, bool encryptedPINData, bool enablePinByPass)
		{
			const string __id = "onlinePin.(Lcom/miurasystems/mpi/enums/InterfaceType;IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;ZZ)Lcom/miurasystems/mpi/Result;";
			IntPtr native_applicationLabel = JNIEnv.NewString (applicationLabel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [4] = new JniArgumentValue (native_applicationLabel);
				__args [5] = new JniArgumentValue (encryptedPINData);
				__args [6] = new JniArgumentValue (enablePinByPass);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationLabel);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (maskedTrack2Data);
			}
		}

		static Delegate cb_openSession;
#pragma warning disable 0169
		static Delegate GetOpenSessionHandler ()
		{
			if (cb_openSession == null)
				cb_openSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OpenSession);
			return cb_openSession;
		}

		static void n_OpenSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='openSession' and count(parameter)=0]"
		[Register ("openSession", "()V", "GetOpenSessionHandler")]
		public virtual unsafe void OpenSession ()
		{
			const string __id = "openSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_p2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetP2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_p2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_p2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_P2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_p2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static IntPtr n_P2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.P2peImport (interfaceType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='p2peImport' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("p2peImport", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/enums/RKIError;", "GetP2peImport_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.RKIError P2peImport (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "p2peImport.(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/enums/RKIError;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.RKIError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_p2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetP2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_p2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_p2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_P2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_p2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static bool n_P2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.P2peInitialise (interfaceType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='p2peInitialise' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("p2peInitialise", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Z", "GetP2peInitialise_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe bool P2peInitialise (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "p2peInitialise.(Lcom/miurasystems/mpi/enums/InterfaceType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_p2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetP2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_p2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_p2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_P2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_p2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static IntPtr n_P2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.P2peStatus (interfaceType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='p2peStatus' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("p2peStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/api/objects/P2PEStatus;", "GetP2peStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus P2peStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "p2peStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/api/objects/P2PEStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_peripheralStatusCommand;
#pragma warning disable 0169
		static Delegate GetPeripheralStatusCommandHandler ()
		{
			if (cb_peripheralStatusCommand == null)
				cb_peripheralStatusCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeripheralStatusCommand);
			return cb_peripheralStatusCommand;
		}

		static IntPtr n_PeripheralStatusCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PeripheralStatusCommand ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='peripheralStatusCommand' and count(parameter)=0]"
		[Register ("peripheralStatusCommand", "()Ljava/util/ArrayList;", "GetPeripheralStatusCommandHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> PeripheralStatusCommand ()
		{
			const string __id = "peripheralStatusCommand.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_powerOff;
#pragma warning disable 0169
		static Delegate GetPowerOffHandler ()
		{
			if (cb_powerOff == null)
				cb_powerOff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PowerOff);
			return cb_powerOff;
		}

		static IntPtr n_PowerOff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PowerOff ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='powerOff' and count(parameter)=0]"
		[Register ("powerOff", "()Lcom/miurasystems/mpi/api/objects/BatteryData;", "GetPowerOffHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.BatteryData PowerOff ()
		{
			const string __id = "powerOff.()Lcom/miurasystems/mpi/api/objects/BatteryData;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_printESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler ()
		{
			if (cb_printESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ == null)
				cb_printESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_PrintESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_);
			return cb_printESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
		}

		static bool n_PrintESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PrintESCPOScommand (interfaceType, text);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='printESCPOScommand' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='java.lang.String']]"
		[Register ("printESCPOScommand", "(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z", "GetPrintESCPOScommand_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler")]
		public virtual unsafe bool PrintESCPOScommand (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string text)
		{
			const string __id = "printESCPOScommand.(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_printerSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
#pragma warning disable 0169
		static Delegate GetPrinterSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler ()
		{
			if (cb_printerSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z == null)
				cb_printerSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_PrinterSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z);
			return cb_printerSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z;
		}

		static IntPtr n_PrinterSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, bool printerSledStatusEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrinterSledStatus (interfaceType, printerSledStatusEnabled));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='printerSledStatus' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='boolean']]"
		[Register ("printerSledStatus", "(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Lcom/miurasystems/mpi/events/PrinterStatus;", "GetPrinterSledStatus_Lcom_miurasystems_mpi_enums_InterfaceType_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Events.PrinterStatus PrinterSledStatus (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, bool printerSledStatusEnabled)
		{
			const string __id = "printerSledStatus.(Lcom/miurasystems/mpi/enums/InterfaceType;Z)Lcom/miurasystems/mpi/events/PrinterStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (printerSledStatusEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_queryProxySocketStatus;
#pragma warning disable 0169
		static Delegate GetQueryProxySocketStatusHandler ()
		{
			if (cb_queryProxySocketStatus == null)
				cb_queryProxySocketStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryProxySocketStatus);
			return cb_queryProxySocketStatus;
		}

		static IntPtr n_QueryProxySocketStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QueryProxySocketStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='queryProxySocketStatus' and count(parameter)=0]"
		[Register ("queryProxySocketStatus", "()Ljava/util/EnumSet;", "GetQueryProxySocketStatusHandler")]
		public virtual unsafe global::Java.Util.EnumSet QueryProxySocketStatus ()
		{
			const string __id = "queryProxySocketStatus.()Ljava/util/EnumSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III;
#pragma warning disable 0169
		static Delegate GetReadBinary_Lcom_miurasystems_mpi_enums_InterfaceType_IIIHandler ()
		{
			if (cb_readBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III == null)
				cb_readBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_ReadBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III);
			return cb_readBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III;
		}

		static IntPtr n_ReadBinary_Lcom_miurasystems_mpi_enums_InterfaceType_III (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, int fileSize, int offset, int size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadBinary (interfaceType, fileSize, offset, size));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='readBinary' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readBinary", "(Lcom/miurasystems/mpi/enums/InterfaceType;III)Lcom/miurasystems/mpi/comms/ResponseMessage;", "GetReadBinary_Lcom_miurasystems_mpi_enums_InterfaceType_IIIHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.ResponseMessage ReadBinary (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, int fileSize, int offset, int size)
		{
			const string __id = "readBinary.(Lcom/miurasystems/mpi/enums/InterfaceType;III)Lcom/miurasystems/mpi/comms/ResponseMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (fileSize);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_rerouteProxySocket_Ljava_util_EnumSet_Z;
#pragma warning disable 0169
		static Delegate GetRerouteProxySocket_Ljava_util_EnumSet_ZHandler ()
		{
			if (cb_rerouteProxySocket_Ljava_util_EnumSet_Z == null)
				cb_rerouteProxySocket_Ljava_util_EnumSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_RerouteProxySocket_Ljava_util_EnumSet_Z);
			return cb_rerouteProxySocket_Ljava_util_EnumSet_Z;
		}

		static bool n_RerouteProxySocket_Ljava_util_EnumSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaces, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaces = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_interfaces, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RerouteProxySocket (interfaces, enabled);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='rerouteProxySocket' and count(parameter)=2 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.ProxyCommsInterface&gt;'] and parameter[2][@type='boolean']]"
		[Register ("rerouteProxySocket", "(Ljava/util/EnumSet;Z)Z", "GetRerouteProxySocket_Ljava_util_EnumSet_ZHandler")]
		public virtual unsafe bool RerouteProxySocket (global::Java.Util.EnumSet interfaces, bool enabled)
		{
			const string __id = "rerouteProxySocket.(Ljava/util/EnumSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaces == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaces).Handle);
				__args [1] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaces);
			}
		}

		static Delegate cb_resetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_;
#pragma warning disable 0169
		static Delegate GetResetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_Handler ()
		{
			if (cb_resetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_ == null)
				cb_resetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ResetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_);
			return cb_resetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_;
		}

		static IntPtr n_ResetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ResetDeviceType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResetDevice (interfaceType, type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='resetDevice' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.ResetDeviceType']]"
		[Register ("resetDevice", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/ResetDeviceType;)Lcom/miurasystems/mpi/api/objects/SoftwareInfo;", "GetResetDevice_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_ResetDeviceType_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo ResetDevice (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.ResetDeviceType type)
		{
			const string __id = "resetDevice.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/ResetDeviceType;)Lcom/miurasystems/mpi/api/objects/SoftwareInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_restartWiFi;
#pragma warning disable 0169
		static Delegate GetRestartWiFiHandler ()
		{
			if (cb_restartWiFi == null)
				cb_restartWiFi = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RestartWiFi);
			return cb_restartWiFi;
		}

		static bool n_RestartWiFi (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RestartWiFi ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='restartWiFi' and count(parameter)=0]"
		[Register ("restartWiFi", "()Z", "GetRestartWiFiHandler")]
		public virtual unsafe bool RestartWiFi ()
		{
			const string __id = "restartWiFi.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Handler ()
		{
			if (cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_ == null)
				cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_SelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_);
			return cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_;
		}

		static int n_SelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_mode, IntPtr native_fileName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SelectFileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SelectFile (interfaceType, mode, fileName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='selectFile' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.SelectFileMode'] and parameter[3][@type='java.lang.String']]"
		[Register ("selectFile", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SelectFileMode;Ljava/lang/String;)I", "GetSelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Handler")]
		public virtual unsafe int SelectFile (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.SelectFileMode mode, string fileName)
		{
			const string __id = "selectFile.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SelectFileMode;Ljava/lang/String;)I";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_;
#pragma warning disable 0169
		static Delegate GetSelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler ()
		{
			if (cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ == null)
				cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_I) n_SelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_);
			return cb_selectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_;
		}

		static int n_SelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_mode, IntPtr native_fileName, IntPtr native_folder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SelectFileMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SelectFile (interfaceType, mode, fileName, folder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='selectFile' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.SelectFileMode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.enums.DeviceFolder']]"
		[Register ("selectFile", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SelectFileMode;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;)I", "GetSelectFile_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SelectFileMode_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Handler")]
		public virtual unsafe int SelectFile (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.SelectFileMode mode, string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder)
		{
			const string __id = "selectFile.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SelectFileMode;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;)I";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (mode);
				global::System.GC.KeepAlive (folder);
			}
		}

		static Delegate cb_sendDataToSerialPort_arrayB;
#pragma warning disable 0169
		static Delegate GetSendDataToSerialPort_arrayBHandler ()
		{
			if (cb_sendDataToSerialPort_arrayB == null)
				cb_sendDataToSerialPort_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SendDataToSerialPort_arrayB);
			return cb_sendDataToSerialPort_arrayB;
		}

		static bool n_SendDataToSerialPort_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SendDataToSerialPort (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='sendDataToSerialPort' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendDataToSerialPort", "([B)Z", "GetSendDataToSerialPort_arrayBHandler")]
		public virtual unsafe bool SendDataToSerialPort (byte[] data)
		{
			const string __id = "sendDataToSerialPort.([B)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_setBatteryStatusEvents_ZZ;
#pragma warning disable 0169
		static Delegate GetSetBatteryStatusEvents_ZZHandler ()
		{
			if (cb_setBatteryStatusEvents_ZZ == null)
				cb_setBatteryStatusEvents_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZ_L) n_SetBatteryStatusEvents_ZZ);
			return cb_setBatteryStatusEvents_ZZ;
		}

		static IntPtr n_SetBatteryStatusEvents_ZZ (IntPtr jnienv, IntPtr native__this, bool onChargingChange, bool onThresholdReached)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBatteryStatusEvents (onChargingChange, onThresholdReached));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='setBatteryStatusEvents' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("setBatteryStatusEvents", "(ZZ)Lcom/miurasystems/mpi/api/objects/BatteryData;", "GetSetBatteryStatusEvents_ZZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.BatteryData SetBatteryStatusEvents (bool onChargingChange, bool onThresholdReached)
		{
			const string __id = "setBatteryStatusEvents.(ZZ)Lcom/miurasystems/mpi/api/objects/BatteryData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (onChargingChange);
				__args [1] = new JniArgumentValue (onThresholdReached);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMSDControl_Z;
#pragma warning disable 0169
		static Delegate GetSetMSDControl_ZHandler ()
		{
			if (cb_setMSDControl_Z == null)
				cb_setMSDControl_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetMSDControl_Z);
			return cb_setMSDControl_Z;
		}

		static IntPtr n_SetMSDControl_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMSDControl (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='setMSDControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMSDControl", "(Z)Lcom/miurasystems/mpi/api/objects/MSDStatus;", "GetSetMSDControl_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus SetMSDControl (bool enable)
		{
			const string __id = "setMSDControl.(Z)Lcom/miurasystems/mpi/api/objects/MSDStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMSDExport_Z;
#pragma warning disable 0169
		static Delegate GetSetMSDExport_ZHandler ()
		{
			if (cb_setMSDExport_Z == null)
				cb_setMSDExport_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetMSDExport_Z);
			return cb_setMSDExport_Z;
		}

		static IntPtr n_SetMSDExport_Z (IntPtr jnienv, IntPtr native__this, bool start)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMSDExport (start));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='setMSDExport' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMSDExport", "(Z)Lcom/miurasystems/mpi/api/objects/MSDStatus;", "GetSetMSDExport_ZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus SetMSDExport (bool start)
		{
			const string __id = "setMSDExport.(Z)Lcom/miurasystems/mpi/api/objects/MSDStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (start);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMSDInstall;
#pragma warning disable 0169
		static Delegate GetSetMSDInstallHandler ()
		{
			if (cb_setMSDInstall == null)
				cb_setMSDInstall = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SetMSDInstall);
			return cb_setMSDInstall;
		}

		static IntPtr n_SetMSDInstall (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMSDInstall ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='setMSDInstall' and count(parameter)=0]"
		[Register ("setMSDInstall", "()Lcom/miurasystems/mpi/api/objects/MSDStatus;", "GetSetMSDInstallHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus SetMSDInstall ()
		{
			const string __id = "setMSDInstall.()Lcom/miurasystems/mpi/api/objects/MSDStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_;
#pragma warning disable 0169
		static Delegate GetSetSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Handler ()
		{
			if (cb_setSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_ == null)
				cb_setSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SetSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_);
			return cb_setSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_;
		}

		static bool n_SetSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serialPortProperties)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serialPortProperties = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (native_serialPortProperties, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSerialPort (serialPortProperties);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='setSerialPort' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.utils.SerialPortProperties']]"
		[Register ("setSerialPort", "(Lcom/miurasystems/mpi/api/utils/SerialPortProperties;)Z", "GetSetSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Handler")]
		public virtual unsafe bool SetSerialPort (global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties serialPortProperties)
		{
			const string __id = "setSerialPort.(Lcom/miurasystems/mpi/api/utils/SerialPortProperties;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serialPortProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serialPortProperties).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (serialPortProperties);
			}
		}

		static Delegate cb_sleep;
#pragma warning disable 0169
		static Delegate GetSleepHandler ()
		{
			if (cb_sleep == null)
				cb_sleep = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Sleep);
			return cb_sleep;
		}

		static IntPtr n_Sleep (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sleep ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='sleep' and count(parameter)=0]"
		[Register ("sleep", "()Lcom/miurasystems/mpi/api/objects/BatteryData;", "GetSleepHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.BatteryData Sleep ()
		{
			const string __id = "sleep.()Lcom/miurasystems/mpi/api/objects/BatteryData;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_spoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetSpoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_spoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_spoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SpoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_spoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static bool n_SpoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SpoolClear (interfaceType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='spoolClear' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("spoolClear", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Z", "GetSpoolClear_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe bool SpoolClear (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "spoolClear.(Lcom/miurasystems/mpi/enums/InterfaceType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_spoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSpoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler ()
		{
			if (cb_spoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ == null)
				cb_spoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SpoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_);
			return cb_spoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
		}

		static bool n_SpoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_fileName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SpoolImage (interfaceType, fileName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='spoolImage' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='java.lang.String']]"
		[Register ("spoolImage", "(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z", "GetSpoolImage_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler")]
		public virtual unsafe bool SpoolImage (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName)
		{
			const string __id = "spoolImage.(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_spoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetSpoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_spoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_spoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SpoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_spoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static bool n_SpoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SpoolPrint (interfaceType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='spoolPrint' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("spoolPrint", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Z", "GetSpoolPrint_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe bool SpoolPrint (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "spoolPrint.(Lcom/miurasystems/mpi/enums/InterfaceType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_spoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSpoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler ()
		{
			if (cb_spoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ == null)
				cb_spoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SpoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_);
			return cb_spoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_;
		}

		static bool n_SpoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_text)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SpoolText (interfaceType, text);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='spoolText' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='java.lang.String']]"
		[Register ("spoolText", "(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z", "GetSpoolText_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_lang_String_Handler")]
		public virtual unsafe bool SpoolText (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string text)
		{
			const string __id = "spoolText.(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;)Z";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (native_text);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIL_L) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_;
		}

		static IntPtr n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_languagePreference)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var languagePreference = JNIEnv.GetString (native_languagePreference, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartContactlessTransaction (interfaceType, transactionType, amountInPennies, currencyCode, languagePreference));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='startContactlessTransaction' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;)Lcom/miurasystems/mpi/Result;", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, string languagePreference)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;)Lcom/miurasystems/mpi/Result;";
			IntPtr native_languagePreference = JNIEnv.NewString (languagePreference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [2] = new JniArgumentValue (amountInPennies);
				__args [3] = new JniArgumentValue (currencyCode);
				__args [4] = new JniArgumentValue (native_languagePreference);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_languagePreference);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (transactionType);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIILL_L) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_;
		}

		static IntPtr n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_languagePreference, IntPtr native_timeoutInSeconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var languagePreference = JNIEnv.GetString (native_languagePreference, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartContactlessTransaction (interfaceType, transactionType, amountInPennies, currencyCode, languagePreference, timeoutInSeconds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='startContactlessTransaction' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Integer']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, string languagePreference, global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Ljava/lang/Integer;)Lcom/miurasystems/mpi/Result;";
			IntPtr native_languagePreference = JNIEnv.NewString (languagePreference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [2] = new JniArgumentValue (amountInPennies);
				__args [3] = new JniArgumentValue (currencyCode);
				__args [4] = new JniArgumentValue (native_languagePreference);
				__args [5] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_languagePreference);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		static Delegate cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II;
#pragma warning disable 0169
		static Delegate GetStartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIHandler ()
		{
			if (cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II == null)
				cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_L) n_StartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II);
			return cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II;
		}

		static IntPtr n_StartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_II (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_transactionType, int amountInPennies, int currencyCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartTransaction (interfaceType, transactionType, amountInPennies, currencyCode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='startTransaction' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("startTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;II)Lcom/miurasystems/mpi/Result;", "GetStartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result StartTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode)
		{
			const string __id = "startTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;II)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [2] = new JniArgumentValue (amountInPennies);
				__args [3] = new JniArgumentValue (currencyCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (transactionType);
			}
		}

		static Delegate cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ;
#pragma warning disable 0169
		static Delegate GetStartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZHandler ()
		{
			if (cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ == null)
				cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIZ_L) n_StartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ);
			return cb_startTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ;
		}

		static IntPtr n_StartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_transactionType, int amountInPennies, int currencyCode, bool enableTRM)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartTransaction (interfaceType, transactionType, amountInPennies, currencyCode, enableTRM));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='startTransaction' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("startTransaction", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IIZ)Lcom/miurasystems/mpi/Result;", "GetStartTransaction_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_TransactionType_IIZHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Result StartTransaction (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, bool enableTRM)
		{
			const string __id = "startTransaction.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/TransactionType;IIZ)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [2] = new JniArgumentValue (amountInPennies);
				__args [3] = new JniArgumentValue (currencyCode);
				__args [4] = new JniArgumentValue (enableTRM);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (transactionType);
			}
		}

		static Delegate cb_startWifiConfigMenu;
#pragma warning disable 0169
		static Delegate GetStartWifiConfigMenuHandler ()
		{
			if (cb_startWifiConfigMenu == null)
				cb_startWifiConfigMenu = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StartWifiConfigMenu);
			return cb_startWifiConfigMenu;
		}

		static IntPtr n_StartWifiConfigMenu (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartWifiConfigMenu ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='startWifiConfigMenu' and count(parameter)=0]"
		[Register ("startWifiConfigMenu", "()Ljava/lang/Boolean;", "GetStartWifiConfigMenuHandler")]
		public virtual unsafe global::Java.Lang.Boolean StartWifiConfigMenu ()
		{
			const string __id = "startWifiConfigMenu.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_streamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII;
#pragma warning disable 0169
		static Delegate GetStreamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIIIHandler ()
		{
			if (cb_streamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII == null)
				cb_streamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIIII_Z) n_StreamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII);
			return cb_streamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII;
		}

		static bool n_StreamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_binary, int readOffset, int writeOffset, int size, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var binary = (byte[]) JNIEnv.GetArray (native_binary, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.StreamBinary (interfaceType, binary, readOffset, writeOffset, size, timeout);
			if (binary != null)
				JNIEnv.CopyArray (binary, native_binary);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='streamBinary' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("streamBinary", "(Lcom/miurasystems/mpi/enums/InterfaceType;[BIIII)Z", "GetStreamBinary_Lcom_miurasystems_mpi_enums_InterfaceType_arrayBIIIIHandler")]
		public virtual unsafe bool StreamBinary (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, byte[] binary, int readOffset, int writeOffset, int size, int timeout)
		{
			const string __id = "streamBinary.(Lcom/miurasystems/mpi/enums/InterfaceType;[BIIII)Z";
			IntPtr native_binary = JNIEnv.NewArray (binary);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue (native_binary);
				__args [2] = new JniArgumentValue (readOffset);
				__args [3] = new JniArgumentValue (writeOffset);
				__args [4] = new JniArgumentValue (size);
				__args [5] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (binary != null) {
					JNIEnv.CopyArray (native_binary, binary);
					JNIEnv.DeleteLocalRef (native_binary);
				}
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (binary);
			}
		}

		static Delegate cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetSystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static IntPtr n_SystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SystemClock (interfaceType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='systemClock' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("systemClock", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Ljava/util/Date;", "GetSystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe global::Java.Util.Date SystemClock (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType)
		{
			const string __id = "systemClock.(Lcom/miurasystems/mpi/enums/InterfaceType;)Ljava/util/Date;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
			}
		}

		static Delegate cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_Handler ()
		{
			if (cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_ == null)
				cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_);
			return cb_systemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_;
		}

		static bool n_SystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_dateTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var dateTime = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_dateTime, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SystemClock (interfaceType, dateTime);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='systemClock' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='java.util.Date']]"
		[Register ("systemClock", "(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/util/Date;)Z", "GetSystemClock_Lcom_miurasystems_mpi_enums_InterfaceType_Ljava_util_Date_Handler")]
		public virtual unsafe bool SystemClock (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Java.Util.Date dateTime)
		{
			const string __id = "systemClock.(Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/util/Date;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dateTime).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (dateTime);
			}
		}

		static Delegate cb_systemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_;
#pragma warning disable 0169
		static Delegate GetSystemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_Handler ()
		{
			if (cb_systemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_ == null)
				cb_systemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SystemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_);
			return cb_systemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_;
		}

		static bool n_SystemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interfaceType, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var interfaceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_interfaceType, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SystemLogMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SystemLog (interfaceType, mode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='systemLog' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.enums.SystemLogMode']]"
		[Register ("systemLog", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SystemLogMode;)Z", "GetSystemLog_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_enums_SystemLogMode_Handler")]
		public virtual unsafe bool SystemLog (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.Enums.SystemLogMode mode)
		{
			const string __id = "systemLog.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/enums/SystemLogMode;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_touchCaptureBegin_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetTouchCaptureBegin_Ljava_util_List_ZHandler ()
		{
			if (cb_touchCaptureBegin_Ljava_util_List_Z == null)
				cb_touchCaptureBegin_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_TouchCaptureBegin_Ljava_util_List_Z);
			return cb_touchCaptureBegin_Ljava_util_List_Z;
		}

		static bool n_TouchCaptureBegin_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_captureAreas, bool highlightAreas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var captureAreas = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea>.FromJniHandle (native_captureAreas, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TouchCaptureBegin (captureAreas, highlightAreas);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='touchCaptureBegin' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.api.objects.TouchCaptureArea&gt;'] and parameter[2][@type='boolean']]"
		[Register ("touchCaptureBegin", "(Ljava/util/List;Z)Z", "GetTouchCaptureBegin_Ljava_util_List_ZHandler")]
		public virtual unsafe bool TouchCaptureBegin (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> captureAreas, bool highlightAreas)
		{
			const string __id = "touchCaptureBegin.(Ljava/util/List;Z)Z";
			IntPtr native_captureAreas = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea>.ToLocalJniHandle (captureAreas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_captureAreas);
				__args [1] = new JniArgumentValue (highlightAreas);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_captureAreas);
				global::System.GC.KeepAlive (captureAreas);
			}
		}

		static Delegate cb_touchCaptureClear;
#pragma warning disable 0169
		static Delegate GetTouchCaptureClearHandler ()
		{
			if (cb_touchCaptureClear == null)
				cb_touchCaptureClear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_TouchCaptureClear);
			return cb_touchCaptureClear;
		}

		static bool n_TouchCaptureClear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchCaptureClear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='touchCaptureClear' and count(parameter)=0]"
		[Register ("touchCaptureClear", "()Z", "GetTouchCaptureClearHandler")]
		public virtual unsafe bool TouchCaptureClear ()
		{
			const string __id = "touchCaptureClear.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_touchCaptureEnd;
#pragma warning disable 0169
		static Delegate GetTouchCaptureEndHandler ()
		{
			if (cb_touchCaptureEnd == null)
				cb_touchCaptureEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_TouchCaptureEnd);
			return cb_touchCaptureEnd;
		}

		static bool n_TouchCaptureEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchCaptureEnd ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='touchCaptureEnd' and count(parameter)=0]"
		[Register ("touchCaptureEnd", "()Z", "GetTouchCaptureEndHandler")]
		public virtual unsafe bool TouchCaptureEnd ()
		{
			const string __id = "touchCaptureEnd.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_touchCaptureExportToPng_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureExportToPng_ILjava_lang_String_Handler ()
		{
			if (cb_touchCaptureExportToPng_ILjava_lang_String_ == null)
				cb_touchCaptureExportToPng_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_TouchCaptureExportToPng_ILjava_lang_String_);
			return cb_touchCaptureExportToPng_ILjava_lang_String_;
		}

		static bool n_TouchCaptureExportToPng_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int areaToExport, IntPtr native_exportFilename)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exportFilename = JNIEnv.GetString (native_exportFilename, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TouchCaptureExportToPng (areaToExport, exportFilename);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='touchCaptureExportToPng' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("touchCaptureExportToPng", "(ILjava/lang/String;)Z", "GetTouchCaptureExportToPng_ILjava_lang_String_Handler")]
		public virtual unsafe bool TouchCaptureExportToPng (int areaToExport, string exportFilename)
		{
			const string __id = "touchCaptureExportToPng.(ILjava/lang/String;)Z";
			IntPtr native_exportFilename = JNIEnv.NewString (exportFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (areaToExport);
				__args [1] = new JniArgumentValue (native_exportFilename);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_exportFilename);
			}
		}

		static Delegate cb_touchCaptureStatus;
#pragma warning disable 0169
		static Delegate GetTouchCaptureStatusHandler ()
		{
			if (cb_touchCaptureStatus == null)
				cb_touchCaptureStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TouchCaptureStatus);
			return cb_touchCaptureStatus;
		}

		static IntPtr n_TouchCaptureStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TouchCaptureStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='MpiClient']/method[@name='touchCaptureStatus' and count(parameter)=0]"
		[Register ("touchCaptureStatus", "()Lcom/miurasystems/mpi/api/objects/TouchCaptureStatus;", "GetTouchCaptureStatusHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus TouchCaptureStatus ()
		{
			const string __id = "touchCaptureStatus.()Lcom/miurasystems/mpi/api/objects/TouchCaptureStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
