using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/StartTransactionResponse", DoNotGenerateAcw=true)]
	public sealed partial class StartTransactionResponse : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/field[@name='ApproveOffline']"
		[Register ("ApproveOffline")]
		public static global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse ApproveOffline {
			get {
				const string __id = "ApproveOffline.Lcom/miurasystems/transactions/emv/StartTransactionResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/field[@name='ApproveOnline']"
		[Register ("ApproveOnline")]
		public static global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse ApproveOnline {
			get {
				const string __id = "ApproveOnline.Lcom/miurasystems/transactions/emv/StartTransactionResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/field[@name='CardDeclined']"
		[Register ("CardDeclined")]
		public static global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse CardDeclined {
			get {
				const string __id = "CardDeclined.Lcom/miurasystems/transactions/emv/StartTransactionResponse;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/StartTransactionResponse", typeof (StartTransactionResponse));
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

		internal StartTransactionResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/StartTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/StartTransactionResponse;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("valueOf", "(Ljava/util/List;)Lcom/miurasystems/transactions/emv/StartTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse ValueOf (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> startTlv)
		{
			const string __id = "valueOf.(Ljava/util/List;)Lcom/miurasystems/transactions/emv/StartTransactionResponse;";
			IntPtr native_startTlv = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (startTlv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_startTlv);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_startTlv);
				global::System.GC.KeepAlive (startTlv);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='StartTransactionResponse']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/emv/StartTransactionResponse;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/emv/StartTransactionResponse;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Emv.StartTransactionResponse));
			} finally {
			}
		}

	}
}
