using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='TypePattern']"
	[Register ("org/aspectj/lang/reflect/TypePattern", "", "Org.Aspectj.Lang.Reflect.ITypePatternInvoker")]
	public partial interface ITypePattern : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='TypePattern']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler:Org.Aspectj.Lang.Reflect.ITypePatternInvoker, OnepayMiuraBindingLibrary")]
		string AsString ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/TypePattern", DoNotGenerateAcw=true)]
	internal partial class ITypePatternInvoker : global::Java.Lang.Object, ITypePattern {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/TypePattern", typeof (ITypePatternInvoker));

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

		public static ITypePattern GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypePattern> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.TypePattern"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypePatternInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asString;
#pragma warning disable 0169
		static Delegate GetAsStringHandler ()
		{
			if (cb_asString == null)
				cb_asString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsString);
			return cb_asString;
		}

		static IntPtr n_AsString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		IntPtr id_asString;
		public unsafe string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
