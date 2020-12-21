using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/MagSwipeTransaction", DoNotGenerateAcw=true)]
	public partial class MagSwipeTransaction : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/MagSwipeTransaction", typeof (MagSwipeTransaction));
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

		protected MagSwipeTransaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']/constructor[@name='MagSwipeTransaction' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.MpiClient']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/MpiClient;)V", "")]
		public unsafe MagSwipeTransaction (global::Com.Miurasystems.Mpi.MpiClient mpiClient)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/MpiClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mpiClient);
			}
		}

		static Delegate cb_abortTransaction;
#pragma warning disable 0169
		static Delegate GetAbortTransactionHandler ()
		{
			if (cb_abortTransaction == null)
				cb_abortTransaction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_AbortTransaction);
			return cb_abortTransaction;
		}

		static bool n_AbortTransaction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbortTransaction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']/method[@name='abortTransaction' and count(parameter)=0]"
		[Register ("abortTransaction", "()Z", "GetAbortTransactionHandler")]
		public virtual unsafe bool AbortTransaction ()
		{
			const string __id = "abortTransaction.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']/method[@name='canProcessMagSwipe' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
		[Register ("canProcessMagSwipe", "(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/mpi/Result;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Result CanProcessMagSwipe (global::Com.Miurasystems.Mpi.Tlv.CardData cardData)
		{
			const string __id = "canProcessMagSwipe.(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/mpi/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cardData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cardData);
			}
		}

		static Delegate cb_processPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II;
#pragma warning disable 0169
		static Delegate GetProcessPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IIHandler ()
		{
			if (cb_processPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II == null)
				cb_processPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_ProcessPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II);
			return cb_processPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II;
		}

		static IntPtr n_ProcessPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_II (IntPtr jnienv, IntPtr native__this, IntPtr native_magSwipeSummary, int amountInPennies, int currencyCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var magSwipeSummary = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (native_magSwipeSummary, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessPinTransaction (magSwipeSummary, amountInPennies, currencyCode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']/method[@name='processPinTransaction' and count(parameter)=3 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("processPinTransaction", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;II)Lcom/onepay/miura/transactions/MagSwipePinResult;", "GetProcessPinTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_IIHandler")]
		public virtual unsafe global::Com.Onepay.Miura.Transactions.MagSwipePinResult ProcessPinTransaction (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, int amountInPennies, int currencyCode)
		{
			const string __id = "processPinTransaction.(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;II)Lcom/onepay/miura/transactions/MagSwipePinResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipePinResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (magSwipeSummary);
			}
		}

		static Delegate cb_processSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_;
#pragma warning disable 0169
		static Delegate GetProcessSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_Handler ()
		{
			if (cb_processSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ == null)
				cb_processSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ProcessSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_);
			return cb_processSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_;
		}

		static IntPtr n_ProcessSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_magSwipeSummary, IntPtr native_signature)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeTransaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var magSwipeSummary = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (native_magSwipeSummary, JniHandleOwnership.DoNotTransfer);
			var signature = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.SignatureSummary> (native_signature, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessSignatureTransaction (magSwipeSummary, signature));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipeTransaction']/method[@name='processSignatureTransaction' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='com.onepay.miura.transactions.SignatureSummary']]"
		[Register ("processSignatureTransaction", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/onepay/miura/transactions/SignatureSummary;)Lcom/onepay/miura/transactions/MagSwipeSignatureResult;", "GetProcessSignatureTransaction_Lcom_miurasystems_transactions_magswipe_MagSwipeSummary_Lcom_onepay_miura_transactions_SignatureSummary_Handler")]
		public virtual unsafe global::Com.Onepay.Miura.Transactions.MagSwipeSignatureResult ProcessSignatureTransaction (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, global::Com.Onepay.Miura.Transactions.SignatureSummary signature)
		{
			const string __id = "processSignatureTransaction.(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/onepay/miura/transactions/SignatureSummary;)Lcom/onepay/miura/transactions/MagSwipeSignatureResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [1] = new JniArgumentValue ((signature == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signature).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.MagSwipeSignatureResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (magSwipeSummary);
				global::System.GC.KeepAlive (signature);
			}
		}

	}
}
