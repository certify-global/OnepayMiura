using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/GetDeviceFile", DoNotGenerateAcw=true)]
	public sealed partial class GetDeviceFile : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']/field[@name='MIN_BYTES_BETWEEN_PROGRESS']"
		[Register ("MIN_BYTES_BETWEEN_PROGRESS")]
		public const int MinBytesBetweenProgress = (int) 2016;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/interface[@name='GetDeviceFile.ProgressCallback']"
		[Register ("com/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback", "", "Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/interface[@name='GetDeviceFile.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("onProgress", "(F)V", "GetOnProgress_FHandler:Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile/IProgressCallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnProgress (float p0);

		}

		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback", DoNotGenerateAcw=true)]
		internal partial class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback", typeof (IProgressCallbackInvoker));

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

			public static IProgressCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.utils.GetDeviceFile.ProgressCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProgress_F;
#pragma warning disable 0169
			static Delegate GetOnProgress_FHandler ()
			{
				if (cb_onProgress_F == null)
					cb_onProgress_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_OnProgress_F);
				return cb_onProgress_F;
			}

			static void n_OnProgress_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgress (p0);
			}
#pragma warning restore 0169

			IntPtr id_onProgress_F;
			public unsafe void OnProgress (float p0)
			{
				if (id_onProgress_F == IntPtr.Zero)
					id_onProgress_F = JNIEnv.GetMethodID (class_ref, "onProgress", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_F, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/GetDeviceFile", typeof (GetDeviceFile));
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

		internal GetDeviceFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']/method[@name='getDeviceFile' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.api.utils.GetDeviceFile.ProgressCallback']]"
		[Register ("getDeviceFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)[B", "")]
		public static unsafe byte[] InvokeGetDeviceFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile.IProgressCallback progress)
		{
			const string __id = "getDeviceFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)[B";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (progress);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']/method[@name='getDeviceFile' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[5][@type='com.miurasystems.mpi.api.utils.GetDeviceFile.ProgressCallback']]"
		[Register ("getDeviceFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)[B", "")]
		public static unsafe byte[] InvokeGetDeviceFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile.IProgressCallback progress)
		{
			const string __id = "getDeviceFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)[B";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [4] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (progress);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']/method[@name='getDeviceFile' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[5][@type='java.io.OutputStream'] and parameter[6][@type='com.miurasystems.mpi.api.utils.GetDeviceFile.ProgressCallback']]"
		[Register ("getDeviceFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)Z", "")]
		public static unsafe bool InvokeGetDeviceFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::System.IO.Stream outputStream, global::Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile.IProgressCallback progress)
		{
			const string __id = "getDeviceFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [4] = new JniArgumentValue (native_outputStream);
				__args [5] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (outputStream);
				global::System.GC.KeepAlive (progress);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='GetDeviceFile']/method[@name='getDeviceFile' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.io.OutputStream'] and parameter[5][@type='com.miurasystems.mpi.api.utils.GetDeviceFile.ProgressCallback']]"
		[Register ("getDeviceFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)Z", "")]
		public static unsafe bool InvokeGetDeviceFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::System.IO.Stream outputStream, global::Com.Miurasystems.Mpi.Api.Utils.GetDeviceFile.IProgressCallback progress)
		{
			const string __id = "getDeviceFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Ljava/io/OutputStream;Lcom/miurasystems/mpi/api/utils/GetDeviceFile$ProgressCallback;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue (native_outputStream);
				__args [4] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_outputStream);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (outputStream);
				global::System.GC.KeepAlive (progress);
			}
		}

	}
}
