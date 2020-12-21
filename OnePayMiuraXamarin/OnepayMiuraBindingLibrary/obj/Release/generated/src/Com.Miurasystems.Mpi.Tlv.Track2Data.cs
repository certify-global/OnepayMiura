using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/Track2Data", DoNotGenerateAcw=true)]
	public partial class Track2Data : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/field[@name='mExpirationDate']"
		[Register ("mExpirationDate")]
		public string MExpirationDate {
			get {
				const string __id = "mExpirationDate.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mExpirationDate.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/field[@name='mIsMasked']"
		[Register ("mIsMasked")]
		public bool MIsMasked {
			get {
				const string __id = "mIsMasked.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsMasked.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/field[@name='mPan']"
		[Register ("mPan")]
		public string MPan {
			get {
				const string __id = "mPan.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPan.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/Track2Data", typeof (Track2Data));
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

		protected Track2Data (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/constructor[@name='Track2Data' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.enums.ServiceCode'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(ZLjava/lang/String;Ljava/lang/String;Lcom/miurasystems/mpi/enums/ServiceCode;[B)V", "")]
		public unsafe Track2Data (bool isMasked, string pan, string expirationDate, global::Com.Miurasystems.Mpi.Enums.ServiceCode serviceCode, byte[] raw)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/lang/String;Ljava/lang/String;Lcom/miurasystems/mpi/enums/ServiceCode;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pan = JNIEnv.NewString (pan);
			IntPtr native_expirationDate = JNIEnv.NewString (expirationDate);
			IntPtr native_raw = JNIEnv.NewArray (raw);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (isMasked);
				__args [1] = new JniArgumentValue (native_pan);
				__args [2] = new JniArgumentValue (native_expirationDate);
				__args [3] = new JniArgumentValue ((serviceCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceCode).Handle);
				__args [4] = new JniArgumentValue (native_raw);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pan);
				JNIEnv.DeleteLocalRef (native_expirationDate);
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				global::System.GC.KeepAlive (serviceCode);
				global::System.GC.KeepAlive (raw);
			}
		}

		static Delegate cb_getExpirationDate;
#pragma warning disable 0169
		static Delegate GetGetExpirationDateHandler ()
		{
			if (cb_getExpirationDate == null)
				cb_getExpirationDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExpirationDate);
			return cb_getExpirationDate;
		}

		static IntPtr n_GetExpirationDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpirationDate);
		}
#pragma warning restore 0169

		public virtual unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/lang/String;", "GetGetExpirationDateHandler")]
			get {
				const string __id = "getExpirationDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMasked;
#pragma warning disable 0169
		static Delegate GetIsMaskedHandler ()
		{
			if (cb_isMasked == null)
				cb_isMasked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMasked);
			return cb_isMasked;
		}

		static bool n_IsMasked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMasked;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMasked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/method[@name='isMasked' and count(parameter)=0]"
			[Register ("isMasked", "()Z", "GetIsMaskedHandler")]
			get {
				const string __id = "isMasked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPAN;
#pragma warning disable 0169
		static Delegate GetGetPANHandler ()
		{
			if (cb_getPAN == null)
				cb_getPAN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPAN);
			return cb_getPAN;
		}

		static IntPtr n_GetPAN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PAN);
		}
#pragma warning restore 0169

		public virtual unsafe string PAN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/method[@name='getPAN' and count(parameter)=0]"
			[Register ("getPAN", "()Ljava/lang/String;", "GetGetPANHandler")]
			get {
				const string __id = "getPAN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceCode;
#pragma warning disable 0169
		static Delegate GetGetServiceCodeHandler ()
		{
			if (cb_getServiceCode == null)
				cb_getServiceCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceCode);
			return cb_getServiceCode;
		}

		static IntPtr n_GetServiceCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ServiceCode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode ServiceCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/method[@name='getServiceCode' and count(parameter)=0]"
			[Register ("getServiceCode", "()Lcom/miurasystems/mpi/enums/ServiceCode;", "GetGetServiceCodeHandler")]
			get {
				const string __id = "getServiceCode.()Lcom/miurasystems/mpi/enums/ServiceCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRaw);
			return cb_getRaw;
		}

		static IntPtr n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRaw ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Track2Data']/method[@name='getRaw' and count(parameter)=0]"
		[Register ("getRaw", "()[B", "GetGetRawHandler")]
		public virtual unsafe byte[] GetRaw ()
		{
			const string __id = "getRaw.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
