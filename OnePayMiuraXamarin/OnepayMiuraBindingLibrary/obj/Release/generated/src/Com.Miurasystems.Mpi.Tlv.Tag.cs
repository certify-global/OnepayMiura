using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Tag']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/Tag", DoNotGenerateAcw=true)]
	public partial class Tag : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Tag']/field[@name='description']"
		[Register ("description")]
		public global::Com.Miurasystems.Mpi.Tlv.Description Description {
			get {
				const string __id = "description.Lcom/miurasystems/mpi/tlv/Description;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Description> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "description.Lcom/miurasystems/mpi/tlv/Description;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/Tag", typeof (Tag));
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

		protected Tag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Tag']/constructor[@name='Tag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Tag (int id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getTagID;
#pragma warning disable 0169
		static Delegate GetGetTagIDHandler ()
		{
			if (cb_getTagID == null)
				cb_getTagID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTagID);
			return cb_getTagID;
		}

		static int n_GetTagID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Tag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagID;
		}
#pragma warning restore 0169

		public virtual unsafe int TagID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='Tag']/method[@name='getTagID' and count(parameter)=0]"
			[Register ("getTagID", "()I", "GetGetTagIDHandler")]
			get {
				const string __id = "getTagID.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
