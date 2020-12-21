using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/onepay/miura/common/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='BluetoothConnectionErrorReason']"
		[Register ("BluetoothConnectionErrorReason")]
		public static string BluetoothConnectionErrorReason {
			get {
				const string __id = "BluetoothConnectionErrorReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BluetoothConnectionErrorReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='BluetoothConnectionErrorStatus']"
		[Register ("BluetoothConnectionErrorStatus")]
		public static int BluetoothConnectionErrorStatus {
			get {
				const string __id = "BluetoothConnectionErrorStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "BluetoothConnectionErrorStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='BluetoothDisconnectedReason']"
		[Register ("BluetoothDisconnectedReason")]
		public static string BluetoothDisconnectedReason {
			get {
				const string __id = "BluetoothDisconnectedReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "BluetoothDisconnectedReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='BluetoothDisconnectedStatus']"
		[Register ("BluetoothDisconnectedStatus")]
		public static int BluetoothDisconnectedStatus {
			get {
				const string __id = "BluetoothDisconnectedStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "BluetoothDisconnectedStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='CancelReason']"
		[Register ("CancelReason")]
		public static string CancelReason {
			get {
				const string __id = "CancelReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CancelReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='CancelStatus']"
		[Register ("CancelStatus")]
		public static int CancelStatus {
			get {
				const string __id = "CancelStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "CancelStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='Chip']"
		[Register ("Chip")]
		public static string Chip {
			get {
				const string __id = "Chip.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Chip.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='EmvSwipe']"
		[Register ("EmvSwipe")]
		public static string EmvSwipe {
			get {
				const string __id = "EmvSwipe.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "EmvSwipe.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='ErrorReason']"
		[Register ("ErrorReason")]
		public static string ErrorReason {
			get {
				const string __id = "ErrorReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ErrorReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='ErrorStatus']"
		[Register ("ErrorStatus")]
		public static int ErrorStatus {
			get {
				const string __id = "ErrorStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ErrorStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='InvalidParametersReason']"
		[Register ("InvalidParametersReason")]
		public static string InvalidParametersReason {
			get {
				const string __id = "InvalidParametersReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "InvalidParametersReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='InvalidParametersStatus']"
		[Register ("InvalidParametersStatus")]
		public static int InvalidParametersStatus {
			get {
				const string __id = "InvalidParametersStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "InvalidParametersStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='Manual']"
		[Register ("Manual")]
		public static string Manual {
			get {
				const string __id = "Manual.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Manual.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='NFC']"
		[Register ("NFC")]
		public static string Nfc {
			get {
				const string __id = "NFC.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "NFC.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='SuccessReason']"
		[Register ("SuccessReason")]
		public static string SuccessReason {
			get {
				const string __id = "SuccessReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "SuccessReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='SuccessStatus']"
		[Register ("SuccessStatus")]
		public static int SuccessStatus {
			get {
				const string __id = "SuccessStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "SuccessStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='Swipe']"
		[Register ("Swipe")]
		public static string Swipe {
			get {
				const string __id = "Swipe.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Swipe.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='TimeoutReason']"
		[Register ("TimeoutReason")]
		public static string TimeoutReason {
			get {
				const string __id = "TimeoutReason.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TimeoutReason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='TimeoutStatus']"
		[Register ("TimeoutStatus")]
		public static int TimeoutStatus {
			get {
				const string __id = "TimeoutStatus.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "TimeoutStatus.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static string Unknown {
			get {
				const string __id = "Unknown.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Unknown.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/common/Constants", typeof (Constants));
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

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.common']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
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
