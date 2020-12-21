using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='OnlinePinSummary']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/OnlinePinSummary", DoNotGenerateAcw=true)]
	public partial class OnlinePinSummary : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='OnlinePinSummary']/field[@name='mPinData']"
		[Register ("mPinData")]
		public string MPinData {
			get {
				const string __id = "mPinData.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPinData.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='OnlinePinSummary']/field[@name='mPinKSN']"
		[Register ("mPinKSN")]
		public string MPinKSN {
			get {
				const string __id = "mPinKSN.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPinKSN.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/OnlinePinSummary", typeof (OnlinePinSummary));
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

		protected OnlinePinSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='OnlinePinSummary']/constructor[@name='OnlinePinSummary' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OnlinePinSummary (string pinData, string pinKSN)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pinData = JNIEnv.NewString (pinData);
			IntPtr native_pinKSN = JNIEnv.NewString (pinKSN);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pinData);
				__args [1] = new JniArgumentValue (native_pinKSN);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pinData);
				JNIEnv.DeleteLocalRef (native_pinKSN);
			}
		}

	}
}
