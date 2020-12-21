using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileStreamListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListenerInvoker")]
	public partial interface IApiGetDeviceFileStreamListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileStreamListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("onError", "(Ljava/io/OutputStream;)V", "GetOnError_Ljava_io_OutputStream_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::System.IO.Stream paramOutputStream);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileStreamListener']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onProgress", "(F)V", "GetOnProgress_FHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnProgress (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileStreamListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("onSuccess", "(Ljava/io/OutputStream;)V", "GetOnSuccess_Ljava_io_OutputStream_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::System.IO.Stream paramOutputStream);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetDeviceFileStreamListenerInvoker : global::Java.Lang.Object, IApiGetDeviceFileStreamListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListener", typeof (IApiGetDeviceFileStreamListenerInvoker));

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

		public static IApiGetDeviceFileStreamListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetDeviceFileStreamListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetDeviceFileStreamListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetDeviceFileStreamListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_io_OutputStream_Handler ()
		{
			if (cb_onError_Ljava_io_OutputStream_ == null)
				cb_onError_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_io_OutputStream_);
			return cb_onError_Ljava_io_OutputStream_;
		}

		static void n_OnError_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramOutputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramOutputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_paramOutputStream, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramOutputStream);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_io_OutputStream_;
		public unsafe void OnError (global::System.IO.Stream paramOutputStream)
		{
			if (id_onError_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_onError_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/io/OutputStream;)V");
			IntPtr native_paramOutputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (paramOutputStream);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_paramOutputStream);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_paramOutputStream);
		}

		static Delegate cb_onProgress_F;
#pragma warning disable 0169
		static Delegate GetOnProgress_FHandler ()
		{
			if (cb_onProgress_F == null)
				cb_onProgress_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnProgress_F);
			return cb_onProgress_F;
		}

		static void n_OnProgress_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_F;
		public unsafe void OnProgress (float p0)
		{
			if (id_onProgress_F == IntPtr.Zero)
				id_onProgress_F = JNIEnv.GetMethodID (class_ref, "onProgress", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_F, __args);
		}

		static Delegate cb_onSuccess_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_io_OutputStream_Handler ()
		{
			if (cb_onSuccess_Ljava_io_OutputStream_ == null)
				cb_onSuccess_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_io_OutputStream_);
			return cb_onSuccess_Ljava_io_OutputStream_;
		}

		static void n_OnSuccess_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramOutputStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramOutputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_paramOutputStream, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramOutputStream);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_io_OutputStream_;
		public unsafe void OnSuccess (global::System.IO.Stream paramOutputStream)
		{
			if (id_onSuccess_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_onSuccess_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/io/OutputStream;)V");
			IntPtr native_paramOutputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (paramOutputStream);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_paramOutputStream);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_paramOutputStream);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDeviceFileStreamListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::System.IO.Stream paramOutputStream)
		{
			this.paramOutputStream = paramOutputStream;
		}

		global::System.IO.Stream paramOutputStream;
		public global::System.IO.Stream ParamOutputStream {
			get { return paramOutputStream; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDeviceFileStreamListener.onProgress
	public partial class ProgressEventArgs : global::System.EventArgs {

		public ProgressEventArgs (float p0)
		{
			this.p0 = p0;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDeviceFileStreamListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::System.IO.Stream paramOutputStream)
		{
			this.paramOutputStream = paramOutputStream;
		}

		global::System.IO.Stream paramOutputStream;
		public global::System.IO.Stream ParamOutputStream {
			get { return paramOutputStream; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListenerImplementor")]
	internal sealed partial class IApiGetDeviceFileStreamListenerImplementor : global::Java.Lang.Object, IApiGetDeviceFileStreamListener {

		object sender;

		public IApiGetDeviceFileStreamListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::System.IO.Stream paramOutputStream)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramOutputStream));
		}
#pragma warning disable 0649
		public EventHandler<ProgressEventArgs> OnProgressHandler;
#pragma warning restore 0649

		public void OnProgress (float p0)
		{
			var __h = OnProgressHandler;
			if (__h != null)
				__h (sender, new ProgressEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::System.IO.Stream paramOutputStream)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramOutputStream));
		}

		internal static bool __IsEmpty (IApiGetDeviceFileStreamListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnProgressHandler == null && value.OnSuccessHandler == null;
		}
	}

}
