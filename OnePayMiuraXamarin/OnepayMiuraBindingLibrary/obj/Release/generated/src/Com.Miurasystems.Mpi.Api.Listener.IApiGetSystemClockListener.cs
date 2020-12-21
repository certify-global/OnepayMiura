using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSystemClockListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetSystemClockListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListenerInvoker")]
	public partial interface IApiGetSystemClockListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSystemClockListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetSystemClockListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("onSuccess", "(Ljava/util/Date;)V", "GetOnSuccess_Ljava_util_Date_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::Java.Util.Date paramDate);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetSystemClockListener", DoNotGenerateAcw=true)]
	internal partial class IApiGetSystemClockListenerInvoker : global::Java.Lang.Object, IApiGetSystemClockListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetSystemClockListener", typeof (IApiGetSystemClockListenerInvoker));

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

		public static IApiGetSystemClockListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetSystemClockListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetSystemClockListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetSystemClockListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_Date_Handler ()
		{
			if (cb_onSuccess_Ljava_util_Date_ == null)
				cb_onSuccess_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_util_Date_);
			return cb_onSuccess_Ljava_util_Date_;
		}

		static void n_OnSuccess_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramDate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_paramDate, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramDate);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_util_Date_;
		public unsafe void OnSuccess (global::Java.Util.Date paramDate)
		{
			if (id_onSuccess_Ljava_util_Date_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/Date;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramDate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramDate).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_util_Date_, __args);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiGetSystemClockListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::Java.Util.Date paramDate)
		{
			this.paramDate = paramDate;
		}

		global::Java.Util.Date paramDate;
		public global::Java.Util.Date ParamDate {
			get { return paramDate; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiGetSystemClockListenerImplementor")]
	internal sealed partial class IApiGetSystemClockListenerImplementor : global::Java.Lang.Object, IApiGetSystemClockListener {

		object sender;

		public IApiGetSystemClockListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiGetSystemClockListenerImplementor", "()V"),
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

		public void OnSuccess (global::Java.Util.Date paramDate)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramDate));
		}

		internal static bool __IsEmpty (IApiGetSystemClockListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
