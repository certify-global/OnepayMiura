using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/events/PrinterStatus", DoNotGenerateAcw=true)]
	public partial class PrinterStatus : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/events/PrinterStatus", typeof (PrinterStatus));
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

		protected PrinterStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isAttached;
#pragma warning disable 0169
		static Delegate GetIsAttachedHandler ()
		{
			if (cb_isAttached == null)
				cb_isAttached = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAttached);
			return cb_isAttached;
		}

		static bool n_IsAttached (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAttached;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAttached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isAttached' and count(parameter)=0]"
			[Register ("isAttached", "()Z", "GetIsAttachedHandler")]
			get {
				const string __id = "isAttached.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isError;
#pragma warning disable 0169
		static Delegate GetIsErrorHandler ()
		{
			if (cb_isError == null)
				cb_isError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsError);
			return cb_isError;
		}

		static bool n_IsError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsError;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler")]
			get {
				const string __id = "isError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPaperOk;
#pragma warning disable 0169
		static Delegate GetIsPaperOkHandler ()
		{
			if (cb_isPaperOk == null)
				cb_isPaperOk = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPaperOk);
			return cb_isPaperOk;
		}

		static bool n_IsPaperOk (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaperOk;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPaperOk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isPaperOk' and count(parameter)=0]"
			[Register ("isPaperOk", "()Z", "GetIsPaperOkHandler")]
			get {
				const string __id = "isPaperOk.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPowered;
#pragma warning disable 0169
		static Delegate GetIsPoweredHandler ()
		{
			if (cb_isPowered == null)
				cb_isPowered = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPowered);
			return cb_isPowered;
		}

		static bool n_IsPowered (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPowered;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPowered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isPowered' and count(parameter)=0]"
			[Register ("isPowered", "()Z", "GetIsPoweredHandler")]
			get {
				const string __id = "isPowered.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrinting;
#pragma warning disable 0169
		static Delegate GetIsPrintingHandler ()
		{
			if (cb_isPrinting == null)
				cb_isPrinting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrinting);
			return cb_isPrinting;
		}

		static bool n_IsPrinting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrinting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrinting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isPrinting' and count(parameter)=0]"
			[Register ("isPrinting", "()Z", "GetIsPrintingHandler")]
			get {
				const string __id = "isPrinting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrintingScheduled;
#pragma warning disable 0169
		static Delegate GetIsPrintingScheduledHandler ()
		{
			if (cb_isPrintingScheduled == null)
				cb_isPrintingScheduled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrintingScheduled);
			return cb_isPrintingScheduled;
		}

		static bool n_IsPrintingScheduled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrintingScheduled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrintingScheduled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='isPrintingScheduled' and count(parameter)=0]"
			[Register ("isPrintingScheduled", "()Z", "GetIsPrintingScheduledHandler")]
			get {
				const string __id = "isPrintingScheduled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetValue);
			return cb_getValue;
		}

		static int n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		public virtual unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("valueOf", "(B)Lcom/miurasystems/mpi/events/PrinterStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Events.PrinterStatus ValueOf (sbyte value)
		{
			const string __id = "valueOf.(B)Lcom/miurasystems/mpi/events/PrinterStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_whatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_;
#pragma warning disable 0169
		static Delegate GetWhatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_Handler ()
		{
			if (cb_whatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_ == null)
				cb_whatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WhatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_);
			return cb_whatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_;
		}

		static IntPtr n_WhatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newStatus = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.PrinterStatus> (native_newStatus, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.WhatChanged (newStatus));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.events']/class[@name='PrinterStatus']/method[@name='whatChanged' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.events.PrinterStatus']]"
		[Register ("whatChanged", "(Lcom/miurasystems/mpi/events/PrinterStatus;)Ljava/util/Map;", "GetWhatChanged_Lcom_miurasystems_mpi_events_PrinterStatus_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask, global::Java.Lang.Boolean> WhatChanged (global::Com.Miurasystems.Mpi.Events.PrinterStatus newStatus)
		{
			const string __id = "whatChanged.(Lcom/miurasystems/mpi/events/PrinterStatus;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newStatus).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask, global::Java.Lang.Boolean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (newStatus);
			}
		}

	}
}
