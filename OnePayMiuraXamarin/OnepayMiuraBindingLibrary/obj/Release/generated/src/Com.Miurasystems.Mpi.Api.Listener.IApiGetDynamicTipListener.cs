using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDynamicTipListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetDynamicTipListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListenerInvoker")]
	public partial interface IApiGetDynamicTipListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDynamicTipListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetNumericDataError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/GetNumericDataError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_GetNumericDataError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDynamicTipListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSuccess", "(I)V", "GetOnSuccess_IHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (int paramInt);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetDynamicTipListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetDynamicTipListenerInvoker : global::Java.Lang.Object, IApiGetDynamicTipListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetDynamicTipListener", typeof (IApiGetDynamicTipListenerInvoker));

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

		public static IApiGetDynamicTipListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetDynamicTipListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetDynamicTipListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetDynamicTipListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_I;
#pragma warning disable 0169
		static Delegate GetOnSuccess_IHandler ()
		{
			if (cb_onSuccess_I == null)
				cb_onSuccess_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnSuccess_I);
			return cb_onSuccess_I;
		}

		static void n_OnSuccess_I (IntPtr jnienv, IntPtr native__this, int paramInt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramInt);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_I;
		public unsafe void OnSuccess (int paramInt)
		{
			if (id_onSuccess_I == IntPtr.Zero)
				id_onSuccess_I = JNIEnv.GetMethodID (class_ref, "onSuccess", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (paramInt);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_I, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDynamicTipListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError)
		{
			this.paramGetNumericDataError = paramGetNumericDataError;
		}

		global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError;
		public global::Com.Miurasystems.Mpi.Enums.GetNumericDataError ParamGetNumericDataError {
			get { return paramGetNumericDataError; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDynamicTipListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (int paramInt)
		{
			this.paramInt = paramInt;
		}

		int paramInt;
		public int ParamInt {
			get { return paramInt; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetDynamicTipListenerImplementor")]
	internal sealed partial class IApiGetDynamicTipListenerImplementor : global::Java.Lang.Object, IApiGetDynamicTipListener {

		object sender;

		public IApiGetDynamicTipListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetDynamicTipListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.GetNumericDataError paramGetNumericDataError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramGetNumericDataError));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (int paramInt)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramInt));
		}

		internal static bool __IsEmpty (IApiGetDynamicTipListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
