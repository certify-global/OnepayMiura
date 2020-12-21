using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/Connector", DoNotGenerateAcw=true)]
	public abstract partial class Connector : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/Connector", typeof (Connector));
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

		protected Connector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/constructor[@name='Connector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Connector ()
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

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected abstract global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")] get;
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public abstract bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")] get;
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		protected abstract global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")] get;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "GetCloseSessionHandler")]
		public virtual unsafe void CloseSession ()
		{
			const string __id = "closeSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		protected abstract void Connect ();

		static Delegate cb_disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_Handler ()
		{
			if (cb_disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_ == null)
				cb_disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_);
			return cb_disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_;
		}

		static void n_Disconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.MpiProtocolSession']]"
		[Register ("disconnect", "(Lcom/miurasystems/mpi/comms/MpiProtocolSession;)V", "GetDisconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_Handler")]
		protected abstract void Disconnect (global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession p0);

		static Delegate cb_openSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_;
#pragma warning disable 0169
		static Delegate GetOpenSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_Handler ()
		{
			if (cb_openSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_ == null)
				cb_openSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OpenSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_);
			return cb_openSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_;
		}

		static IntPtr n_OpenSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unsolicitedResponseCallback, IntPtr native_connectionStateCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unsolicitedResponseCallback = (global::Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallback> (native_unsolicitedResponseCallback, JniHandleOwnership.DoNotTransfer);
			var connectionStateCallback = (global::Com.Miurasystems.Mpi.Comms.IConnectionStateCallback)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.IConnectionStateCallback> (native_connectionStateCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenSession (unsolicitedResponseCallback, connectionStateCallback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='openSession' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.comms.UnsolicitedResponseCallback'] and parameter[2][@type='com.miurasystems.mpi.comms.ConnectionStateCallback']]"
		[Register ("openSession", "(Lcom/miurasystems/mpi/comms/UnsolicitedResponseCallback;Lcom/miurasystems/mpi/comms/ConnectionStateCallback;)Lcom/miurasystems/mpi/comms/MpiProtocolSession;", "GetOpenSession_Lcom_miurasystems_mpi_comms_UnsolicitedResponseCallback_Lcom_miurasystems_mpi_comms_ConnectionStateCallback_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession OpenSession (global::Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallback unsolicitedResponseCallback, global::Com.Miurasystems.Mpi.Comms.IConnectionStateCallback connectionStateCallback)
		{
			const string __id = "openSession.(Lcom/miurasystems/mpi/comms/UnsolicitedResponseCallback;Lcom/miurasystems/mpi/comms/ConnectionStateCallback;)Lcom/miurasystems/mpi/comms/MpiProtocolSession;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((unsolicitedResponseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unsolicitedResponseCallback).Handle);
				__args [1] = new JniArgumentValue ((connectionStateCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectionStateCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (unsolicitedResponseCallback);
				global::System.GC.KeepAlive (connectionStateCallback);
			}
		}

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/Connector", DoNotGenerateAcw=true)]
	internal partial class ConnectorInvoker : Connector {

		public ConnectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/Connector", typeof (ConnectorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		protected override unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='Connector']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.MpiProtocolSession']]"
		[Register ("disconnect", "(Lcom/miurasystems/mpi/comms/MpiProtocolSession;)V", "GetDisconnect_Lcom_miurasystems_mpi_comms_MpiProtocolSession_Handler")]
		protected override unsafe void Disconnect (global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession p0)
		{
			const string __id = "disconnect.(Lcom/miurasystems/mpi/comms/MpiProtocolSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
