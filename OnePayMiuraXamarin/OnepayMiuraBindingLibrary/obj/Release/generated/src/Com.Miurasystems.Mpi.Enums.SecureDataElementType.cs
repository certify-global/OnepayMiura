using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/enums/SecureDataElementType", DoNotGenerateAcw=true)]
	public sealed partial class SecureDataElementType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='Cvv']"
		[Register ("Cvv")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType Cvv {
			get {
				const string __id = "Cvv.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='ExpiryDateMmYy']"
		[Register ("ExpiryDateMmYy")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType ExpiryDateMmYy {
			get {
				const string __id = "ExpiryDateMmYy.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='ExpiryDateYyMm']"
		[Register ("ExpiryDateYyMm")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType ExpiryDateYyMm {
			get {
				const string __id = "ExpiryDateYyMm.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='Pan']"
		[Register ("Pan")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType Pan {
			get {
				const string __id = "Pan.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='StartDateMmYy']"
		[Register ("StartDateMmYy")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType StartDateMmYy {
			get {
				const string __id = "StartDateMmYy.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/field[@name='StartDateYyMm']"
		[Register ("StartDateYyMm")]
		public static global::Com.Miurasystems.Mpi.Enums.SecureDataElementType StartDateYyMm {
			get {
				const string __id = "StartDateYyMm.Lcom/miurasystems/mpi/enums/SecureDataElementType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/enums/SecureDataElementType", typeof (SecureDataElementType));
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

		internal SecureDataElementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecureDataE0' and count(parameter)=0]"
		[Register ("toGetSecureDataE0", "()Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecureDataE0 ()
		{
			const string __id = "toGetSecureDataE0.()Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecureDataE0' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("toGetSecureDataE0", "(Ljava/lang/Integer;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecureDataE0 (global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "toGetSecureDataE0.(Ljava/lang/Integer;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecureDataE0' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("toGetSecureDataE0", "(Ljava/lang/Integer;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecureDataE0 (global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Tlv.TLVObject tlvCommandOptions)
		{
			const string __id = "toGetSecureDataE0.(Ljava/lang/Integer;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [1] = new JniArgumentValue ((tlvCommandOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlvCommandOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (tlvCommandOptions);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecurePanE0' and count(parameter)=0]"
		[Register ("toGetSecurePanE0", "()Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecurePanE0 ()
		{
			const string __id = "toGetSecurePanE0.()Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecurePanE0' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("toGetSecurePanE0", "(Ljava/lang/Integer;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecurePanE0 (global::Java.Lang.Integer timeoutInSeconds)
		{
			const string __id = "toGetSecurePanE0.(Ljava/lang/Integer;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeoutInSeconds);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='toGetSecurePanE0' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.miurasystems.mpi.tlv.TLVObject']]"
		[Register ("toGetSecurePanE0", "(Ljava/lang/Integer;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/TLVObject;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Tlv.TLVObject ToGetSecurePanE0 (global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Tlv.TLVObject tlvCommandOptions)
		{
			const string __id = "toGetSecurePanE0.(Ljava/lang/Integer;Lcom/miurasystems/mpi/tlv/TLVObject;)Lcom/miurasystems/mpi/tlv/TLVObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [1] = new JniArgumentValue ((tlvCommandOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlvCommandOptions).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (tlvCommandOptions);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SecureDataElementType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SecureDataElementType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/enums/SecureDataElementType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.SecureDataElementType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.enums']/class[@name='SecureDataElementType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/miurasystems/mpi/enums/SecureDataElementType;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Enums.SecureDataElementType[] Values ()
		{
			const string __id = "values.()[Lcom/miurasystems/mpi/enums/SecureDataElementType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Miurasystems.Mpi.Enums.SecureDataElementType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Enums.SecureDataElementType));
			} finally {
			}
		}

	}
}
