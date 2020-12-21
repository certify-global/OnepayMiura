using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/MagSwipeSummary", DoNotGenerateAcw=true)]
	public partial class MagSwipeSummary : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mIsPinRequired']"
		[Register ("mIsPinRequired")]
		public bool MIsPinRequired {
			get {
				const string __id = "mIsPinRequired.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsPinRequired.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mMaskedTrack2Data']"
		[Register ("mMaskedTrack2Data")]
		public global::Com.Miurasystems.Mpi.Tlv.Track2Data MMaskedTrack2Data {
			get {
				const string __id = "mMaskedTrack2Data.Lcom/miurasystems/mpi/tlv/Track2Data;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMaskedTrack2Data.Lcom/miurasystems/mpi/tlv/Track2Data;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mPlainTrack1Data']"
		[Register ("mPlainTrack1Data")]
		public string MPlainTrack1Data {
			get {
				const string __id = "mPlainTrack1Data.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPlainTrack1Data.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mPlainTrack2Data']"
		[Register ("mPlainTrack2Data")]
		public global::Com.Miurasystems.Mpi.Tlv.Track2Data MPlainTrack2Data {
			get {
				const string __id = "mPlainTrack2Data.Lcom/miurasystems/mpi/tlv/Track2Data;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPlainTrack2Data.Lcom/miurasystems/mpi/tlv/Track2Data;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mSredData']"
		[Register ("mSredData")]
		public string MSredData {
			get {
				const string __id = "mSredData.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSredData.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/field[@name='mSredKSN']"
		[Register ("mSredKSN")]
		public string MSredKSN {
			get {
				const string __id = "mSredKSN.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSredKSN.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/MagSwipeSummary", typeof (MagSwipeSummary));
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

		protected MagSwipeSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/constructor[@name='MagSwipeSummary' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.miurasystems.mpi.tlv.Track2Data']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/miurasystems/mpi/tlv/Track2Data;)V", "")]
		public unsafe MagSwipeSummary (global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string sredData, string sredKSN, bool isPinRequired, string plainTrack1Data, global::Com.Miurasystems.Mpi.Tlv.Track2Data plainTrack2Data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/miurasystems/mpi/tlv/Track2Data;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sredData = JNIEnv.NewString (sredData);
			IntPtr native_sredKSN = JNIEnv.NewString (sredKSN);
			IntPtr native_plainTrack1Data = JNIEnv.NewString (plainTrack1Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [1] = new JniArgumentValue (native_sredData);
				__args [2] = new JniArgumentValue (native_sredKSN);
				__args [3] = new JniArgumentValue (isPinRequired);
				__args [4] = new JniArgumentValue (native_plainTrack1Data);
				__args [5] = new JniArgumentValue ((plainTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plainTrack2Data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sredData);
				JNIEnv.DeleteLocalRef (native_sredKSN);
				JNIEnv.DeleteLocalRef (native_plainTrack1Data);
				global::System.GC.KeepAlive (maskedTrack2Data);
				global::System.GC.KeepAlive (plainTrack2Data);
			}
		}

		static Delegate cb_getSignature;
#pragma warning disable 0169
		static Delegate GetGetSignatureHandler ()
		{
			if (cb_getSignature == null)
				cb_getSignature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignature);
			return cb_getSignature;
		}

		static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSignature ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/method[@name='getSignature' and count(parameter)=0]"
		[Register ("getSignature", "()[B", "GetGetSignatureHandler")]
		public virtual unsafe byte[] GetSignature ()
		{
			const string __id = "getSignature.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setSignature_arrayB;
#pragma warning disable 0169
		static Delegate GetSetSignature_arrayBHandler ()
		{
			if (cb_setSignature_arrayB == null)
				cb_setSignature_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSignature_arrayB);
			return cb_setSignature_arrayB;
		}

		static void n_SetSignature_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_signature)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var signature = (byte[]) JNIEnv.GetArray (native_signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetSignature (signature);
			if (signature != null)
				JNIEnv.CopyArray (signature, native_signature);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeSummary']/method[@name='setSignature' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setSignature", "([B)V", "GetSetSignature_arrayBHandler")]
		public virtual unsafe void SetSignature (byte[] signature)
		{
			const string __id = "setSignature.([B)V";
			IntPtr native_signature = JNIEnv.NewArray (signature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_signature);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				global::System.GC.KeepAlive (signature);
			}
		}

	}
}
