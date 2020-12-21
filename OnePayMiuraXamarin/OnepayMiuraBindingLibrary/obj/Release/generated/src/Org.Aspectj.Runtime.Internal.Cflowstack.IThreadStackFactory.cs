using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStackFactory']"
	[Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactory", "", "Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactoryInvoker")]
	public partial interface IThreadStackFactory : IJavaObject, IJavaPeerable {

		global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter NewThreadCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStackFactory']/method[@name='getNewThreadCounter' and count(parameter)=0]"
			[Register ("getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;", "GetGetNewThreadCounterHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactoryInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack NewThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStackFactory']/method[@name='getNewThreadStack' and count(parameter)=0]"
			[Register ("getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;", "GetGetNewThreadStackHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactoryInvoker, OnepayMiuraBindingLibrary")] get;
		}

	}

	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactory", DoNotGenerateAcw=true)]
	internal partial class IThreadStackFactoryInvoker : global::Java.Lang.Object, IThreadStackFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadStackFactory", typeof (IThreadStackFactoryInvoker));

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

		public static IThreadStackFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadStackFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.runtime.internal.cflowstack.ThreadStackFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadStackFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getNewThreadCounter;
#pragma warning disable 0169
		static Delegate GetGetNewThreadCounterHandler ()
		{
			if (cb_getNewThreadCounter == null)
				cb_getNewThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadCounter);
			return cb_getNewThreadCounter;
		}

		static IntPtr n_GetNewThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadCounter);
		}
#pragma warning restore 0169

		IntPtr id_getNewThreadCounter;
		public unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter NewThreadCounter {
			get {
				if (id_getNewThreadCounter == IntPtr.Zero)
					id_getNewThreadCounter = JNIEnv.GetMethodID (class_ref, "getNewThreadCounter", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadCounter;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewThreadCounter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNewThreadStack;
#pragma warning disable 0169
		static Delegate GetGetNewThreadStackHandler ()
		{
			if (cb_getNewThreadStack == null)
				cb_getNewThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNewThreadStack);
			return cb_getNewThreadStack;
		}

		static IntPtr n_GetNewThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewThreadStack);
		}
#pragma warning restore 0169

		IntPtr id_getNewThreadStack;
		public unsafe global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack NewThreadStack {
			get {
				if (id_getNewThreadStack == IntPtr.Zero)
					id_getNewThreadStack = JNIEnv.GetMethodID (class_ref, "getNewThreadStack", "()Lorg/aspectj/runtime/internal/cflowstack/ThreadStack;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewThreadStack), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
