using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.events']/interface[@name='MpiEventHandler']"
	[Register ("com/miurasystems/mpi/events/MpiEventHandler", "", "Com.Miurasystems.Mpi.Events.IMpiEventHandlerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Event"})]
	public partial interface IMpiEventHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/interface[@name='MpiEventHandler']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='Event']]"
		[Register ("handle", "(Ljava/lang/Object;)V", "GetHandle_Ljava_lang_Object_Handler:Com.Miurasystems.Mpi.Events.IMpiEventHandlerInvoker, OnepayMiuraBindingLibrary")]
		void Handle (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/MpiEventHandler", DoNotGenerateAcw=true)]
	internal partial class IMpiEventHandlerInvoker : global::Java.Lang.Object, IMpiEventHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/MpiEventHandler", typeof (IMpiEventHandlerInvoker));

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

		public static IMpiEventHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMpiEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.events.MpiEventHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMpiEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandle_Ljava_lang_Object_Handler ()
		{
			if (cb_handle_Ljava_lang_Object_ == null)
				cb_handle_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Handle_Ljava_lang_Object_);
			return cb_handle_Ljava_lang_Object_;
		}

		static void n_Handle_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.IMpiEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0);
		}
#pragma warning restore 0169

		IntPtr id_handle_Ljava_lang_Object_;
		public unsafe void Handle (global::Java.Lang.Object p0)
		{
			if (id_handle_Ljava_lang_Object_ == IntPtr.Zero)
				id_handle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "handle", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
