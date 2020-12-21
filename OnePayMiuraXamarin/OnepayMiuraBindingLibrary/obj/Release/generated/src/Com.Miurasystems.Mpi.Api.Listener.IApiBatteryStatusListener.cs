using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBatteryStatusListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiBatteryStatusListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListenerInvoker")]
	public partial interface IApiBatteryStatusListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBatteryStatusListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBatteryStatusListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSuccess", "(II)V", "GetOnSuccess_IIHandler:Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiBatteryStatusListener", DoNotGenerateAcw=true)]
	internal partial class IApiBatteryStatusListenerInvoker : global::Java.Lang.Object, IApiBatteryStatusListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiBatteryStatusListener", typeof (IApiBatteryStatusListenerInvoker));

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

		public static IApiBatteryStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiBatteryStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiBatteryStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiBatteryStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_II;
#pragma warning disable 0169
		static Delegate GetOnSuccess_IIHandler ()
		{
			if (cb_onSuccess_II == null)
				cb_onSuccess_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnSuccess_II);
			return cb_onSuccess_II;
		}

		static void n_OnSuccess_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_II;
		public unsafe void OnSuccess (int p0, int p1)
		{
			if (id_onSuccess_II == IntPtr.Zero)
				id_onSuccess_II = JNIEnv.GetMethodID (class_ref, "onSuccess", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_II, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiBatteryStatusListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiBatteryStatusListenerImplementor")]
	internal sealed partial class IApiBatteryStatusListenerImplementor : global::Java.Lang.Object, IApiBatteryStatusListener {

		object sender;

		public IApiBatteryStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiBatteryStatusListenerImplementor", "()V"),
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

		public void OnSuccess (int p0, int p1)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IApiBatteryStatusListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
