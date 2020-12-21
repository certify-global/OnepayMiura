using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AdviceKind", DoNotGenerateAcw=true)]
	public sealed partial class AdviceKind : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER']"
		[Register ("AFTER")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind After {
			get {
				const string __id = "AFTER.Lorg/aspectj/lang/reflect/AdviceKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER_RETURNING']"
		[Register ("AFTER_RETURNING")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind AfterReturning {
			get {
				const string __id = "AFTER_RETURNING.Lorg/aspectj/lang/reflect/AdviceKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AFTER_THROWING']"
		[Register ("AFTER_THROWING")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind AfterThrowing {
			get {
				const string __id = "AFTER_THROWING.Lorg/aspectj/lang/reflect/AdviceKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='AROUND']"
		[Register ("AROUND")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind Around {
			get {
				const string __id = "AROUND.Lorg/aspectj/lang/reflect/AdviceKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/field[@name='BEFORE']"
		[Register ("BEFORE")]
		public static global::Org.Aspectj.Lang.Reflect.AdviceKind Before {
			get {
				const string __id = "BEFORE.Lorg/aspectj/lang/reflect/AdviceKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/AdviceKind", typeof (AdviceKind));
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

		internal AdviceKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceKind;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.AdviceKind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AdviceKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/aspectj/lang/reflect/AdviceKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.AdviceKind[] Values ()
		{
			const string __id = "values.()[Lorg/aspectj/lang/reflect/AdviceKind;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			} finally {
			}
		}

	}
}
