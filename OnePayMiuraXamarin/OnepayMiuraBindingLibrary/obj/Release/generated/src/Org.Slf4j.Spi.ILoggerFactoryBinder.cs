using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Spi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LoggerFactoryBinder']"
	[Register ("org/slf4j/spi/LoggerFactoryBinder", "", "Org.Slf4j.Spi.ILoggerFactoryBinderInvoker")]
	public partial interface ILoggerFactoryBinder : IJavaObject, IJavaPeerable {

		global::Org.Slf4j.ILoggerFactory LoggerFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LoggerFactoryBinder']/method[@name='getLoggerFactory' and count(parameter)=0]"
			[Register ("getLoggerFactory", "()Lorg/slf4j/ILoggerFactory;", "GetGetLoggerFactoryHandler:Org.Slf4j.Spi.ILoggerFactoryBinderInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string LoggerFactoryClassStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.spi']/interface[@name='LoggerFactoryBinder']/method[@name='getLoggerFactoryClassStr' and count(parameter)=0]"
			[Register ("getLoggerFactoryClassStr", "()Ljava/lang/String;", "GetGetLoggerFactoryClassStrHandler:Org.Slf4j.Spi.ILoggerFactoryBinderInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/slf4j/spi/LoggerFactoryBinder", DoNotGenerateAcw=true)]
	internal partial class ILoggerFactoryBinderInvoker : global::Java.Lang.Object, ILoggerFactoryBinder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/spi/LoggerFactoryBinder", typeof (ILoggerFactoryBinderInvoker));

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

		public static ILoggerFactoryBinder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerFactoryBinder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.spi.LoggerFactoryBinder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerFactoryBinderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLoggerFactory;
#pragma warning disable 0169
		static Delegate GetGetLoggerFactoryHandler ()
		{
			if (cb_getLoggerFactory == null)
				cb_getLoggerFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggerFactory);
			return cb_getLoggerFactory;
		}

		static IntPtr n_GetLoggerFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILoggerFactoryBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoggerFactory);
		}
#pragma warning restore 0169

		IntPtr id_getLoggerFactory;
		public unsafe global::Org.Slf4j.ILoggerFactory LoggerFactory {
			get {
				if (id_getLoggerFactory == IntPtr.Zero)
					id_getLoggerFactory = JNIEnv.GetMethodID (class_ref, "getLoggerFactory", "()Lorg/slf4j/ILoggerFactory;");
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.ILoggerFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggerFactory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLoggerFactoryClassStr;
#pragma warning disable 0169
		static Delegate GetGetLoggerFactoryClassStrHandler ()
		{
			if (cb_getLoggerFactoryClassStr == null)
				cb_getLoggerFactoryClassStr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLoggerFactoryClassStr);
			return cb_getLoggerFactoryClassStr;
		}

		static IntPtr n_GetLoggerFactoryClassStr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Spi.ILoggerFactoryBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LoggerFactoryClassStr);
		}
#pragma warning restore 0169

		IntPtr id_getLoggerFactoryClassStr;
		public unsafe string LoggerFactoryClassStr {
			get {
				if (id_getLoggerFactoryClassStr == IntPtr.Zero)
					id_getLoggerFactoryClassStr = JNIEnv.GetMethodID (class_ref, "getLoggerFactoryClassStr", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggerFactoryClassStr), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
