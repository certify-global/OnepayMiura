using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='MiuraDefaultListener']"
	[Register ("com/miurasystems/mpi/api/listener/MiuraDefaultListener", "", "Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListenerInvoker")]
	public partial interface IMiuraDefaultListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='MiuraDefaultListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='MiuraDefaultListener']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/MiuraDefaultListener", DoNotGenerateAcw=true)]
	internal partial class IMiuraDefaultListenerInvoker : global::Java.Lang.Object, IMiuraDefaultListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/MiuraDefaultListener", typeof (IMiuraDefaultListenerInvoker));

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

		public static IMiuraDefaultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMiuraDefaultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.MiuraDefaultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMiuraDefaultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/MiuraDefaultListenerImplementor")]
	internal sealed partial class IMiuraDefaultListenerImplementor : global::Java.Lang.Object, IMiuraDefaultListener {

		object sender;

		public IMiuraDefaultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/MiuraDefaultListenerImplementor", "()V"),
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
		public EventHandler OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess ()
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IMiuraDefaultListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
