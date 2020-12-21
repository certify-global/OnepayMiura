using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEImportListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiP2PEImportListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListenerInvoker")]
	public partial interface IApiP2PEImportListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEImportListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.RKIError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/RKIError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_RKIError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.RKIError paramRKIError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiP2PEImportListener']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiP2PEImportListener", DoNotGenerateAcw=true)]
	internal partial class IApiP2PEImportListenerInvoker : global::Java.Lang.Object, IApiP2PEImportListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiP2PEImportListener", typeof (IApiP2PEImportListenerInvoker));

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

		public static IApiP2PEImportListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiP2PEImportListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiP2PEImportListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiP2PEImportListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_RKIError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_RKIError_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_RKIError_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_RKIError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_RKIError_);
			return cb_onError_Lcom_miurasystems_mpi_enums_RKIError_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_RKIError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramRKIError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramRKIError = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.RKIError> (native_paramRKIError, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramRKIError);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_RKIError_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.RKIError paramRKIError)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_RKIError_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_RKIError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/RKIError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramRKIError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramRKIError).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_RKIError_, __args);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiP2PEImportListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.RKIError paramRKIError)
		{
			this.paramRKIError = paramRKIError;
		}

		global::Com.Miurasystems.Mpi.Enums.RKIError paramRKIError;
		public global::Com.Miurasystems.Mpi.Enums.RKIError ParamRKIError {
			get { return paramRKIError; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiP2PEImportListenerImplementor")]
	internal sealed partial class IApiP2PEImportListenerImplementor : global::Java.Lang.Object, IApiP2PEImportListener {

		object sender;

		public IApiP2PEImportListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiP2PEImportListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.RKIError paramRKIError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramRKIError));
		}
#pragma warning disable 0649
		public EventHandler OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess ()
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IApiP2PEImportListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
