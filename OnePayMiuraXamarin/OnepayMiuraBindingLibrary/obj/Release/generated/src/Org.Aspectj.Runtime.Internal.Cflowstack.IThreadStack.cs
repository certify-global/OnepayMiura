using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStack']"
	[Register ("org/aspectj/runtime/internal/cflowstack/ThreadStack", "", "Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackInvoker")]
	public partial interface IThreadStack : IJavaObject, IJavaPeerable {

		global::Java.Util.Stack ThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStack']/method[@name='getThreadStack' and count(parameter)=0]"
			[Register ("getThreadStack", "()Ljava/util/Stack;", "GetGetThreadStackHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/interface[@name='ThreadStack']/method[@name='removeThreadStack' and count(parameter)=0]"
		[Register ("removeThreadStack", "()V", "GetRemoveThreadStackHandler:Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStackInvoker, OnepayMiuraBindingLibrary")]
		void RemoveThreadStack ();

	}

	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStack", DoNotGenerateAcw=true)]
	internal partial class IThreadStackInvoker : global::Java.Lang.Object, IThreadStack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/cflowstack/ThreadStack", typeof (IThreadStackInvoker));

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

		public static IThreadStack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThreadStack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.runtime.internal.cflowstack.ThreadStack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThreadStackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getThreadStack;
#pragma warning disable 0169
		static Delegate GetGetThreadStackHandler ()
		{
			if (cb_getThreadStack == null)
				cb_getThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThreadStack);
			return cb_getThreadStack;
		}

		static IntPtr n_GetThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadStack);
		}
#pragma warning restore 0169

		IntPtr id_getThreadStack;
		public unsafe global::Java.Util.Stack ThreadStack {
			get {
				if (id_getThreadStack == IntPtr.Zero)
					id_getThreadStack = JNIEnv.GetMethodID (class_ref, "getThreadStack", "()Ljava/util/Stack;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Stack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThreadStack), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_removeThreadStack;
#pragma warning disable 0169
		static Delegate GetRemoveThreadStackHandler ()
		{
			if (cb_removeThreadStack == null)
				cb_removeThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadStack);
			return cb_removeThreadStack;
		}

		static void n_RemoveThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadStack ();
		}
#pragma warning restore 0169

		IntPtr id_removeThreadStack;
		public unsafe void RemoveThreadStack ()
		{
			if (id_removeThreadStack == IntPtr.Zero)
				id_removeThreadStack = JNIEnv.GetMethodID (class_ref, "removeThreadStack", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeThreadStack);
		}

	}

}
