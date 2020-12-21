using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/HexUtil", DoNotGenerateAcw=true)]
	public partial class HexUtil : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/field[@name='hexArray']"
		[Register ("hexArray")]
		protected static IList<char> HexArray {
			get {
				const string __id = "hexArray.[C";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<char>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/HexUtil", typeof (HexUtil));
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

		protected HexUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/constructor[@name='HexUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HexUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/method[@name='asciiToHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("asciiToHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AsciiToHex (string asciiString)
		{
			const string __id = "asciiToHex.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_asciiString = JNIEnv.NewString (asciiString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_asciiString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_asciiString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/method[@name='bytesToHexStrings' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToHexStrings", "([B)Ljava/lang/String;", "")]
		public static unsafe string BytesToHexStrings (byte[] bytes)
		{
			const string __id = "bytesToHexStrings.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/method[@name='bytesToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToString", "([B)Ljava/lang/String;", "")]
		public static unsafe string BytesToString (byte[] bytes)
		{
			const string __id = "bytesToString.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/method[@name='hexToASCII' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexToASCII", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HexToASCII (string hexValue)
		{
			const string __id = "hexToASCII.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_hexValue = JNIEnv.NewString (hexValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hexValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hexValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='HexUtil']/method[@name='hexToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexToString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HexToString (string hexString)
		{
			const string __id = "hexToString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_hexString = JNIEnv.NewString (hexString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hexString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hexString);
			}
		}

	}
}
