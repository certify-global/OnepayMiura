using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionType']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/EmvTransactionType", DoNotGenerateAcw=true)]
	public sealed partial class EmvTransactionType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionType']/field[@name='Chip']"
		[Register ("Chip")]
		public static global::Com.Miurasystems.Transactions.Emv.EmvTransactionType Chip {
			get {
				const string __id = "Chip.Lcom/miurasystems/transactions/emv/EmvTransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionType']/field[@name='Contactless']"
		[Register ("Contactless")]
		public static global::Com.Miurasystems.Transactions.Emv.EmvTransactionType Contactless {
			get {
				const string __id = "Contactless.Lcom/miurasystems/transactions/emv/EmvTransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/EmvTransactionType", typeof (EmvTransactionType));
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

		internal EmvTransactionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/EmvTransactionType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvTransactionType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/EmvTransactionType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvTransactionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/emv/EmvTransactionType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvTransactionType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/emv/EmvTransactionType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Emv.EmvTransactionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Emv.EmvTransactionType));
			} finally {
			}
		}

	}
}
