using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='DisplayTextUtils']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/DisplayTextUtils", DoNotGenerateAcw=true)]
	public partial class DisplayTextUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/DisplayTextUtils", typeof (DisplayTextUtils));
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

		protected DisplayTextUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='DisplayTextUtils']/constructor[@name='DisplayTextUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DisplayTextUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='DisplayTextUtils']/method[@name='getCenteredText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCenteredText", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetCenteredText (string text)
		{
			const string __id = "getCenteredText.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
