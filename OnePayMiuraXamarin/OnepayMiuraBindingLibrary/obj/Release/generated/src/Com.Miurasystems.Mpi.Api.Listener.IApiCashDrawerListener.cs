using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiCashDrawerListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiCashDrawerListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListenerInvoker")]
	public partial interface IApiCashDrawerListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiCashDrawerListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiCashDrawerListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onSuccess", "(Z)V", "GetOnSuccess_ZHandler:Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (bool paramBoolean);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiCashDrawerListener", DoNotGenerateAcw=true)]
	internal partial class IApiCashDrawerListenerInvoker : global::Java.Lang.Object, IApiCashDrawerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiCashDrawerListener", typeof (IApiCashDrawerListenerInvoker));

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

		public static IApiCashDrawerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiCashDrawerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiCashDrawerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiCashDrawerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Z;
#pragma warning disable 0169
		static Delegate GetOnSuccess_ZHandler ()
		{
			if (cb_onSuccess_Z == null)
				cb_onSuccess_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnSuccess_Z);
			return cb_onSuccess_Z;
		}

		static void n_OnSuccess_Z (IntPtr jnienv, IntPtr native__this, bool paramBoolean)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramBoolean);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Z;
		public unsafe void OnSuccess (bool paramBoolean)
		{
			if (id_onSuccess_Z == IntPtr.Zero)
				id_onSuccess_Z = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (paramBoolean);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Z, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiCashDrawerListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (bool paramBoolean)
		{
			this.paramBoolean = paramBoolean;
		}

		bool paramBoolean;
		public bool ParamBoolean {
			get { return paramBoolean; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiCashDrawerListenerImplementor")]
	internal sealed partial class IApiCashDrawerListenerImplementor : global::Java.Lang.Object, IApiCashDrawerListener {

		object sender;

		public IApiCashDrawerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiCashDrawerListenerImplementor", "()V"),
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
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (bool paramBoolean)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramBoolean));
		}

		internal static bool __IsEmpty (IApiCashDrawerListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
