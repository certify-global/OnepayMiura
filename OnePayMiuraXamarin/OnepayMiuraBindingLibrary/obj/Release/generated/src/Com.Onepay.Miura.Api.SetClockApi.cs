using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onepay.Miura.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='SetClockApi']"
	[global::Android.Runtime.Register ("com/onepay/miura/api/SetClockApi", DoNotGenerateAcw=true)]
	public partial class SetClockApi : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='SetClockApi.SetClockListener']"
		[Register ("com/onepay/miura/api/SetClockApi$SetClockListener", "", "Com.Onepay.Miura.Api.SetClockApi/ISetClockListenerInvoker")]
		public partial interface ISetClockListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/interface[@name='SetClockApi.SetClockListener']/method[@name='onConnectionComplete' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.data.SetClockApiData']]"
			[Register ("onConnectionComplete", "(Lcom/onepay/miura/data/SetClockApiData;)V", "GetOnConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_Handler:Com.Onepay.Miura.Api.SetClockApi/ISetClockListenerInvoker, OnepayMiuraBindingLibrary")]
			void OnConnectionComplete (global::Com.Onepay.Miura.Data.SetClockApiData p0);

		}

		[global::Android.Runtime.Register ("com/onepay/miura/api/SetClockApi$SetClockListener", DoNotGenerateAcw=true)]
		internal partial class ISetClockListenerInvoker : global::Java.Lang.Object, ISetClockListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/SetClockApi$SetClockListener", typeof (ISetClockListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ISetClockListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISetClockListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onepay.miura.api.SetClockApi.SetClockListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISetClockListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_;
#pragma warning disable 0169
			static Delegate GetOnConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_Handler ()
			{
				if (cb_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_ == null)
					cb_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_);
				return cb_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_;
			}

			static void n_OnConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Data.SetClockApiData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_;
			public unsafe void OnConnectionComplete (global::Com.Onepay.Miura.Data.SetClockApiData p0)
			{
				if (id_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_ == IntPtr.Zero)
					id_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_ = JNIEnv.GetMethodID (class_ref, "onConnectionComplete", "(Lcom/onepay/miura/data/SetClockApiData;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionComplete_Lcom_onepay_miura_data_SetClockApiData_, __args);
			}

		}

		// event args for com.onepay.miura.api.SetClockApi.SetClockListener.onConnectionComplete
		public partial class SetClockEventArgs : global::System.EventArgs {

			public SetClockEventArgs (global::Com.Onepay.Miura.Data.SetClockApiData p0)
			{
				this.p0 = p0;
			}

			global::Com.Onepay.Miura.Data.SetClockApiData p0;
			public global::Com.Onepay.Miura.Data.SetClockApiData P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/onepay/miura/api/SetClockApi_SetClockListenerImplementor")]
		internal sealed partial class ISetClockListenerImplementor : global::Java.Lang.Object, ISetClockListener {

			object sender;

			public ISetClockListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onepay/miura/api/SetClockApi_SetClockListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SetClockEventArgs> Handler;
#pragma warning restore 0649

			public void OnConnectionComplete (global::Com.Onepay.Miura.Data.SetClockApiData p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SetClockEventArgs (p0));
			}

			internal static bool __IsEmpty (ISetClockListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onepay/miura/api/SetClockApi", typeof (SetClockApi));
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

		protected SetClockApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='SetClockApi']/constructor[@name='SetClockApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SetClockApi ()
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

		public static unsafe global::Com.Onepay.Miura.Api.SetClockApi Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='SetClockApi']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onepay/miura/api/SetClockApi;", "")]
			get {
				const string __id = "getInstance.()Lcom/onepay/miura/api/SetClockApi;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.SetClockApi> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_;
#pragma warning disable 0169
		static Delegate GetSetClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_Handler ()
		{
			if (cb_setClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_ == null)
				cb_setClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_);
			return cb_setClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_;
		}

		static void n_SetClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.SetClockApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener)global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetClockListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='SetClockApi']/method[@name='setClockListener' and count(parameter)=1 and parameter[1][@type='com.onepay.miura.api.SetClockApi.SetClockListener']]"
		[Register ("setClockListener", "(Lcom/onepay/miura/api/SetClockApi$SetClockListener;)V", "GetSetClockListener_Lcom_onepay_miura_api_SetClockApi_SetClockListener_Handler")]
		public virtual unsafe void SetClockListener (global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener listener)
		{
			const string __id = "setClockListener.(Lcom/onepay/miura/api/SetClockApi$SetClockListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setDeviceClock_Ljava_lang_String_ILjava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDeviceClock_Ljava_lang_String_ILjava_util_Date_Handler ()
		{
			if (cb_setDeviceClock_Ljava_lang_String_ILjava_util_Date_ == null)
				cb_setDeviceClock_Ljava_lang_String_ILjava_util_Date_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_SetDeviceClock_Ljava_lang_String_ILjava_util_Date_);
			return cb_setDeviceClock_Ljava_lang_String_ILjava_util_Date_;
		}

		static void n_SetDeviceClock_Ljava_lang_String_ILjava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_btAddress, int tOut, IntPtr native_date)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onepay.Miura.Api.SetClockApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var btAddress = JNIEnv.GetString (native_btAddress, JniHandleOwnership.DoNotTransfer);
			var date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceClock (btAddress, tOut, date);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onepay.miura.api']/class[@name='SetClockApi']/method[@name='setDeviceClock' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Date']]"
		[Register ("setDeviceClock", "(Ljava/lang/String;ILjava/util/Date;)V", "GetSetDeviceClock_Ljava_lang_String_ILjava_util_Date_Handler")]
		public virtual unsafe void SetDeviceClock (string btAddress, int tOut, global::Java.Util.Date date)
		{
			const string __id = "setDeviceClock.(Ljava/lang/String;ILjava/util/Date;)V";
			IntPtr native_btAddress = JNIEnv.NewString (btAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_btAddress);
				__args [1] = new JniArgumentValue (tOut);
				__args [2] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_btAddress);
				global::System.GC.KeepAlive (date);
			}
		}

#region "Event implementation for Com.Onepay.Miura.Api.SetClockApi.ISetClockListener"
		public event EventHandler<global::Com.Onepay.Miura.Api.SetClockApi.SetClockEventArgs> Clock {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener, global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListenerImplementor>(
						ref weak_implementor_SetClockListener,
						__CreateISetClockListenerImplementor,
						SetClockListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListener, global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListenerImplementor>(
						ref weak_implementor_SetClockListener,
						global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListenerImplementor.__IsEmpty,
						__v => SetClockListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetClockListener;

		global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListenerImplementor __CreateISetClockListenerImplementor ()
		{
			return new global::Com.Onepay.Miura.Api.SetClockApi.ISetClockListenerImplementor (this);
		}
#endregion
	}
}
