using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiStartTransactionListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiStartTransactionListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListenerInvoker")]
	public partial interface IApiStartTransactionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiStartTransactionListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionResponse']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/TransactionResponse;)V", "GetOnError_Lcom_miurasystems_mpi_enums_TransactionResponse_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiStartTransactionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onSuccess", "([B)V", "GetOnSuccess_arrayBHandler:Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiStartTransactionListener", DoNotGenerateAcw=true)]
	internal partial class IApiStartTransactionListenerInvoker : global::Java.Lang.Object, IApiStartTransactionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiStartTransactionListener", typeof (IApiStartTransactionListenerInvoker));

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

		public static IApiStartTransactionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiStartTransactionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiStartTransactionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiStartTransactionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_OnSuccess_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnSuccess (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_arrayB;
		public unsafe void OnSuccess (byte[] p0)
		{
			if (id_onSuccess_arrayB == IntPtr.Zero)
				id_onSuccess_arrayB = JNIEnv.GetMethodID (class_ref, "onSuccess", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiStartTransactionListener.onError
	public partial class ApiStartTransactionListenerErrorEventArgs : global::System.EventArgs {

		public ApiStartTransactionListenerErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse)
		{
			this.paramTransactionResponse = paramTransactionResponse;
		}

		global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse;
		public global::Com.Miurasystems.Mpi.Enums.TransactionResponse ParamTransactionResponse {
			get { return paramTransactionResponse; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiStartTransactionListener.onSuccess
	public partial class ApiStartTransactionListenerSuccessEventArgs : global::System.EventArgs {

		public ApiStartTransactionListenerSuccessEventArgs (byte[] p0)
		{
			this.p0 = p0;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiStartTransactionListenerImplementor")]
	internal sealed partial class IApiStartTransactionListenerImplementor : global::Java.Lang.Object, IApiStartTransactionListener {

		object sender;

		public IApiStartTransactionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiStartTransactionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ApiStartTransactionListenerErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.TransactionResponse paramTransactionResponse)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ApiStartTransactionListenerErrorEventArgs (paramTransactionResponse));
		}
#pragma warning disable 0649
		public EventHandler<ApiStartTransactionListenerSuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (byte[] p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new ApiStartTransactionListenerSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IApiStartTransactionListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
