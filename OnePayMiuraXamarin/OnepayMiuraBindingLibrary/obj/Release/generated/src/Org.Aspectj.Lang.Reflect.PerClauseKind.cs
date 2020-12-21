using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/PerClauseKind", DoNotGenerateAcw=true)]
	public sealed partial class PerClauseKind : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERCFLOW']"
		[Register ("PERCFLOW")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Percflow {
			get {
				const string __id = "PERCFLOW.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERCFLOWBELOW']"
		[Register ("PERCFLOWBELOW")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Percflowbelow {
			get {
				const string __id = "PERCFLOWBELOW.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTARGET']"
		[Register ("PERTARGET")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Pertarget {
			get {
				const string __id = "PERTARGET.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTHIS']"
		[Register ("PERTHIS")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Perthis {
			get {
				const string __id = "PERTHIS.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='PERTYPEWITHIN']"
		[Register ("PERTYPEWITHIN")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Pertypewithin {
			get {
				const string __id = "PERTYPEWITHIN.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/field[@name='SINGLETON']"
		[Register ("SINGLETON")]
		public static global::Org.Aspectj.Lang.Reflect.PerClauseKind Singleton {
			get {
				const string __id = "SINGLETON.Lorg/aspectj/lang/reflect/PerClauseKind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/PerClauseKind", typeof (PerClauseKind));
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

		internal PerClauseKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/PerClauseKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.PerClauseKind ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/PerClauseKind;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.PerClauseKind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='PerClauseKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/aspectj/lang/reflect/PerClauseKind;", "")]
		public static unsafe global::Org.Aspectj.Lang.Reflect.PerClauseKind[] Values ()
		{
			const string __id = "values.()[Lorg/aspectj/lang/reflect/PerClauseKind;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Aspectj.Lang.Reflect.PerClauseKind[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.PerClauseKind));
			} finally {
			}
		}

	}
}
