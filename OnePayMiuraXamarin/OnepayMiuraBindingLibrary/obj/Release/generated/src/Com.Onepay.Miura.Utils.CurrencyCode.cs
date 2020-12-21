using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']"
	[global::Android.Runtime.Register ("com/onepay/miura/utils/CurrencyCode", DoNotGenerateAcw=true)]
	public sealed partial class CurrencyCode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']/field[@name='USD']"
		[Register ("USD")]
		public static global::Com.Onepay.Miura.Utils.CurrencyCode Usd {
			get {
				const string __id = "USD.Lcom/onepay/miura/utils/CurrencyCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Utils.CurrencyCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/utils/CurrencyCode", typeof (CurrencyCode));
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

		internal CurrencyCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Sign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']/method[@name='getSign' and count(parameter)=0]"
			[Register ("getSign", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSign.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/onepay/miura/utils/CurrencyCode;", "")]
		public static unsafe global::Com.Onepay.Miura.Utils.CurrencyCode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/onepay/miura/utils/CurrencyCode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Utils.CurrencyCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.utils']/class[@name='CurrencyCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/onepay/miura/utils/CurrencyCode;", "")]
		public static unsafe global::Com.Onepay.Miura.Utils.CurrencyCode[] Values ()
		{
			const string __id = "values.()[Lcom/onepay/miura/utils/CurrencyCode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Onepay.Miura.Utils.CurrencyCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Onepay.Miura.Utils.CurrencyCode));
			} finally {
			}
		}

	}
}
