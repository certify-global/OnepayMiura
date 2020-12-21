using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryOutputStream']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/StreamBinaryOutputStream", DoNotGenerateAcw=true)]
	public partial class StreamBinaryOutputStream : global::Java.IO.OutputStream {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryOutputStream']/field[@name='MAX_BYTES_TO_WRITE']"
		[Register ("MAX_BYTES_TO_WRITE")]
		public const int MaxBytesToWrite = (int) 131072;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/StreamBinaryOutputStream", typeof (StreamBinaryOutputStream));
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

		protected StreamBinaryOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryOutputStream']/constructor[@name='StreamBinaryOutputStream' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[2][@type='com.miurasystems.mpi.MpiClient'] and parameter[3][@type='com.miurasystems.mpi.api.utils.StreamBinaryFile.ProgressCallback']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)V", "")]
		public unsafe StreamBinaryOutputStream (global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, global::Com.Miurasystems.Mpi.MpiClient mpiClient, global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile.IProgressCallback progressCallback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/InterfaceType;Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [1] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				__args [2] = new JniArgumentValue ((progressCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (mpiClient);
				global::System.GC.KeepAlive (progressCallback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryOutputStream']/constructor[@name='StreamBinaryOutputStream' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.api.utils.StreamBinaryFile.ProgressCallback']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)V", "")]
		public unsafe StreamBinaryOutputStream (global::Com.Miurasystems.Mpi.MpiClient mpiClient, global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile.IProgressCallback progressCallback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				__args [1] = new JniArgumentValue ((progressCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progressCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mpiClient);
				global::System.GC.KeepAlive (progressCallback);
			}
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			const string __id = "write.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
