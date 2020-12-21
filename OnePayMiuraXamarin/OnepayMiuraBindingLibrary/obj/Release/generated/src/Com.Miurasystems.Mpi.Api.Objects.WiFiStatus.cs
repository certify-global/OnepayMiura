using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/WiFiStatus", DoNotGenerateAcw=true)]
	public partial class WiFiStatus : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/field[@name='SSID']"
		[Register ("SSID")]
		public string Ssid {
			get {
				const string __id = "SSID.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SSID.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/field[@name='connectionStatus']"
		[Register ("connectionStatus")]
		public string ConnectionStatus {
			get {
				const string __id = "connectionStatus.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "connectionStatus.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/field[@name='ipAddress']"
		[Register ("ipAddress")]
		public string IpAddress {
			get {
				const string __id = "ipAddress.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ipAddress.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/field[@name='signalStrength']"
		[Register ("signalStrength")]
		public int SignalStrength {
			get {
				const string __id = "signalStrength.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "signalStrength.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/field[@name='trueConnectionStatus']"
		[Register ("trueConnectionStatus")]
		public string TrueConnectionStatus {
			get {
				const string __id = "trueConnectionStatus.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trueConnectionStatus.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/WiFiStatus", typeof (WiFiStatus));
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

		protected WiFiStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_checkIfRefreshRequired_J;
#pragma warning disable 0169
		static Delegate GetCheckIfRefreshRequired_JHandler ()
		{
			if (cb_checkIfRefreshRequired_J == null)
				cb_checkIfRefreshRequired_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_Z) n_CheckIfRefreshRequired_J);
			return cb_checkIfRefreshRequired_J;
		}

		static bool n_CheckIfRefreshRequired_J (IntPtr jnienv, IntPtr native__this, long refreshPeriod)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.WiFiStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckIfRefreshRequired (refreshPeriod);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/method[@name='checkIfRefreshRequired' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("checkIfRefreshRequired", "(J)Z", "GetCheckIfRefreshRequired_JHandler")]
		public virtual unsafe bool CheckIfRefreshRequired (long refreshPeriod)
		{
			const string __id = "checkIfRefreshRequired.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (refreshPeriod);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='WiFiStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("valueOf", "(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/WiFiStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.WiFiStatus ValueOf (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvList)
		{
			const string __id = "valueOf.(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/WiFiStatus;";
			IntPtr native_tlvList = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tlvList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.WiFiStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvList);
				global::System.GC.KeepAlive (tlvList);
			}
		}

	}
}
