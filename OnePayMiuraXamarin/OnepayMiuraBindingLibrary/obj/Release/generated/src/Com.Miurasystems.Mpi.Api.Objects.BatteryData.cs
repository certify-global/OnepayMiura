using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='BatteryData']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/BatteryData", DoNotGenerateAcw=true)]
	public partial class BatteryData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='BatteryData']/field[@name='mBatteryLevel']"
		[Register ("mBatteryLevel")]
		public int MBatteryLevel {
			get {
				const string __id = "mBatteryLevel.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mBatteryLevel.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='BatteryData']/field[@name='mChargingStatus']"
		[Register ("mChargingStatus")]
		public global::Com.Miurasystems.Mpi.Enums.ChargingStatus MChargingStatus {
			get {
				const string __id = "mChargingStatus.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChargingStatus.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/BatteryData", typeof (BatteryData));
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

		protected BatteryData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckIfRefreshRequired (refreshPeriod);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='BatteryData']/method[@name='checkIfRefreshRequired' and count(parameter)=1 and parameter[1][@type='long']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='BatteryData']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("valueOf", "(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/BatteryData;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.BatteryData ValueOf (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvObjects)
		{
			const string __id = "valueOf.(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/BatteryData;";
			IntPtr native_tlvObjects = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvObjects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tlvObjects);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.BatteryData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvObjects);
				global::System.GC.KeepAlive (tlvObjects);
			}
		}

	}
}
