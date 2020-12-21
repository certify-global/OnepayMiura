using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/SoftwareInfo", DoNotGenerateAcw=true)]
	public partial class SoftwareInfo : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/SoftwareInfo", typeof (SoftwareInfo));
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

		protected SoftwareInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/constructor[@name='SoftwareInfo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SoftwareInfo (string serialNumber, string mpiType, string mpiVersion, string osType, string osVersion)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serialNumber = JNIEnv.NewString (serialNumber);
			IntPtr native_mpiType = JNIEnv.NewString (mpiType);
			IntPtr native_mpiVersion = JNIEnv.NewString (mpiVersion);
			IntPtr native_osType = JNIEnv.NewString (osType);
			IntPtr native_osVersion = JNIEnv.NewString (osVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_serialNumber);
				__args [1] = new JniArgumentValue (native_mpiType);
				__args [2] = new JniArgumentValue (native_mpiVersion);
				__args [3] = new JniArgumentValue (native_osType);
				__args [4] = new JniArgumentValue (native_osVersion);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serialNumber);
				JNIEnv.DeleteLocalRef (native_mpiType);
				JNIEnv.DeleteLocalRef (native_mpiVersion);
				JNIEnv.DeleteLocalRef (native_osType);
				JNIEnv.DeleteLocalRef (native_osVersion);
			}
		}

		static Delegate cb_getMpiType;
#pragma warning disable 0169
		static Delegate GetGetMpiTypeHandler ()
		{
			if (cb_getMpiType == null)
				cb_getMpiType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMpiType);
			return cb_getMpiType;
		}

		static IntPtr n_GetMpiType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MpiType);
		}
#pragma warning restore 0169

		public virtual unsafe string MpiType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/method[@name='getMpiType' and count(parameter)=0]"
			[Register ("getMpiType", "()Ljava/lang/String;", "GetGetMpiTypeHandler")]
			get {
				const string __id = "getMpiType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMpiVersion;
#pragma warning disable 0169
		static Delegate GetGetMpiVersionHandler ()
		{
			if (cb_getMpiVersion == null)
				cb_getMpiVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMpiVersion);
			return cb_getMpiVersion;
		}

		static IntPtr n_GetMpiVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MpiVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string MpiVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/method[@name='getMpiVersion' and count(parameter)=0]"
			[Register ("getMpiVersion", "()Ljava/lang/String;", "GetGetMpiVersionHandler")]
			get {
				const string __id = "getMpiVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOsType;
#pragma warning disable 0169
		static Delegate GetGetOsTypeHandler ()
		{
			if (cb_getOsType == null)
				cb_getOsType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOsType);
			return cb_getOsType;
		}

		static IntPtr n_GetOsType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OsType);
		}
#pragma warning restore 0169

		public virtual unsafe string OsType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/method[@name='getOsType' and count(parameter)=0]"
			[Register ("getOsType", "()Ljava/lang/String;", "GetGetOsTypeHandler")]
			get {
				const string __id = "getOsType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOsVersion;
#pragma warning disable 0169
		static Delegate GetGetOsVersionHandler ()
		{
			if (cb_getOsVersion == null)
				cb_getOsVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOsVersion);
			return cb_getOsVersion;
		}

		static IntPtr n_GetOsVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OsVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				const string __id = "getOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.SoftwareInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='SoftwareInfo']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				const string __id = "getSerialNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
