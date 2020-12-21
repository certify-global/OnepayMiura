using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='TypePatternBasedPerClause']"
	[Register ("org/aspectj/lang/reflect/TypePatternBasedPerClause", "", "Org.Aspectj.Lang.Reflect.ITypePatternBasedPerClauseInvoker")]
	public partial interface ITypePatternBasedPerClause : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='TypePatternBasedPerClause']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler:Org.Aspectj.Lang.Reflect.ITypePatternBasedPerClauseInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/TypePatternBasedPerClause", DoNotGenerateAcw=true)]
	internal partial class ITypePatternBasedPerClauseInvoker : global::Java.Lang.Object, ITypePatternBasedPerClause {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/TypePatternBasedPerClause", typeof (ITypePatternBasedPerClauseInvoker));

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

		public static ITypePatternBasedPerClause GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypePatternBasedPerClause> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.TypePatternBasedPerClause"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypePatternBasedPerClauseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTypePattern;
#pragma warning disable 0169
		static Delegate GetGetTypePatternHandler ()
		{
			if (cb_getTypePattern == null)
				cb_getTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypePattern);
			return cb_getTypePattern;
		}

		static IntPtr n_GetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePatternBasedPerClause> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		IntPtr id_getTypePattern;
		public unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			get {
				if (id_getTypePattern == IntPtr.Zero)
					id_getTypePattern = JNIEnv.GetMethodID (class_ref, "getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypePattern), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
