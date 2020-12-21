using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j']/class[@name='MarkerFactory']"
	[global::Android.Runtime.Register ("org/slf4j/MarkerFactory", DoNotGenerateAcw=true)]
	public partial class MarkerFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/MarkerFactory", typeof (MarkerFactory));
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

		protected MarkerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Org.Slf4j.IMarkerFactory IMarkerFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MarkerFactory']/method[@name='getIMarkerFactory' and count(parameter)=0]"
			[Register ("getIMarkerFactory", "()Lorg/slf4j/IMarkerFactory;", "")]
			get {
				const string __id = "getIMarkerFactory.()Lorg/slf4j/IMarkerFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarkerFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MarkerFactory']/method[@name='getDetachedMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetachedMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "")]
		public static unsafe global::Org.Slf4j.IMarker GetDetachedMarker (string name)
		{
			const string __id = "getDetachedMarker.(Ljava/lang/String;)Lorg/slf4j/Marker;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/class[@name='MarkerFactory']/method[@name='getMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMarker", "(Ljava/lang/String;)Lorg/slf4j/Marker;", "")]
		public static unsafe global::Org.Slf4j.IMarker GetMarker (string name)
		{
			const string __id = "getMarker.(Ljava/lang/String;)Lorg/slf4j/Marker;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
