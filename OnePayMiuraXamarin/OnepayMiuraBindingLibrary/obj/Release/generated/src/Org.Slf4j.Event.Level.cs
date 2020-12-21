using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']"
	[global::Android.Runtime.Register ("org/slf4j/event/Level", DoNotGenerateAcw=true)]
	public sealed partial class Level : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Org.Slf4j.Event.Level Debug {
			get {
				const string __id = "DEBUG.Lorg/slf4j/event/Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Org.Slf4j.Event.Level Error {
			get {
				const string __id = "ERROR.Lorg/slf4j/event/Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Org.Slf4j.Event.Level Info {
			get {
				const string __id = "INFO.Lorg/slf4j/event/Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/field[@name='TRACE']"
		[Register ("TRACE")]
		public static global::Org.Slf4j.Event.Level Trace {
			get {
				const string __id = "TRACE.Lorg/slf4j/event/Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/field[@name='WARN']"
		[Register ("WARN")]
		public static global::Org.Slf4j.Event.Level Warn {
			get {
				const string __id = "WARN.Lorg/slf4j/event/Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/event/Level", typeof (Level));
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

		internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/method[@name='toInt' and count(parameter)=0]"
		[Register ("toInt", "()I", "")]
		public unsafe int ToInt ()
		{
			const string __id = "toInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/slf4j/event/Level;", "")]
		public static unsafe global::Org.Slf4j.Event.Level ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/slf4j/event/Level;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.Event.Level> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.event']/class[@name='Level']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/slf4j/event/Level;", "")]
		public static unsafe global::Org.Slf4j.Event.Level[] Values ()
		{
			const string __id = "values.()[Lorg/slf4j/event/Level;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Slf4j.Event.Level[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Slf4j.Event.Level));
			} finally {
			}
		}

	}
}
