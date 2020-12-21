using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEStatusListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiP2PEStatusListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListenerInvoker")]
	public partial interface IApiP2PEStatusListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEStatusListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEStatusListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.P2PEStatus']]"
		[Register ("onSuccess", "(Lcom/miurasystems/mpi/api/objects/P2PEStatus;)V", "GetOnSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus paramP2PEStatus);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiP2PEStatusListener", DoNotGenerateAcw=true)]
	internal partial class IApiP2PEStatusListenerInvoker : global::Java.Lang.Object, IApiP2PEStatusListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiP2PEStatusListener", typeof (IApiP2PEStatusListenerInvoker));

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

		public static IApiP2PEStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiP2PEStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiP2PEStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiP2PEStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError;
#pragma warning disable 0169
		static Delegate GetOnErrorHandler ()
		{
			if (cb_onError == null)
				cb_onError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnError);
			return cb_onError;
		}

		static void n_OnError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		IntPtr id_onError;
		public unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
		}

		static Delegate cb_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_Handler ()
		{
			if (cb_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_ == null)
				cb_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_);
			return cb_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_;
		}

		static void n_OnSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramP2PEStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramP2PEStatus = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus> (native_paramP2PEStatus, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramP2PEStatus);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_;
		public unsafe void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus paramP2PEStatus)
		{
			if (id_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_ == IntPtr.Zero)
				id_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/miurasystems/mpi/api/objects/P2PEStatus;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramP2PEStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramP2PEStatus).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_miurasystems_mpi_api_objects_P2PEStatus_, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiP2PEStatusListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus paramP2PEStatus)
		{
			this.paramP2PEStatus = paramP2PEStatus;
		}

		global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus paramP2PEStatus;
		public global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus ParamP2PEStatus {
			get { return paramP2PEStatus; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiP2PEStatusListenerImplementor")]
	internal sealed partial class IApiP2PEStatusListenerImplementor : global::Java.Lang.Object, IApiP2PEStatusListener {

		object sender;

		public IApiP2PEStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiP2PEStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnErrorHandler;
#pragma warning restore 0649

		public void OnError ()
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.P2PEStatus paramP2PEStatus)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramP2PEStatus));
		}

		internal static bool __IsEmpty (IApiP2PEStatusListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
