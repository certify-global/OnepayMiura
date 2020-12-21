using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']"
	[global::Android.Runtime.Register ("org/aspectj/lang/Aspects", DoNotGenerateAcw=true)]
	public partial class Aspects : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/Aspects", typeof (Aspects));
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

		protected Aspects (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/constructor[@name='Aspects' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Aspects ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='aspectOf' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("aspectOf", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Class perTypeWithin)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perTypeWithin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perTypeWithin).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perTypeWithin);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='aspectOf' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("aspectOf", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AspectOf (global::Java.Lang.Class aspectClass, global::Java.Lang.Object perObject)
		{
			const string __id = "aspectOf.(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((aspectClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) aspectClass).Handle);
				__args [1] = new JniArgumentValue ((perObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) perObject).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (aspectClass);
				global::System.GC.KeepAlive (perObject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='hasAspect' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang']/class[@name='Aspects']/method[@name='hasAspect' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
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
