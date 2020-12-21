using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/DisplayMediaData", DoNotGenerateAcw=true)]
	public partial class DisplayMediaData : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/DisplayMediaData$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/DisplayMediaData$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/constructor[@name='DisplayMediaData.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/constructor[@name='DisplayMediaData.Builder' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(ZZ)V", "")]
			public unsafe Builder (bool turnBacklightOn, bool useUTF8Encoding)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (turnBacklightOn);
					__args [1] = new JniArgumentValue (useUTF8Encoding);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_addBlinkArea_IIII;
#pragma warning disable 0169
			static Delegate GetAddBlinkArea_IIIIHandler ()
			{
				if (cb_addBlinkArea_IIII == null)
					cb_addBlinkArea_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_L) n_AddBlinkArea_IIII);
				return cb_addBlinkArea_IIII;
			}

			static IntPtr n_AddBlinkArea_IIII (IntPtr jnienv, IntPtr native__this, int startX, int startY, int endX, int endY)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddBlinkArea (startX, startY, endX, endY));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addBlinkArea' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("addBlinkArea", "(IIII)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddBlinkArea_IIIIHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddBlinkArea (int startX, int startY, int endX, int endY)
			{
				const string __id = "addBlinkArea.(IIII)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (startX);
					__args [1] = new JniArgumentValue (startY);
					__args [2] = new JniArgumentValue (endX);
					__args [3] = new JniArgumentValue (endY);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_addBlinkTimeInverted_I;
#pragma warning disable 0169
			static Delegate GetAddBlinkTimeInverted_IHandler ()
			{
				if (cb_addBlinkTimeInverted_I == null)
					cb_addBlinkTimeInverted_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AddBlinkTimeInverted_I);
				return cb_addBlinkTimeInverted_I;
			}

			static IntPtr n_AddBlinkTimeInverted_I (IntPtr jnienv, IntPtr native__this, int blinkTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddBlinkTimeInverted (blinkTime));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addBlinkTimeInverted' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("addBlinkTimeInverted", "(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddBlinkTimeInverted_IHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddBlinkTimeInverted (int blinkTime)
			{
				const string __id = "addBlinkTimeInverted.(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (blinkTime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_addBlinkTimeNormal_I;
#pragma warning disable 0169
			static Delegate GetAddBlinkTimeNormal_IHandler ()
			{
				if (cb_addBlinkTimeNormal_I == null)
					cb_addBlinkTimeNormal_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AddBlinkTimeNormal_I);
				return cb_addBlinkTimeNormal_I;
			}

			static IntPtr n_AddBlinkTimeNormal_I (IntPtr jnienv, IntPtr native__this, int blinkTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddBlinkTimeNormal (blinkTime));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addBlinkTimeNormal' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("addBlinkTimeNormal", "(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddBlinkTimeNormal_IHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddBlinkTimeNormal (int blinkTime)
			{
				const string __id = "addBlinkTimeNormal.(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (blinkTime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_addBlinkTimePeriod_I;
#pragma warning disable 0169
			static Delegate GetAddBlinkTimePeriod_IHandler ()
			{
				if (cb_addBlinkTimePeriod_I == null)
					cb_addBlinkTimePeriod_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AddBlinkTimePeriod_I);
				return cb_addBlinkTimePeriod_I;
			}

			static IntPtr n_AddBlinkTimePeriod_I (IntPtr jnienv, IntPtr native__this, int blinkTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddBlinkTimePeriod (blinkTime));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addBlinkTimePeriod' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("addBlinkTimePeriod", "(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddBlinkTimePeriod_IHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddBlinkTimePeriod (int blinkTime)
			{
				const string __id = "addBlinkTimePeriod.(I)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (blinkTime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_addImage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddImage_Ljava_lang_String_Handler ()
			{
				if (cb_addImage_Ljava_lang_String_ == null)
					cb_addImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddImage_Ljava_lang_String_);
				return cb_addImage_Ljava_lang_String_;
			}

			static IntPtr n_AddImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddImage (filename));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addImage", "(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddImage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddImage (string filename)
			{
				const string __id = "addImage.(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				IntPtr native_filename = JNIEnv.NewString (filename);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_filename);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			static Delegate cb_addScreenPosition_II;
#pragma warning disable 0169
			static Delegate GetAddScreenPosition_IIHandler ()
			{
				if (cb_addScreenPosition_II == null)
					cb_addScreenPosition_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_AddScreenPosition_II);
				return cb_addScreenPosition_II;
			}

			static IntPtr n_AddScreenPosition_II (IntPtr jnienv, IntPtr native__this, int x, int y)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddScreenPosition (x, y));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addScreenPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("addScreenPosition", "(II)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddScreenPosition_IIHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddScreenPosition (int x, int y)
			{
				const string __id = "addScreenPosition.(II)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (x);
					__args [1] = new JniArgumentValue (y);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_addText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddText_Ljava_lang_String_Handler ()
			{
				if (cb_addText_Ljava_lang_String_ == null)
					cb_addText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddText_Ljava_lang_String_);
				return cb_addText_Ljava_lang_String_;
			}

			static IntPtr n_AddText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddText (text));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='addText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addText", "(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;", "GetAddText_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder AddText (string text)
			{
				const string __id = "addText.(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/DisplayMediaData$Builder;";
				IntPtr native_text = JNIEnv.NewString (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/miurasystems/mpi/api/objects/DisplayMediaData;", "GetBuildHandler")]
			public virtual unsafe global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData Build ()
			{
				const string __id = "build.()Lcom/miurasystems/mpi/api/objects/DisplayMediaData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/DisplayMediaData", typeof (DisplayMediaData));
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

		protected DisplayMediaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isTurnBacklightOn;
#pragma warning disable 0169
		static Delegate GetIsTurnBacklightOnHandler ()
		{
			if (cb_isTurnBacklightOn == null)
				cb_isTurnBacklightOn = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTurnBacklightOn);
			return cb_isTurnBacklightOn;
		}

		static bool n_IsTurnBacklightOn (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTurnBacklightOn;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTurnBacklightOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData']/method[@name='isTurnBacklightOn' and count(parameter)=0]"
			[Register ("isTurnBacklightOn", "()Z", "GetIsTurnBacklightOnHandler")]
			get {
				const string __id = "isTurnBacklightOn.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUseUTF8Encoding;
#pragma warning disable 0169
		static Delegate GetIsUseUTF8EncodingHandler ()
		{
			if (cb_isUseUTF8Encoding == null)
				cb_isUseUTF8Encoding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseUTF8Encoding);
			return cb_isUseUTF8Encoding;
		}

		static bool n_IsUseUTF8Encoding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUseUTF8Encoding;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUseUTF8Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData']/method[@name='isUseUTF8Encoding' and count(parameter)=0]"
			[Register ("isUseUTF8Encoding", "()Z", "GetIsUseUTF8EncodingHandler")]
			get {
				const string __id = "isUseUTF8Encoding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTvlList;
#pragma warning disable 0169
		static Delegate GetGetTvlListHandler ()
		{
			if (cb_getTvlList == null)
				cb_getTvlList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTvlList);
			return cb_getTvlList;
		}

		static IntPtr n_GetTvlList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (__this.TvlList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> TvlList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='DisplayMediaData']/method[@name='getTvlList' and count(parameter)=0]"
			[Register ("getTvlList", "()Ljava/util/List;", "GetGetTvlListHandler")]
			get {
				const string __id = "getTvlList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
