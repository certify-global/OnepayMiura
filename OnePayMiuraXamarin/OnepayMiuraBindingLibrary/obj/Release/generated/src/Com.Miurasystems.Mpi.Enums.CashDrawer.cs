using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/CashDrawer", DoNotGenerateAcw=true)]
	public sealed partial class CashDrawer : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/field[@name='Closed']"
		[Register ("Closed")]
		public static global::Com.Miurasystems.Mpi.Enums.CashDrawer Closed {
			get {
				const string __id = "Closed.Lcom/miurasystems/mpi/enums/CashDrawer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.CashDrawer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/field[@name='Opened']"
		[Register ("Opened")]
		public static global::Com.Miurasystems.Mpi.Enums.CashDrawer Opened {
			get {
				const string __id = "Opened.Lcom/miurasystems/mpi/enums/CashDrawer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.CashDrawer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/CashDrawer", typeof (CashDrawer));
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

		internal CashDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe sbyte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getByValue", "(B)Lcom/miurasystems/mpi/enums/CashDrawer;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.CashDrawer GetByValue (sbyte value)
		{
			const string __id = "getByValue.(B)Lcom/miurasystems/mpi/enums/CashDrawer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.CashDrawer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/CashDrawer;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.CashDrawer ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/CashDrawer;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.CashDrawer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='CashDrawer']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/CashDrawer;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.CashDrawer[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/CashDrawer;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.CashDrawer[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.CashDrawer));
			} finally {
			}
		}

	}
}
