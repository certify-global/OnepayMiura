using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetContactlessHashValues']"
	[Register ("com/miurasystems/mpi/api/listener/ApiGetContactlessHashValues", "", "Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValuesInvoker")]
	public partial interface IApiGetContactlessHashValues : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.listener']/interface[@name='ApiGetContactlessHashValues']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onSuccess", "(Ljava/util/Map;)V", "GetOnSuccess_Ljava_util_Map_Handler:Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValuesInvoker, OnepayMiuraBindingLibrary")]
		void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/listener/ApiGetContactlessHashValues", DoNotGenerateAcw=true)]
	internal partial class IApiGetContactlessHashValuesInvoker : global::Java.Lang.Object, IApiGetContactlessHashValues {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/listener/ApiGetContactlessHashValues", typeof (IApiGetContactlessHashValuesInvoker));

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

		public static IApiGetContactlessHashValues GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiGetContactlessHashValues> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.listener.ApiGetContactlessHashValues"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiGetContactlessHashValuesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_util_Map_Handler ()
		{
			if (cb_onSuccess_Ljava_util_Map_ == null)
				cb_onSuccess_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_util_Map_);
			return cb_onSuccess_Ljava_util_Map_;
		}

		static void n_OnSuccess_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValues> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_util_Map_;
		public unsafe void OnSuccess (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_onSuccess_Ljava_util_Map_ == IntPtr.Zero)
				id_onSuccess_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
