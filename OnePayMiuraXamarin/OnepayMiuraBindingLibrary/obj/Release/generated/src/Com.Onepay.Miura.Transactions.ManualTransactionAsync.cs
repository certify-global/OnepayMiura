using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Transactions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='ManualTransactionAsync']"
	[global::Android.Runtime.Register ("com/onepay/miura/transactions/ManualTransactionAsync", DoNotGenerateAcw=true)]
	public partial class ManualTransactionAsync : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='ManualTransactionAsync']/field[@name='result']"
		[Register ("result")]
		public global::Com.Miurasystems.Mpi.Result Result {
			get {
				const string __id = "result.Lcom/miurasystems/mpi/Result;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "result.Lcom/miurasystems/mpi/Result;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/transactions/ManualTransactionAsync", typeof (ManualTransactionAsync));
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

		protected ManualTransactionAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='ManualTransactionAsync']/constructor[@name='ManualTransactionAsync' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.executor.MiuraManager']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/api/executor/MiuraManager;)V", "")]
		public unsafe ManualTransactionAsync (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager miuraManager)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/api/executor/MiuraManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((miuraManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) miuraManager).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (miuraManager);
			}
		}

		static Delegate cb_manualTransaction_Z;
#pragma warning disable 0169
		static Delegate GetManualTransaction_ZHandler ()
		{
			if (cb_manualTransaction_Z == null)
				cb_manualTransaction_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ManualTransaction_Z);
			return cb_manualTransaction_Z;
		}

		static void n_ManualTransaction_Z (IntPtr jnienv, IntPtr native__this, bool isCvv)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Transactions.ManualTransactionAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ManualTransaction (isCvv);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.transactions']/class[@name='ManualTransactionAsync']/method[@name='manualTransaction' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("manualTransaction", "(Z)V", "GetManualTransaction_ZHandler")]
		public virtual unsafe void ManualTransaction (bool isCvv)
		{
			const string __id = "manualTransaction.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isCvv);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
