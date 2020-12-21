using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiPeripheralTypeListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiPeripheralTypeListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListenerInvoker")]
	public partial interface IApiPeripheralTypeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiPeripheralTypeListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiPeripheralTypeListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("onSuccess", "(Ljava/util/ArrayList;)V", "GetOnSuccess_Ljava_util_ArrayList_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::System.Collections.Generic.IList<string> paramArrayList);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiPeripheralTypeListener", DoNotGenerateAcw=true)]
	internal partial class IApiPeripheralTypeListenerInvoker : global::Java.Lang.Object, IApiPeripheralTypeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiPeripheralTypeListener", typeof (IApiPeripheralTypeListenerInvoker));

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

		public static IApiPeripheralTypeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiPeripheralTypeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiPeripheralTypeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiPeripheralTypeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_ArrayList_Handler ()
		{
			if (cb_onSuccess_Ljava_util_ArrayList_ == null)
				cb_onSuccess_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_util_ArrayList_);
			return cb_onSuccess_Ljava_util_ArrayList_;
		}

		static void n_OnSuccess_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramArrayList)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramArrayList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_paramArrayList, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramArrayList);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_util_ArrayList_;
		public unsafe void OnSuccess (global::System.Collections.Generic.IList<string> paramArrayList)
		{
			if (id_onSuccess_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/ArrayList;)V");
			IntPtr native_paramArrayList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (paramArrayList);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_paramArrayList);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_paramArrayList);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiPeripheralTypeListener.onSuccess
	public partial class ApiPeripheralTypeListenerSuccessEventArgs : global::System.EventArgs {

		public ApiPeripheralTypeListenerSuccessEventArgs (global::System.Collections.Generic.IList<string> paramArrayList)
		{
			this.paramArrayList = paramArrayList;
		}

		global::System.Collections.Generic.IList<string> paramArrayList;
		public global::System.Collections.Generic.IList<string> ParamArrayList {
			get { return paramArrayList; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiPeripheralTypeListenerImplementor")]
	internal sealed partial class IApiPeripheralTypeListenerImplementor : global::Java.Lang.Object, IApiPeripheralTypeListener {

		object sender;

		public IApiPeripheralTypeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiPeripheralTypeListenerImplementor", "()V"),
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
		public EventHandler<ApiPeripheralTypeListenerSuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (global::System.Collections.Generic.IList<string> paramArrayList)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new ApiPeripheralTypeListenerSuccessEventArgs (paramArrayList));
		}

		internal static bool __IsEmpty (IApiPeripheralTypeListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
