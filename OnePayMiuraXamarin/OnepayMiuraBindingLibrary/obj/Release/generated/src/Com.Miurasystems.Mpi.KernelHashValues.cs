using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='KernelHashValues']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/KernelHashValues", DoNotGenerateAcw=true)]
	public sealed partial class KernelHashValues : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/KernelHashValues", typeof (KernelHashValues));
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

		internal KernelHashValues (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='KernelHashValues']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Lookup (string hashValue)
		{
			const string __id = "lookup.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_hashValue = JNIEnv.NewString (hashValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hashValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hashValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='KernelHashValues']/method[@name='lookup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Lookup (string kernel, string hashValue)
		{
			const string __id = "lookup.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_kernel = JNIEnv.NewString (kernel);
			IntPtr native_hashValue = JNIEnv.NewString (hashValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_kernel);
				__args [1] = new JniArgumentValue (native_hashValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kernel);
				JNIEnv.DeleteLocalRef (native_hashValue);
			}
		}

	}
}
