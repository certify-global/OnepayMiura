using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/BinaryUtil", DoNotGenerateAcw=true)]
	public partial class BinaryUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/BinaryUtil", typeof (BinaryUtil));
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

		protected BinaryUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/constructor[@name='BinaryUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BinaryUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='assertByteRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("assertByteRange", "(I)V", "")]
		public static unsafe void AssertByteRange (int i)
		{
			const string __id = "assertByteRange.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='convertHexByteArrayToInt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("convertHexByteArrayToInt", "([B)I", "")]
		public static unsafe int ConvertHexByteArrayToInt (byte[] array)
		{
			const string __id = "convertHexByteArrayToInt.([B)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='convertIntToHexByteArray' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("convertIntToHexByteArray", "([BIII)[B", "")]
		public static unsafe byte[] ConvertIntToHexByteArray (byte[] array, int value, int byteCount, int index)
		{
			const string __id = "convertIntToHexByteArray.([BIII)[B";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue (byteCount);
				__args [3] = new JniArgumentValue (index);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='convertIntToHexByteArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("convertIntToHexByteArray", "(II)[B", "")]
		public static unsafe byte[] ConvertIntToHexByteArray (int value, int byteCount)
		{
			const string __id = "convertIntToHexByteArray.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='getBCD' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getBCD", "(II)[B", "")]
		public static unsafe byte[] GetBCD (int value, int byteCount)
		{
			const string __id = "getBCD.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (byteCount);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='intToUbyte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intToUbyte", "(I)B", "")]
		public static unsafe sbyte IntToUbyte (int i)
		{
			const string __id = "intToUbyte.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseBinaryString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseBinaryString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ParseBinaryString (byte[] bytes)
		{
			const string __id = "parseBinaryString.([B)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseBinaryString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("parseBinaryString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ParseBinaryString (int b)
		{
			const string __id = "parseBinaryString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexBinary' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.Description']]"
		[Register ("parseHexBinary", "(Lcom/miurasystems/mpi/tlv/Description;)[B", "")]
		public static unsafe byte[] ParseHexBinary (global::Com.Miurasystems.Mpi.Tlv.Description tag)
		{
			const string __id = "parseHexBinary.(Lcom/miurasystems/mpi/tlv/Description;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexBinary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseHexBinary", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] ParseHexBinary (string s)
		{
			const string __id = "parseHexBinary.(Ljava/lang/String;)[B";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexBinary' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.Description&gt;']]"
		[Register ("parseHexBinary", "(Ljava/util/List;)[B", "")]
		public static unsafe byte[] ParseHexBinary (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.Description> tag)
		{
			const string __id = "parseHexBinary.(Ljava/util/List;)[B";
			IntPtr native_tag = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.Description>.ToLocalJniHandle (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexString' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("parseHexString", "(B)Ljava/lang/String;", "")]
		public static unsafe string ParseHexString (sbyte b)
		{
			const string __id = "parseHexString.(B)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseHexString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ParseHexString (byte[] bytes)
		{
			const string __id = "parseHexString.([B)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='parseHexString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("parseHexString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ParseHexString (int b)
		{
			const string __id = "parseHexString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='BinaryUtil']/method[@name='ubyteToInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ubyteToInt", "(B)I", "")]
		public static unsafe int UbyteToInt (sbyte b)
		{
			const string __id = "ubyteToInt.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
