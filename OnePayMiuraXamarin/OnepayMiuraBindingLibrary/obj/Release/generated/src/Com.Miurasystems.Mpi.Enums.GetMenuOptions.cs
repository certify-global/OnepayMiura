using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/GetMenuOptions", DoNotGenerateAcw=true)]
	public sealed partial class GetMenuOptions : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='EnlargeBottomRow']"
		[Register ("EnlargeBottomRow")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions EnlargeBottomRow {
			get {
				const string __id = "EnlargeBottomRow.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='EnlargeTitleRow']"
		[Register ("EnlargeTitleRow")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions EnlargeTitleRow {
			get {
				const string __id = "EnlargeTitleRow.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='EventMonitoring']"
		[Register ("EventMonitoring")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions EventMonitoring {
			get {
				const string __id = "EventMonitoring.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='HideBottomRow']"
		[Register ("HideBottomRow")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions HideBottomRow {
			get {
				const string __id = "HideBottomRow.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='HideTitleRow']"
		[Register ("HideTitleRow")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions HideTitleRow {
			get {
				const string __id = "HideTitleRow.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/field[@name='ShowStatusBar']"
		[Register ("ShowStatusBar")]
		public static global::Com.Miurasystems.Mpi.Enums.GetMenuOptions ShowStatusBar {
			get {
				const string __id = "ShowStatusBar.Lcom/miurasystems/mpi/enums/GetMenuOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/GetMenuOptions", typeof (GetMenuOptions));
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

		internal GetMenuOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/method[@name='makeOptionsSet' and count(parameter)=0]"
		[Register ("makeOptionsSet", "()Ljava/util/EnumSet;", "")]
		public static unsafe global::Java.Util.EnumSet MakeOptionsSet ()
		{
			const string __id = "makeOptionsSet.()Ljava/util/EnumSet;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/method[@name='makeOptionsSet' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.GetMenuOptions'] and parameter[2][@type='com.miurasystems.mpi.enums.GetMenuOptions...']]"
		[Register ("makeOptionsSet", "(Lcom/miurasystems/mpi/enums/GetMenuOptions;[Lcom/miurasystems/mpi/enums/GetMenuOptions;)Ljava/util/EnumSet;", "")]
		public static unsafe global::Java.Util.EnumSet MakeOptionsSet (global::Com.Miurasystems.Mpi.Enums.GetMenuOptions first, params global::Com.Miurasystems.Mpi.Enums.GetMenuOptions[] rest)
		{
			const string __id = "makeOptionsSet.(Lcom/miurasystems/mpi/enums/GetMenuOptions;[Lcom/miurasystems/mpi/enums/GetMenuOptions;)Ljava/util/EnumSet;";
			IntPtr native_rest = JNIEnv.NewArray (rest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue (native_rest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (rest != null) {
					JNIEnv.CopyArray (native_rest, rest);
					JNIEnv.DeleteLocalRef (native_rest);
				}
				global::System.GC.KeepAlive (first);
				global::System.GC.KeepAlive (rest);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/method[@name='makeOptionsSet' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetMenuOptions&gt;']]"
		[Register ("makeOptionsSet", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;", "")]
		public static unsafe global::Java.Util.EnumSet MakeOptionsSet (global::Java.Util.EnumSet from)
		{
			const string __id = "makeOptionsSet.(Ljava/util/EnumSet;)Ljava/util/EnumSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (from);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetMenuOptions;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetMenuOptions ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/GetMenuOptions;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.GetMenuOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='GetMenuOptions']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/GetMenuOptions;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.GetMenuOptions[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/GetMenuOptions;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.GetMenuOptions[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.GetMenuOptions));
			} finally {
			}
		}

	}
}
