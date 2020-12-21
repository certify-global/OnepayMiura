using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/CommandUtil", DoNotGenerateAcw=true)]
	public partial class CommandUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/CommandUtil", typeof (CommandUtil));
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

		protected CommandUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/constructor[@name='CommandUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='addLRC' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("addLRC", "([B)[B", "")]
		public static unsafe byte[] AddLRC (byte[] test)
		{
			const string __id = "addLRC.([B)[B";
			IntPtr native_test = JNIEnv.NewArray (test);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_test);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (test != null) {
					JNIEnv.CopyArray (native_test, test);
					JNIEnv.DeleteLocalRef (native_test);
				}
				global::System.GC.KeepAlive (test);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='calcMaxDataSize' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.tlv.Description']]"
		[Register ("calcMaxDataSize", "(Lcom/miurasystems/mpi/tlv/Description;)I", "")]
		public static unsafe int CalcMaxDataSize (global::Com.Miurasystems.Mpi.Tlv.Description topTag)
		{
			const string __id = "calcMaxDataSize.(Lcom/miurasystems/mpi/tlv/Description;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((topTag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) topTag).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (topTag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='copyArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("copyArray", "([B[B)[B", "")]
		public static unsafe byte[] CopyArray (byte[] array1, byte[] array2)
		{
			const string __id = "copyArray.([B[B)[B";
			IntPtr native_array1 = JNIEnv.NewArray (array1);
			IntPtr native_array2 = JNIEnv.NewArray (array2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array1);
				__args [1] = new JniArgumentValue (native_array2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (array1 != null) {
					JNIEnv.CopyArray (native_array1, array1);
					JNIEnv.DeleteLocalRef (native_array1);
				}
				if (array2 != null) {
					JNIEnv.CopyArray (native_array2, array2);
					JNIEnv.DeleteLocalRef (native_array2);
				}
				global::System.GC.KeepAlive (array1);
				global::System.GC.KeepAlive (array2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='cutArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("cutArray", "([BI)[B", "")]
		public static unsafe byte[] CutArray (byte[] array, int length)
		{
			const string __id = "cutArray.([BI)[B";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (length);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='cutArray' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("cutArray", "([BII)[B", "")]
		public static unsafe byte[] CutArray (byte[] array, int offset, int length)
		{
			const string __id = "cutArray.([BII)[B";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='firstMatch' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;'] and parameter[2][@type='com.miurasystems.mpi.tlv.Description']]"
		[Register ("firstMatch", "(Ljava/util/List;Lcom/miurasystems/mpi/tlv/Description;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject FirstMatch (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvs, global::Com.Miurasystems.Mpi.Tlv.Description tag)
		{
			const string __id = "firstMatch.(Ljava/util/List;Lcom/miurasystems/mpi/tlv/Description;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			IntPtr native_tlvs = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tlvs);
				__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvs);
				global::System.GC.KeepAlive (tlvs);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='searchTagValue' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;'] and parameter[2][@type='com.miurasystems.mpi.tlv.Description'] and parameter[3][@type='int']]"
		[Register ("searchTagValue", "(Ljava/util/List;Lcom/miurasystems/mpi/tlv/Description;I)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject SearchTagValue (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvs, global::Com.Miurasystems.Mpi.Tlv.Description tag, int count)
		{
			const string __id = "searchTagValue.(Ljava/util/List;Lcom/miurasystems/mpi/tlv/Description;I)Lcom/miurasystems/mpi/tlv/TLVObject;";
			IntPtr native_tlvs = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tlvs);
				__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [2] = new JniArgumentValue (count);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvs);
				global::System.GC.KeepAlive (tlvs);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='serialise' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("serialise", "([B[B)[B", "")]
		public static unsafe byte[] Serialise (byte[] tag, byte[] value)
		{
			const string __id = "serialise.([B[B)[B";
			IntPtr native_tag = JNIEnv.NewArray (tag);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (tag != null) {
					JNIEnv.CopyArray (native_tag, tag);
					JNIEnv.DeleteLocalRef (native_tag);
				}
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
				global::System.GC.KeepAlive (tag);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='CommandUtil']/method[@name='splitTlvIntoApdus' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("splitTlvIntoApdus", "(ILjava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>> SplitTlvIntoApdus (int maxApduDataSize, global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvListToSplit)
		{
			const string __id = "splitTlvIntoApdus.(ILjava/util/List;)Ljava/util/List;";
			IntPtr native_tlvListToSplit = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvListToSplit);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (maxApduDataSize);
				__args [1] = new JniArgumentValue (native_tlvListToSplit);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvListToSplit);
				global::System.GC.KeepAlive (tlvListToSplit);
			}
		}

	}
}
