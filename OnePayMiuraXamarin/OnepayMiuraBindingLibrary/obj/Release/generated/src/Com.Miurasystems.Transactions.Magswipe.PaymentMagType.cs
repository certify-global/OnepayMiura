using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/PaymentMagType", DoNotGenerateAcw=true)]
	public sealed partial class PaymentMagType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']/field[@name='Auto']"
		[Register ("Auto")]
		public static global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType Auto {
			get {
				const string __id = "Auto.Lcom/miurasystems/transactions/magswipe/PaymentMagType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']/field[@name='Pin']"
		[Register ("Pin")]
		public static global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType Pin {
			get {
				const string __id = "Pin.Lcom/miurasystems/transactions/magswipe/PaymentMagType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']/field[@name='Signature']"
		[Register ("Signature")]
		public static global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType Signature {
			get {
				const string __id = "Signature.Lcom/miurasystems/transactions/magswipe/PaymentMagType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/PaymentMagType", typeof (PaymentMagType));
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

		internal PaymentMagType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/PaymentMagType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/PaymentMagType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='PaymentMagType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/magswipe/PaymentMagType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/magswipe/PaymentMagType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType));
			} finally {
			}
		}

	}
}
