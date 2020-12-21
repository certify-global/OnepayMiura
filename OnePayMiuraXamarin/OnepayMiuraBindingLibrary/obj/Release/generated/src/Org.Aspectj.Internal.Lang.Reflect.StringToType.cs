using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/StringToType", DoNotGenerateAcw=true)]
	public partial class StringToType : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/StringToType", typeof (StringToType));
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

		protected StringToType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/constructor[@name='StringToType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringToType ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/method[@name='commaSeparatedListToTypeArray' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register ("commaSeparatedListToTypeArray", "(Ljava/lang/String;Ljava/lang/Class;)[Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType[] CommaSeparatedListToTypeArray (string typeNames, global::Java.Lang.Class classScope)
		{
			const string __id = "commaSeparatedListToTypeArray.(Ljava/lang/String;Ljava/lang/Class;)[Ljava/lang/reflect/Type;";
			IntPtr native_typeNames = JNIEnv.NewString (typeNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_typeNames);
				__args [1] = new JniArgumentValue ((classScope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classScope).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Reflect.IType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.IType));
			} finally {
				JNIEnv.DeleteLocalRef (native_typeNames);
				global::System.GC.KeepAlive (classScope);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='StringToType']/method[@name='stringToType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register ("stringToType", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Type;", "")]
		public static unsafe global::Java.Lang.Reflect.IType InvokeStringToType (string typeName, global::Java.Lang.Class classScope)
		{
			const string __id = "stringToType.(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Type;";
			IntPtr native_typeName = JNIEnv.NewString (typeName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_typeName);
				__args [1] = new JniArgumentValue ((classScope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classScope).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_typeName);
				global::System.GC.KeepAlive (classScope);
			}
		}

	}
}
