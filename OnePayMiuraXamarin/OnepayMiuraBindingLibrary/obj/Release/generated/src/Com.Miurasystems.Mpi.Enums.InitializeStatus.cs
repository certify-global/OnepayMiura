using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/InitializeStatus", DoNotGenerateAcw=true)]
	public sealed partial class InitializeStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='readProd']"
		[Register ("readProd")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus ReadProd {
			get {
				const string __id = "readProd.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='readSuggested']"
		[Register ("readSuggested")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus ReadSuggested {
			get {
				const string __id = "readSuggested.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='readTemp']"
		[Register ("readTemp")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus ReadTemp {
			get {
				const string __id = "readTemp.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='readTerminal']"
		[Register ("readTerminal")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus ReadTerminal {
			get {
				const string __id = "readTerminal.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='selectProd']"
		[Register ("selectProd")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus SelectProd {
			get {
				const string __id = "selectProd.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='selectSuggested']"
		[Register ("selectSuggested")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus SelectSuggested {
			get {
				const string __id = "selectSuggested.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='selectTemp']"
		[Register ("selectTemp")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus SelectTemp {
			get {
				const string __id = "selectTemp.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/field[@name='selectTerminal']"
		[Register ("selectTerminal")]
		public static global::Com.Miurasystems.Mpi.Enums.InitializeStatus SelectTerminal {
			get {
				const string __id = "selectTerminal.Lcom/miurasystems/mpi/enums/InitializeStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/InitializeStatus", typeof (InitializeStatus));
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

		internal InitializeStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/InitializeStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.InitializeStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/InitializeStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.InitializeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='InitializeStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/InitializeStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.InitializeStatus[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/InitializeStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.InitializeStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.InitializeStatus));
			} finally {
			}
		}

	}
}
