using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Aspects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/aspects/LoggingAspect", DoNotGenerateAcw=true)]
	public partial class LoggingAspect : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/aspects/LoggingAspect", typeof (LoggingAspect));
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

		protected LoggingAspect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/constructor[@name='LoggingAspect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggingAspect ()
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

		public static unsafe bool HasAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='hasAspect' and count(parameter)=0]"
			[Register ("hasAspect", "()Z", "")]
			get {
				const string __id = "hasAspect.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='aspectOf' and count(parameter)=0]"
		[Register ("aspectOf", "()Lcom/miurasystems/mpi/aspects/LoggingAspect;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Aspects.LoggingAspect AspectOf ()
		{
			const string __id = "aspectOf.()Lcom/miurasystems/mpi/aspects/LoggingAspect;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Aspects.LoggingAspect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLogAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_Handler ()
		{
			if (cb_logAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_ == null)
				cb_logAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_LogAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_);
			return cb_logAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_;
		}

		static void n_LogAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_joinPoint, IntPtr native_returnValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Aspects.LoggingAspect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var joinPoint = (global::Org.Aspectj.Lang.IJoinPoint)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (native_joinPoint, JniHandleOwnership.DoNotTransfer);
			var returnValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_returnValue, JniHandleOwnership.DoNotTransfer);
			__this.LogAfterMpiClient (joinPoint, returnValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='logAfterMpiClient' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.JoinPoint'] and parameter[2][@type='java.lang.Object']]"
		[Register ("logAfterMpiClient", "(Lorg/aspectj/lang/JoinPoint;Ljava/lang/Object;)V", "GetLogAfterMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Object_Handler")]
		public virtual unsafe void LogAfterMpiClient (global::Org.Aspectj.Lang.IJoinPoint joinPoint, global::Java.Lang.Object returnValue)
		{
			const string __id = "logAfterMpiClient.(Lorg/aspectj/lang/JoinPoint;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((joinPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) joinPoint).Handle);
				__args [1] = new JniArgumentValue ((returnValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnValue).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (joinPoint);
				global::System.GC.KeepAlive (returnValue);
			}
		}

		static Delegate cb_logAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetLogAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_Handler ()
		{
			if (cb_logAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_ == null)
				cb_logAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_LogAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_);
			return cb_logAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_;
		}

		static void n_LogAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_joinPoint, IntPtr native_ex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Aspects.LoggingAspect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var joinPoint = (global::Org.Aspectj.Lang.IJoinPoint)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (native_joinPoint, JniHandleOwnership.DoNotTransfer);
			var ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.LogAfterThrowingMpiClient (joinPoint, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='logAfterThrowingMpiClient' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.JoinPoint'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("logAfterThrowingMpiClient", "(Lorg/aspectj/lang/JoinPoint;Ljava/lang/Exception;)V", "GetLogAfterThrowingMpiClient_Lorg_aspectj_lang_JoinPoint_Ljava_lang_Exception_Handler")]
		public virtual unsafe void LogAfterThrowingMpiClient (global::Org.Aspectj.Lang.IJoinPoint joinPoint, global::Java.Lang.Exception ex)
		{
			const string __id = "logAfterThrowingMpiClient.(Lorg/aspectj/lang/JoinPoint;Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((joinPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) joinPoint).Handle);
				__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (joinPoint);
				global::System.GC.KeepAlive (ex);
			}
		}

		static Delegate cb_logBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_;
#pragma warning disable 0169
		static Delegate GetLogBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_Handler ()
		{
			if (cb_logBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_ == null)
				cb_logBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_LogBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_);
			return cb_logBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_;
		}

		static void n_LogBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_joinPoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Aspects.LoggingAspect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var joinPoint = (global::Org.Aspectj.Lang.IJoinPoint)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (native_joinPoint, JniHandleOwnership.DoNotTransfer);
			__this.LogBeforeMpiClient (joinPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='logBeforeMpiClient' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.JoinPoint']]"
		[Register ("logBeforeMpiClient", "(Lorg/aspectj/lang/JoinPoint;)V", "GetLogBeforeMpiClient_Lorg_aspectj_lang_JoinPoint_Handler")]
		public virtual unsafe void LogBeforeMpiClient (global::Org.Aspectj.Lang.IJoinPoint joinPoint)
		{
			const string __id = "logBeforeMpiClient.(Lorg/aspectj/lang/JoinPoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((joinPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) joinPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (joinPoint);
			}
		}

		static Delegate cb_loggingAnnotation;
#pragma warning disable 0169
		static Delegate GetLoggingAnnotationHandler ()
		{
			if (cb_loggingAnnotation == null)
				cb_loggingAnnotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_LoggingAnnotation);
			return cb_loggingAnnotation;
		}

		static void n_LoggingAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Aspects.LoggingAspect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoggingAnnotation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='loggingAnnotation' and count(parameter)=0]"
		[Register ("loggingAnnotation", "()V", "GetLoggingAnnotationHandler")]
		public virtual unsafe void LoggingAnnotation ()
		{
			const string __id = "loggingAnnotation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.aspects']/class[@name='LoggingAspect']/method[@name='mpiClient' and count(parameter)=0]"
		[Register ("mpiClient", "()V", "")]
		public static unsafe void MpiClient ()
		{
			const string __id = "mpiClient.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
