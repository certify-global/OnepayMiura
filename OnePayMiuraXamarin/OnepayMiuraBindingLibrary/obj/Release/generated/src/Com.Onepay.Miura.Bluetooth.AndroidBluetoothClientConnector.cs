using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']"
	[global::Android.Runtime.Register ("com/onepay/miura/bluetooth/AndroidBluetoothClientConnector", DoNotGenerateAcw=true)]
	public sealed partial class AndroidBluetoothClientConnector : global::Com.Miurasystems.Mpi.Comms.Connector {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/bluetooth/AndroidBluetoothClientConnector", typeof (AndroidBluetoothClientConnector));
		internal static new IntPtr class_ref {
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

		internal AndroidBluetoothClientConnector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/constructor[@name='AndroidBluetoothClientConnector' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
		[Register (".ctor", "(Landroid/bluetooth/BluetoothDevice;)V", "")]
		public unsafe AndroidBluetoothClientConnector (global::Android.Bluetooth.BluetoothDevice device)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/bluetooth/BluetoothDevice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (device);
			}
		}

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected override unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "")]
		protected override unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.bluetooth']/class[@name='AndroidBluetoothClientConnector']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.MpiProtocolSession']]"
		[Register ("disconnect", "(Lcom/miurasystems/mpi/comms/MpiProtocolSession;)V", "")]
		protected override unsafe void Disconnect (global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession closingSession)
		{
			const string __id = "disconnect.(Lcom/miurasystems/mpi/comms/MpiProtocolSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closingSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closingSession).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (closingSession);
			}
		}

	}
}
