using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEventPublisher']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/MpiEventPublisher", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Event"})]
	public partial class MpiEventPublisher : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/MpiEventPublisher", typeof (MpiEventPublisher));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MpiEventPublisher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_;
#pragma warning disable 0169
		static Delegate GetDeregister_Lcom_miurasystems_mpi_events_MpiEventHandler_Handler ()
		{
			if (cb_deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_ == null)
				cb_deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_);
			return cb_deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_;
		}

		static bool n_Deregister_Lcom_miurasystems_mpi_events_MpiEventHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var handler = (global::Com.Miurasystems.Mpi.Events.IMpiEventHandler)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.IMpiEventHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Deregister (handler);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEventPublisher']/method[@name='deregister' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.events.MpiEventHandler&lt;Event&gt;']]"
		[Register ("deregister", "(Lcom/miurasystems/mpi/events/MpiEventHandler;)Z", "GetDeregister_Lcom_miurasystems_mpi_events_MpiEventHandler_Handler")]
		public virtual unsafe bool Deregister (global::Com.Miurasystems.Mpi.Events.IMpiEventHandler handler)
		{
			const string __id = "deregister.(Lcom/miurasystems/mpi/events/MpiEventHandler;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		static Delegate cb_register_Lcom_miurasystems_mpi_events_MpiEventHandler_;
#pragma warning disable 0169
		static Delegate GetRegister_Lcom_miurasystems_mpi_events_MpiEventHandler_Handler ()
		{
			if (cb_register_Lcom_miurasystems_mpi_events_MpiEventHandler_ == null)
				cb_register_Lcom_miurasystems_mpi_events_MpiEventHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Register_Lcom_miurasystems_mpi_events_MpiEventHandler_);
			return cb_register_Lcom_miurasystems_mpi_events_MpiEventHandler_;
		}

		static bool n_Register_Lcom_miurasystems_mpi_events_MpiEventHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEventPublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var handler = (global::Com.Miurasystems.Mpi.Events.IMpiEventHandler)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.IMpiEventHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Register (handler);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='MpiEventPublisher']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.events.MpiEventHandler&lt;Event&gt;']]"
		[Register ("register", "(Lcom/miurasystems/mpi/events/MpiEventHandler;)Z", "GetRegister_Lcom_miurasystems_mpi_events_MpiEventHandler_Handler")]
		public virtual unsafe bool Register (global::Com.Miurasystems.Mpi.Events.IMpiEventHandler handler)
		{
			const string __id = "register.(Lcom/miurasystems/mpi/events/MpiEventHandler;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

	}
}
