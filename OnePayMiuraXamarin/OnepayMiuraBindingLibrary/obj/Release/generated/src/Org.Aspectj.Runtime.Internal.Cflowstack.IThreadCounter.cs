using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadCounter']"
	[Register ("org/aspectj/runtime/internal/cflowstack/ThreadCounter", "", "Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounterInvoker")]
	public partial interface IThreadCounter : IJavaObject, IJavaPeerable {

		bool IsNotZero {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadCounter']/method[@name='isNotZero' and count(parameter)=0]"
			[Register ("isNotZero", "()Z", "GetIsNotZeroHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounterInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadCounter']/method[@name='dec' and count(parameter)=0]"
		[Register ("dec", "()V", "GetDecHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounterInvoker, OnepayMiuraBindingLibrary")]
		void Dec ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadCounter']/method[@name='inc' and count(parameter)=0]"
		[Register ("inc", "()V", "GetIncHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounterInvoker, OnepayMiuraBindingLibrary")]
		void Inc ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadCounter']/method[@name='removeThreadCounter' and count(parameter)=0]"
		[Register ("removeThreadCounter", "()V", "GetRemoveThreadCounterHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounterInvoker, OnepayMiuraBindingLibrary")]
		void RemoveThreadCounter ();

	}

	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadCounter", DoNotGenerateAcw=true)]
	internal partial class IThreadCounterInvoker : global::Java.Lang.Object, IThreadCounter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadCounter", typeof (IThreadCounterInvoker));

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

		public static IThreadCounter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadCounter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.runtime.internal.cflowstack.ThreadCounter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadCounterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isNotZero;
#pragma warning disable 0169
		static Delegate GetIsNotZeroHandler ()
		{
			if (cb_isNotZero == null)
				cb_isNotZero = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNotZero);
			return cb_isNotZero;
		}

		static bool n_IsNotZero (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotZero;
		}
#pragma warning restore 0169

		IntPtr id_isNotZero;
		public unsafe bool IsNotZero {
			get {
				if (id_isNotZero == IntPtr.Zero)
					id_isNotZero = JNIEnv.GetMethodID (class_ref, "isNotZero", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotZero);
			}
		}

		static Delegate cb_dec;
#pragma warning disable 0169
		static Delegate GetDecHandler ()
		{
			if (cb_dec == null)
				cb_dec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dec);
			return cb_dec;
		}

		static void n_Dec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dec ();
		}
#pragma warning restore 0169

		IntPtr id_dec;
		public unsafe void Dec ()
		{
			if (id_dec == IntPtr.Zero)
				id_dec = JNIEnv.GetMethodID (class_ref, "dec", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dec);
		}

		static Delegate cb_inc;
#pragma warning disable 0169
		static Delegate GetIncHandler ()
		{
			if (cb_inc == null)
				cb_inc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Inc);
			return cb_inc;
		}

		static void n_Inc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inc ();
		}
#pragma warning restore 0169

		IntPtr id_inc;
		public unsafe void Inc ()
		{
			if (id_inc == IntPtr.Zero)
				id_inc = JNIEnv.GetMethodID (class_ref, "inc", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inc);
		}

		static Delegate cb_removeThreadCounter;
#pragma warning disable 0169
		static Delegate GetRemoveThreadCounterHandler ()
		{
			if (cb_removeThreadCounter == null)
				cb_removeThreadCounter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadCounter);
			return cb_removeThreadCounter;
		}

		static void n_RemoveThreadCounter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadCounter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadCounter ();
		}
#pragma warning restore 0169

		IntPtr id_removeThreadCounter;
		public unsafe void RemoveThreadCounter ()
		{
			if (id_removeThreadCounter == IntPtr.Zero)
				id_removeThreadCounter = JNIEnv.GetMethodID (class_ref, "removeThreadCounter", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeThreadCounter);
		}

	}

}
