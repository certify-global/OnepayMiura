using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/EmvTransaction", DoNotGenerateAcw=true)]
	public sealed partial class EmvTransaction : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/EmvTransaction", typeof (EmvTransaction));
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

		internal EmvTransaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/constructor[@name='EmvTransaction' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.transactions.emv.EmvTransactionType'] and parameter[3][@type='com.miurasystems.transactions.TransactionSummary']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/emv/EmvTransactionType;Lcom/miurasystems/transactions/TransactionSummary;)V", "")]
		public unsafe EmvTransaction (global::Com.Miurasystems.Mpi.MpiClient mpiClient, global::Com.Miurasystems.Transactions.Emv.EmvTransactionType emvTransactionType, global::Com.Miurasystems.Transactions.TransactionSummary details)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/emv/EmvTransactionType;Lcom/miurasystems/transactions/TransactionSummary;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				__args [1] = new JniArgumentValue ((emvTransactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emvTransactionType).Handle);
				__args [2] = new JniArgumentValue ((details == null) ? IntPtr.Zero : ((global::Java.Lang.Object) details).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mpiClient);
				global::System.GC.KeepAlive (emvTransactionType);
				global::System.GC.KeepAlive (details);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> ContinueTlv {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='getContinueTlv' and count(parameter)=0]"
			[Register ("getContinueTlv", "()Ljava/util/List;", "")]
			get {
				const string __id = "getContinueTlv.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> StartTlv {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='getStartTlv' and count(parameter)=0]"
			[Register ("getStartTlv", "()Ljava/util/List;", "")]
			get {
				const string __id = "getStartTlv.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='abort' and count(parameter)=0]"
		[Register ("abort", "()V", "")]
		public unsafe void Abort ()
		{
			const string __id = "abort.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='canProcessEmvChip' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='continueTransaction' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("continueTransaction", "(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;", "")]
		public unsafe global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse ContinueTransaction (global::Com.Miurasystems.Mpi.Tlv.TLVObject hsmTlv)
		{
			const string __id = "continueTransaction.(Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((hsmTlv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hsmTlv).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (hsmTlv);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransaction']/method[@name='startTransaction' and count(parameter)=0]"
		[Register ("startTransaction", "()Lcom/miurasystems/transactions/emv/StartTransactionResponse;", "")]
		public unsafe global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse StartTransaction ()
		{
			const string __id = "startTransaction.()Lcom/miurasystems/transactions/emv/StartTransactionResponse;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
