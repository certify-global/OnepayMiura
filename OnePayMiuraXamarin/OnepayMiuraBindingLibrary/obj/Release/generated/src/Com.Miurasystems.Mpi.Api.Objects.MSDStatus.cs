using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/MSDStatus", DoNotGenerateAcw=true)]
	public partial class MSDStatus : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/MSDStatus", typeof (MSDStatus));
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

		protected MSDStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasMSDStatusError;
#pragma warning disable 0169
		static Delegate GetHasMSDStatusErrorHandler ()
		{
			if (cb_hasMSDStatusError == null)
				cb_hasMSDStatusError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasMSDStatusError);
			return cb_hasMSDStatusError;
		}

		static bool n_HasMSDStatusError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMSDStatusError;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasMSDStatusError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='hasMSDStatusError' and count(parameter)=0]"
			[Register ("hasMSDStatusError", "()Z", "GetHasMSDStatusErrorHandler")]
			get {
				const string __id = "hasMSDStatusError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAppControlEnabled;
#pragma warning disable 0169
		static Delegate GetIsAppControlEnabledHandler ()
		{
			if (cb_isAppControlEnabled == null)
				cb_isAppControlEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAppControlEnabled);
			return cb_isAppControlEnabled;
		}

		static bool n_IsAppControlEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAppControlEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAppControlEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='isAppControlEnabled' and count(parameter)=0]"
			[Register ("isAppControlEnabled", "()Z", "GetIsAppControlEnabledHandler")]
			get {
				const string __id = "isAppControlEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConfigured;
#pragma warning disable 0169
		static Delegate GetIsConfiguredHandler ()
		{
			if (cb_isConfigured == null)
				cb_isConfigured = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConfigured);
			return cb_isConfigured;
		}

		static bool n_IsConfigured (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConfigured;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConfigured {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='isConfigured' and count(parameter)=0]"
			[Register ("isConfigured", "()Z", "GetIsConfiguredHandler")]
			get {
				const string __id = "isConfigured.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isExported;
#pragma warning disable 0169
		static Delegate GetIsExportedHandler ()
		{
			if (cb_isExported == null)
				cb_isExported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExported);
			return cb_isExported;
		}

		static bool n_IsExported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExported;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='isExported' and count(parameter)=0]"
			[Register ("isExported", "()Z", "GetIsExportedHandler")]
			get {
				const string __id = "isExported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMSDStatusError;
#pragma warning disable 0169
		static Delegate GetGetMSDStatusErrorHandler ()
		{
			if (cb_getMSDStatusError == null)
				cb_getMSDStatusError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMSDStatusError);
			return cb_getMSDStatusError;
		}

		static IntPtr n_GetMSDStatusError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MSDStatusError);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.MSDStatusError MSDStatusError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='getMSDStatusError' and count(parameter)=0]"
			[Register ("getMSDStatusError", "()Lcom/miurasystems/mpi/enums/MSDStatusError;", "GetGetMSDStatusErrorHandler")]
			get {
				const string __id = "getMSDStatusError.()Lcom/miurasystems/mpi/enums/MSDStatusError;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.MSDStatusError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("valueOf", "(B)Lcom/miurasystems/mpi/api/objects/MSDStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus ValueOf (sbyte value)
		{
			const string __id = "valueOf.(B)Lcom/miurasystems/mpi/api/objects/MSDStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='MSDStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.MSDStatusError']]"
		[Register ("valueOf", "(Lcom/miurasystems/mpi/enums/MSDStatusError;)Lcom/miurasystems/mpi/api/objects/MSDStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus ValueOf (global::Com.Miurasystems.Mpi.Enums.MSDStatusError msdStatusError)
		{
			const string __id = "valueOf.(Lcom/miurasystems/mpi/enums/MSDStatusError;)Lcom/miurasystems/mpi/api/objects/MSDStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msdStatusError == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msdStatusError).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.MSDStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (msdStatusError);
			}
		}

	}
}
