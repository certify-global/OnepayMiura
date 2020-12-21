using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Magswipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/magswipe/UserInputType", DoNotGenerateAcw=true)]
	public sealed partial class UserInputType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']/field[@name='Pin']"
		[Register ("Pin")]
		public static global::Com.Miurasystems.Transactions.Magswipe.UserInputType Pin {
			get {
				const string __id = "Pin.Lcom/miurasystems/transactions/magswipe/UserInputType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.UserInputType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']/field[@name='Signature']"
		[Register ("Signature")]
		public static global::Com.Miurasystems.Transactions.Magswipe.UserInputType Signature {
			get {
				const string __id = "Signature.Lcom/miurasystems/transactions/magswipe/UserInputType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.UserInputType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/magswipe/UserInputType", typeof (UserInputType));
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

		internal UserInputType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']/method[@name='resolvePaymentType' and count(parameter)=2 and parameter[1][@type='com.miurasystems.transactions.magswipe.PaymentMagType'] and parameter[2][@type='com.miurasystems.transactions.magswipe.MagSwipeSummary']]"
		[Register ("resolvePaymentType", "(Lcom/miurasystems/transactions/magswipe/PaymentMagType;Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;)Lcom/miurasystems/transactions/magswipe/UserInputType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.UserInputType ResolvePaymentType (global::Com.Miurasystems.Transactions.Magswipe.PaymentMagType type, global::Com.Miurasystems.Transactions.Magswipe.MagSwipeSummary magSwipeSummary)
		{
			const string __id = "resolvePaymentType.(Lcom/miurasystems/transactions/magswipe/PaymentMagType;Lcom/miurasystems/transactions/magswipe/MagSwipeSummary;)Lcom/miurasystems/transactions/magswipe/UserInputType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((magSwipeSummary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) magSwipeSummary).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.UserInputType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (magSwipeSummary);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/UserInputType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.UserInputType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/transactions/magswipe/UserInputType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Transactions.Magswipe.UserInputType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.transactions.magswipe']/class[@name='UserInputType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/transactions/magswipe/UserInputType;", "")]
		public static unsafe global::Com.Miurasystems.Transactions.Magswipe.UserInputType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/transactions/magswipe/UserInputType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Transactions.Magswipe.UserInputType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Transactions.Magswipe.UserInputType));
			} finally {
			}
		}

	}
}
