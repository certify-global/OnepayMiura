using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipePinResult']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/MagSwipePinResult", DoNotGenerateAcw=true)]
	public partial class MagSwipePinResult : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipePinResult']/field[@name='mMagSwipeSummary']"
		[Register ("mMagSwipeSummary")]
		public global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary MMagSwipeSummary {
			get {
				const string __id = "mMagSwipeSummary.Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMagSwipeSummary.Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipePinResult']/field[@name='mOnlinePinSummary']"
		[Register ("mOnlinePinSummary")]
		public global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary MOnlinePinSummary {
			get {
				const string __id = "mOnlinePinSummary.Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOnlinePinSummary.Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/MagSwipePinResult", typeof (MagSwipePinResult));
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

		protected MagSwipePinResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='MagSwipePinResult']/constructor[@name='MagSwipePinResult' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary'] and parameter[2][@type='com.miurasystems.transactions.magswipe.OnlinePinSummary']]"
		[Register (".ctor", "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;)V", "")]
		public unsafe MagSwipePinResult (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary, global::Com.Miurasystems.Transactions.Magswipe.OnlinePinSummary onlinePinSummary)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;Lcom/miurasystems/transactions/magswipe/OnlinePinSummary;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				__args [1] = new JniArgumentValue ((onlinePinSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onlinePinSummary).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (magSwipeSummary);
				global::System.GC.KeepAlive (onlinePinSummary);
			}
		}

	}
}
