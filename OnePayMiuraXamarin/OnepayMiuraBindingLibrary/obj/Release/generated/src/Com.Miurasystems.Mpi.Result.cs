using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/Result", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ReturnType", "ErrorType"})]
	public abstract partial class Result : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Error']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/Result$Error", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReturnType", "ErrorType"})]
		public sealed partial class Error : global::Com.Miurasystems.Mpi.Result {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/Result$Error", typeof (Error));
			internal static new IntPtr class_ref {
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

			internal Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Error']/constructor[@name='Result.Error' and count(parameter)=1 and parameter[1][@type='ErrorType']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe Error (global::Java.Lang.Object err)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_err = JNIEnv.ToLocalJniHandle (err);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_err);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_err);
					global::System.GC.KeepAlive (err);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Error']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object GetError ()
			{
				const string __id = "getError.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Success']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/Result$Success", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"ReturnType", "ErrorType"})]
		public sealed partial class Success : global::Com.Miurasystems.Mpi.Result {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/Result$Success", typeof (Success));
			internal static new IntPtr class_ref {
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

			internal Success (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Success']/constructor[@name='Result.Success' and count(parameter)=1 and parameter[1][@type='ReturnType']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe Success (global::Java.Lang.Object value)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}

			public unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result.Success']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "")]
				get {
					const string __id = "getValue.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/Result", typeof (Result));
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

		protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "")]
			get {
				const string __id = "isError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result']/method[@name='asError' and count(parameter)=0]"
		[Register ("asError", "()Lcom/miurasystems/mpi/Result$Error;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Result.Error AsError ()
		{
			const string __id = "asError.()Lcom/miurasystems/mpi/Result$Error;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result.Error> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi']/class[@name='Result']/method[@name='asSuccess' and count(parameter)=0]"
		[Register ("asSuccess", "()Lcom/miurasystems/mpi/Result$Success;", "")]
		public unsafe global::Com.Miurasystems.Mpi.Result.Success AsSuccess ()
		{
			const string __id = "asSuccess.()Lcom/miurasystems/mpi/Result$Success;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Result.Success> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/miurasystems/mpi/Result", DoNotGenerateAcw=true)]
	internal partial class ResultInvoker : Result {

		public ResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/Result", typeof (ResultInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
