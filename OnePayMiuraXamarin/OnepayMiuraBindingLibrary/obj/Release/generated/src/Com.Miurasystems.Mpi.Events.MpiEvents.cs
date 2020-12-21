using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/MpiEvents", DoNotGenerateAcw=true)]
	public partial class MpiEvents : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='BarcodeScanned']"
		[Register ("BarcodeScanned")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher BarcodeScanned {
			get {
				const string __id = "BarcodeScanned.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BarcodeScanned.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='BatteryStatusEvent']"
		[Register ("BatteryStatusEvent")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher BatteryStatusEvent {
			get {
				const string __id = "BatteryStatusEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BatteryStatusEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='CardStatusChanged']"
		[Register ("CardStatusChanged")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher CardStatusChanged {
			get {
				const string __id = "CardStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CardStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='CommsChannelStatusChanged']"
		[Register ("CommsChannelStatusChanged")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher CommsChannelStatusChanged {
			get {
				const string __id = "CommsChannelStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CommsChannelStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='Connected']"
		[Register ("Connected")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher Connected {
			get {
				const string __id = "Connected.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Connected.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='DeviceStatusChanged']"
		[Register ("DeviceStatusChanged")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher DeviceStatusChanged {
			get {
				const string __id = "DeviceStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DeviceStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='Disconnected']"
		[Register ("Disconnected")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher Disconnected {
			get {
				const string __id = "Disconnected.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Disconnected.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='KeyPressed']"
		[Register ("KeyPressed")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher KeyPressed {
			get {
				const string __id = "KeyPressed.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "KeyPressed.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='PrinterStatusChanged']"
		[Register ("PrinterStatusChanged")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher PrinterStatusChanged {
			get {
				const string __id = "PrinterStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "PrinterStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='TouchCaptureEvent']"
		[Register ("TouchCaptureEvent")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher TouchCaptureEvent {
			get {
				const string __id = "TouchCaptureEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TouchCaptureEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='USBStatusEvent']"
		[Register ("USBStatusEvent")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher USBStatusEvent {
			get {
				const string __id = "USBStatusEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "USBStatusEvent.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='UsbSerialPortDataReceived']"
		[Register ("UsbSerialPortDataReceived")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher UsbSerialPortDataReceived {
			get {
				const string __id = "UsbSerialPortDataReceived.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "UsbSerialPortDataReceived.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/field[@name='WifiStatusChanged']"
		[Register ("WifiStatusChanged")]
		public global::Com.Miurasystems.Mpi.Events.MpiEventPublisher WifiStatusChanged {
			get {
				const string __id = "WifiStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "WifiStatusChanged.Lcom/miurasystems/mpi/events/MpiEventPublisher;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/MpiEvents", typeof (MpiEvents));
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

		protected MpiEvents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEvents']/constructor[@name='MpiEvents' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MpiEvents ()
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

	}
}
