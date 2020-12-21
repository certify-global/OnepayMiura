using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ServiceCode", DoNotGenerateAcw=true)]
	public partial class ServiceCode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit", DoNotGenerateAcw=true)]
		public sealed partial class ServiceCodeFirstDigit : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='InternationalInterchange']"
			[Register ("InternationalInterchange")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit InternationalInterchange {
				get {
					const string __id = "InternationalInterchange.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='InternationalInterchange_UseIC']"
			[Register ("InternationalInterchange_UseIC")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit InternationalInterchangeUseIC {
				get {
					const string __id = "InternationalInterchange_UseIC.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='NationalInterchangeOnly']"
			[Register ("NationalInterchangeOnly")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit NationalInterchangeOnly {
				get {
					const string __id = "NationalInterchangeOnly.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='NationalInterchangeOnly_UseIC']"
			[Register ("NationalInterchangeOnly_UseIC")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit NationalInterchangeOnlyUseIC {
				get {
					const string __id = "NationalInterchangeOnly_UseIC.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='NoInterchange']"
			[Register ("NoInterchange")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit NoInterchange {
				get {
					const string __id = "NoInterchange.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/field[@name='Test']"
			[Register ("Test")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit Test {
				get {
					const string __id = "Test.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit", typeof (ServiceCodeFirstDigit));
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

			internal ServiceCodeFirstDigit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getByValue", "(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit GetByValue (int value)
			{
				const string __id = "getByValue.(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeFirstDigit']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit[] Values ()
			{
				const string __id = "values.()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit", DoNotGenerateAcw=true)]
		public sealed partial class ServiceCodeSecondDigit : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/field[@name='AuthorizedOnline']"
			[Register ("AuthorizedOnline")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit AuthorizedOnline {
				get {
					const string __id = "AuthorizedOnline.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/field[@name='AuthorizedOnlineExceptBilateralAgreement']"
			[Register ("AuthorizedOnlineExceptBilateralAgreement")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit AuthorizedOnlineExceptBilateralAgreement {
				get {
					const string __id = "AuthorizedOnlineExceptBilateralAgreement.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/field[@name='Normal']"
			[Register ("Normal")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit Normal {
				get {
					const string __id = "Normal.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit", typeof (ServiceCodeSecondDigit));
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

			internal ServiceCodeSecondDigit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getByValue", "(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit GetByValue (int value)
			{
				const string __id = "getByValue.(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeSecondDigit']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit[] Values ()
			{
				const string __id = "values.()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit", DoNotGenerateAcw=true)]
		public sealed partial class ServiceCodeThirdDigit : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='ATMOnly_PINRequired']"
			[Register ("ATMOnly_PINRequired")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit ATMOnlyPINRequired {
				get {
					const string __id = "ATMOnly_PINRequired.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='CashOnly']"
			[Register ("CashOnly")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit CashOnly {
				get {
					const string __id = "CashOnly.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='GoodsAndServicesOnly_NoCash']"
			[Register ("GoodsAndServicesOnly_NoCash")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit GoodsAndServicesOnlyNoCash {
				get {
					const string __id = "GoodsAndServicesOnly_NoCash.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='GoodsAndServicesOnly_NoCash_PINOptional']"
			[Register ("GoodsAndServicesOnly_NoCash_PINOptional")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit GoodsAndServicesOnlyNoCashPINOptional {
				get {
					const string __id = "GoodsAndServicesOnly_NoCash_PINOptional.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='GoodsAndServicesOnly_NoCash_PINRequired']"
			[Register ("GoodsAndServicesOnly_NoCash_PINRequired")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit GoodsAndServicesOnlyNoCashPINRequired {
				get {
					const string __id = "GoodsAndServicesOnly_NoCash_PINRequired.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='NoRestrictions']"
			[Register ("NoRestrictions")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit NoRestrictions {
				get {
					const string __id = "NoRestrictions.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='NoRestrictions_PINOptional']"
			[Register ("NoRestrictions_PINOptional")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit NoRestrictionsPINOptional {
				get {
					const string __id = "NoRestrictions_PINOptional.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/field[@name='NoRestrictions_PINRequired']"
			[Register ("NoRestrictions_PINRequired")]
			public static global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit NoRestrictionsPINRequired {
				get {
					const string __id = "NoRestrictions_PINRequired.Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit", typeof (ServiceCodeThirdDigit));
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

			internal ServiceCodeThirdDigit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/method[@name='getByValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getByValue", "(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit GetByValue (int value)
			{
				const string __id = "getByValue.(I)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode.ServiceCodeThirdDigit']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit[] Values ()
			{
				const string __id = "values.()[Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/ServiceCode", typeof (ServiceCode));
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

		protected ServiceCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']/constructor[@name='ServiceCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ServiceCode (string serviceCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serviceCode = JNIEnv.NewString (serviceCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serviceCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serviceCode);
			}
		}

		static Delegate cb_getFirstDigit;
#pragma warning disable 0169
		static Delegate GetGetFirstDigitHandler ()
		{
			if (cb_getFirstDigit == null)
				cb_getFirstDigit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstDigit);
			return cb_getFirstDigit;
		}

		static IntPtr n_GetFirstDigit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstDigit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit FirstDigit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']/method[@name='getFirstDigit' and count(parameter)=0]"
			[Register ("getFirstDigit", "()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;", "GetGetFirstDigitHandler")]
			get {
				const string __id = "getFirstDigit.()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeFirstDigit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeFirstDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecondDigit;
#pragma warning disable 0169
		static Delegate GetGetSecondDigitHandler ()
		{
			if (cb_getSecondDigit == null)
				cb_getSecondDigit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecondDigit);
			return cb_getSecondDigit;
		}

		static IntPtr n_GetSecondDigit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SecondDigit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit SecondDigit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']/method[@name='getSecondDigit' and count(parameter)=0]"
			[Register ("getSecondDigit", "()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;", "GetGetSecondDigitHandler")]
			get {
				const string __id = "getSecondDigit.()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeSecondDigit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeSecondDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThirdDigit;
#pragma warning disable 0169
		static Delegate GetGetThirdDigitHandler ()
		{
			if (cb_getThirdDigit == null)
				cb_getThirdDigit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThirdDigit);
			return cb_getThirdDigit;
		}

		static IntPtr n_GetThirdDigit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThirdDigit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit ThirdDigit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']/method[@name='getThirdDigit' and count(parameter)=0]"
			[Register ("getThirdDigit", "()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;", "GetGetThirdDigitHandler")]
			get {
				const string __id = "getThirdDigit.()Lcom/miurasystems/mpi/enums/ServiceCode$ServiceCodeThirdDigit;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode.ServiceCodeThirdDigit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceCode;
#pragma warning disable 0169
		static Delegate GetGetServiceCodeHandler ()
		{
			if (cb_getServiceCode == null)
				cb_getServiceCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceCode);
			return cb_getServiceCode;
		}

		static IntPtr n_GetServiceCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.ServiceCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetServiceCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='ServiceCode']/method[@name='getServiceCode' and count(parameter)=0]"
		[Register ("getServiceCode", "()Ljava/lang/String;", "GetGetServiceCodeHandler")]
		public virtual unsafe string GetServiceCode ()
		{
			const string __id = "getServiceCode.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
