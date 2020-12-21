using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/EmvChipInsertStatus", DoNotGenerateAcw=true)]
	public sealed partial class EmvChipInsertStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/field[@name='CardIncompatibleError']"
		[Register ("CardIncompatibleError")]
		public static global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus CardIncompatibleError {
			get {
				const string __id = "CardIncompatibleError.Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/field[@name='CardInsertedOk']"
		[Register ("CardInsertedOk")]
		public static global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus CardInsertedOk {
			get {
				const string __id = "CardInsertedOk.Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/field[@name='NoCardPresentError']"
		[Register ("NoCardPresentError")]
		public static global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus NoCardPresentError {
			get {
				const string __id = "NoCardPresentError.Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/field[@name='mStatusText']"
		[Register ("mStatusText")]
		public string MStatusText {
			get {
				const string __id = "mStatusText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mStatusText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/EmvChipInsertStatus", typeof (EmvChipInsertStatus));
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

		internal EmvChipInsertStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvChipInsertStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/emv/EmvChipInsertStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Emv.EmvChipInsertStatus));
			} finally {
			}
		}

	}
}
