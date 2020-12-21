using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetNumericDataListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetNumericDataListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListenerInvoker")]
	public partial interface IApiGetNumericDataListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetNumericDataListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetNumericDataError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/GetNumericDataError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_GetNumericDataError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetNumericDataListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetNumericDataListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetNumericDataListenerInvoker : global::Java.Lang.Object, IApiGetNumericDataListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetNumericDataListener", typeof (IApiGetNumericDataListenerInvoker));

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

		public static IApiGetNumericDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetNumericDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetNumericDataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetNumericDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_GetNumericDataError_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_GetNumericDataError_);
			return cb_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_GetNumericDataError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramGetNumericDataError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramGetNumericDataError = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetNumericDataError> (native_paramGetNumericDataError, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramGetNumericDataError);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/GetNumericDataError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramGetNumericDataError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramGetNumericDataError).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_GetNumericDataError_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetNumericDataListener.onError
	public partial class ApiGetNumericDataListenerErrorEventArgs : global::System.EventArgs {

		public ApiGetNumericDataListenerErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError)
		{
			this.paramGetNumericDataError = paramGetNumericDataError;
		}

		global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError;
		public global::Com.Miurasystems.Mpi.Enums.GetNumericDataError ParamGetNumericDataError {
			get { return paramGetNumericDataError; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetNumericDataListener.onSuccess
	public partial class ApiGetNumericDataListenerSuccessEventArgs : global::System.EventArgs {

		public ApiGetNumericDataListenerSuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetNumericDataListenerImplementor")]
	internal sealed partial class IApiGetNumericDataListenerImplementor : global::Java.Lang.Object, IApiGetNumericDataListener {

		object sender;

		public IApiGetNumericDataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetNumericDataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ApiGetNumericDataListenerErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ApiGetNumericDataListenerErrorEventArgs (paramGetNumericDataError));
		}
#pragma warning disable 0649
		public EventHandler<ApiGetNumericDataListenerSuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (string p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new ApiGetNumericDataListenerSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IApiGetNumericDataListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
