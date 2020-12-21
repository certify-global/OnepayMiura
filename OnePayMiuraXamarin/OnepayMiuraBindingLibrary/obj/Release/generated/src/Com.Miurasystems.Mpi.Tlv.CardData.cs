using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/CardData", DoNotGenerateAcw=true)]
	public partial class CardData : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/CardData", typeof (CardData));
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

		protected CardData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/constructor[@name='CardData' and count(parameter)=12 and parameter[1][@type='com.miurasystems.mpi.tlv.CardStatus'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/CardStatus;[BLcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CardData (global::Com.Miurasystems.Mpi.Tlv.CardStatus cardStatus, byte[] raw, global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string answerToReset, string sredData, string sredKSN, string plainTrack1Data, global::Com.Miurasystems.Mpi.Tlv.Track2Data plainTrack2Data, string rawTrack1Encrypted, string rawTrack2Encrypted, string cardholderName, string panTrack2Encrypted)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/CardStatus;[BLcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_raw = JNIEnv.NewArray (raw);
			IntPtr native_answerToReset = JNIEnv.NewString (answerToReset);
			IntPtr native_sredData = JNIEnv.NewString (sredData);
			IntPtr native_sredKSN = JNIEnv.NewString (sredKSN);
			IntPtr native_plainTrack1Data = JNIEnv.NewString (plainTrack1Data);
			IntPtr native_rawTrack1Encrypted = JNIEnv.NewString (rawTrack1Encrypted);
			IntPtr native_rawTrack2Encrypted = JNIEnv.NewString (rawTrack2Encrypted);
			IntPtr native_cardholderName = JNIEnv.NewString (cardholderName);
			IntPtr native_panTrack2Encrypted = JNIEnv.NewString (panTrack2Encrypted);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue ((cardStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardStatus).Handle);
				__args [1] = new JniArgumentValue (native_raw);
				__args [2] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [3] = new JniArgumentValue (native_answerToReset);
				__args [4] = new JniArgumentValue (native_sredData);
				__args [5] = new JniArgumentValue (native_sredKSN);
				__args [6] = new JniArgumentValue (native_plainTrack1Data);
				__args [7] = new JniArgumentValue ((plainTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plainTrack2Data).Handle);
				__args [8] = new JniArgumentValue (native_rawTrack1Encrypted);
				__args [9] = new JniArgumentValue (native_rawTrack2Encrypted);
				__args [10] = new JniArgumentValue (native_cardholderName);
				__args [11] = new JniArgumentValue (native_panTrack2Encrypted);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (raw != null) {
					JNIEnv.CopyArray (native_raw, raw);
					JNIEnv.DeleteLocalRef (native_raw);
				}
				JNIEnv.DeleteLocalRef (native_answerToReset);
				JNIEnv.DeleteLocalRef (native_sredData);
				JNIEnv.DeleteLocalRef (native_sredKSN);
				JNIEnv.DeleteLocalRef (native_plainTrack1Data);
				JNIEnv.DeleteLocalRef (native_rawTrack1Encrypted);
				JNIEnv.DeleteLocalRef (native_rawTrack2Encrypted);
				JNIEnv.DeleteLocalRef (native_cardholderName);
				JNIEnv.DeleteLocalRef (native_panTrack2Encrypted);
				global::System.GC.KeepAlive (cardStatus);
				global::System.GC.KeepAlive (raw);
				global::System.GC.KeepAlive (maskedTrack2Data);
				global::System.GC.KeepAlive (plainTrack2Data);
			}
		}

		static Delegate cb_getAnswerToReset;
#pragma warning disable 0169
		static Delegate GetGetAnswerToResetHandler ()
		{
			if (cb_getAnswerToReset == null)
				cb_getAnswerToReset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnswerToReset);
			return cb_getAnswerToReset;
		}

		static IntPtr n_GetAnswerToReset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AnswerToReset);
		}
#pragma warning restore 0169

		public virtual unsafe string AnswerToReset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getAnswerToReset' and count(parameter)=0]"
			[Register ("getAnswerToReset", "()Ljava/lang/String;", "GetGetAnswerToResetHandler")]
			get {
				const string __id = "getAnswerToReset.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCardStatus;
#pragma warning disable 0169
		static Delegate GetGetCardStatusHandler ()
		{
			if (cb_getCardStatus == null)
				cb_getCardStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCardStatus);
			return cb_getCardStatus;
		}

		static IntPtr n_GetCardStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CardStatus);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.CardStatus CardStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getCardStatus' and count(parameter)=0]"
			[Register ("getCardStatus", "()Lcom/miurasystems/mpi/tlv/CardStatus;", "GetGetCardStatusHandler")]
			get {
				const string __id = "getCardStatus.()Lcom/miurasystems/mpi/tlv/CardStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCardholderName;
#pragma warning disable 0169
		static Delegate GetGetCardholderNameHandler ()
		{
			if (cb_getCardholderName == null)
				cb_getCardholderName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCardholderName);
			return cb_getCardholderName;
		}

		static IntPtr n_GetCardholderName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardholderName);
		}
#pragma warning restore 0169

		public virtual unsafe string CardholderName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getCardholderName' and count(parameter)=0]"
			[Register ("getCardholderName", "()Ljava/lang/String;", "GetGetCardholderNameHandler")]
			get {
				const string __id = "getCardholderName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaskedTrack2Data;
#pragma warning disable 0169
		static Delegate GetGetMaskedTrack2DataHandler ()
		{
			if (cb_getMaskedTrack2Data == null)
				cb_getMaskedTrack2Data = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMaskedTrack2Data);
			return cb_getMaskedTrack2Data;
		}

		static IntPtr n_GetMaskedTrack2Data (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaskedTrack2Data);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.Track2Data MaskedTrack2Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getMaskedTrack2Data' and count(parameter)=0]"
			[Register ("getMaskedTrack2Data", "()Lcom/miurasystems/mpi/tlv/Track2Data;", "GetGetMaskedTrack2DataHandler")]
			get {
				const string __id = "getMaskedTrack2Data.()Lcom/miurasystems/mpi/tlv/Track2Data;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPanTrack2Encrypted;
#pragma warning disable 0169
		static Delegate GetGetPanTrack2EncryptedHandler ()
		{
			if (cb_getPanTrack2Encrypted == null)
				cb_getPanTrack2Encrypted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPanTrack2Encrypted);
			return cb_getPanTrack2Encrypted;
		}

		static IntPtr n_GetPanTrack2Encrypted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PanTrack2Encrypted);
		}
#pragma warning restore 0169

		public virtual unsafe string PanTrack2Encrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getPanTrack2Encrypted' and count(parameter)=0]"
			[Register ("getPanTrack2Encrypted", "()Ljava/lang/String;", "GetGetPanTrack2EncryptedHandler")]
			get {
				const string __id = "getPanTrack2Encrypted.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlainTrack1Data;
#pragma warning disable 0169
		static Delegate GetGetPlainTrack1DataHandler ()
		{
			if (cb_getPlainTrack1Data == null)
				cb_getPlainTrack1Data = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlainTrack1Data);
			return cb_getPlainTrack1Data;
		}

		static IntPtr n_GetPlainTrack1Data (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlainTrack1Data);
		}
#pragma warning restore 0169

		public virtual unsafe string PlainTrack1Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getPlainTrack1Data' and count(parameter)=0]"
			[Register ("getPlainTrack1Data", "()Ljava/lang/String;", "GetGetPlainTrack1DataHandler")]
			get {
				const string __id = "getPlainTrack1Data.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlainTrack2Data;
#pragma warning disable 0169
		static Delegate GetGetPlainTrack2DataHandler ()
		{
			if (cb_getPlainTrack2Data == null)
				cb_getPlainTrack2Data = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlainTrack2Data);
			return cb_getPlainTrack2Data;
		}

		static IntPtr n_GetPlainTrack2Data (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlainTrack2Data);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.Track2Data PlainTrack2Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getPlainTrack2Data' and count(parameter)=0]"
			[Register ("getPlainTrack2Data", "()Lcom/miurasystems/mpi/tlv/Track2Data;", "GetGetPlainTrack2DataHandler")]
			get {
				const string __id = "getPlainTrack2Data.()Lcom/miurasystems/mpi/tlv/Track2Data;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawTrack1Encrypted;
#pragma warning disable 0169
		static Delegate GetGetRawTrack1EncryptedHandler ()
		{
			if (cb_getRawTrack1Encrypted == null)
				cb_getRawTrack1Encrypted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawTrack1Encrypted);
			return cb_getRawTrack1Encrypted;
		}

		static IntPtr n_GetRawTrack1Encrypted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawTrack1Encrypted);
		}
#pragma warning restore 0169

		public virtual unsafe string RawTrack1Encrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getRawTrack1Encrypted' and count(parameter)=0]"
			[Register ("getRawTrack1Encrypted", "()Ljava/lang/String;", "GetGetRawTrack1EncryptedHandler")]
			get {
				const string __id = "getRawTrack1Encrypted.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawTrack2Encrypted;
#pragma warning disable 0169
		static Delegate GetGetRawTrack2EncryptedHandler ()
		{
			if (cb_getRawTrack2Encrypted == null)
				cb_getRawTrack2Encrypted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawTrack2Encrypted);
			return cb_getRawTrack2Encrypted;
		}

		static IntPtr n_GetRawTrack2Encrypted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawTrack2Encrypted);
		}
#pragma warning restore 0169

		public virtual unsafe string RawTrack2Encrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getRawTrack2Encrypted' and count(parameter)=0]"
			[Register ("getRawTrack2Encrypted", "()Ljava/lang/String;", "GetGetRawTrack2EncryptedHandler")]
			get {
				const string __id = "getRawTrack2Encrypted.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSredData;
#pragma warning disable 0169
		static Delegate GetGetSredDataHandler ()
		{
			if (cb_getSredData == null)
				cb_getSredData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSredData);
			return cb_getSredData;
		}

		static IntPtr n_GetSredData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SredData);
		}
#pragma warning restore 0169

		public virtual unsafe string SredData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getSredData' and count(parameter)=0]"
			[Register ("getSredData", "()Ljava/lang/String;", "GetGetSredDataHandler")]
			get {
				const string __id = "getSredData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSredKSN;
#pragma warning disable 0169
		static Delegate GetGetSredKSNHandler ()
		{
			if (cb_getSredKSN == null)
				cb_getSredKSN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSredKSN);
			return cb_getSredKSN;
		}

		static IntPtr n_GetSredKSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SredKSN);
		}
#pragma warning restore 0169

		public virtual unsafe string SredKSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getSredKSN' and count(parameter)=0]"
			[Register ("getSredKSN", "()Ljava/lang/String;", "GetGetSredKSNHandler")]
			get {
				const string __id = "getSredKSN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRaw ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='getRaw' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardData']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("valueOf", "(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/CardData;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Tlv.CardData ValueOf (global::Com.Miurasystems.Mpi.Tlv.TLVObject tlvObject)
		{
			const string __id = "valueOf.(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/CardData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tlvObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlvObject).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (tlvObject);
			}
		}

	}
}
