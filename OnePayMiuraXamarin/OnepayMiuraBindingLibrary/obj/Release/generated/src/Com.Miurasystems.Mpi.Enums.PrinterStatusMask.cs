using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/PrinterStatusMask", DoNotGenerateAcw=true)]
	public sealed partial class PrinterStatusMask : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='PaperStatus']"
		[Register ("PaperStatus")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask PaperStatus {
			get {
				const string __id = "PaperStatus.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='PrintDataScheduled']"
		[Register ("PrintDataScheduled")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask PrintDataScheduled {
			get {
				const string __id = "PrintDataScheduled.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='PrinterError']"
		[Register ("PrinterError")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask PrinterError {
			get {
				const string __id = "PrinterError.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='PrinterPower']"
		[Register ("PrinterPower")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask PrinterPower {
			get {
				const string __id = "PrinterPower.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='PrinterPresent']"
		[Register ("PrinterPresent")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask PrinterPresent {
			get {
				const string __id = "PrinterPresent.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/field[@name='Printing']"
		[Register ("Printing")]
		public static global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask Printing {
			get {
				const string __id = "Printing.Lcom/miurasystems/mpi/enums/PrinterStatusMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/PrinterStatusMask", typeof (PrinterStatusMask));
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

		internal PrinterStatusMask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Mask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/method[@name='getMask' and count(parameter)=0]"
			[Register ("getMask", "()I", "")]
			get {
				const string __id = "getMask.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/PrinterStatusMask;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/PrinterStatusMask;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='PrinterStatusMask']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/PrinterStatusMask;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/PrinterStatusMask;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.PrinterStatusMask));
			} finally {
			}
		}

	}
}
