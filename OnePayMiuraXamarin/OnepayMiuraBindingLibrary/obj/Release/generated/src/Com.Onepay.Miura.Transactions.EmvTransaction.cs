using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransaction']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/EmvTransaction", DoNotGenerateAcw=true)]
	public partial class EmvTransaction : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/EmvTransaction", typeof (EmvTransaction));
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

		protected EmvTransaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransaction']/constructor[@name='EmvTransaction' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.transactions.emv.EmvTransactionType']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/emv/EmvTransactionType;)V", "")]
		public unsafe EmvTransaction (global::Com.Miurasystems.Mpi.MpiClient mpiClient, global::Com.Miurasystems.Transactions.Emv.EmvTransactionType emvTransactionType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/emv/EmvTransactionType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				__args [1] = new JniArgumentValue ((emvTransactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emvTransactionType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mpiClient);
				global::System.GC.KeepAlive (emvTransactionType);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbortTransaction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransaction']/method[@name='abortTransaction' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransaction']/method[@name='canProcessEmvChip' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
		[Register ("canProcessEmvChip", "(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus CanProcessEmvChip (global::Com.Miurasystems.Mpi.Tlv.CardData cardData)
		{
			const string __id = "canProcessEmvChip.(Lcom/miurasystems/mpi/tlv/CardData;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cardData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cardData).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cardData);
			}
		}

		static Delegate cb_startTransaction_II;
#pragma warning disable 0169
		static Delegate GetStartTransaction_IIHandler ()
		{
			if (cb_startTransaction_II == null)
				cb_startTransaction_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_StartTransaction_II);
			return cb_startTransaction_II;
		}

		static IntPtr n_StartTransaction_II (IntPtr jnienv, IntPtr native__this, int amountInPennies, int currencyCode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.EmvTransaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTransaction (amountInPennies, currencyCode));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='EmvTransaction']/method[@name='startTransaction' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startTransaction", "(II)Lcom/miurasystems/transactions/emv/EmvTransactionSummary;", "GetStartTransaction_IIHandler")]
		public virtual unsafe global::Com.Miurasystems.Transactions.Emv.EmvTransactionSummary StartTransaction (int amountInPennies, int currencyCode)
		{
			const string __id = "startTransaction.(II)Lcom/miurasystems/transactions/emv/EmvTransactionSummary;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (amountInPennies);
				__args [1] = new JniArgumentValue (currencyCode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionSummary> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
