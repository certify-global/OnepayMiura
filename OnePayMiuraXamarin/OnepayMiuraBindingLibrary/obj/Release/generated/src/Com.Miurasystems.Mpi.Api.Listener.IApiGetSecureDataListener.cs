using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSecureDataListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetSecureDataListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListenerInvoker")]
	public partial interface IApiGetSecureDataListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSecureDataListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetEncryptedPanError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/GetEncryptedPanError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError paramGetEncryptedPanError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSecureDataListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.EncryptedPan']]"
		[Register ("onSuccess", "(Lcom/miurasystems/mpi/api/objects/EncryptedPan;)V", "GetOnSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan paramEncryptedPan);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetSecureDataListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetSecureDataListenerInvoker : global::Java.Lang.Object, IApiGetSecureDataListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetSecureDataListener", typeof (IApiGetSecureDataListenerInvoker));

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

		public static IApiGetSecureDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetSecureDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetSecureDataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetSecureDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_);
			return cb_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramGetEncryptedPanError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramGetEncryptedPanError = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError> (native_paramGetEncryptedPanError, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramGetEncryptedPanError);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError paramGetEncryptedPanError)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/GetEncryptedPanError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramGetEncryptedPanError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramGetEncryptedPanError).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_GetEncryptedPanError_, __args);
		}

		static Delegate cb_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_Handler ()
		{
			if (cb_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_ == null)
				cb_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_);
			return cb_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_;
		}

		static void n_OnSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramEncryptedPan)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramEncryptedPan = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan> (native_paramEncryptedPan, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramEncryptedPan);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_;
		public unsafe void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan paramEncryptedPan)
		{
			if (id_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_ == IntPtr.Zero)
				id_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/miurasystems/mpi/api/objects/EncryptedPan;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramEncryptedPan == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramEncryptedPan).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_miurasystems_mpi_api_objects_EncryptedPan_, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetSecureDataListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError paramGetEncryptedPanError)
		{
			this.paramGetEncryptedPanError = paramGetEncryptedPanError;
		}

		global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError paramGetEncryptedPanError;
		public global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError ParamGetEncryptedPanError {
			get { return paramGetEncryptedPanError; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetSecureDataListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan paramEncryptedPan)
		{
			this.paramEncryptedPan = paramEncryptedPan;
		}

		global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan paramEncryptedPan;
		public global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan ParamEncryptedPan {
			get { return paramEncryptedPan; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetSecureDataListenerImplementor")]
	internal sealed partial class IApiGetSecureDataListenerImplementor : global::Java.Lang.Object, IApiGetSecureDataListener {

		object sender;

		public IApiGetSecureDataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetSecureDataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.GetEncryptedPanError paramGetEncryptedPanError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramGetEncryptedPanError));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan paramEncryptedPan)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramEncryptedPan));
		}

		internal static bool __IsEmpty (IApiGetSecureDataListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
