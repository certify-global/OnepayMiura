using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='PointcutBasedPerClause']"
	[Register ("org/aspectj/lang/reflect/PointcutBasedPerClause", "", "Org.Aspectj.Lang.Reflect.IPointcutBasedPerClauseInvoker")]
	public partial interface IPointcutBasedPerClause : global::Org.Aspectj.Lang.Reflect.IPerClause {

		global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='PointcutBasedPerClause']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler:Org.Aspectj.Lang.Reflect.IPointcutBasedPerClauseInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/PointcutBasedPerClause", DoNotGenerateAcw=true)]
	internal partial class IPointcutBasedPerClauseInvoker : global::Java.Lang.Object, IPointcutBasedPerClause {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/PointcutBasedPerClause", typeof (IPointcutBasedPerClauseInvoker));

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

		public static IPointcutBasedPerClause GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPointcutBasedPerClause> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.PointcutBasedPerClause"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPointcutBasedPerClauseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPointcutExpression;
#pragma warning disable 0169
		static Delegate GetGetPointcutExpressionHandler ()
		{
			if (cb_getPointcutExpression == null)
				cb_getPointcutExpression = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPointcutExpression);
			return cb_getPointcutExpression;
		}

		static IntPtr n_GetPointcutExpression (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutBasedPerClause> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		IntPtr id_getPointcutExpression;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			get {
				if (id_getPointcutExpression == IntPtr.Zero)
					id_getPointcutExpression = JNIEnv.GetMethodID (class_ref, "getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutExpression> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointcutExpression), JniHandleOwnership.TransferLocalRef);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutBasedPerClause> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
