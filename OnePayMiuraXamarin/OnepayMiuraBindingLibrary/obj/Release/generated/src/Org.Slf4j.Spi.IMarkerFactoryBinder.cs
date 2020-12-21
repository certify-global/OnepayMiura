using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Spi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MarkerFactoryBinder']"
	[Register ("org/slf4j/spi/MarkerFactoryBinder", "", "Org.Slf4j.Spi.IMarkerFactoryBinderInvoker")]
	public partial interface IMarkerFactoryBinder : IJavaObject, IJavaPeerable {

		global::Org.Slf4j.IMarkerFactory MarkerFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MarkerFactoryBinder']/method[@name='getMarkerFactory' and count(parameter)=0]"
			[Register ("getMarkerFactory", "()Lorg/slf4j/IMarkerFactory;", "GetGetMarkerFactoryHandler:Org.Slf4j.Spi.IMarkerFactoryBinderInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string MarkerFactoryClassStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='MarkerFactoryBinder']/method[@name='getMarkerFactoryClassStr' and count(parameter)=0]"
			[Register ("getMarkerFactoryClassStr", "()Ljava/lang/String;", "GetGetMarkerFactoryClassStrHandler:Org.Slf4j.Spi.IMarkerFactoryBinderInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/slf4j/spi/MarkerFactoryBinder", DoNotGenerateAcw=true)]
	internal partial class IMarkerFactoryBinderInvoker : global::Java.Lang.Object, IMarkerFactoryBinder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/spi/MarkerFactoryBinder", typeof (IMarkerFactoryBinderInvoker));

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

		public static IMarkerFactoryBinder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMarkerFactoryBinder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.spi.MarkerFactoryBinder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMarkerFactoryBinderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMarkerFactory;
#pragma warning disable 0169
		static Delegate GetGetMarkerFactoryHandler ()
		{
			if (cb_getMarkerFactory == null)
				cb_getMarkerFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMarkerFactory);
			return cb_getMarkerFactory;
		}

		static IntPtr n_GetMarkerFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMarkerFactoryBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MarkerFactory);
		}
#pragma warning restore 0169

		IntPtr id_getMarkerFactory;
		public unsafe global::Org.Slf4j.IMarkerFactory MarkerFactory {
			get {
				if (id_getMarkerFactory == IntPtr.Zero)
					id_getMarkerFactory = JNIEnv.GetMethodID (class_ref, "getMarkerFactory", "()Lorg/slf4j/IMarkerFactory;");
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarkerFactory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMarkerFactoryClassStr;
#pragma warning disable 0169
		static Delegate GetGetMarkerFactoryClassStrHandler ()
		{
			if (cb_getMarkerFactoryClassStr == null)
				cb_getMarkerFactoryClassStr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMarkerFactoryClassStr);
			return cb_getMarkerFactoryClassStr;
		}

		static IntPtr n_GetMarkerFactoryClassStr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.IMarkerFactoryBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MarkerFactoryClassStr);
		}
#pragma warning restore 0169

		IntPtr id_getMarkerFactoryClassStr;
		public unsafe string MarkerFactoryClassStr {
			get {
				if (id_getMarkerFactoryClassStr == IntPtr.Zero)
					id_getMarkerFactoryClassStr = JNIEnv.GetMethodID (class_ref, "getMarkerFactoryClassStr", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarkerFactoryClassStr), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
