using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSoftwareInfoListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListenerInvoker")]
	public partial interface IApiGetSoftwareInfoListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSoftwareInfoListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSoftwareInfoListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.SoftwareInfo']]"
		[Register ("onSuccess", "(Lcom/miurasystems/mpi/api/objects/SoftwareInfo;)V", "GetOnSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo paramSoftwareInfo);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetSoftwareInfoListenerInvoker : global::Java.Lang.Object, IApiGetSoftwareInfoListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListener", typeof (IApiGetSoftwareInfoListenerInvoker));

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

		public static IApiGetSoftwareInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetSoftwareInfoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetSoftwareInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_Handler ()
		{
			if (cb_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_ == null)
				cb_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_);
			return cb_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_;
		}

		static void n_OnSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramSoftwareInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramSoftwareInfo = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (native_paramSoftwareInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramSoftwareInfo);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_;
		public unsafe void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo paramSoftwareInfo)
		{
			if (id_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_ == IntPtr.Zero)
				id_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/miurasystems/mpi/api/objects/SoftwareInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramSoftwareInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramSoftwareInfo).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_miurasystems_mpi_api_objects_SoftwareInfo_, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo paramSoftwareInfo)
		{
			this.paramSoftwareInfo = paramSoftwareInfo;
		}

		global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo paramSoftwareInfo;
		public global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo ParamSoftwareInfo {
			get { return paramSoftwareInfo; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListenerImplementor")]
	internal sealed partial class IApiGetSoftwareInfoListenerImplementor : global::Java.Lang.Object, IApiGetSoftwareInfoListener {

		object sender;

		public IApiGetSoftwareInfoListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListenerImplementor", "()V"),
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

		public void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo paramSoftwareInfo)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramSoftwareInfo));
		}

		internal static bool __IsEmpty (IApiGetSoftwareInfoListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
