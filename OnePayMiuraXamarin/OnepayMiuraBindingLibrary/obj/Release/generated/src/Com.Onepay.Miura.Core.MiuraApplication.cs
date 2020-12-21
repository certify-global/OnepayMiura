using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='MiuraApplication']"
	[global::Android.Runtime.Register ("com/onepay/miura/core/MiuraApplication", DoNotGenerateAcw=true)]
	public partial class MiuraApplication : global::Android.App.Application {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='MiuraApplication']/field[@name='currencyCode']"
		[Register ("currencyCode")]
		public static global::Com.Onepay.Miura.Utils.CurrencyCode CurrencyCode {
			get {
				const string __id = "currencyCode.Lcom/onepay/miura/utils/CurrencyCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Utils.CurrencyCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "currencyCode.Lcom/onepay/miura/utils/CurrencyCode;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/core/MiuraApplication", typeof (MiuraApplication));
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

		protected MiuraApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='MiuraApplication']/constructor[@name='MiuraApplication' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiuraApplication ()
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

	}
}
