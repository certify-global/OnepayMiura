using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiOnlinePinListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiOnlinePinListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListenerInvoker")]
	public partial interface IApiOnlinePinListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiOnlinePinListener']/method[@name='onBypassedPINEntry' and count(parameter)=0]"
		[Register ("onBypassedPINEntry", "()V", "GetOnBypassedPINEntryHandler:Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnBypassedPINEntry ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiOnlinePinListener']/method[@name='onCancelOrTimeout' and count(parameter)=0]"
		[Register ("onCancelOrTimeout", "()V", "GetOnCancelOrTimeoutHandler:Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnCancelOrTimeout ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiOnlinePinListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.OnlinePINError']]"
		[Register ("onError", "(Lcom/miurasystems/mpi/enums/OnlinePINError;)V", "GetOnError_Lcom_miurasystems_mpi_enums_OnlinePINError_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError (global::Com.Miurasystems.Mpi.Enums.OnlinePINError paramOnlinePINError);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiOnlinePinListener']/method[@name='onOnlinePIN' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("onOnlinePIN", "([B[B)V", "GetOnOnlinePIN_arrayBarrayBHandler:Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnOnlinePIN (byte[] p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiOnlinePinListener", DoNotGenerateAcw=true)]
	internal partial class IApiOnlinePinListenerInvoker : global::Java.Lang.Object, IApiOnlinePinListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiOnlinePinListener", typeof (IApiOnlinePinListenerInvoker));

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

		public static IApiOnlinePinListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiOnlinePinListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiOnlinePinListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiOnlinePinListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBypassedPINEntry;
#pragma warning disable 0169
		static Delegate GetOnBypassedPINEntryHandler ()
		{
			if (cb_onBypassedPINEntry == null)
				cb_onBypassedPINEntry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBypassedPINEntry);
			return cb_onBypassedPINEntry;
		}

		static void n_OnBypassedPINEntry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBypassedPINEntry ();
		}
#pragma warning restore 0169

		IntPtr id_onBypassedPINEntry;
		public unsafe void OnBypassedPINEntry ()
		{
			if (id_onBypassedPINEntry == IntPtr.Zero)
				id_onBypassedPINEntry = JNIEnv.GetMethodID (class_ref, "onBypassedPINEntry", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBypassedPINEntry);
		}

		static Delegate cb_onCancelOrTimeout;
#pragma warning disable 0169
		static Delegate GetOnCancelOrTimeoutHandler ()
		{
			if (cb_onCancelOrTimeout == null)
				cb_onCancelOrTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancelOrTimeout);
			return cb_onCancelOrTimeout;
		}

		static void n_OnCancelOrTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelOrTimeout ();
		}
#pragma warning restore 0169

		IntPtr id_onCancelOrTimeout;
		public unsafe void OnCancelOrTimeout ()
		{
			if (id_onCancelOrTimeout == IntPtr.Zero)
				id_onCancelOrTimeout = JNIEnv.GetMethodID (class_ref, "onCancelOrTimeout", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelOrTimeout);
		}

		static Delegate cb_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_miurasystems_mpi_enums_OnlinePINError_Handler ()
		{
			if (cb_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_ == null)
				cb_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_miurasystems_mpi_enums_OnlinePINError_);
			return cb_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_;
		}

		static void n_OnError_Lcom_miurasystems_mpi_enums_OnlinePINError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramOnlinePINError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramOnlinePINError = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.OnlinePINError> (native_paramOnlinePINError, JniHandleOwnership.DoNotTransfer);
			__this.OnError (paramOnlinePINError);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_;
		public unsafe void OnError (global::Com.Miurasystems.Mpi.Enums.OnlinePINError paramOnlinePINError)
		{
			if (id_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_ == IntPtr.Zero)
				id_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/miurasystems/mpi/enums/OnlinePINError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((paramOnlinePINError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramOnlinePINError).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_miurasystems_mpi_enums_OnlinePINError_, __args);
		}

		static Delegate cb_onOnlinePIN_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetOnOnlinePIN_arrayBarrayBHandler ()
		{
			if (cb_onOnlinePIN_arrayBarrayB == null)
				cb_onOnlinePIN_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnOnlinePIN_arrayBarrayB);
			return cb_onOnlinePIN_arrayBarrayB;
		}

		static void n_OnOnlinePIN_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnOnlinePIN (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onOnlinePIN_arrayBarrayB;
		public unsafe void OnOnlinePIN (byte[] p0, byte[] p1)
		{
			if (id_onOnlinePIN_arrayBarrayB == IntPtr.Zero)
				id_onOnlinePIN_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "onOnlinePIN", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOnlinePIN_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiOnlinePinListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Miurasystems.Mpi.Enums.OnlinePINError paramOnlinePINError)
		{
			this.paramOnlinePINError = paramOnlinePINError;
		}

		global::Com.Miurasystems.Mpi.Enums.OnlinePINError paramOnlinePINError;
		public global::Com.Miurasystems.Mpi.Enums.OnlinePINError ParamOnlinePINError {
			get { return paramOnlinePINError; }
		}
	}

	// event args for com.miurasystems.mpi.api.listener.ApiOnlinePinListener.onOnlinePIN
	public partial class OnlinePINEventArgs : global::System.EventArgs {

		public OnlinePINEventArgs (byte[] p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiOnlinePinListenerImplementor")]
	internal sealed partial class IApiOnlinePinListenerImplementor : global::Java.Lang.Object, IApiOnlinePinListener {

		object sender;

		public IApiOnlinePinListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiOnlinePinListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnBypassedPINEntryHandler;
#pragma warning restore 0649

		public void OnBypassedPINEntry ()
		{
			var __h = OnBypassedPINEntryHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnCancelOrTimeoutHandler;
#pragma warning restore 0649

		public void OnCancelOrTimeout ()
		{
			var __h = OnCancelOrTimeoutHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Miurasystems.Mpi.Enums.OnlinePINError paramOnlinePINError)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (paramOnlinePINError));
		}
#pragma warning disable 0649
		public EventHandler<OnlinePINEventArgs> OnOnlinePINHandler;
#pragma warning restore 0649

		public void OnOnlinePIN (byte[] p0, byte[] p1)
		{
			var __h = OnOnlinePINHandler;
			if (__h != null)
				__h (sender, new OnlinePINEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IApiOnlinePinListenerImplementor value)
		{
			return value.OnBypassedPINEntryHandler == null && value.OnCancelOrTimeoutHandler == null && value.OnErrorHandler == null && value.OnOnlinePINHandler == null;
		}
	}

}
