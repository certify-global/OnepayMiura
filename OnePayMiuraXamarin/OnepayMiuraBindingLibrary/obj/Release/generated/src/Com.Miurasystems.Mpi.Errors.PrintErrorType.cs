using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Errors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/errors/PrintErrorType", DoNotGenerateAcw=true)]
	public partial class PrintErrorType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='IMAGE_FILE_INCORRECT_FORMAT']"
		[Register ("IMAGE_FILE_INCORRECT_FORMAT")]
		public const int ImageFileIncorrectFormat = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='IMAGE_FILE_NOT_PRESENT']"
		[Register ("IMAGE_FILE_NOT_PRESENT")]
		public const int ImageFileNotPresent = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='INTERNAL_PRINTER_ERROR']"
		[Register ("INTERNAL_PRINTER_ERROR")]
		public const int InternalPrinterError = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='NO_PAPER_IN_PRINTER']"
		[Register ("NO_PAPER_IN_PRINTER")]
		public const int NoPaperInPrinter = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='NO_PRINTER_AVAILABLE']"
		[Register ("NO_PRINTER_AVAILABLE")]
		public const int NoPrinterAvailable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='SPOOL_EMPTY']"
		[Register ("SPOOL_EMPTY")]
		public const int SpoolEmpty = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/field[@name='SPOOL_FULL']"
		[Register ("SPOOL_FULL")]
		public const int SpoolFull = (int) 5;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/errors/PrintErrorType", typeof (PrintErrorType));
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

		protected PrintErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/constructor[@name='PrintErrorType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrintErrorType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.errors']/class[@name='PrintErrorType']/method[@name='hasPrintError' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.ResponseMessage']]"
		[Register ("hasPrintError", "(Lcom/miurasystems/mpi/comms/ResponseMessage;)Z", "")]
		public static unsafe bool HasPrintError (global::Com.Miurasystems.Mpi.Comms.ResponseMessage responseMessage)
		{
			const string __id = "hasPrintError.(Lcom/miurasystems/mpi/comms/ResponseMessage;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((responseMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseMessage).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (responseMessage);
			}
		}

	}
}
