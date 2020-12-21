using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/MagSwipeError", DoNotGenerateAcw=true)]
	public sealed partial class MagSwipeError : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/field[@name='ErrNoMaskedTrack2Data']"
		[Register ("ErrNoMaskedTrack2Data")]
		public static global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError ErrNoMaskedTrack2Data {
			get {
				const string __id = "ErrNoMaskedTrack2Data.Lcom/miurasystems/transactions/magswipe/MagSwipeError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/field[@name='ErrNoMsrData']"
		[Register ("ErrNoMsrData")]
		public static global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError ErrNoMsrData {
			get {
				const string __id = "ErrNoMsrData.Lcom/miurasystems/transactions/magswipe/MagSwipeError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/field[@name='ErrNoServiceCode']"
		[Register ("ErrNoServiceCode")]
		public static global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError ErrNoServiceCode {
			get {
				const string __id = "ErrNoServiceCode.Lcom/miurasystems/transactions/magswipe/MagSwipeError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/field[@name='mErrorText']"
		[Register ("mErrorText")]
		public string MErrorText {
			get {
				const string __id = "mErrorText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mErrorText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/MagSwipeError", typeof (MagSwipeError));
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

		internal MagSwipeError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/MagSwipeError;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/MagSwipeError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='MagSwipeError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/magswipe/MagSwipeError;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/magswipe/MagSwipeError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Magswipe.MagSwipeError));
			} finally {
			}
		}

	}
}
