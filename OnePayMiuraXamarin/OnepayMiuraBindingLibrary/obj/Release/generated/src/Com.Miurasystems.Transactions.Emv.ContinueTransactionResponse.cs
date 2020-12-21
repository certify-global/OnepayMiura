using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/ContinueTransactionResponse", DoNotGenerateAcw=true)]
	public sealed partial class ContinueTransactionResponse : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']/field[@name='Approved']"
		[Register ("Approved")]
		public static global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse Approved {
			get {
				const string __id = "Approved.Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']/field[@name='Declined']"
		[Register ("Declined")]
		public static global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse Declined {
			get {
				const string __id = "Declined.Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/ContinueTransactionResponse", typeof (ContinueTransactionResponse));
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

		internal ContinueTransactionResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("valueOf", "(Ljava/util/List;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse ValueOf (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> continueTlv)
		{
			const string __id = "valueOf.(Ljava/util/List;)Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";
			IntPtr native_continueTlv = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (continueTlv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_continueTlv);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_continueTlv);
				global::System.GC.KeepAlive (continueTlv);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='ContinueTransactionResponse']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/emv/ContinueTransactionResponse;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Emv.ContinueTransactionResponse));
			} finally {
			}
		}

	}
}
