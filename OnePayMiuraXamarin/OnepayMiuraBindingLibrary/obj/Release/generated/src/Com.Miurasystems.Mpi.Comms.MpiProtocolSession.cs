using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/MpiProtocolSession", DoNotGenerateAcw=true)]
	public partial class MpiProtocolSession : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/MpiProtocolSession", typeof (MpiProtocolSession));
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

		protected MpiProtocolSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				const string __id = "isActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_receiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_;
#pragma warning disable 0169
		static Delegate GetReceiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_Handler ()
		{
			if (cb_receiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_ == null)
				cb_receiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ReceiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_);
			return cb_receiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_;
		}

		static IntPtr n_ReceiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nad = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_nad, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReceiveResponse (nad));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='receiveResponse' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType']]"
		[Register ("receiveResponse", "(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/comms/ResponseMessage;", "GetReceiveResponse_Lcom_miurasystems_mpi_enums_InterfaceType_Handler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.ResponseMessage ReceiveResponse (global::Com.Miurasystems.Mpi.Enums.InterfaceType nad)
		{
			const string __id = "receiveResponse.(Lcom/miurasystems/mpi/enums/InterfaceType;)Lcom/miurasystems/mpi/comms/ResponseMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nad).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (nad);
			}
		}

		static Delegate cb_receiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J;
#pragma warning disable 0169
		static Delegate GetReceiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_JHandler ()
		{
			if (cb_receiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J == null)
				cb_receiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_ReceiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J);
			return cb_receiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J;
		}

		static IntPtr n_ReceiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_J (IntPtr jnienv, IntPtr native__this, IntPtr native_nad, long timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nad = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_nad, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReceiveResponseTimeout (nad, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='receiveResponseTimeout' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='long']]"
		[Register ("receiveResponseTimeout", "(Lcom/miurasystems/mpi/enums/InterfaceType;J)Lcom/miurasystems/mpi/comms/ResponseMessage;", "GetReceiveResponseTimeout_Lcom_miurasystems_mpi_enums_InterfaceType_JHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.ResponseMessage ReceiveResponseTimeout (global::Com.Miurasystems.Mpi.Enums.InterfaceType nad, long timeout)
		{
			const string __id = "receiveResponseTimeout.(Lcom/miurasystems/mpi/enums/InterfaceType;J)Lcom/miurasystems/mpi/comms/ResponseMessage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((nad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nad).Handle);
				__args [1] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.ResponseMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (nad);
			}
		}

		static Delegate cb_sendBinaryStream_arrayBII;
#pragma warning disable 0169
		static Delegate GetSendBinaryStream_arrayBIIHandler ()
		{
			if (cb_sendBinaryStream_arrayBII == null)
				cb_sendBinaryStream_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_SendBinaryStream_arrayBII);
			return cb_sendBinaryStream_arrayBII;
		}

		static void n_SendBinaryStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes, int offset, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SendBinaryStream (bytes, offset, len);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='sendBinaryStream' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("sendBinaryStream", "([BII)V", "GetSendBinaryStream_arrayBIIHandler")]
		public virtual unsafe void SendBinaryStream (byte[] bytes, int offset, int len)
		{
			const string __id = "sendBinaryStream.([BII)V";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (len);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		static Delegate cb_sendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_;
#pragma warning disable 0169
		static Delegate GetSendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_Handler ()
		{
			if (cb_sendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_ == null)
				cb_sendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_SendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_);
			return cb_sendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_;
		}

		static int n_SendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nad, IntPtr native_apdu)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.MpiProtocolSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var nad = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InterfaceType> (native_nad, JniHandleOwnership.DoNotTransfer);
			var apdu = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.CommandApdu> (native_apdu, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SendCommandAPDU (nad, apdu);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/class[@name='MpiProtocolSession']/method[@name='sendCommandAPDU' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.comms.CommandApdu']]"
		[Register ("sendCommandAPDU", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/comms/CommandApdu;)I", "GetSendCommandAPDU_Lcom_miurasystems_mpi_enums_InterfaceType_Lcom_miurasystems_mpi_comms_CommandApdu_Handler")]
		public virtual unsafe int SendCommandAPDU (global::Com.Miurasystems.Mpi.Enums.InterfaceType nad, global::Com.Miurasystems.Mpi.Comms.CommandApdu apdu)
		{
			const string __id = "sendCommandAPDU.(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/comms/CommandApdu;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((nad == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nad).Handle);
				__args [1] = new JniArgumentValue ((apdu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apdu).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (nad);
				global::System.GC.KeepAlive (apdu);
			}
		}

	}
}
