using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']"
	[global::Android.Runtime.Register ("com/onepay/miura/data/SetClockApiData", DoNotGenerateAcw=true)]
	public partial class SetClockApiData : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/data/SetClockApiData", typeof (SetClockApiData));
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

		protected SetClockApiData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']/constructor[@name='SetClockApiData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SetClockApiData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_returnReason;
#pragma warning disable 0169
		static Delegate GetReturnReasonHandler ()
		{
			if (cb_returnReason == null)
				cb_returnReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReturnReason);
			return cb_returnReason;
		}

		static IntPtr n_ReturnReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.SetClockApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReturnReason ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']/method[@name='returnReason' and count(parameter)=0]"
		[Register ("returnReason", "()Ljava/lang/String;", "GetReturnReasonHandler")]
		public virtual unsafe string ReturnReason ()
		{
			const string __id = "returnReason.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_returnStatus;
#pragma warning disable 0169
		static Delegate GetReturnStatusHandler ()
		{
			if (cb_returnStatus == null)
				cb_returnStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ReturnStatus);
			return cb_returnStatus;
		}

		static int n_ReturnStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.SetClockApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReturnStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']/method[@name='returnStatus' and count(parameter)=0]"
		[Register ("returnStatus", "()I", "GetReturnStatusHandler")]
		public virtual unsafe int ReturnStatus ()
		{
			const string __id = "returnStatus.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setReturnReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReturnReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReturnReason_Ljava_lang_String_ == null)
				cb_setReturnReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReturnReason_Ljava_lang_String_);
			return cb_setReturnReason_Ljava_lang_String_;
		}

		static void n_SetReturnReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_returnReason)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.SetClockApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var returnReason = JNIEnv.GetString (native_returnReason, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnReason (returnReason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']/method[@name='setReturnReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReturnReason", "(Ljava/lang/String;)V", "GetSetReturnReason_Ljava_lang_String_Handler")]
		public virtual unsafe void SetReturnReason (string returnReason)
		{
			const string __id = "setReturnReason.(Ljava/lang/String;)V";
			IntPtr native_returnReason = JNIEnv.NewString (returnReason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_returnReason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_returnReason);
			}
		}

		static Delegate cb_setReturnStatus_I;
#pragma warning disable 0169
		static Delegate GetSetReturnStatus_IHandler ()
		{
			if (cb_setReturnStatus_I == null)
				cb_setReturnStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetReturnStatus_I);
			return cb_setReturnStatus_I;
		}

		static void n_SetReturnStatus_I (IntPtr jnienv, IntPtr native__this, int returnStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.SetClockApiData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReturnStatus (returnStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.data']/class[@name='SetClockApiData']/method[@name='setReturnStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReturnStatus", "(I)V", "GetSetReturnStatus_IHandler")]
		public virtual unsafe void SetReturnStatus (int returnStatus)
		{
			const string __id = "setReturnStatus.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (returnStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
