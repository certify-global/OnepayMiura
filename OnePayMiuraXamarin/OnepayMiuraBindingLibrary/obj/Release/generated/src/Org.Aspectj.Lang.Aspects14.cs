using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']"
	[global::Android.Runtime.Register ("org/aspectj/lang/Aspects14", DoNotGenerateAcw=true)]
	public partial class Aspects14 : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/Aspects14", typeof (Aspects14));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Aspects14 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/constructor[@name='Aspects14' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Aspects14 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("aspectOf", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Class perTypeWithin)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perTypeWithin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perTypeWithin).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perTypeWithin);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Object']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Object perObject)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perObject).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("hasAspect", "(Ljava/lang/Class;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass)
		{
			const string __id = "hasAspect.(Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (aspectClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class']]"
		[Register ("hasAspect", "(Ljava/lang/Class;Ljava/lang/Class;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass, global::Java.Lang.Class perTypeWithin)
		{
			const string __id = "hasAspect.(Ljava/lang/Class;Ljava/lang/Class;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perTypeWithin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perTypeWithin).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perTypeWithin);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects14']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Object']]"
		[Register ("hasAspect", "(Ljava/lang/Class;Ljava/lang/Object;)Z", "")]
		public static unsafe bool HasAspect (global::Java.Lang.Class aspectClass, global::Java.Lang.Object perObject)
		{
			const string __id = "hasAspect.(Ljava/lang/Class;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perObject).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perObject);
			}
		}

	}
}
