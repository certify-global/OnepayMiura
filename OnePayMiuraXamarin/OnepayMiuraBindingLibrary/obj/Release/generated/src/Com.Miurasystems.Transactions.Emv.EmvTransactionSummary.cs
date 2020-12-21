using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionSummary']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/EmvTransactionSummary", DoNotGenerateAcw=true)]
	public partial class EmvTransactionSummary : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionSummary']/field[@name='mContinueTransactionResponse']"
		[Register ("mContinueTransactionResponse")]
		public string MContinueTransactionResponse {
			get {
				const string __id = "mContinueTransactionResponse.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContinueTransactionResponse.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionSummary']/field[@name='mStartTransactionResponse']"
		[Register ("mStartTransactionResponse")]
		public string MStartTransactionResponse {
			get {
				const string __id = "mStartTransactionResponse.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mStartTransactionResponse.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/EmvTransactionSummary", typeof (EmvTransactionSummary));
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

		protected EmvTransactionSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionSummary']/constructor[@name='EmvTransactionSummary' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe EmvTransactionSummary (string startTransactionResponse, string continueTransactionResponse)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_startTransactionResponse = JNIEnv.NewString (startTransactionResponse);
			IntPtr native_continueTransactionResponse = JNIEnv.NewString (continueTransactionResponse);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_startTransactionResponse);
				__args [1] = new JniArgumentValue (native_continueTransactionResponse);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_startTransactionResponse);
				JNIEnv.DeleteLocalRef (native_continueTransactionResponse);
			}
		}

	}
}
