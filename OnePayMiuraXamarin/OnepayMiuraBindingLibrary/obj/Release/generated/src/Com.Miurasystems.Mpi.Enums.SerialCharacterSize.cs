using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/SerialCharacterSize", DoNotGenerateAcw=true)]
	public sealed partial class SerialCharacterSize : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/field[@name='SERIAL_CHARACTER_SIZE_5']"
		[Register ("SERIAL_CHARACTER_SIZE_5")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize SerialCharacterSize5 {
			get {
				const string __id = "SERIAL_CHARACTER_SIZE_5.Lcom/miurasystems/mpi/enums/SerialCharacterSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/field[@name='SERIAL_CHARACTER_SIZE_6']"
		[Register ("SERIAL_CHARACTER_SIZE_6")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize SerialCharacterSize6 {
			get {
				const string __id = "SERIAL_CHARACTER_SIZE_6.Lcom/miurasystems/mpi/enums/SerialCharacterSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/field[@name='SERIAL_CHARACTER_SIZE_7']"
		[Register ("SERIAL_CHARACTER_SIZE_7")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize SerialCharacterSize7 {
			get {
				const string __id = "SERIAL_CHARACTER_SIZE_7.Lcom/miurasystems/mpi/enums/SerialCharacterSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/field[@name='SERIAL_CHARACTER_SIZE_8']"
		[Register ("SERIAL_CHARACTER_SIZE_8")]
		public static global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize SerialCharacterSize8 {
			get {
				const string __id = "SERIAL_CHARACTER_SIZE_8.Lcom/miurasystems/mpi/enums/SerialCharacterSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/SerialCharacterSize", typeof (SerialCharacterSize));
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

		internal SerialCharacterSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe sbyte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()B", "")]
			get {
				const string __id = "getValue.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SerialCharacterSize;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SerialCharacterSize;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SerialCharacterSize']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/SerialCharacterSize;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/SerialCharacterSize;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.SerialCharacterSize));
			} finally {
			}
		}

	}
}
