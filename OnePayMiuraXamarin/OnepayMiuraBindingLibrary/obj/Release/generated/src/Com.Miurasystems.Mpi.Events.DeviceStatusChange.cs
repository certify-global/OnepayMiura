using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='DeviceStatusChange']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/DeviceStatusChange", DoNotGenerateAcw=true)]
	public partial class DeviceStatusChange : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='DeviceStatusChange']/field[@name='deviceStatus']"
		[Register ("deviceStatus")]
		public global::Com.Miurasystems.Mpi.Enums.DeviceStatus DeviceStatus {
			get {
				const string __id = "deviceStatus.Lcom/miurasystems/mpi/enums/DeviceStatus;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "deviceStatus.Lcom/miurasystems/mpi/enums/DeviceStatus;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='DeviceStatusChange']/field[@name='statusText']"
		[Register ("statusText")]
		public string StatusText {
			get {
				const string __id = "statusText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "statusText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/DeviceStatusChange", typeof (DeviceStatusChange));
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

		protected DeviceStatusChange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
