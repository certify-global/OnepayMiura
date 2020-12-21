using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiContinueTransactionListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiContinueTransactionListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListenerInvoker")]
	public partial interface IApiContinueTransactionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiContinueTransactionListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionResponse']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/TransactionResponse;)V", "GetOnError_Lcom_miurasystems_mpi_enums_TransactionResponse_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiContinueTransactionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onSuccess", "([B)V", "GetOnSuccess_arrayBHandler:Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (byte[] paramArrayOfbyte);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiContinueTransactionListener", DoNotGenerateAcw=true)]
	internal partial class IApiContinueTransactionListenerInvoker : global::Java.Lang.Object, IApiContinueTransactionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiContinueTransactionListener", typeof (IApiContinueTransactionListenerInvoker));

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

		public static IApiContinueTransactionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiContinueTransactionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiContinueTransactionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiContinueTransactionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_TransactionResponse_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_TransactionResponse_);
			return cb_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_TransactionResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramTransactionResponse)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramTransactionResponse = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionResponse> (native_paramTransactionResponse, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramTransactionResponse);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/TransactionResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramTransactionResponse == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramTransactionResponse).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_TransactionResponse_, __args);
		}

		static Delegate cb_onSuccess_arrayB;
#pragma warning disable 0169
		static Delegate GetOnSuccess_arrayBHandler ()
		{
			if (cb_onSuccess_arrayB == null)
				cb_onSuccess_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_arrayB);
			return cb_onSuccess_arrayB;
		}

		static void n_OnSuccess_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_paramArrayOfbyte)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramArrayOfbyte = (byte[]) JNIEnv.GetArray (native_paramArrayOfbyte, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnSuccess (paramArrayOfbyte);
			if (paramArrayOfbyte != null)
				JNIEnv.CopyArray (paramArrayOfbyte, native_paramArrayOfbyte);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_arrayB;
		public unsafe void OnSuccess (byte[] paramArrayOfbyte)
		{
			if (id_onSuccess_arrayB == IntPtr.Zero)
				id_onSuccess_arrayB = JNIEnv.GetMethodID (class_ref, "onSuccess", "([B)V");
			IntPtr native_paramArrayOfbyte = JNIEnv.NewArray (paramArrayOfbyte);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_paramArrayOfbyte);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_arrayB, __args);
			if (paramArrayOfbyte != null) {
				JNIEnv.CopyArray (native_paramArrayOfbyte, paramArrayOfbyte);
				JNIEnv.DeleteLocalRef (native_paramArrayOfbyte);
			}
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiContinueTransactionListener.onError
	public partial class ApiContinueTransactionListenerErrorEventArgs : global::System.EventArgs {

		public ApiContinueTransactionListenerErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse)
		{
			this.paramTransactionResponse = paramTransactionResponse;
		}

		global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse;
		public global::Com.Miurasystems.Mpi.Enums.TransactionResponse ParamTransactionResponse {
			get { return paramTransactionResponse; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiContinueTransactionListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (byte[] paramArrayOfbyte)
		{
			this.paramArrayOfbyte = paramArrayOfbyte;
		}

		byte[] paramArrayOfbyte;
		public byte[] ParamArrayOfbyte {
			get { return paramArrayOfbyte; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiContinueTransactionListenerImplementor")]
	internal sealed partial class IApiContinueTransactionListenerImplementor : global::Java.Lang.Object, IApiContinueTransactionListener {

		object sender;

		public IApiContinueTransactionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiContinueTransactionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ApiContinueTransactionListenerErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ApiContinueTransactionListenerErrorEventArgs (paramTransactionResponse));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (byte[] paramArrayOfbyte)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramArrayOfbyte));
		}

		internal static bool __IsEmpty (IApiContinueTransactionListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
