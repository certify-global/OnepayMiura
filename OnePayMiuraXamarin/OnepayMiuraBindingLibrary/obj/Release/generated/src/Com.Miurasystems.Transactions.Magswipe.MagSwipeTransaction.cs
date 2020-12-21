using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeTransaction']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/MagSwipeTransaction", DoNotGenerateAcw=true)]
	public sealed partial class MagSwipeTransaction : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/MagSwipeTransaction", typeof (MagSwipeTransaction));
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

		internal MagSwipeTransaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeTransaction']/method[@name='canProcessMagSwipe' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.CardData']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeTransaction']/method[@name='processOnlinePinTransaction' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("processOnlinePinTransaction", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;II)Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary ProcessOnlinePinTransaction (global::Com.Miurasystems.Mpi.MpiClient mpiClient, global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, int amountInPennies, int currencyCode)
		{
			const string __id = "processOnlinePinTransaction.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;II)Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((mpiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mpiClient).Handle);
				__args [1] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [2] = new JniArgumentValue (amountInPennies);
				__args [3] = new JniArgumentValue (currencyCode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (mpiClient);
				global::System.GC.KeepAlive (magSwipeSummary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeTransaction']/method[@name='processSignatureTransaction' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='com.miurasystems.transactions.TransactionSummary']]"
		[Register ("processSignatureTransaction", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/TransactionSummary;)Ljava/lang/String;", "")]
		public static unsafe string ProcessSignatureTransaction (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, global::Com.Miurasystems.Transactions.TransactionSummary details)
		{
			const string __id = "processSignatureTransaction.(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/TransactionSummary;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [1] = new JniArgumentValue ((details == null) ? IntPtr.Zero : ((global::Java.Lang.Object) details).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (magSwipeSummary);
				global::System.GC.KeepAlive (details);
			}
		}

	}
}
