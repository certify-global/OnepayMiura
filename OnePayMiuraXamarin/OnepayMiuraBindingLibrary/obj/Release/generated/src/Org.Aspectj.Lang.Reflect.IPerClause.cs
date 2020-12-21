using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='PerClause']"
	[Register ("org/aspectj/lang/reflect/PerClause", "", "Org.Aspectj.Lang.Reflect.IPerClauseInvoker")]
	public partial interface IPerClause : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.PerClauseKind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='PerClause']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/aspectj/lang/reflect/PerClauseKind;", "GetGetKindHandler:Org.Aspectj.Lang.Reflect.IPerClauseInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/PerClause", DoNotGenerateAcw=true)]
	internal partial class IPerClauseInvoker : global::Java.Lang.Object, IPerClause {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/PerClause", typeof (IPerClauseInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPerClause GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPerClause> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.PerClause"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPerClauseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getKind;
#pragma warning disable 0169
		static Delegate GetGetKindHandler ()
		{
			if (cb_getKind == null)
				cb_getKind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetKind);
			return cb_getKind;
		}

		static IntPtr n_GetKind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPerClause> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kind);
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		public unsafe global::Org.Aspectj.Lang.Reflect.PerClauseKind Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Lorg/aspectj/lang/reflect/PerClauseKind;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
