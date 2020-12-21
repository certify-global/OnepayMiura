using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='APITransferFileListener']"
	[Register ("com/miurasystems/mpi/api/listener/APITransferFileListener", "", "Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListenerInvoker")]
	public partial interface IAPITransferFileListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='APITransferFileListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='APITransferFileListener']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnProgress (int paramInt);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='APITransferFileListener']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/APITransferFileListener", DoNotGenerateAcw=true)]
	internal partial class IAPITransferFileListenerInvoker : global::Java.Lang.Object, IAPITransferFileListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/APITransferFileListener", typeof (IAPITransferFileListenerInvoker));

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

		public static IAPITransferFileListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAPITransferFileListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.APITransferFileListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAPITransferFileListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onProgress_I;
#pragma warning disable 0169
		static Delegate GetOnProgress_IHandler ()
		{
			if (cb_onProgress_I == null)
				cb_onProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnProgress_I);
			return cb_onProgress_I;
		}

		static void n_OnProgress_I (IntPtr jnienv, IntPtr native__this, int paramInt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (paramInt);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_I;
		public unsafe void OnProgress (int paramInt)
		{
			if (id_onProgress_I == IntPtr.Zero)
				id_onProgress_I = JNIEnv.GetMethodID (class_ref, "onProgress", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (paramInt);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// event args for com.miurasystems.mpi.api.listener.APITransferFileListener.onProgress
	public partial class ProgressEventArgs : global::System.EventArgs {

		public ProgressEventArgs (int paramInt)
		{
			this.paramInt = paramInt;
		}

		int paramInt;
		public int ParamInt {
			get { return paramInt; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/APITransferFileListenerImplementor")]
	internal sealed partial class IAPITransferFileListenerImplementor : global::Java.Lang.Object, IAPITransferFileListener {

		object sender;

		public IAPITransferFileListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/APITransferFileListenerImplementor", "()V"),
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
		public EventHandler<ProgressEventArgs> OnProgressHandler;
#pragma warning restore 0649

		public void OnProgress (int paramInt)
		{
			var __h = OnProgressHandler;
			if (__h != null)
				__h (sender, new ProgressEventArgs (paramInt));
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

		internal static bool __IsEmpty (IAPITransferFileListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnProgressHandler == null && value.OnSuccessHandler == null;
		}
	}

}
