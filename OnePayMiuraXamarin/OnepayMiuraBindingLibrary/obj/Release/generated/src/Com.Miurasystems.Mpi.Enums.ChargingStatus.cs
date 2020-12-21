using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ChargingStatus", DoNotGenerateAcw=true)]
	public sealed partial class ChargingStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='ChargeError']"
		[Register ("ChargeError")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus ChargeError {
			get {
				const string __id = "ChargeError.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='ChargeTimerExpired']"
		[Register ("ChargeTimerExpired")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus ChargeTimerExpired {
			get {
				const string __id = "ChargeTimerExpired.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='Charged']"
		[Register ("Charged")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus Charged {
			get {
				const string __id = "Charged.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='Charging']"
		[Register ("Charging")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus Charging {
			get {
				const string __id = "Charging.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='OnBattery']"
		[Register ("OnBattery")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus OnBattery {
			get {
				const string __id = "OnBattery.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/field[@name='UnhandledValue']"
		[Register ("UnhandledValue")]
		public static global::Com.Miurasystems.Mpi.Enums.ChargingStatus UnhandledValue {
			get {
				const string __id = "UnhandledValue.Lcom/miurasystems/mpi/enums/ChargingStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ChargingStatus", typeof (ChargingStatus));
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

		internal ChargingStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe sbyte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getByValue", "(B)Lcom/miurasystems/mpi/enums/ChargingStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ChargingStatus GetByValue (sbyte value)
		{
			const string __id = "getByValue.(B)Lcom/miurasystems/mpi/enums/ChargingStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ChargingStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ChargingStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ChargingStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ChargingStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ChargingStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/ChargingStatus;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.ChargingStatus[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/ChargingStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.ChargingStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ChargingStatus));
			} finally {
			}
		}

	}
}
