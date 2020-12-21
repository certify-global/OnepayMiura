using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryFile']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/StreamBinaryFile", DoNotGenerateAcw=true)]
	public sealed partial class StreamBinaryFile : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/interface[@name='StreamBinaryFile.ProgressCallback']"
		[Register ("com/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback", "", "Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/interface[@name='StreamBinaryFile.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile/IProgressCallbackInvoker, OnepayMiuraBindingLibrary")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback", DoNotGenerateAcw=true)]
		internal partial class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback", typeof (IProgressCallbackInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "com.miurasystems.mpi.api.utils.StreamBinaryFile.ProgressCallback"));
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

			static Delegate cb_onProgress_I;
#pragma warning disable 0169
			static Delegate GetOnProgress_IHandler ()
			{
				if (cb_onProgress_I == null)
					cb_onProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnProgress_I);
				return cb_onProgress_I;
			}

			static void n_OnProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgress (p0);
			}
#pragma warning restore 0169

			IntPtr id_onProgress_I;
			public unsafe void OnProgress (int p0)
			{
				if (id_onProgress_I == IntPtr.Zero)
					id_onProgress_I = JNIEnv.GetMethodID (class_ref, "onProgress", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_I, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/utils/StreamBinaryFile", typeof (StreamBinaryFile));
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

		internal StreamBinaryFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryFile']/method[@name='streamBinaryFile' and count(parameter)=6 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[5][@type='java.io.InputStream'] and parameter[6][@type='com.miurasystems.mpi.api.utils.StreamBinaryFile.ProgressCallback']]"
		[Register ("streamBinaryFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)Z", "")]
		public static unsafe bool InvokeStreamBinaryFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, global::System.IO.Stream fileInStream, global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile.IProgressCallback progress)
		{
			const string __id = "streamBinaryFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileInStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fileInStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [4] = new JniArgumentValue (native_fileInStream);
				__args [5] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_fileInStream);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (fileInStream);
				global::System.GC.KeepAlive (progress);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryFile']/method[@name='streamBinaryFile' and count(parameter)=5 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='com.miurasystems.mpi.enums.InterfaceType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.io.InputStream'] and parameter[5][@type='com.miurasystems.mpi.api.utils.StreamBinaryFile.ProgressCallback']]"
		[Register ("streamBinaryFile", "(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)Z", "")]
		public static unsafe bool InvokeStreamBinaryFile (global::Com.Miurasystems.Mpi.MpiClient client, global::Com.Miurasystems.Mpi.Enums.InterfaceType interfaceType, string fileName, global::System.IO.Stream fileInStream, global::Com.Miurasystems.Mpi.Api.Utils.StreamBinaryFile.IProgressCallback progress)
		{
			const string __id = "streamBinaryFile.(Lcom/miurasystems/mpi/MpiClient;Lcom/miurasystems/mpi/enums/InterfaceType;Ljava/lang/String;Ljava/io/InputStream;Lcom/miurasystems/mpi/api/utils/StreamBinaryFile$ProgressCallback;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileInStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (fileInStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue ((interfaceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interfaceType).Handle);
				__args [2] = new JniArgumentValue (native_fileName);
				__args [3] = new JniArgumentValue (native_fileInStream);
				__args [4] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_fileInStream);
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (interfaceType);
				global::System.GC.KeepAlive (fileInStream);
				global::System.GC.KeepAlive (progress);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryFile']/method[@name='streamBinaryFile' and count(parameter)=3 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("streamBinaryFile", "(Lcom/miurasystems/mpi/MpiClient;Ljava/lang/String;[B)Z", "")]
		public static unsafe bool InvokeStreamBinaryFile (global::Com.Miurasystems.Mpi.MpiClient client, string fileName, byte[] fileBytes)
		{
			const string __id = "streamBinaryFile.(Lcom/miurasystems/mpi/MpiClient;Ljava/lang/String;[B)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileBytes = JNIEnv.NewArray (fileBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue (native_fileName);
				__args [2] = new JniArgumentValue (native_fileBytes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				if (fileBytes != null) {
					JNIEnv.CopyArray (native_fileBytes, fileBytes);
					JNIEnv.DeleteLocalRef (native_fileBytes);
				}
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (fileBytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.utils']/class[@name='StreamBinaryFile']/method[@name='streamBinaryFile' and count(parameter)=4 and parameter[1][@type='com.miurasystems.mpi.MpiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.miurasystems.mpi.enums.DeviceFolder'] and parameter[4][@type='byte[]']]"
		[Register ("streamBinaryFile", "(Lcom/miurasystems/mpi/MpiClient;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;[B)Z", "")]
		public static unsafe bool InvokeStreamBinaryFile (global::Com.Miurasystems.Mpi.MpiClient client, string fileName, global::Com.Miurasystems.Mpi.Enums.DeviceFolder folder, byte[] fileBytes)
		{
			const string __id = "streamBinaryFile.(Lcom/miurasystems/mpi/MpiClient;Ljava/lang/String;Lcom/miurasystems/mpi/enums/DeviceFolder;[B)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_fileBytes = JNIEnv.NewArray (fileBytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [1] = new JniArgumentValue (native_fileName);
				__args [2] = new JniArgumentValue ((folder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) folder).Handle);
				__args [3] = new JniArgumentValue (native_fileBytes);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				if (fileBytes != null) {
					JNIEnv.CopyArray (native_fileBytes, fileBytes);
					JNIEnv.DeleteLocalRef (native_fileBytes);
				}
				global::System.GC.KeepAlive (client);
				global::System.GC.KeepAlive (folder);
				global::System.GC.KeepAlive (fileBytes);
			}
		}

	}
}
