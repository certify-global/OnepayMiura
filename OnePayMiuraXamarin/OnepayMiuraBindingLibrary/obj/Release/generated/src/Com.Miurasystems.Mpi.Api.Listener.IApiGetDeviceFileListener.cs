using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListenerInvoker")]
	public partial interface IApiGetDeviceFileListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileListener']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onProgress", "(F)V", "GetOnProgress_FHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnProgress (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetDeviceFileListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onSuccess", "([B)V", "GetOnSuccess_arrayBHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetDeviceFileListenerInvoker : global::Java.Lang.Object, IApiGetDeviceFileListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetDeviceFileListener", typeof (IApiGetDeviceFileListenerInvoker));

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

		public static IApiGetDeviceFileListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetDeviceFileListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetDeviceFileListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener.onProgress
	public partial class ApiDeviceFileListenerProgressEventArgs : global::System.EventArgs {

		public ApiDeviceFileListenerProgressEventArgs (float p0)
		{
			this.p0 = p0;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener.onSuccess
	public partial class ApiDeviceFileListenerSuccessEventArgs : global::System.EventArgs {

		public ApiDeviceFileListenerSuccessEventArgs (byte[] p0)
		{
			this.p0 = p0;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetDeviceFileListenerImplementor")]
	internal sealed partial class IApiGetDeviceFileListenerImplementor : global::Java.Lang.Object, IApiGetDeviceFileListener {

		object sender;

		public IApiGetDeviceFileListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetDeviceFileListenerImplementor", "()V"),
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
		public EventHandler<ApiDeviceFileListenerProgressEventArgs> OnProgressHandler;
#pragma warning restore 0649

		public void OnProgress (float p0)
		{
			var __h = OnProgressHandler;
			if (__h != null)
				__h (sender, new ApiDeviceFileListenerProgressEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ApiDeviceFileListenerSuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (byte[] p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new ApiDeviceFileListenerSuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IApiGetDeviceFileListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnProgressHandler == null && value.OnSuccessHandler == null;
		}
	}

}
