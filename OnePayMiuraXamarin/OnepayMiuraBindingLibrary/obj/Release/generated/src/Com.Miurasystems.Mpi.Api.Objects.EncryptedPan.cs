using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='EncryptedPan']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/EncryptedPan", DoNotGenerateAcw=true)]
	public sealed partial class EncryptedPan : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='EncryptedPan']/field[@name='P2peSredData']"
		[Register ("P2peSredData")]
		public IList<byte> P2peSredData {
			get {
				const string __id = "P2peSredData.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "P2peSredData.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='EncryptedPan']/field[@name='P2peSredKsn']"
		[Register ("P2peSredKsn")]
		public IList<byte> P2peSredKsn {
			get {
				const string __id = "P2peSredKsn.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "P2peSredKsn.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='EncryptedPan']/field[@name='RedactedPan']"
		[Register ("RedactedPan")]
		public string RedactedPan {
			get {
				const string __id = "RedactedPan.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "RedactedPan.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/EncryptedPan", typeof (EncryptedPan));
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

		internal EncryptedPan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='EncryptedPan']/method[@name='fromE1' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register ("fromE1", "(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/EncryptedPan;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan FromE1 (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> rmE1List)
		{
			const string __id = "fromE1.(Ljava/util/List;)Lcom/miurasystems/mpi/api/objects/EncryptedPan;";
			IntPtr native_rmE1List = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (rmE1List);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rmE1List);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.EncryptedPan> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rmE1List);
				global::System.GC.KeepAlive (rmE1List);
			}
		}

	}
}
