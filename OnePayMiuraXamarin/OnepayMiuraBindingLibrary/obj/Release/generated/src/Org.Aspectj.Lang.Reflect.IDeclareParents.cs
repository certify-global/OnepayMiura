using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']"
	[Register ("org/aspectj/lang/reflect/DeclareParents", "", "Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker")]
	public partial interface IDeclareParents : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsExtends {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']/method[@name='isExtends' and count(parameter)=0]"
			[Register ("isExtends", "()Z", "GetIsExtendsHandler:Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsImplements {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']/method[@name='isImplements' and count(parameter)=0]"
			[Register ("isImplements", "()Z", "GetIsImplementsHandler:Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.ITypePattern TargetTypesPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']/method[@name='getTargetTypesPattern' and count(parameter)=0]"
			[Register ("getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTargetTypesPatternHandler:Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='DeclareParents']/method[@name='getParentTypes' and count(parameter)=0]"
		[Register ("getParentTypes", "()[Ljava/lang/reflect/Type;", "GetGetParentTypesHandler:Org.Aspectj.Lang.Reflect.IDeclareParentsInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.IType[] GetParentTypes ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/DeclareParents", DoNotGenerateAcw=true)]
	internal partial class IDeclareParentsInvoker : global::Java.Lang.Object, IDeclareParents {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/DeclareParents", typeof (IDeclareParentsInvoker));

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

		public static IDeclareParents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeclareParents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.DeclareParents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeclareParentsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeclaringType;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeHandler ()
		{
			if (cb_getDeclaringType == null)
				cb_getDeclaringType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringType);
			return cb_getDeclaringType;
		}

		static IntPtr n_GetDeclaringType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isExtends;
#pragma warning disable 0169
		static Delegate GetIsExtendsHandler ()
		{
			if (cb_isExtends == null)
				cb_isExtends = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExtends);
			return cb_isExtends;
		}

		static bool n_IsExtends (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExtends;
		}
#pragma warning restore 0169

		IntPtr id_isExtends;
		public unsafe bool IsExtends {
			get {
				if (id_isExtends == IntPtr.Zero)
					id_isExtends = JNIEnv.GetMethodID (class_ref, "isExtends", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExtends);
			}
		}

		static Delegate cb_isImplements;
#pragma warning disable 0169
		static Delegate GetIsImplementsHandler ()
		{
			if (cb_isImplements == null)
				cb_isImplements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsImplements);
			return cb_isImplements;
		}

		static bool n_IsImplements (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImplements;
		}
#pragma warning restore 0169

		IntPtr id_isImplements;
		public unsafe bool IsImplements {
			get {
				if (id_isImplements == IntPtr.Zero)
					id_isImplements = JNIEnv.GetMethodID (class_ref, "isImplements", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImplements);
			}
		}

		static Delegate cb_getTargetTypesPattern;
#pragma warning disable 0169
		static Delegate GetGetTargetTypesPatternHandler ()
		{
			if (cb_getTargetTypesPattern == null)
				cb_getTargetTypesPattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetTypesPattern);
			return cb_getTargetTypesPattern;
		}

		static IntPtr n_GetTargetTypesPattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetTypesPattern);
		}
#pragma warning restore 0169

		IntPtr id_getTargetTypesPattern;
		public unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TargetTypesPattern {
			get {
				if (id_getTargetTypesPattern == IntPtr.Zero)
					id_getTargetTypesPattern = JNIEnv.GetMethodID (class_ref, "getTargetTypesPattern", "()Lorg/aspectj/lang/reflect/TypePattern;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetTypesPattern), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParentTypes;
#pragma warning disable 0169
		static Delegate GetGetParentTypesHandler ()
		{
			if (cb_getParentTypes == null)
				cb_getParentTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParentTypes);
			return cb_getParentTypes;
		}

		static IntPtr n_GetParentTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IDeclareParents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParentTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getParentTypes;
		public unsafe global::Java.Lang.Reflect.IType[] GetParentTypes ()
		{
			if (id_getParentTypes == IntPtr.Zero)
				id_getParentTypes = JNIEnv.GetMethodID (class_ref, "getParentTypes", "()[Ljava/lang/reflect/Type;");
			return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
		}

	}

}
