using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiTouchCaptureStatusListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListenerInvoker")]
	public partial interface IApiTouchCaptureStatusListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiTouchCaptureStatusListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiTouchCaptureStatusListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.TouchCaptureStatus']]"
		[Register ("onSuccess", "(Lcom/miurasystems/mpi/api/objects/TouchCaptureStatus;)V", "GetOnSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus paramTouchCaptureStatus);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListener", DoNotGenerateAcw=true)]
	internal partial class IApiTouchCaptureStatusListenerInvoker : global::Java.Lang.Object, IApiTouchCaptureStatusListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListener", typeof (IApiTouchCaptureStatusListenerInvoker));

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

		public static IApiTouchCaptureStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiTouchCaptureStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiTouchCaptureStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiTouchCaptureStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_Handler ()
		{
			if (cb_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_ == null)
				cb_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_);
			return cb_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_;
		}

		static void n_OnSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramTouchCaptureStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramTouchCaptureStatus = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus> (native_paramTouchCaptureStatus, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramTouchCaptureStatus);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_;
		public unsafe void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus paramTouchCaptureStatus)
		{
			if (id_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_ == IntPtr.Zero)
				id_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/miurasystems/mpi/api/objects/TouchCaptureStatus;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramTouchCaptureStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramTouchCaptureStatus).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_miurasystems_mpi_api_objects_TouchCaptureStatus_, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiTouchCaptureStatusListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus paramTouchCaptureStatus)
		{
			this.paramTouchCaptureStatus = paramTouchCaptureStatus;
		}

		global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus paramTouchCaptureStatus;
		public global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus ParamTouchCaptureStatus {
			get { return paramTouchCaptureStatus; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListenerImplementor")]
	internal sealed partial class IApiTouchCaptureStatusListenerImplementor : global::Java.Lang.Object, IApiTouchCaptureStatusListener {

		object sender;

		public IApiTouchCaptureStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListenerImplementor", "()V"),
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

		public void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus paramTouchCaptureStatus)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramTouchCaptureStatus));
		}

		internal static bool __IsEmpty (IApiTouchCaptureStatusListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
