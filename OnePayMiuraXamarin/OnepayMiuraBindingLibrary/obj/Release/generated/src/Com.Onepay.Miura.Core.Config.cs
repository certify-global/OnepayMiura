using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/onepay/miura/core/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/core/Config", typeof (Config));
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

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Config ()
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

		public static unsafe string ConfigVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getConfigVersion' and count(parameter)=0]"
			[Register ("getConfigVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getConfigVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string OsFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getOsFileName' and count(parameter)=0]"
			[Register ("getOsFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOsFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string OsUpdateFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getOsUpdateFileName' and count(parameter)=0]"
			[Register ("getOsUpdateFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOsUpdateFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string RpiFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getRpiFileName' and count(parameter)=0]"
			[Register ("getRpiFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRpiFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string RpiOsFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getRpiOsFileName' and count(parameter)=0]"
			[Register ("getRpiOsFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRpiOsFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string RpiOsUpdateFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getRpiOsUpdateFileName' and count(parameter)=0]"
			[Register ("getRpiOsUpdateFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRpiOsUpdateFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestMpiConfFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestMpiConfFileName' and count(parameter)=0]"
			[Register ("getTestMpiConfFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestMpiConfFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestMpiFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestMpiFileName' and count(parameter)=0]"
			[Register ("getTestMpiFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestMpiFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestOsFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestOsFileName' and count(parameter)=0]"
			[Register ("getTestOsFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestOsFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestOsUpdateFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestOsUpdateFileName' and count(parameter)=0]"
			[Register ("getTestOsUpdateFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestOsUpdateFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestRpiFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestRpiFileName' and count(parameter)=0]"
			[Register ("getTestRpiFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestRpiFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestRpiOsFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestRpiOsFileName' and count(parameter)=0]"
			[Register ("getTestRpiOsFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestRpiOsFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TestRpiOsUpdateFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='getTestRpiOsUpdateFileName' and count(parameter)=0]"
			[Register ("getTestRpiOsUpdateFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTestRpiOsUpdateFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isBatteryValid' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isBatteryValid", "(I)Z", "")]
		public static unsafe bool IsBatteryValid (int batteryLevel)
		{
			const string __id = "isBatteryValid.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (batteryLevel);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isConfigVersionValid' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("isConfigVersionValid", "(Ljava/util/HashMap;)Z", "")]
		public static unsafe bool IsConfigVersionValid (global::System.Collections.Generic.IDictionary<string, string> configVersions)
		{
			const string __id = "isConfigVersionValid.(Ljava/util/HashMap;)Z";
			IntPtr native_configVersions = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (configVersions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configVersions);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_configVersions);
				global::System.GC.KeepAlive (configVersions);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isMpiVersionValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isMpiVersionValid", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsMpiVersionValid (string mpiVersion)
		{
			const string __id = "isMpiVersionValid.(Ljava/lang/String;)Z";
			IntPtr native_mpiVersion = JNIEnv.NewString (mpiVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mpiVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mpiVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isOsVersionValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isOsVersionValid", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsOsVersionValid (string osVersion)
		{
			const string __id = "isOsVersionValid.(Ljava/lang/String;)Z";
			IntPtr native_osVersion = JNIEnv.NewString (osVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_osVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_osVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isRpiOsVersionValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRpiOsVersionValid", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsRpiOsVersionValid (string rpiVersion)
		{
			const string __id = "isRpiOsVersionValid.(Ljava/lang/String;)Z";
			IntPtr native_rpiVersion = JNIEnv.NewString (rpiVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rpiVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_rpiVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isRpiVersionValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRpiVersionValid", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsRpiVersionValid (string mpiVersion)
		{
			const string __id = "isRpiVersionValid.(Ljava/lang/String;)Z";
			IntPtr native_mpiVersion = JNIEnv.NewString (mpiVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mpiVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mpiVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.core']/class[@name='Config']/method[@name='isTimeValid' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("isTimeValid", "(Ljava/util/Date;)Z", "")]
		public static unsafe bool IsTimeValid (global::Java.Util.Date dateTime)
		{
			const string __id = "isTimeValid.(Ljava/util/Date;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dateTime).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dateTime);
			}
		}

	}
}
