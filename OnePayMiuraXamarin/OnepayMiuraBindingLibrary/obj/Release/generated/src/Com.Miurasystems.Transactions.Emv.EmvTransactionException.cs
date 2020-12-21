using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Transactions.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']"
	[global::Android.Runtime.Register ("com/miurasystems/transactions/emv/EmvTransactionException", DoNotGenerateAcw=true)]
	public partial class EmvTransactionException : global::Java.IO.IOException {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']/field[@name='mErrCode']"
		[Register ("mErrCode")]
		public global::Com.Miurasystems.Mpi.Enums.TransactionResponse MErrCode {
			get {
				const string __id = "mErrCode.Lcom/miurasystems/mpi/enums/TransactionResponse;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionResponse> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mErrCode.Lcom/miurasystems/mpi/enums/TransactionResponse;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/transactions/emv/EmvTransactionException", typeof (EmvTransactionException));
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

		protected EmvTransactionException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']/constructor[@name='EmvTransactionException' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionResponse']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/enums/TransactionResponse;)V", "")]
		public unsafe EmvTransactionException (global::Com.Miurasystems.Mpi.Enums.TransactionResponse errCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/enums/TransactionResponse;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errCode).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (errCode);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']/constructor[@name='EmvTransactionException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe EmvTransactionException (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']/constructor[@name='EmvTransactionException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.enums.TransactionResponse']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/TransactionResponse;)V", "")]
		public unsafe EmvTransactionException (string message, global::Com.Miurasystems.Mpi.Enums.TransactionResponse errCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/TransactionResponse;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((errCode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errCode).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (errCode);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.transactions.emv']/class[@name='EmvTransactionException']/constructor[@name='EmvTransactionException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe EmvTransactionException (string message, global::Java.Lang.Throwable e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
