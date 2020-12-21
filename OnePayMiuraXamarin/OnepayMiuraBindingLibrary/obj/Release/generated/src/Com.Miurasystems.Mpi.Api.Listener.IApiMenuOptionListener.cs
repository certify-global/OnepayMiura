using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiMenuOptionListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiMenuOptionListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListenerInvoker")]
	public partial interface IApiMenuOptionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiMenuOptionListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetMenuOptionError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/GetMenuOptionError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError paramGetMenuOptionError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiMenuOptionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiMenuOptionListener", DoNotGenerateAcw=true)]
	internal partial class IApiMenuOptionListenerInvoker : global::Java.Lang.Object, IApiMenuOptionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiMenuOptionListener", typeof (IApiMenuOptionListenerInvoker));

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

		public static IApiMenuOptionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiMenuOptionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiMenuOptionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiMenuOptionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_);
			return cb_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramGetMenuOptionError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramGetMenuOptionError = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError> (native_paramGetMenuOptionError, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramGetMenuOptionError);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError paramGetMenuOptionError)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/GetMenuOptionError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramGetMenuOptionError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramGetMenuOptionError).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_GetMenuOptionError_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.miurasystems.mpi.api.listener.ApiMenuOptionListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError paramGetMenuOptionError)
		{
			this.paramGetMenuOptionError = paramGetMenuOptionError;
		}

		global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError paramGetMenuOptionError;
		public global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError ParamGetMenuOptionError {
			get { return paramGetMenuOptionError; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiMenuOptionListener.onSuccess
	public partial class ApiMenuOptionListenerSuccessEventArgs : global::System.EventArgs {

		public ApiMenuOptionListenerSuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiMenuOptionListenerImplementor")]
	internal sealed partial class IApiMenuOptionListenerImplementor : global::Java.Lang.Object, IApiMenuOptionListener {

		object sender;

		public IApiMenuOptionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiMenuOptionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.GetMenuOptionError paramGetMenuOptionError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramGetMenuOptionError));
		}
#pragma warning disable 0649
		public EventHandler<ApiMenuOptionListenerSuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (string p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new ApiMenuOptionListenerSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IApiMenuOptionListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
