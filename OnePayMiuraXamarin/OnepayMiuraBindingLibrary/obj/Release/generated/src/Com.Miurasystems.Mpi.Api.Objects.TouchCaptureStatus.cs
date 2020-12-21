using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/TouchCaptureStatus", DoNotGenerateAcw=true)]
	public partial class TouchCaptureStatus : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/TouchCaptureStatus", typeof (TouchCaptureStatus));
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

		protected TouchCaptureStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureStatus']/constructor[@name='TouchCaptureStatus' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe TouchCaptureStatus (sbyte statusBitmap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (statusBitmap);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getErrorString;
#pragma warning disable 0169
		static Delegate GetGetErrorStringHandler ()
		{
			if (cb_getErrorString == null)
				cb_getErrorString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorString);
			return cb_getErrorString;
		}

		static IntPtr n_GetErrorString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorString);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureStatus']/method[@name='getErrorString' and count(parameter)=0]"
			[Register ("getErrorString", "()Ljava/lang/String;", "GetGetErrorStringHandler")]
			get {
				const string __id = "getErrorString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAvailable;
#pragma warning disable 0169
		static Delegate GetIsAvailableHandler ()
		{
			if (cb_isAvailable == null)
				cb_isAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAvailable);
			return cb_isAvailable;
		}

		static bool n_IsAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureStatus']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "GetIsAvailableHandler")]
			get {
				const string __id = "isAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isScreenCaptureBegun;
#pragma warning disable 0169
		static Delegate GetIsScreenCaptureBegunHandler ()
		{
			if (cb_isScreenCaptureBegun == null)
				cb_isScreenCaptureBegun = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsScreenCaptureBegun);
			return cb_isScreenCaptureBegun;
		}

		static bool n_IsScreenCaptureBegun (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScreenCaptureBegun;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsScreenCaptureBegun {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureStatus']/method[@name='isScreenCaptureBegun' and count(parameter)=0]"
			[Register ("isScreenCaptureBegun", "()Z", "GetIsScreenCaptureBegunHandler")]
			get {
				const string __id = "isScreenCaptureBegun.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
