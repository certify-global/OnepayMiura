using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AjTypeSystem", DoNotGenerateAcw=true)]
	public partial class AjTypeSystem : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/AjTypeSystem", typeof (AjTypeSystem));
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

		protected AjTypeSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']/constructor[@name='AjTypeSystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AjTypeSystem ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']/method[@name='getAjType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAjType", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AjType;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Aspectj.Lang.Reflect.IAjType GetAjType (global::Java.Lang.Class fromClass)
		{
			const string __id = "getAjType.(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AjType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fromClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromClass).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fromClass);
			}
		}

	}
}
