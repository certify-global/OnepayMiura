using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/TransactionType", DoNotGenerateAcw=true)]
	public sealed partial class TransactionType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/field[@name='Cash']"
		[Register ("Cash")]
		public static global::Com.Miurasystems.Mpi.Enums.TransactionType Cash {
			get {
				const string __id = "Cash.Lcom/miurasystems/mpi/enums/TransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/field[@name='Purchase']"
		[Register ("Purchase")]
		public static global::Com.Miurasystems.Mpi.Enums.TransactionType Purchase {
			get {
				const string __id = "Purchase.Lcom/miurasystems/mpi/enums/TransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/field[@name='PurchaseWithCashback']"
		[Register ("PurchaseWithCashback")]
		public static global::Com.Miurasystems.Mpi.Enums.TransactionType PurchaseWithCashback {
			get {
				const string __id = "PurchaseWithCashback.Lcom/miurasystems/mpi/enums/TransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/field[@name='Refund']"
		[Register ("Refund")]
		public static global::Com.Miurasystems.Mpi.Enums.TransactionType Refund {
			get {
				const string __id = "Refund.Lcom/miurasystems/mpi/enums/TransactionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/TransactionType", typeof (TransactionType));
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

		internal TransactionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe sbyte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()B", "")]
			get {
				const string __id = "getValue.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getByValue", "(B)Lcom/miurasystems/mpi/enums/TransactionType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.TransactionType GetByValue (sbyte value)
		{
			const string __id = "getByValue.(B)Lcom/miurasystems/mpi/enums/TransactionType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/TransactionType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.TransactionType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/TransactionType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='TransactionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/TransactionType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.TransactionType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/TransactionType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.TransactionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.TransactionType));
			} finally {
			}
		}

	}
}
