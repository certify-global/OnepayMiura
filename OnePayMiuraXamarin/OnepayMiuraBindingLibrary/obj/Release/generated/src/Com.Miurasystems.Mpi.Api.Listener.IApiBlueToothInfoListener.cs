using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBlueToothInfoListener']"
	[Register ("com/miurasystems/mpi/api/listener/ApiBlueToothInfoListener", "", "Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListenerInvoker")]
	public partial interface IApiBlueToothInfoListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBlueToothInfoListener']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiBlueToothInfoListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSuccess", "(Ljava/util/HashMap;)V", "GetOnSuccess_Ljava_util_HashMap_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListenerInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> paramHashMap);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiBlueToothInfoListener", DoNotGenerateAcw=true)]
	internal partial class IApiBlueToothInfoListenerInvoker : global::Java.Lang.Object, IApiBlueToothInfoListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiBlueToothInfoListener", typeof (IApiBlueToothInfoListenerInvoker));

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

		public static IApiBlueToothInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiBlueToothInfoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiBlueToothInfoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiBlueToothInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_HashMap_Handler ()
		{
			if (cb_onSuccess_Ljava_util_HashMap_ == null)
				cb_onSuccess_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_util_HashMap_);
			return cb_onSuccess_Ljava_util_HashMap_;
		}

		static void n_OnSuccess_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paramHashMap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paramHashMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_paramHashMap, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (paramHashMap);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_util_HashMap_;
		public unsafe void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> paramHashMap)
		{
			if (id_onSuccess_Ljava_util_HashMap_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/HashMap;)V");
			IntPtr native_paramHashMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (paramHashMap);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_paramHashMap);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_util_HashMap_, __args);
			JNIEnv.DeleteLocalRef (native_paramHashMap);
		}

	}

	// event args for com.miurasystems.mpi.api.listener.ApiBlueToothInfoListener.onSuccess
	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (global::System.Collections.Generic.IDictionary<string, string> paramHashMap)
		{
			this.paramHashMap = paramHashMap;
		}

		global::System.Collections.Generic.IDictionary<string, string> paramHashMap;
		public global::System.Collections.Generic.IDictionary<string, string> ParamHashMap {
			get { return paramHashMap; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/miurasystems/mpi/api/listener/ApiBlueToothInfoListenerImplementor")]
	internal sealed partial class IApiBlueToothInfoListenerImplementor : global::Java.Lang.Object, IApiBlueToothInfoListener {

		object sender;

		public IApiBlueToothInfoListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/miurasystems/mpi/api/listener/ApiBlueToothInfoListenerImplementor", "()V"),
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

		public void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> paramHashMap)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (paramHashMap));
		}

		internal static bool __IsEmpty (IApiBlueToothInfoListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
