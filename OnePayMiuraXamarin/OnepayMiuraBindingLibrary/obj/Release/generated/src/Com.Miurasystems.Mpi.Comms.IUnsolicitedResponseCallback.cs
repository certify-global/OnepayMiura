using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.comms']/interface[@name='UnsolicitedResponseCallback']"
	[Register ("com/miurasystems/mpi/comms/UnsolicitedResponseCallback", "", "Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallbackInvoker")]
	public partial interface IUnsolicitedResponseCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/interface[@name='UnsolicitedResponseCallback']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.PollerMessage']]"
		[Register ("handle", "(Lcom/miurasystems/mpi/comms/PollerMessage;)V", "GetHandle_Lcom_miurasystems_mpi_comms_PollerMessage_Handler:Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallbackInvoker, OnepayMiuraBindingLibrary")]
		void Handle (global::Com.Miurasystems.Mpi.Comms.PollerMessage p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/UnsolicitedResponseCallback", DoNotGenerateAcw=true)]
	internal partial class IUnsolicitedResponseCallbackInvoker : global::Java.Lang.Object, IUnsolicitedResponseCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/UnsolicitedResponseCallback", typeof (IUnsolicitedResponseCallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IUnsolicitedResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnsolicitedResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.comms.UnsolicitedResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnsolicitedResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Lcom_miurasystems_mpi_comms_PollerMessage_;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_miurasystems_mpi_comms_PollerMessage_Handler ()
		{
			if (cb_handle_Lcom_miurasystems_mpi_comms_PollerMessage_ == null)
				cb_handle_Lcom_miurasystems_mpi_comms_PollerMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Handle_Lcom_miurasystems_mpi_comms_PollerMessage_);
			return cb_handle_Lcom_miurasystems_mpi_comms_PollerMessage_;
		}

		static void n_Handle_Lcom_miurasystems_mpi_comms_PollerMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.IUnsolicitedResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.PollerMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0);
		}
#pragma warning restore 0169

		IntPtr id_handle_Lcom_miurasystems_mpi_comms_PollerMessage_;
		public unsafe void Handle (global::Com.Miurasystems.Mpi.Comms.PollerMessage p0)
		{
			if (id_handle_Lcom_miurasystems_mpi_comms_PollerMessage_ == IntPtr.Zero)
				id_handle_Lcom_miurasystems_mpi_comms_PollerMessage_ = JNIEnv.GetMethodID (class_ref, "handle", "(Lcom/miurasystems/mpi/comms/PollerMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Lcom_miurasystems_mpi_comms_PollerMessage_, __args);
		}

	}

}
