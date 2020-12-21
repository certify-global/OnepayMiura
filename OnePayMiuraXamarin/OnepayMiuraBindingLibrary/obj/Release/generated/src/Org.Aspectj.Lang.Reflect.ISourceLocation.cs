using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SourceLocation']"
	[Register ("org/aspectj/lang/reflect/SourceLocation", "", "Org.Aspectj.Lang.Reflect.ISourceLocationInvoker")]
	public partial interface ISourceLocation : IJavaObject, IJavaPeerable {

		int Column {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SourceLocation']/method[@name='getColumn' and count(parameter)=0]"
			[Register ("getColumn", "()I", "GetGetColumnHandler:Org.Aspectj.Lang.Reflect.ISourceLocationInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string FileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SourceLocation']/method[@name='getFileName' and count(parameter)=0]"
			[Register ("getFileName", "()Ljava/lang/String;", "GetGetFileNameHandler:Org.Aspectj.Lang.Reflect.ISourceLocationInvoker, OnepayMiuraBindingLibrary")] get;
		}

		int Line {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SourceLocation']/method[@name='getLine' and count(parameter)=0]"
			[Register ("getLine", "()I", "GetGetLineHandler:Org.Aspectj.Lang.Reflect.ISourceLocationInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Class WithinType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SourceLocation']/method[@name='getWithinType' and count(parameter)=0]"
			[Register ("getWithinType", "()Ljava/lang/Class;", "GetGetWithinTypeHandler:Org.Aspectj.Lang.Reflect.ISourceLocationInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/SourceLocation", DoNotGenerateAcw=true)]
	internal partial class ISourceLocationInvoker : global::Java.Lang.Object, ISourceLocation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/SourceLocation", typeof (ISourceLocationInvoker));

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

		public static ISourceLocation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISourceLocation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.SourceLocation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISourceLocationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getColumn;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetColumnHandler ()
		{
			if (cb_getColumn == null)
				cb_getColumn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetColumn);
			return cb_getColumn;
		}

		[Obsolete]
		static int n_GetColumn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Column;
		}
#pragma warning restore 0169

		IntPtr id_getColumn;
		public unsafe int Column {
			get {
				if (id_getColumn == IntPtr.Zero)
					id_getColumn = JNIEnv.GetMethodID (class_ref, "getColumn", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColumn);
			}
		}

		static Delegate cb_getFileName;
#pragma warning disable 0169
		static Delegate GetGetFileNameHandler ()
		{
			if (cb_getFileName == null)
				cb_getFileName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFileName);
			return cb_getFileName;
		}

		static IntPtr n_GetFileName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileName);
		}
#pragma warning restore 0169

		IntPtr id_getFileName;
		public unsafe string FileName {
			get {
				if (id_getFileName == IntPtr.Zero)
					id_getFileName = JNIEnv.GetMethodID (class_ref, "getFileName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLine;
#pragma warning disable 0169
		static Delegate GetGetLineHandler ()
		{
			if (cb_getLine == null)
				cb_getLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLine);
			return cb_getLine;
		}

		static int n_GetLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Line;
		}
#pragma warning restore 0169

		IntPtr id_getLine;
		public unsafe int Line {
			get {
				if (id_getLine == IntPtr.Zero)
					id_getLine = JNIEnv.GetMethodID (class_ref, "getLine", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLine);
			}
		}

		static Delegate cb_getWithinType;
#pragma warning disable 0169
		static Delegate GetGetWithinTypeHandler ()
		{
			if (cb_getWithinType == null)
				cb_getWithinType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWithinType);
			return cb_getWithinType;
		}

		static IntPtr n_GetWithinType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithinType);
		}
#pragma warning restore 0169

		IntPtr id_getWithinType;
		public unsafe global::Java.Lang.Class WithinType {
			get {
				if (id_getWithinType == IntPtr.Zero)
					id_getWithinType = JNIEnv.GetMethodID (class_ref, "getWithinType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWithinType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
