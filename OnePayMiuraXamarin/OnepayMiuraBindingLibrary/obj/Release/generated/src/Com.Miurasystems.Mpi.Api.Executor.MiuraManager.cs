using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Executor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/executor/MiuraManager", DoNotGenerateAcw=true)]
	public partial class MiuraManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/interface[@name='MiuraManager.AsyncRunnable']"
		[Register ("com/miurasystems/mpi/api/executor/MiuraManager$AsyncRunnable", "", "Com.Miurasystems.Mpi.Api.Executor.MiuraManager/IAsyncRunnableInvoker")]
		public partial interface IAsyncRunnable : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/interface[@name='MiuraManager.AsyncRunnable']/method[@name='runOnAsyncThread' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.MpiClient']]"
			[Register ("runOnAsyncThread", "(Lcom/miurasystems/mpi/MpiClient;)V", "GetRunOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_Handler:Com.Miurasystems.Mpi.Api.Executor.MiuraManager/IAsyncRunnableInvoker, OnepayMiuraBindingLibrary")]
			void RunOnAsyncThread (global::Com.Miurasystems.Mpi.MpiClient p0);

		}

		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/executor/MiuraManager$AsyncRunnable", DoNotGenerateAcw=true)]
		internal partial class IAsyncRunnableInvoker : global::Java.Lang.Object, IAsyncRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/executor/MiuraManager$AsyncRunnable", typeof (IAsyncRunnableInvoker));

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

			public static IAsyncRunnable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAsyncRunnable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.executor.MiuraManager.AsyncRunnable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAsyncRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_;
#pragma warning disable 0169
			static Delegate GetRunOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_Handler ()
			{
				if (cb_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_ == null)
					cb_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RunOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_);
				return cb_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_;
			}

			static void n_RunOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.IAsyncRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RunOnAsyncThread (p0);
			}
#pragma warning restore 0169

			IntPtr id_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_;
			public unsafe void RunOnAsyncThread (global::Com.Miurasystems.Mpi.MpiClient p0)
			{
				if (id_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_ == IntPtr.Zero)
					id_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_ = JNIEnv.GetMethodID (class_ref, "runOnAsyncThread", "(Lcom/miurasystems/mpi/MpiClient;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runOnAsyncThread_Lcom_miurasystems_mpi_MpiClient_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager.DeviceType']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/executor/MiuraManager$DeviceType", DoNotGenerateAcw=true)]
		public sealed partial class DeviceType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager.DeviceType']/field[@name='PED']"
			[Register ("PED")]
			public static global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType Ped {
				get {
					const string __id = "PED.Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager.DeviceType']/field[@name='POS']"
			[Register ("POS")]
			public static global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType Pos {
				get {
					const string __id = "POS.Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/executor/MiuraManager$DeviceType", typeof (DeviceType));
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

			internal DeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager.DeviceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager.DeviceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;", "")]
			public static unsafe global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType[] Values ()
			{
				const string __id = "values.()[Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/executor/MiuraManager", typeof (MiuraManager));
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

		protected MiuraManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnector;
#pragma warning disable 0169
		static Delegate GetGetConnectorHandler ()
		{
			if (cb_getConnector == null)
				cb_getConnector = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConnector);
			return cb_getConnector;
		}

		static IntPtr n_GetConnector (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connector);
		}
#pragma warning restore 0169

		static Delegate cb_setConnector_Lcom_miurasystems_mpi_comms_Connector_;
#pragma warning disable 0169
		static Delegate GetSetConnector_Lcom_miurasystems_mpi_comms_Connector_Handler ()
		{
			if (cb_setConnector_Lcom_miurasystems_mpi_comms_Connector_ == null)
				cb_setConnector_Lcom_miurasystems_mpi_comms_Connector_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnector_Lcom_miurasystems_mpi_comms_Connector_);
			return cb_setConnector_Lcom_miurasystems_mpi_comms_Connector_;
		}

		static void n_SetConnector_Lcom_miurasystems_mpi_comms_Connector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connector)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var connector = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (native_connector, JniHandleOwnership.DoNotTransfer);
			__this.Connector = connector;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Comms.Connector Connector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getConnector' and count(parameter)=0]"
			[Register ("getConnector", "()Lcom/miurasystems/mpi/comms/Connector;", "GetGetConnectorHandler")]
			get {
				const string __id = "getConnector.()Lcom/miurasystems/mpi/comms/Connector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Comms.Connector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='setConnector' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.comms.Connector']]"
			[Register ("setConnector", "(Lcom/miurasystems/mpi/comms/Connector;)V", "GetSetConnector_Lcom_miurasystems_mpi_comms_Connector_Handler")]
			set {
				const string __id = "setConnector.(Lcom/miurasystems/mpi/comms/Connector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/miurasystems/mpi/api/executor/MiuraManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/miurasystems/mpi/api/executor/MiuraManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMpiClient;
#pragma warning disable 0169
		static Delegate GetGetMpiClientHandler ()
		{
			if (cb_getMpiClient == null)
				cb_getMpiClient = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMpiClient);
			return cb_getMpiClient;
		}

		static IntPtr n_GetMpiClient (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MpiClient);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.MpiClient MpiClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getMpiClient' and count(parameter)=0]"
			[Register ("getMpiClient", "()Lcom/miurasystems/mpi/MpiClient;", "GetGetMpiClientHandler")]
			get {
				const string __id = "getMpiClient.()Lcom/miurasystems/mpi/MpiClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.MpiClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMpiEvents;
#pragma warning disable 0169
		static Delegate GetGetMpiEventsHandler ()
		{
			if (cb_getMpiEvents == null)
				cb_getMpiEvents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMpiEvents);
			return cb_getMpiEvents;
		}

		static IntPtr n_GetMpiEvents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MpiEvents);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Miurasystems.Mpi.Events.MpiEvents MpiEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getMpiEvents' and count(parameter)=0]"
			[Register ("getMpiEvents", "()Lcom/miurasystems/mpi/events/MpiEvents;", "GetGetMpiEventsHandler")]
			get {
				const string __id = "getMpiEvents.()Lcom/miurasystems/mpi/events/MpiEvents;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Events.MpiEvents> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_;
#pragma warning disable 0169
		static Delegate GetP2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_Handler ()
		{
			if (cb_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_ == null)
				cb_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_);
			return cb_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_;
		}

		static void n_P2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.P2PEImport (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='P2PEImport' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiP2PEImportListener']]"
		[Register ("P2PEImport", "(Lcom/miurasystems/mpi/api/listener/ApiP2PEImportListener;)V", "GetP2PEImport_Lcom_miurasystems_mpi_api_listener_ApiP2PEImportListener_Handler")]
		public virtual unsafe void P2PEImport (global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEImportListener listener)
		{
			const string __id = "P2PEImport.(Lcom/miurasystems/mpi/api/listener/ApiP2PEImportListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetP2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_P2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.P2PEInitialise (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='P2PEInitialise' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("P2PEInitialise", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetP2PEInitialise_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void P2PEInitialise (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "P2PEInitialise.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_abortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetAbortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_abortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_abortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AbortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_abortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_AbortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AbortTransaction (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='abortTransaction' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("abortTransaction", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetAbortTransaction_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void AbortTransaction (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "abortTransaction.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_barcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetBarcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_barcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_barcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_BarcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_barcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_BarcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, bool enabled, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.BarcodeScannerStatus (enabled, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='barcodeScannerStatus' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("barcodeScannerStatus", "(ZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetBarcodeScannerStatus_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void BarcodeScannerStatus (bool enabled, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "barcodeScannerStatus.(ZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (enabled);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_;
#pragma warning disable 0169
		static Delegate GetBuzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_Handler ()
		{
			if (cb_buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ == null)
				cb_buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_Buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_);
			return cb_buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_;
		}

		static void n_Buzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ (IntPtr jnienv, IntPtr native__this, bool synchronousSound, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Buzzer (synchronousSound, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='buzzer' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiBuzzerListener']]"
		[Register ("buzzer", "(ZLcom/miurasystems/mpi/api/listener/ApiBuzzerListener;)V", "GetBuzzer_ZLcom_miurasystems_mpi_api_listener_ApiBuzzerListener_Handler")]
		public virtual unsafe void Buzzer (bool synchronousSound, global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener listener)
		{
			const string __id = "buzzer.(ZLcom/miurasystems/mpi/api/listener/ApiBuzzerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (synchronousSound);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_;
#pragma warning disable 0169
		static Delegate GetBuzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_Handler ()
		{
			if (cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ == null)
				cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLLLL_V) n_Buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_);
			return cb_buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_;
		}

		static void n_Buzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_ (IntPtr jnienv, IntPtr native__this, bool synchronousSound, IntPtr native_duration, IntPtr native_volume, IntPtr native_frequency, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var duration = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_duration, JniHandleOwnership.DoNotTransfer);
			var volume = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_volume, JniHandleOwnership.DoNotTransfer);
			var frequency = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_frequency, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Buzzer (synchronousSound, duration, volume, frequency, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='buzzer' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiBuzzerListener']]"
		[Register ("buzzer", "(ZLjava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiBuzzerListener;)V", "GetBuzzer_ZLjava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiBuzzerListener_Handler")]
		public virtual unsafe void Buzzer (bool synchronousSound, global::Java.Lang.Integer duration, global::Java.Lang.Integer volume, global::Java.Lang.Integer frequency, global::Com.Miurasystems.Mpi.Api.Listener.IApiBuzzerListener listener)
		{
			const string __id = "buzzer.(ZLjava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiBuzzerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (synchronousSound);
				__args [1] = new JniArgumentValue ((duration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) duration).Handle);
				__args [2] = new JniArgumentValue ((volume == null) ? IntPtr.Zero : ((global::Java.Lang.Object) volume).Handle);
				__args [3] = new JniArgumentValue ((frequency == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frequency).Handle);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (duration);
				global::System.GC.KeepAlive (volume);
				global::System.GC.KeepAlive (frequency);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_cardStatus_Z;
#pragma warning disable 0169
		static Delegate GetCardStatus_ZHandler ()
		{
			if (cb_cardStatus_Z == null)
				cb_cardStatus_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_CardStatus_Z);
			return cb_cardStatus_Z;
		}

		static void n_CardStatus_Z (IntPtr jnienv, IntPtr native__this, bool enableCardStatusChange)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CardStatus (enableCardStatusChange);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='cardStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cardStatus", "(Z)V", "GetCardStatus_ZHandler")]
		public virtual unsafe void CardStatus (bool enableCardStatusChange)
		{
			const string __id = "cardStatus.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableCardStatusChange);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_;
#pragma warning disable 0169
		static Delegate GetCardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_Handler ()
		{
			if (cb_cardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_ == null)
				cb_cardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_CardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_);
			return cb_cardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_;
		}

		static void n_CardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_ (IntPtr jnienv, IntPtr native__this, bool enableCardStatusChange, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiCardStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiCardStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CardStatusUnsolicited (enableCardStatusChange, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='cardStatusUnsolicited' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiCardStatusListener']]"
		[Register ("cardStatusUnsolicited", "(ZLcom/miurasystems/mpi/api/listener/ApiCardStatusListener;)V", "GetCardStatusUnsolicited_ZLcom_miurasystems_mpi_api_listener_ApiCardStatusListener_Handler")]
		public virtual unsafe void CardStatusUnsolicited (bool enableCardStatusChange, global::Com.Miurasystems.Mpi.Api.Listener.IApiCardStatusListener listener)
		{
			const string __id = "cardStatusUnsolicited.(ZLcom/miurasystems/mpi/api/listener/ApiCardStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (enableCardStatusChange);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_cashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_;
#pragma warning disable 0169
		static Delegate GetCashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_Handler ()
		{
			if (cb_cashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_ == null)
				cb_cashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_CashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_);
			return cb_cashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_;
		}

		static void n_CashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_ (IntPtr jnienv, IntPtr native__this, bool openCashDrawer, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CashDrawer (openCashDrawer, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='cashDrawer' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiCashDrawerListener']]"
		[Register ("cashDrawer", "(ZLcom/miurasystems/mpi/api/listener/ApiCashDrawerListener;)V", "GetCashDrawer_ZLcom_miurasystems_mpi_api_listener_ApiCashDrawerListener_Handler")]
		public virtual unsafe void CashDrawer (bool openCashDrawer, global::Com.Miurasystems.Mpi.Api.Listener.IApiCashDrawerListener listener)
		{
			const string __id = "cashDrawer.(ZLcom/miurasystems/mpi/api/listener/ApiCashDrawerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (openCashDrawer);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_clearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetClearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_clearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_clearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ClearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_clearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_ClearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ClearDeviceMemory (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='clearDeviceMemory' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("clearDeviceMemory", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetClearDeviceMemory_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void ClearDeviceMemory (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "clearDeviceMemory.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_clearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_ClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folder, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ClearFolder (folder, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='clearFolder' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("clearFolder", "(Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetClearFolder_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void ClearFolder (global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "clearFolder.(Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_closeSession;
#pragma warning disable 0169
		static Delegate GetCloseSessionHandler ()
		{
			if (cb_closeSession == null)
				cb_closeSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseSession);
			return cb_closeSession;
		}

		static void n_CloseSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "GetCloseSessionHandler")]
		public virtual unsafe void CloseSession ()
		{
			const string __id = "closeSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_configureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetConfigureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_configureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_configureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConfigureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_configureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_ConfigureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serialPortProperties, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serialPortProperties = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties> (native_serialPortProperties, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureSerialPort (serialPortProperties, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='configureSerialPort' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.api.utils.SerialPortProperties'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("configureSerialPort", "(Lcom/miurasystems/mpi/api/utils/SerialPortProperties;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetConfigureSerialPort_Lcom_miurasystems_mpi_api_utils_SerialPortProperties_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void ConfigureSerialPort (global::Com.Miurasystems.Mpi.Api.Utils.SerialPortProperties serialPortProperties, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "configureSerialPort.(Lcom/miurasystems/mpi/api/utils/SerialPortProperties;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((serialPortProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serialPortProperties).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (serialPortProperties);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_continueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_;
#pragma warning disable 0169
		static Delegate GetContinueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_Handler ()
		{
			if (cb_continueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_ == null)
				cb_continueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ContinueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_);
			return cb_continueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_;
		}

		static void n_ContinueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tlvObjects, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tlvObjects = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.FromJniHandle (native_tlvObjects, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ContinueTransaction (tlvObjects, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='continueTransaction' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;com.miurasystems.mpi.tlv.TLVObject&gt;'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiContinueTransactionListener']]"
		[Register ("continueTransaction", "(Ljava/util/ArrayList;Lcom/miurasystems/mpi/api/listener/ApiContinueTransactionListener;)V", "GetContinueTransaction_Ljava_util_ArrayList_Lcom_miurasystems_mpi_api_listener_ApiContinueTransactionListener_Handler")]
		public virtual unsafe void ContinueTransaction (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Tlv.TLVObject> tlvObjects, global::Com.Miurasystems.Mpi.Api.Listener.IApiContinueTransactionListener listener)
		{
			const string __id = "continueTransaction.(Ljava/util/ArrayList;Lcom/miurasystems/mpi/api/listener/ApiContinueTransactionListener;)V";
			IntPtr native_tlvObjects = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Tlv.TLVObject>.ToLocalJniHandle (tlvObjects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tlvObjects);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tlvObjects);
				global::System.GC.KeepAlive (tlvObjects);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFile (fileName, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='deleteFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("deleteFile", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DeleteFile (string fileName, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "deleteFile.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_deleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_folder, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFile (fileName, folder, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='deleteFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[3][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("deleteFile", "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDeleteFile_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DeleteFile (string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "deleteFile.(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_deleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDeleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_deleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_deleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_deleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DeleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DeleteLog (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='deleteLog' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("deleteLog", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDeleteLog_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DeleteLog (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "deleteLog.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_displayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDisplayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_displayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_displayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZL_V) n_DisplayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_displayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DisplayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageFilename, bool isFullScreen, bool isBacklightOn, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageFilename = JNIEnv.GetString (native_imageFilename, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DisplayImage (imageFilename, isFullScreen, isBacklightOn, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='displayImage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("displayImage", "(Ljava/lang/String;ZZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDisplayImage_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DisplayImage (string imageFilename, bool isFullScreen, bool isBacklightOn, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "displayImage.(Ljava/lang/String;ZZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_imageFilename = JNIEnv.NewString (imageFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_imageFilename);
				__args [1] = new JniArgumentValue (isFullScreen);
				__args [2] = new JniArgumentValue (isBacklightOn);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageFilename);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_displayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_displayMediaData, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var displayMediaData = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData> (native_displayMediaData, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DisplayMedia (displayMediaData, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='displayMedia' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.api.objects.DisplayMediaData'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("displayMedia", "(Lcom/miurasystems/mpi/api/objects/DisplayMediaData;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDisplayMedia_Lcom_miurasystems_mpi_api_objects_DisplayMediaData_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DisplayMedia (global::Com.Miurasystems.Mpi.Api.Objects.DisplayMediaData displayMediaData, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "displayMedia.(Lcom/miurasystems/mpi/api/objects/DisplayMediaData;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((displayMediaData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) displayMediaData).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (displayMediaData);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_displayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetDisplayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_displayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_displayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DisplayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_displayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_DisplayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DisplayText (text, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='displayText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("displayText", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetDisplayText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void DisplayText (string text, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "displayText.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
#pragma warning disable 0169
		static Delegate GetDownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler ()
		{
			if (cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ == null)
				cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_);
			return cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
		}

		static void n_DownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DownloadBinaryWithFileName (fileName, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='downloadBinaryWithFileName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener']]"
		[Register ("downloadBinaryWithFileName", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V", "GetDownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler")]
		public virtual unsafe void DownloadBinaryWithFileName (string fileName, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener listener)
		{
			const string __id = "downloadBinaryWithFileName.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
#pragma warning disable 0169
		static Delegate GetDownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler ()
		{
			if (cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ == null)
				cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_);
			return cb_downloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
		}

		static void n_DownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_folder, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DownloadBinaryWithFileName (fileName, folder, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='downloadBinaryWithFileName' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[3][@type='com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener']]"
		[Register ("downloadBinaryWithFileName", "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V", "GetDownloadBinaryWithFileName_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler")]
		public virtual unsafe void DownloadBinaryWithFileName (string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener listener)
		{
			const string __id = "downloadBinaryWithFileName.(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_executeAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_;
#pragma warning disable 0169
		static Delegate GetExecuteAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_Handler ()
		{
			if (cb_executeAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_ == null)
				cb_executeAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ExecuteAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_);
			return cb_executeAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_;
		}

		static void n_ExecuteAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var runnable = (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.IAsyncRunnable)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.IAsyncRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteAsync (runnable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='executeAsync' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.executor.MiuraManager.AsyncRunnable']]"
		[Register ("executeAsync", "(Lcom/miurasystems/mpi/api/executor/MiuraManager$AsyncRunnable;)V", "GetExecuteAsync_Lcom_miurasystems_mpi_api_executor_MiuraManager_AsyncRunnable_Handler")]
		public virtual unsafe void ExecuteAsync (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.IAsyncRunnable runnable)
		{
			const string __id = "executeAsync.(Lcom/miurasystems/mpi/api/executor/MiuraManager$AsyncRunnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (runnable);
			}
		}

		static Delegate cb_getBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_;
#pragma warning disable 0169
		static Delegate GetGetBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_Handler ()
		{
			if (cb_getBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ == null)
				cb_getBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_);
			return cb_getBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_;
		}

		static void n_GetBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetBatteryStatus (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getBatteryStatus' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiBatteryStatusListener']]"
		[Register ("getBatteryStatus", "(Lcom/miurasystems/mpi/api/listener/ApiBatteryStatusListener;)V", "GetGetBatteryStatus_Lcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_Handler")]
		public virtual unsafe void GetBatteryStatus (global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener listener)
		{
			const string __id = "getBatteryStatus.(Lcom/miurasystems/mpi/api/listener/ApiBatteryStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_;
#pragma warning disable 0169
		static Delegate GetGetBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_Handler ()
		{
			if (cb_getBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_ == null)
				cb_getBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_);
			return cb_getBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_;
		}

		static void n_GetBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetBluetoothInfo (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getBluetoothInfo' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiBlueToothInfoListener']]"
		[Register ("getBluetoothInfo", "(Lcom/miurasystems/mpi/api/listener/ApiBlueToothInfoListener;)V", "GetGetBluetoothInfo_Lcom_miurasystems_mpi_api_listener_ApiBlueToothInfoListener_Handler")]
		public virtual unsafe void GetBluetoothInfo (global::Com.Miurasystems.Mpi.Api.Listener.IApiBlueToothInfoListener listener)
		{
			const string __id = "getBluetoothInfo.(Lcom/miurasystems/mpi/api/listener/ApiBlueToothInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_;
#pragma warning disable 0169
		static Delegate GetGetContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_Handler ()
		{
			if (cb_getContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_ == null)
				cb_getContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_);
			return cb_getContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_;
		}

		static void n_GetContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValues)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValues> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetContactlessKernelVersions (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getContactlessKernelVersions' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetContactlessHashValues']]"
		[Register ("getContactlessKernelVersions", "(Lcom/miurasystems/mpi/api/listener/ApiGetContactlessHashValues;)V", "GetGetContactlessKernelVersions_Lcom_miurasystems_mpi_api_listener_ApiGetContactlessHashValues_Handler")]
		public virtual unsafe void GetContactlessKernelVersions (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetContactlessHashValues listener)
		{
			const string __id = "getContactlessKernelVersions.(Lcom/miurasystems/mpi/api/listener/ApiGetContactlessHashValues;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_Handler ()
		{
			if (cb_getDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_ == null)
				cb_getDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_);
			return cb_getDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_;
		}

		static void n_GetDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceInfoListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetDeviceInfo (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetDeviceInfoListener']]"
		[Register ("getDeviceInfo", "(Lcom/miurasystems/mpi/api/listener/ApiGetDeviceInfoListener;)V", "GetGetDeviceInfo_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceInfoListener_Handler")]
		public virtual unsafe void GetDeviceInfo (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceInfoListener listener)
		{
			const string __id = "getDeviceInfo.(Lcom/miurasystems/mpi/api/listener/ApiGetDeviceInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDeviceType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getDeviceType' and count(parameter)=0]"
		[Register ("getDeviceType", "()Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;", "GetGetDeviceTypeHandler")]
		public virtual unsafe global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType GetDeviceType ()
		{
			const string __id = "getDeviceType.()Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_;
#pragma warning disable 0169
		static Delegate GetGetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_Handler ()
		{
			if (cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_ == null)
				cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLIIIILLL_V) n_GetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_);
			return cb_getDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_;
		}

		static void n_GetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_ (IntPtr jnienv, IntPtr native__this, bool displayedAmountIncludesTotal, IntPtr native_percentages, int tipTemplate, int amountInPennies, int currencyCode, int currencyExponent, IntPtr native_options, IntPtr native_timeoutInSeconds, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var percentages = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_percentages, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetDynamicTip (displayedAmountIncludesTotal, percentages, tipTemplate, amountInPennies, currencyCode, currencyExponent, options, timeoutInSeconds, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getDynamicTip' and count(parameter)=9 and parameter[1][@type='boolean'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[8][@type='java.lang.Integer'] and parameter[9][@type='com.miurasystems.mpi.api.listener.ApiGetDynamicTipListener']]"
		[Register ("getDynamicTip", "(ZLjava/util/List;IIIILjava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetDynamicTipListener;)V", "GetGetDynamicTip_ZLjava_util_List_IIIILjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetDynamicTipListener_Handler")]
		public virtual unsafe void GetDynamicTip (bool displayedAmountIncludesTotal, global::System.Collections.Generic.IList<global::Java.Lang.Integer> percentages, int tipTemplate, int amountInPennies, int currencyCode, int currencyExponent, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDynamicTipListener listener)
		{
			const string __id = "getDynamicTip.(ZLjava/util/List;IIIILjava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetDynamicTipListener;)V";
			IntPtr native_percentages = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (percentages);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (displayedAmountIncludesTotal);
				__args [1] = new JniArgumentValue (native_percentages);
				__args [2] = new JniArgumentValue (tipTemplate);
				__args [3] = new JniArgumentValue (amountInPennies);
				__args [4] = new JniArgumentValue (currencyCode);
				__args [5] = new JniArgumentValue (currencyExponent);
				__args [6] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [7] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [8] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_percentages);
				global::System.GC.KeepAlive (percentages);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_;
#pragma warning disable 0169
		static Delegate GetGetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_Handler ()
		{
			if (cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_ == null)
				cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_GetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_);
			return cb_getMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_;
		}

		static void n_GetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_menuTitle, IntPtr native_options, IntPtr native_timeoutInSeconds, IntPtr native_menuOptions, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var menuTitle = JNIEnv.GetString (native_menuTitle, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var menuOptions = global::Android.Runtime.JavaList<string>.FromJniHandle (native_menuOptions, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetMenuOption (menuTitle, options, timeoutInSeconds, menuOptions, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getMenuOption' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetMenuOptions&gt;'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiMenuOptionListener']]"
		[Register ("getMenuOption", "(Ljava/lang/String;Ljava/util/EnumSet;Ljava/lang/Integer;Ljava/util/List;Lcom/miurasystems/mpi/api/listener/ApiMenuOptionListener;)V", "GetGetMenuOption_Ljava_lang_String_Ljava_util_EnumSet_Ljava_lang_Integer_Ljava_util_List_Lcom_miurasystems_mpi_api_listener_ApiMenuOptionListener_Handler")]
		public virtual unsafe void GetMenuOption (string menuTitle, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds, global::System.Collections.Generic.IList<string> menuOptions, global::Com.Miurasystems.Mpi.Api.Listener.IApiMenuOptionListener listener)
		{
			const string __id = "getMenuOption.(Ljava/lang/String;Ljava/util/EnumSet;Ljava/lang/Integer;Ljava/util/List;Lcom/miurasystems/mpi/api/listener/ApiMenuOptionListener;)V";
			IntPtr native_menuTitle = JNIEnv.NewString (menuTitle);
			IntPtr native_menuOptions = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (menuOptions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_menuTitle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [3] = new JniArgumentValue (native_menuOptions);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_menuTitle);
				JNIEnv.DeleteLocalRef (native_menuOptions);
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (menuOptions);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_;
#pragma warning disable 0169
		static Delegate GetGetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_Handler ()
		{
			if (cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_ == null)
				cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_);
			return cb_getNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_;
		}

		static void n_GetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetNumericData (request, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getNumericData' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.api.objects.GetNumericDataRequest'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiGetNumericDataListener']]"
		[Register ("getNumericData", "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;Lcom/miurasystems/mpi/api/listener/ApiGetNumericDataListener;)V", "GetGetNumericData_Lcom_miurasystems_mpi_api_objects_GetNumericDataRequest_Lcom_miurasystems_mpi_api_listener_ApiGetNumericDataListener_Handler")]
		public virtual unsafe void GetNumericData (global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest request, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetNumericDataListener listener)
		{
			const string __id = "getNumericData.(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;Lcom/miurasystems/mpi/api/listener/ApiGetNumericDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (request);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_;
#pragma warning disable 0169
		static Delegate GetGetP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_Handler ()
		{
			if (cb_getP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_ == null)
				cb_getP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_);
			return cb_getP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_;
		}

		static void n_GetP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetP2PEStatus (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getP2PEStatus' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiP2PEStatusListener']]"
		[Register ("getP2PEStatus", "(Lcom/miurasystems/mpi/api/listener/ApiP2PEStatusListener;)V", "GetGetP2PEStatus_Lcom_miurasystems_mpi_api_listener_ApiP2PEStatusListener_Handler")]
		public virtual unsafe void GetP2PEStatus (global::Com.Miurasystems.Mpi.Api.Listener.IApiP2PEStatusListener listener)
		{
			const string __id = "getP2PEStatus.(Lcom/miurasystems/mpi/api/listener/ApiP2PEStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_;
#pragma warning disable 0169
		static Delegate GetGetPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_Handler ()
		{
			if (cb_getPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_ == null)
				cb_getPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_);
			return cb_getPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_;
		}

		static void n_GetPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetConfigListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetConfigListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetPEDConfig (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getPEDConfig' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetConfigListener']]"
		[Register ("getPEDConfig", "(Lcom/miurasystems/mpi/api/listener/ApiGetConfigListener;)V", "GetGetPEDConfig_Lcom_miurasystems_mpi_api_listener_ApiGetConfigListener_Handler")]
		public virtual unsafe void GetPEDConfig (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetConfigListener listener)
		{
			const string __id = "getPEDConfig.(Lcom/miurasystems/mpi/api/listener/ApiGetConfigListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_;
#pragma warning disable 0169
		static Delegate GetGetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_Handler ()
		{
			if (cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ == null)
				cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZZZZLLL_V) n_GetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_);
			return cb_getSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_;
		}

		static void n_GetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ (IntPtr jnienv, IntPtr native__this, bool getPan, bool getStartDate, bool getExpiryDate, bool getCVV, bool yyMm, IntPtr native_options, IntPtr native_timeoutInSeconds, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSecureCardData (getPan, getStartDate, getExpiryDate, getCVV, yyMm, options, timeoutInSeconds, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSecureCardData' and count(parameter)=8 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[7][@type='java.lang.Integer'] and parameter[8][@type='com.miurasystems.mpi.api.listener.ApiGetSecureDataListener']]"
		[Register ("getSecureCardData", "(ZZZZZLjava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetSecureDataListener;)V", "GetGetSecureCardData_ZZZZZLjava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_Handler")]
		public virtual unsafe void GetSecureCardData (bool getPan, bool getStartDate, bool getExpiryDate, bool getCVV, bool yyMm, global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener listener)
		{
			const string __id = "getSecureCardData.(ZZZZZLjava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetSecureDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (getPan);
				__args [1] = new JniArgumentValue (getStartDate);
				__args [2] = new JniArgumentValue (getExpiryDate);
				__args [3] = new JniArgumentValue (getCVV);
				__args [4] = new JniArgumentValue (yyMm);
				__args [5] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [6] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [7] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_;
#pragma warning disable 0169
		static Delegate GetGetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_Handler ()
		{
			if (cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ == null)
				cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_);
			return cb_getSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_;
		}

		static void n_GetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_timeoutInSeconds, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_options, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSecurePan (options, timeoutInSeconds, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSecurePan' and count(parameter)=3 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='com.miurasystems.mpi.api.listener.ApiGetSecureDataListener']]"
		[Register ("getSecurePan", "(Ljava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetSecureDataListener;)V", "GetGetSecurePan_Ljava_util_EnumSet_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiGetSecureDataListener_Handler")]
		public virtual unsafe void GetSecurePan (global::Java.Util.EnumSet options, global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSecureDataListener listener)
		{
			const string __id = "getSecurePan.(Ljava/util/EnumSet;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiGetSecureDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [1] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_;
#pragma warning disable 0169
		static Delegate GetGetSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_Handler ()
		{
			if (cb_getSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_ == null)
				cb_getSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_);
			return cb_getSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_;
		}

		static void n_GetSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSoftwareInfo (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSoftwareInfo' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetSoftwareInfoListener']]"
		[Register ("getSoftwareInfo", "(Lcom/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListener;)V", "GetGetSoftwareInfo_Lcom_miurasystems_mpi_api_listener_ApiGetSoftwareInfoListener_Handler")]
		public virtual unsafe void GetSoftwareInfo (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSoftwareInfoListener listener)
		{
			const string __id = "getSoftwareInfo.(Lcom/miurasystems/mpi/api/listener/ApiGetSoftwareInfoListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_;
#pragma warning disable 0169
		static Delegate GetGetSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_Handler ()
		{
			if (cb_getSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_ == null)
				cb_getSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_);
			return cb_getSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_;
		}

		static void n_GetSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSystemClock (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSystemClock' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetSystemClockListener']]"
		[Register ("getSystemClock", "(Lcom/miurasystems/mpi/api/listener/ApiGetSystemClockListener;)V", "GetGetSystemClock_Lcom_miurasystems_mpi_api_listener_ApiGetSystemClockListener_Handler")]
		public virtual unsafe void GetSystemClock (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetSystemClockListener listener)
		{
			const string __id = "getSystemClock.(Lcom/miurasystems/mpi/api/listener/ApiGetSystemClockListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
#pragma warning disable 0169
		static Delegate GetGetSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler ()
		{
			if (cb_getSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ == null)
				cb_getSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_);
			return cb_getSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_;
		}

		static void n_GetSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSystemLog (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSystemLog' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiGetDeviceFileListener']]"
		[Register ("getSystemLog", "(Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V", "GetGetSystemLog_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileListener_Handler")]
		public virtual unsafe void GetSystemLog (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileListener listener)
		{
			const string __id = "getSystemLog.(Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_getSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_;
#pragma warning disable 0169
		static Delegate GetGetSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_Handler ()
		{
			if (cb_getSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_ == null)
				cb_getSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_);
			return cb_getSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_;
		}

		static void n_GetSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outputStream, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var outputStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outputStream, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetSystemLog (outputStream, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='getSystemLog' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiGetDeviceFileStreamListener']]"
		[Register ("getSystemLog", "(Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListener;)V", "GetGetSystemLog_Ljava_io_OutputStream_Lcom_miurasystems_mpi_api_listener_ApiGetDeviceFileStreamListener_Handler")]
		public virtual unsafe void GetSystemLog (global::System.IO.Stream outputStream, global::Com.Miurasystems.Mpi.Api.Listener.IApiGetDeviceFileStreamListener listener)
		{
			const string __id = "getSystemLog.(Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/listener/ApiGetDeviceFileStreamListener;)V";
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_outputStream);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (outputStream);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_hardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetHardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_hardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_hardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_HardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_hardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_HardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.HardReset (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='hardReset' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("hardReset", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetHardReset_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void HardReset (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "hardReset.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_keyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetKeyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_keyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_keyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_KeyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_keyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_KeyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_statusSettings, IntPtr native_backlightSettings, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var statusSettings = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.StatusSettings> (native_statusSettings, JniHandleOwnership.DoNotTransfer);
			var backlightSettings = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.BacklightSettings> (native_backlightSettings, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.KeyboardStatus (statusSettings, backlightSettings, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='keyboardStatus' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.enums.StatusSettings'] and parameter[2][@type='com.miurasystems.mpi.enums.BacklightSettings'] and parameter[3][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("keyboardStatus", "(Lcom/miurasystems/mpi/enums/StatusSettings;Lcom/miurasystems/mpi/enums/BacklightSettings;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetKeyboardStatus_Lcom_miurasystems_mpi_enums_StatusSettings_Lcom_miurasystems_mpi_enums_BacklightSettings_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void KeyboardStatus (global::Com.Miurasystems.Mpi.Enums.StatusSettings statusSettings, global::Com.Miurasystems.Mpi.Enums.BacklightSettings backlightSettings, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "keyboardStatus.(Lcom/miurasystems/mpi/enums/StatusSettings;Lcom/miurasystems/mpi/enums/BacklightSettings;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((statusSettings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statusSettings).Handle);
				__args [1] = new JniArgumentValue ((backlightSettings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backlightSettings).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (statusSettings);
				global::System.GC.KeepAlive (backlightSettings);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_listFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_;
#pragma warning disable 0169
		static Delegate GetListFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_Handler ()
		{
			if (cb_listFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ == null)
				cb_listFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ListFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_);
			return cb_listFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_;
		}

		static void n_ListFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ListFiles (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='listFiles' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiListFilesListener']]"
		[Register ("listFiles", "(Lcom/miurasystems/mpi/api/listener/ApiListFilesListener;)V", "GetListFiles_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_Handler")]
		public virtual unsafe void ListFiles (global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener listener)
		{
			const string __id = "listFiles.(Lcom/miurasystems/mpi/api/listener/ApiListFilesListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_;
#pragma warning disable 0169
		static Delegate GetListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_Handler ()
		{
			if (cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ == null)
				cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_);
			return cb_listFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_;
		}

		static void n_ListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folder, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ListFiles (folder, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='listFiles' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiListFilesListener']]"
		[Register ("listFiles", "(Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/ApiListFilesListener;)V", "GetListFiles_Lcom_miurasystems_mpi_enums_DeviceFolder_Lcom_miurasystems_mpi_api_listener_ApiListFilesListener_Handler")]
		public virtual unsafe void ListFiles (global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::Com.Miurasystems.Mpi.Api.Listener.IApiListFilesListener listener)
		{
			const string __id = "listFiles.(Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/listener/ApiListFilesListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_;
#pragma warning disable 0169
		static Delegate GetOnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_Handler ()
		{
			if (cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ == null)
				cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILLZZL_V) n_OnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_);
			return cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_;
		}

		static void n_OnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ (IntPtr jnienv, IntPtr native__this, int amountInPennies, int currencyCode, IntPtr native_maskedTrack2Data, IntPtr native_applicationLabel, bool encryptedPINData, bool enablePinByPass, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var maskedTrack2Data = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (native_maskedTrack2Data, JniHandleOwnership.DoNotTransfer);
			var applicationLabel = JNIEnv.GetString (native_applicationLabel, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OnlinePin (amountInPennies, currencyCode, maskedTrack2Data, applicationLabel, encryptedPINData, enablePinByPass, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='onlinePin' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='com.miurasystems.mpi.api.listener.ApiOnlinePinListener']]"
		[Register ("onlinePin", "(IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;ZZLcom/miurasystems/mpi/api/listener/ApiOnlinePinListener;)V", "GetOnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_ZZLcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_Handler")]
		public virtual unsafe void OnlinePin (int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string applicationLabel, bool encryptedPINData, bool enablePinByPass, global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener listener)
		{
			const string __id = "onlinePin.(IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;ZZLcom/miurasystems/mpi/api/listener/ApiOnlinePinListener;)V";
			IntPtr native_applicationLabel = JNIEnv.NewString (applicationLabel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (amountInPennies);
				__args [1] = new JniArgumentValue (currencyCode);
				__args [2] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [3] = new JniArgumentValue (native_applicationLabel);
				__args [4] = new JniArgumentValue (encryptedPINData);
				__args [5] = new JniArgumentValue (enablePinByPass);
				__args [6] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationLabel);
				global::System.GC.KeepAlive (maskedTrack2Data);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_;
#pragma warning disable 0169
		static Delegate GetOnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_Handler ()
		{
			if (cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ == null)
				cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILLL_V) n_OnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_);
			return cb_onlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_;
		}

		static void n_OnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_ (IntPtr jnienv, IntPtr native__this, int amountInPennies, int currencyCode, IntPtr native_maskedTrack2Data, IntPtr native_applicationLabel, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var maskedTrack2Data = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.Track2Data> (native_maskedTrack2Data, JniHandleOwnership.DoNotTransfer);
			var applicationLabel = JNIEnv.GetString (native_applicationLabel, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OnlinePin (amountInPennies, currencyCode, maskedTrack2Data, applicationLabel, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='onlinePin' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.miurasystems.mpi.tlv.Track2Data'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiOnlinePinListener']]"
		[Register ("onlinePin", "(IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiOnlinePinListener;)V", "GetOnlinePin_IILcom_miurasystems_mpi_tlv_Track2Data_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiOnlinePinListener_Handler")]
		public virtual unsafe void OnlinePin (int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Tlv.Track2Data maskedTrack2Data, string applicationLabel, global::Com.Miurasystems.Mpi.Api.Listener.IApiOnlinePinListener listener)
		{
			const string __id = "onlinePin.(IILcom/miurasystems/mpi/tlv/Track2Data;Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiOnlinePinListener;)V";
			IntPtr native_applicationLabel = JNIEnv.NewString (applicationLabel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (amountInPennies);
				__args [1] = new JniArgumentValue (currencyCode);
				__args [2] = new JniArgumentValue ((maskedTrack2Data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maskedTrack2Data).Handle);
				__args [3] = new JniArgumentValue (native_applicationLabel);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationLabel);
				global::System.GC.KeepAlive (maskedTrack2Data);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_openSession;
#pragma warning disable 0169
		static Delegate GetOpenSessionHandler ()
		{
			if (cb_openSession == null)
				cb_openSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OpenSession);
			return cb_openSession;
		}

		static void n_OpenSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='openSession' and count(parameter)=0]"
		[Register ("openSession", "()V", "GetOpenSessionHandler")]
		public virtual unsafe void OpenSession ()
		{
			const string __id = "openSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_peripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_;
#pragma warning disable 0169
		static Delegate GetPeripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_Handler ()
		{
			if (cb_peripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_ == null)
				cb_peripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PeripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_);
			return cb_peripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_;
		}

		static void n_PeripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.PeripheralStatusCommand (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='peripheralStatusCommand' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiPeripheralTypeListener']]"
		[Register ("peripheralStatusCommand", "(Lcom/miurasystems/mpi/api/listener/ApiPeripheralTypeListener;)V", "GetPeripheralStatusCommand_Lcom_miurasystems_mpi_api_listener_ApiPeripheralTypeListener_Handler")]
		public virtual unsafe void PeripheralStatusCommand (global::Com.Miurasystems.Mpi.Api.Listener.IApiPeripheralTypeListener listener)
		{
			const string __id = "peripheralStatusCommand.(Lcom/miurasystems/mpi/api/listener/ApiPeripheralTypeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_printESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetPrintESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_printESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_printESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_printESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_PrintESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.PrintESCPOSWithString (text, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='printESCPOSWithString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("printESCPOSWithString", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetPrintESCPOSWithString_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void PrintESCPOSWithString (string text, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "printESCPOSWithString.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_printerSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_;
#pragma warning disable 0169
		static Delegate GetPrinterSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_Handler ()
		{
			if (cb_printerSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_ == null)
				cb_printerSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_PrinterSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_);
			return cb_printerSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_;
		}

		static void n_PrinterSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_ (IntPtr jnienv, IntPtr native__this, bool printerSledStatusEnabled, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiPrinterStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiPrinterStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.PrinterSledStatus (printerSledStatusEnabled, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='printerSledStatus' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.miurasystems.mpi.api.listener.ApiPrinterStatusListener']]"
		[Register ("printerSledStatus", "(ZLcom/miurasystems/mpi/api/listener/ApiPrinterStatusListener;)V", "GetPrinterSledStatus_ZLcom_miurasystems_mpi_api_listener_ApiPrinterStatusListener_Handler")]
		public virtual unsafe void PrinterSledStatus (bool printerSledStatusEnabled, global::Com.Miurasystems.Mpi.Api.Listener.IApiPrinterStatusListener listener)
		{
			const string __id = "printerSledStatus.(ZLcom/miurasystems/mpi/api/listener/ApiPrinterStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (printerSledStatusEnabled);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_sendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_sendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_sendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_sendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SendDataToSerialPort (data, listener);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='sendDataToSerialPort' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("sendDataToSerialPort", "([BLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSendDataToSerialPort_arrayBLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SendDataToSerialPort (byte[] data, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "sendDataToSerialPort.([BLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_;
#pragma warning disable 0169
		static Delegate GetSetBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_Handler ()
		{
			if (cb_setBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ == null)
				cb_setBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZL_V) n_SetBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_);
			return cb_setBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_;
		}

		static void n_SetBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_ (IntPtr jnienv, IntPtr native__this, bool onChargingChange, bool onThresholdReached, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetBatteryStatusEvents (onChargingChange, onThresholdReached, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='setBatteryStatusEvents' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='com.miurasystems.mpi.api.listener.ApiBatteryStatusListener']]"
		[Register ("setBatteryStatusEvents", "(ZZLcom/miurasystems/mpi/api/listener/ApiBatteryStatusListener;)V", "GetSetBatteryStatusEvents_ZZLcom_miurasystems_mpi_api_listener_ApiBatteryStatusListener_Handler")]
		public virtual unsafe void SetBatteryStatusEvents (bool onChargingChange, bool onThresholdReached, global::Com.Miurasystems.Mpi.Api.Listener.IApiBatteryStatusListener listener)
		{
			const string __id = "setBatteryStatusEvents.(ZZLcom/miurasystems/mpi/api/listener/ApiBatteryStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (onChargingChange);
				__args [1] = new JniArgumentValue (onThresholdReached);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_setDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_Handler ()
		{
			if (cb_setDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_ == null)
				cb_setDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_);
			return cb_setDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_;
		}

		static void n_SetDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var deviceType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType> (native_deviceType, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceType (deviceType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.executor.MiuraManager.DeviceType']]"
		[Register ("setDeviceType", "(Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;)V", "GetSetDeviceType_Lcom_miurasystems_mpi_api_executor_MiuraManager_DeviceType_Handler")]
		public virtual unsafe void SetDeviceType (global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager.DeviceType deviceType)
		{
			const string __id = "setDeviceType.(Lcom/miurasystems/mpi/api/executor/MiuraManager$DeviceType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((deviceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deviceType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (deviceType);
			}
		}

		static Delegate cb_setSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSetSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_setSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_setSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_setSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SetSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newDate, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_newDate, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetSystemClock (newDate, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='setSystemClock' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("setSystemClock", "(Ljava/util/Date;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSetSystemClock_Ljava_util_Date_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SetSystemClock (global::Java.Util.Date newDate, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "setSystemClock.(Ljava/util/Date;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((newDate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newDate).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newDate);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_spoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSpoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_spoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_spoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SpoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_spoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SpoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SpoolClear (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='spoolClear' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("spoolClear", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSpoolClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SpoolClear (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "spoolClear.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_spoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSpoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_spoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_spoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SpoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_spoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SpoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageFileName, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageFileName = JNIEnv.GetString (native_imageFileName, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SpoolImage (imageFileName, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='spoolImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("spoolImage", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSpoolImage_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SpoolImage (string imageFileName, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "spoolImage.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_imageFileName = JNIEnv.NewString (imageFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_imageFileName);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageFileName);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_spoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSpoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_spoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_spoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SpoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_spoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SpoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SpoolPrint (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='spoolPrint' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("spoolPrint", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSpoolPrint_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SpoolPrint (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "spoolPrint.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_spoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetSpoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_spoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_spoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SpoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_spoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_SpoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SpoolText (text, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='spoolText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("spoolText", "(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetSpoolText_Ljava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void SpoolText (string text, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "spoolText.(Ljava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartContactlessTransaction (transactionType, amountInPennies, currencyCode, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startContactlessTransaction' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IILcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IILcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILL_V) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_timeoutInSeconds, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartContactlessTransaction (transactionType, amountInPennies, currencyCode, timeoutInSeconds, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startContactlessTransaction' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILL_V) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_languagePreference, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var languagePreference = JNIEnv.GetString (native_languagePreference, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartContactlessTransaction (transactionType, amountInPennies, currencyCode, languagePreference, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startContactlessTransaction' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, string languagePreference, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			IntPtr native_languagePreference = JNIEnv.NewString (languagePreference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue (native_languagePreference);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_languagePreference);
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILLL_V) n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_languagePreference, IntPtr native_timeoutInSeconds, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var languagePreference = JNIEnv.GetString (native_languagePreference, JniHandleOwnership.DoNotTransfer);
			var timeoutInSeconds = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_timeoutInSeconds, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartContactlessTransaction (transactionType, amountInPennies, currencyCode, languagePreference, timeoutInSeconds, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startContactlessTransaction' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Integer'] and parameter[6][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startContactlessTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartContactlessTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILjava_lang_String_Ljava_lang_Integer_Lcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartContactlessTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, string languagePreference, global::Java.Lang.Integer timeoutInSeconds, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startContactlessTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IILjava/lang/String;Ljava/lang/Integer;Lcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			IntPtr native_languagePreference = JNIEnv.NewString (languagePreference);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue (native_languagePreference);
				__args [4] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
				__args [5] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_languagePreference);
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (timeoutInSeconds);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZL_V) n_StartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, bool enableTrmStage, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartTransaction (transactionType, amountInPennies, currencyCode, enableTrmStage, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startTransaction' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IIZLcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IIZLcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, bool enableTrmStage, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IIZLcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue (enableTrmStage);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
#pragma warning disable 0169
		static Delegate GetStartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler ()
		{
			if (cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ == null)
				cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_StartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_);
			return cb_startTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_;
		}

		static void n_StartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transactionType, int amountInPennies, int currencyCode, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var transactionType = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.TransactionType> (native_transactionType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartTransaction (transactionType, amountInPennies, currencyCode, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='startTransaction' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.enums.TransactionType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.miurasystems.mpi.api.listener.ApiStartTransactionListener']]"
		[Register ("startTransaction", "(Lcom/miurasystems/mpi/enums/TransactionType;IILcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V", "GetStartTransaction_Lcom_miurasystems_mpi_enums_TransactionType_IILcom_miurasystems_mpi_api_listener_ApiStartTransactionListener_Handler")]
		public virtual unsafe void StartTransaction (global::Com.Miurasystems.Mpi.Enums.TransactionType transactionType, int amountInPennies, int currencyCode, global::Com.Miurasystems.Mpi.Api.Listener.IApiStartTransactionListener listener)
		{
			const string __id = "startTransaction.(Lcom/miurasystems/mpi/enums/TransactionType;IILcom/miurasystems/mpi/api/listener/ApiStartTransactionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((transactionType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transactionType).Handle);
				__args [1] = new JniArgumentValue (amountInPennies);
				__args [2] = new JniArgumentValue (currencyCode);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (transactionType);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_touchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_touchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_touchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_TouchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_touchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_TouchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_captureAreas, bool highlightAreas, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var captureAreas = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea>.FromJniHandle (native_captureAreas, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TouchCaptureBegin (captureAreas, highlightAreas, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='touchCaptureBegin' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.miurasystems.mpi.api.objects.TouchCaptureArea&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("touchCaptureBegin", "(Ljava/util/List;ZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetTouchCaptureBegin_Ljava_util_List_ZLcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void TouchCaptureBegin (global::System.Collections.Generic.IList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea> captureAreas, bool highlightAreas, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "touchCaptureBegin.(Ljava/util/List;ZLcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_captureAreas = global::Android.Runtime.JavaList<global::Com.Miurasystems.Mpi.Api.Objects.TouchCaptureArea>.ToLocalJniHandle (captureAreas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_captureAreas);
				__args [1] = new JniArgumentValue (highlightAreas);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_captureAreas);
				global::System.GC.KeepAlive (captureAreas);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_touchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_touchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_touchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_TouchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_touchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_TouchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TouchCaptureClear (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='touchCaptureClear' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("touchCaptureClear", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetTouchCaptureClear_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void TouchCaptureClear (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "touchCaptureClear.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_touchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_touchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_touchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_TouchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_touchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_TouchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TouchCaptureEnd (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='touchCaptureEnd' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("touchCaptureEnd", "(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetTouchCaptureEnd_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void TouchCaptureEnd (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "touchCaptureEnd.(Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_touchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler ()
		{
			if (cb_touchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ == null)
				cb_touchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_TouchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_);
			return cb_touchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_;
		}

		static void n_TouchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_ (IntPtr jnienv, IntPtr native__this, int areaToExport, IntPtr native_exportFilename, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exportFilename = JNIEnv.GetString (native_exportFilename, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TouchCaptureExportToPng (areaToExport, exportFilename, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='touchCaptureExportToPng' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.miurasystems.mpi.api.listener.MiuraDefaultListener']]"
		[Register ("touchCaptureExportToPng", "(ILjava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V", "GetTouchCaptureExportToPng_ILjava_lang_String_Lcom_miurasystems_mpi_api_listener_MiuraDefaultListener_Handler")]
		public virtual unsafe void TouchCaptureExportToPng (int areaToExport, string exportFilename, global::Com.Miurasystems.Mpi.Api.Listener.IMiuraDefaultListener listener)
		{
			const string __id = "touchCaptureExportToPng.(ILjava/lang/String;Lcom/miurasystems/mpi/api/listener/MiuraDefaultListener;)V";
			IntPtr native_exportFilename = JNIEnv.NewString (exportFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (areaToExport);
				__args [1] = new JniArgumentValue (native_exportFilename);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_exportFilename);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_touchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_;
#pragma warning disable 0169
		static Delegate GetTouchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_Handler ()
		{
			if (cb_touchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_ == null)
				cb_touchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_TouchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_);
			return cb_touchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_;
		}

		static void n_TouchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TouchCaptureStatus (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='touchCaptureStatus' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.listener.ApiTouchCaptureStatusListener']]"
		[Register ("touchCaptureStatus", "(Lcom/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListener;)V", "GetTouchCaptureStatus_Lcom_miurasystems_mpi_api_listener_ApiTouchCaptureStatusListener_Handler")]
		public virtual unsafe void TouchCaptureStatus (global::Com.Miurasystems.Mpi.Api.Listener.IApiTouchCaptureStatusListener listener)
		{
			const string __id = "touchCaptureStatus.(Lcom/miurasystems/mpi/api/listener/ApiTouchCaptureStatusListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_transferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_;
#pragma warning disable 0169
		static Delegate GetTransferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_Handler ()
		{
			if (cb_transferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ == null)
				cb_transferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_TransferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_);
			return cb_transferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_;
		}

		static void n_TransferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_folder, IntPtr native_fileStream, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var folder = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Enums.DeviceFolder> (native_folder, JniHandleOwnership.DoNotTransfer);
			var fileStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_fileStream, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TransferFileToDevice (fileName, folder, fileStream, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='transferFileToDevice' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='com.miurasystems.mpi.api.listener.APITransferFileListener']]"
		[Register ("transferFileToDevice", "(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/listener/APITransferFileListener;)V", "GetTransferFileToDevice_Ljava_lang_String_Lcom_miurasystems_mpi_enums_DeviceFolder_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_Handler")]
		public virtual unsafe void TransferFileToDevice (string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::System.IO.Stream fileStream, global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener listener)
		{
			const string __id = "transferFileToDevice.(Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/listener/APITransferFileListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fileStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [2] = new JniArgumentValue (native_fileStream);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_fileStream);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (fileStream);
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_transferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_;
#pragma warning disable 0169
		static Delegate GetTransferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_Handler ()
		{
			if (cb_transferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ == null)
				cb_transferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_TransferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_);
			return cb_transferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_;
		}

		static void n_TransferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_fileStream, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Executor.MiuraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			var fileStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_fileStream, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener)global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.TransferFileToDevice (fileName, fileStream, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.executor']/class[@name='MiuraManager']/method[@name='transferFileToDevice' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='com.miurasystems.mpi.api.listener.APITransferFileListener']]"
		[Register ("transferFileToDevice", "(Ljava/lang/String;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/listener/APITransferFileListener;)V", "GetTransferFileToDevice_Ljava_lang_String_Ljava_io_InputStream_Lcom_miurasystems_mpi_api_listener_APITransferFileListener_Handler")]
		public virtual unsafe void TransferFileToDevice (string fileName, global::System.IO.Stream fileStream, global::Com.Miurasystems.Mpi.Api.Listener.IAPITransferFileListener listener)
		{
			const string __id = "transferFileToDevice.(Ljava/lang/String;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/listener/APITransferFileListener;)V";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fileStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue (native_fileStream);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_fileStream);
				global::System.GC.KeepAlive (fileStream);
				global::System.GC.KeepAlive (listener);
			}
		}

	}
}
