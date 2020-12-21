using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Comms {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.comms']/interface[@name='ConnectionStateCallback']"
	[Register ("com/miurasystems/mpi/comms/ConnectionStateCallback", "", "Com.Miurasystems.Mpi.Comms.IConnectionStateCallbackInvoker")]
	public partial interface IConnectionStateCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.comms']/interface[@name='ConnectionStateCallback']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("handle", "(Z)V", "GetHandle_ZHandler:Com.Miurasystems.Mpi.Comms.IConnectionStateCallbackInvoker, OnepayMiuraBindingLibrary")]
		void Handle (bool p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/comms/ConnectionStateCallback", DoNotGenerateAcw=true)]
	internal partial class IConnectionStateCallbackInvoker : global::Java.Lang.Object, IConnectionStateCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/comms/ConnectionStateCallback", typeof (IConnectionStateCallbackInvoker));

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

		public static IConnectionStateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionStateCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.comms.ConnectionStateCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionStateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Z;
#pragma warning disable 0169
		static Delegate GetHandle_ZHandler ()
		{
			if (cb_handle_Z == null)
				cb_handle_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Handle_Z);
			return cb_handle_Z;
		}

		static void n_Handle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0);
		}
#pragma warning restore 0169

		IntPtr id_handle_Z;
		public unsafe void Handle (bool p0)
		{
			if (id_handle_Z == IntPtr.Zero)
				id_handle_Z = JNIEnv.GetMethodID (class_ref, "handle", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Z, __args);
		}

	}

}
