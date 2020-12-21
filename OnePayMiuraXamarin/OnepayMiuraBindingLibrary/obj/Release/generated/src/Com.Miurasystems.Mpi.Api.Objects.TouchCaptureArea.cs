using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/TouchCaptureArea", DoNotGenerateAcw=true)]
	public partial class TouchCaptureArea : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/field[@name='HIDDEN_CAPTURE_AREA']"
		[Register ("HIDDEN_CAPTURE_AREA")]
		public static global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea HiddenCaptureArea {
			get {
				const string __id = "HIDDEN_CAPTURE_AREA.Lcom/miurasystems/mpi/api/objects/TouchCaptureArea;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/TouchCaptureArea", typeof (TouchCaptureArea));
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

		protected TouchCaptureArea (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/constructor[@name='TouchCaptureArea' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(IIIIZZ)V", "")]
		public unsafe TouchCaptureArea (int x, int y, int width, int height, bool record, bool report)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIIZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				__args [4] = new JniArgumentValue (record);
				__args [5] = new JniArgumentValue (report);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRecord;
#pragma warning disable 0169
		static Delegate GetIsRecordHandler ()
		{
			if (cb_isRecord == null)
				cb_isRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRecord);
			return cb_isRecord;
		}

		static bool n_IsRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecord;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='isRecord' and count(parameter)=0]"
			[Register ("isRecord", "()Z", "GetIsRecordHandler")]
			get {
				const string __id = "isRecord.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isReport;
#pragma warning disable 0169
		static Delegate GetIsReportHandler ()
		{
			if (cb_isReport == null)
				cb_isReport = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReport);
			return cb_isReport;
		}

		static bool n_IsReport (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReport;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsReport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='isReport' and count(parameter)=0]"
			[Register ("isReport", "()Z", "GetIsReportHandler")]
			get {
				const string __id = "isReport.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetX);
			return cb_getX;
		}

		static int n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()I", "GetGetXHandler")]
		public virtual unsafe int GetX ()
		{
			const string __id = "getX.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetY);
			return cb_getY;
		}

		static int n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()I", "GetGetYHandler")]
		public virtual unsafe int GetY ()
		{
			const string __id = "getY.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toRawData;
#pragma warning disable 0169
		static Delegate GetToRawDataHandler ()
		{
			if (cb_toRawData == null)
				cb_toRawData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToRawData);
			return cb_toRawData;
		}

		static IntPtr n_ToRawData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToRawData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='TouchCaptureArea']/method[@name='toRawData' and count(parameter)=0]"
		[Register ("toRawData", "()[B", "GetToRawDataHandler")]
		public virtual unsafe byte[] ToRawData ()
		{
			const string __id = "toRawData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
