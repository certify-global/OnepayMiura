using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/TLVObject", DoNotGenerateAcw=true)]
	public partial class TLVObject : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/field[@name='constructedTLVObject']"
		[Register ("constructedTLVObject")]
		public global::System.Collections.IList ConstructedTLVObject {
			get {
				const string __id = "constructedTLVObject.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "constructedTLVObject.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/TLVObject", typeof (TLVObject));
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

		protected TLVObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/constructor[@name='TLVObject' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.tlv.Description'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/Description;[B)V", "")]
		public unsafe TLVObject (global::Com.Miurasystems.Mpi.Tlv.Description tag, byte[] rawData)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/Description;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawData = JNIEnv.NewArray (rawData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [1] = new JniArgumentValue (native_rawData);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rawData != null) {
					JNIEnv.CopyArray (native_rawData, rawData);
					JNIEnv.DeleteLocalRef (native_rawData);
				}
				global::System.GC.KeepAlive (tag);
				global::System.GC.KeepAlive (rawData);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/constructor[@name='TLVObject' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.tlv.Description'] and parameter[2][@type='java.util.List&lt;com.miurasystems.mpi.tlv.TLVObject&gt;']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/Description;Ljava/util/List;)V", "")]
		public unsafe TLVObject (global::Com.Miurasystems.Mpi.Tlv.Description tag, global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> constructed)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/Description;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_constructed = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (constructed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [1] = new JniArgumentValue (native_constructed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_constructed);
				global::System.GC.KeepAlive (tag);
				global::System.GC.KeepAlive (constructed);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/constructor[@name='TLVObject' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.tlv.Tag'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/Tag;[B)V", "")]
		public unsafe TLVObject (global::Com.Miurasystems.Mpi.Tlv.Tag tag, byte[] rawData)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/Tag;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawData = JNIEnv.NewArray (rawData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [1] = new JniArgumentValue (native_rawData);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (rawData != null) {
					JNIEnv.CopyArray (native_rawData, rawData);
					JNIEnv.DeleteLocalRef (native_rawData);
				}
				global::System.GC.KeepAlive (tag);
				global::System.GC.KeepAlive (rawData);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/constructor[@name='TLVObject' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.tlv.Tag'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/miurasystems/mpi/tlv/Tag;Ljava/lang/String;)V", "")]
		public unsafe TLVObject (global::Com.Miurasystems.Mpi.Tlv.Tag tag, string data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/miurasystems/mpi/tlv/Tag;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewString (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [1] = new JniArgumentValue (native_data);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (tag);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/constructor[@name='TLVObject' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.miurasystems.mpi.tlv.Tag'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(ILcom/miurasystems/mpi/tlv/Tag;III)V", "")]
		public unsafe TLVObject (int topTag, global::Com.Miurasystems.Mpi.Tlv.Tag tag, int tLength, int vLength, int lLength)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/miurasystems/mpi/tlv/Tag;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (topTag);
				__args [1] = new JniArgumentValue ((tag == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tag).Handle);
				__args [2] = new JniArgumentValue (tLength);
				__args [3] = new JniArgumentValue (vLength);
				__args [4] = new JniArgumentValue (lLength);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tag);
			}
		}

		static Delegate cb_getConstructedTLVLength;
#pragma warning disable 0169
		static Delegate GetGetConstructedTLVLengthHandler ()
		{
			if (cb_getConstructedTLVLength == null)
				cb_getConstructedTLVLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConstructedTLVLength);
			return cb_getConstructedTLVLength;
		}

		static int n_GetConstructedTLVLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConstructedTLVLength;
		}
#pragma warning restore 0169

		public virtual unsafe int ConstructedTLVLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getConstructedTLVLength' and count(parameter)=0]"
			[Register ("getConstructedTLVLength", "()I", "GetGetConstructedTLVLengthHandler")]
			get {
				const string __id = "getConstructedTLVLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getConstrustedTLV;
#pragma warning disable 0169
		static Delegate GetGetConstrustedTLVHandler ()
		{
			if (cb_getConstrustedTLV == null)
				cb_getConstrustedTLV = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConstrustedTLV);
			return cb_getConstrustedTLV;
		}

		static IntPtr n_GetConstrustedTLV (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (__this.ConstrustedTLV);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> ConstrustedTLV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getConstrustedTLV' and count(parameter)=0]"
			[Register ("getConstrustedTLV", "()Ljava/util/List;", "GetGetConstrustedTLVHandler")]
			get {
				const string __id = "getConstrustedTLV.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		public virtual unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFullLength;
#pragma warning disable 0169
		static Delegate GetGetFullLengthHandler ()
		{
			if (cb_getFullLength == null)
				cb_getFullLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFullLength);
			return cb_getFullLength;
		}

		static int n_GetFullLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FullLength;
		}
#pragma warning restore 0169

		public virtual unsafe int FullLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getFullLength' and count(parameter)=0]"
			[Register ("getFullLength", "()I", "GetGetFullLengthHandler")]
			get {
				const string __id = "getFullLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConstructed;
#pragma warning disable 0169
		static Delegate GetIsConstructedHandler ()
		{
			if (cb_isConstructed == null)
				cb_isConstructed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConstructed);
			return cb_isConstructed;
		}

		static bool n_IsConstructed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConstructed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConstructed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='isConstructed' and count(parameter)=0]"
			[Register ("isConstructed", "()Z", "GetIsConstructedHandler")]
			get {
				const string __id = "isConstructed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRawData;
#pragma warning disable 0169
		static Delegate GetIsRawDataHandler ()
		{
			if (cb_isRawData == null)
				cb_isRawData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRawData);
			return cb_isRawData;
		}

		static bool n_IsRawData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRawData;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRawData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='isRawData' and count(parameter)=0]"
			[Register ("isRawData", "()Z", "GetIsRawDataHandler")]
			get {
				const string __id = "isRawData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Tlv.Tag Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Lcom/miurasystems/mpi/tlv/Tag;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Lcom/miurasystems/mpi/tlv/Tag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Tag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopTag;
#pragma warning disable 0169
		static Delegate GetGetTopTagHandler ()
		{
			if (cb_getTopTag == null)
				cb_getTopTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTopTag);
			return cb_getTopTag;
		}

		static int n_GetTopTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopTag;
		}
#pragma warning restore 0169

		public virtual unsafe int TopTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getTopTag' and count(parameter)=0]"
			[Register ("getTopTag", "()I", "GetGetTopTagHandler")]
			get {
				const string __id = "getTopTag.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getRawData' and count(parameter)=0]"
		[Register ("getRawData", "()[B", "GetGetRawDataHandler")]
		public virtual unsafe byte[] GetRawData ()
		{
			const string __id = "getRawData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getlLength;
#pragma warning disable 0169
		static Delegate GetGetlLengthHandler ()
		{
			if (cb_getlLength == null)
				cb_getlLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetlLength);
			return cb_getlLength;
		}

		static int n_GetlLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetlLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getlLength' and count(parameter)=0]"
		[Register ("getlLength", "()I", "GetGetlLengthHandler")]
		public virtual unsafe int GetlLength ()
		{
			const string __id = "getlLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_gettLength;
#pragma warning disable 0169
		static Delegate GetGettLengthHandler ()
		{
			if (cb_gettLength == null)
				cb_gettLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GettLength);
			return cb_gettLength;
		}

		static int n_GettLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GettLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='gettLength' and count(parameter)=0]"
		[Register ("gettLength", "()I", "GetGettLengthHandler")]
		public virtual unsafe int GettLength ()
		{
			const string __id = "gettLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getvLength;
#pragma warning disable 0169
		static Delegate GetGetvLengthHandler ()
		{
			if (cb_getvLength == null)
				cb_getvLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetvLength);
			return cb_getvLength;
		}

		static int n_GetvLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetvLength ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='getvLength' and count(parameter)=0]"
		[Register ("getvLength", "()I", "GetGetvLengthHandler")]
		public virtual unsafe int GetvLength ()
		{
			const string __id = "getvLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetData_arrayBHandler ()
		{
			if (cb_setData_arrayB == null)
				cb_setData_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetData_arrayB);
			return cb_setData_arrayB;
		}

		static void n_SetData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_rawData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.TLVObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rawData = (byte[]) JNIEnv.GetArray (native_rawData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetData (rawData);
			if (rawData != null)
				JNIEnv.CopyArray (rawData, native_rawData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='TLVObject']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setData", "([B)V", "GetSetData_arrayBHandler")]
		public virtual unsafe void SetData (byte[] rawData)
		{
			const string __id = "setData.([B)V";
			IntPtr native_rawData = JNIEnv.NewArray (rawData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (rawData != null) {
					JNIEnv.CopyArray (native_rawData, rawData);
					JNIEnv.DeleteLocalRef (native_rawData);
				}
				global::System.GC.KeepAlive (rawData);
			}
		}

	}
}
