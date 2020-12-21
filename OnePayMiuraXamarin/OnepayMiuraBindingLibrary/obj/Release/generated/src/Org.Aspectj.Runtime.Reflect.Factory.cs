using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/reflect/Factory", DoNotGenerateAcw=true)]
	public sealed partial class Factory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/reflect/Factory", typeof (Factory));
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

		internal Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/constructor[@name='Factory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public unsafe Factory (string filename, global::Java.Lang.Class lexicalClass)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filename);
				__args [1] = new JniArgumentValue ((lexicalClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lexicalClass).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
				global::System.GC.KeepAlive (lexicalClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceESJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.Class[]'] and parameter[8][@type='java.lang.Class'] and parameter[9][@type='int']]"
		[Register ("makeAdviceESJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeAdviceESJP (string kind, int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType, int line)
		{
			const string __id = "makeAdviceESJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue (native_parameterTypes);
				__args [5] = new JniArgumentValue (native_parameterNames);
				__args [6] = new JniArgumentValue (native_exceptionTypes);
				__args [7] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				__args [8] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.Class[]'] and parameter[8][@type='java.lang.Class'] and parameter[9][@type='int']]"
		[Register ("makeAdviceSJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeAdviceSJP (string kind, int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType, int line)
		{
			const string __id = "makeAdviceSJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue (native_parameterTypes);
				__args [5] = new JniArgumentValue (native_parameterNames);
				__args [6] = new JniArgumentValue (native_exceptionTypes);
				__args [7] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				__args [8] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='java.lang.Class']]"
		[Register ("makeAdviceSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType)
		{
			const string __id = "makeAdviceSig.(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AdviceSignature;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (modifiers);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				__args [4] = new JniArgumentValue (native_parameterNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeAdviceSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (string stringRep)
		{
			const string __id = "makeAdviceSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeAdviceSig' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("makeAdviceSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdviceSignature MakeAdviceSig (string modifiers, string name, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType)
		{
			const string __id = "makeAdviceSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/AdviceSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_declaringType);
				__args [3] = new JniArgumentValue (native_paramTypes);
				__args [4] = new JniArgumentValue (native_paramNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue (native_returnType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdviceSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseESJP' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("makeCatchClauseESJP", "(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeCatchClauseESJP (string kind, global::Java.Lang.Class declaringType, global::Java.Lang.Class parameterType, string parameterName, int line)
		{
			const string __id = "makeCatchClauseESJP.(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue ((parameterType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameterType).Handle);
				__args [3] = new JniArgumentValue (native_parameterName);
				__args [4] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_parameterName);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSJP' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("makeCatchClauseSJP", "(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeCatchClauseSJP (string kind, global::Java.Lang.Class declaringType, global::Java.Lang.Class parameterType, string parameterName, int line)
		{
			const string __id = "makeCatchClauseSJP.(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue ((parameterType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameterType).Handle);
				__args [3] = new JniArgumentValue (native_parameterName);
				__args [4] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_parameterName);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (global::Java.Lang.Class declaringType, global::Java.Lang.Class parameterType, string parameterName)
		{
			const string __id = "makeCatchClauseSig.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;";
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [1] = new JniArgumentValue ((parameterType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameterType).Handle);
				__args [2] = new JniArgumentValue (native_parameterName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_parameterName);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (string stringRep)
		{
			const string __id = "makeCatchClauseSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeCatchClauseSig' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("makeCatchClauseSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature MakeCatchClauseSig (string declaringType, string parameterType, string parameterName)
		{
			const string __id = "makeCatchClauseSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/CatchClauseSignature;";
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_parameterType = JNIEnv.NewString (parameterType);
			IntPtr native_parameterName = JNIEnv.NewString (parameterName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_declaringType);
				__args [1] = new JniArgumentValue (native_parameterType);
				__args [2] = new JniArgumentValue (native_parameterName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ICatchClauseSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_parameterType);
				JNIEnv.DeleteLocalRef (native_parameterName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorESJP' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='int']]"
		[Register ("makeConstructorESJP", "(Ljava/lang/String;ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeConstructorESJP (string kind, int modifiers, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, int line)
		{
			const string __id = "makeConstructorESJP.(Ljava/lang/String;ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				__args [4] = new JniArgumentValue (native_parameterNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSJP' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='int']]"
		[Register ("makeConstructorSJP", "(Ljava/lang/String;ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeConstructorSJP (string kind, int modifiers, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, int line)
		{
			const string __id = "makeConstructorSJP.(Ljava/lang/String;ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				__args [4] = new JniArgumentValue (native_parameterNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.Class[]']]"
		[Register ("makeConstructorSig", "(ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (int modifiers, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes)
		{
			const string __id = "makeConstructorSig.(ILjava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;)Lorg/aspectj/lang/reflect/ConstructorSignature;";
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (modifiers);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue (native_parameterTypes);
				__args [3] = new JniArgumentValue (native_parameterNames);
				__args [4] = new JniArgumentValue (native_exceptionTypes);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeConstructorSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (string stringRep)
		{
			const string __id = "makeConstructorSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeConstructorSig' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("makeConstructorSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IConstructorSignature MakeConstructorSig (string modifiers, string declaringType, string paramTypes, string paramNames, string exceptionTypes)
		{
			const string __id = "makeConstructorSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/ConstructorSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_declaringType);
				__args [2] = new JniArgumentValue (native_paramTypes);
				__args [3] = new JniArgumentValue (native_paramNames);
				__args [4] = new JniArgumentValue (native_exceptionTypes);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IConstructorSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l)
		{
			const string __id = "makeESJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue (l);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l, int c)
		{
			const string __id = "makeESJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue (l);
				__args [3] = new JniArgumentValue (c);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='org.aspectj.lang.reflect.SourceLocation']]"
		[Register ("makeESJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeESJP (string kind, global::Org.Aspectj.Lang.ISignature sig, global::Org.Aspectj.Lang.Reflect.ISourceLocation loc)
		{
			const string __id = "makeESJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue ((loc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loc).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
				global::System.GC.KeepAlive (loc);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeEncSJP' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Member']]"
		[Register ("makeEncSJP", "(Ljava/lang/reflect/Member;)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeEncSJP (global::Java.Lang.Reflect.IMember member)
		{
			const string __id = "makeEncSJP.(Ljava/lang/reflect/Member;)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((member == null) ? IntPtr.Zero : ((global::Java.Lang.Object) member).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (member);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldESJP' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class'] and parameter[6][@type='int']]"
		[Register ("makeFieldESJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeFieldESJP (string kind, int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class fieldType, int line)
		{
			const string __id = "makeFieldESJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue ((fieldType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldType).Handle);
				__args [5] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (fieldType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSJP' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class'] and parameter[6][@type='int']]"
		[Register ("makeFieldSJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeFieldSJP (string kind, int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class fieldType, int line)
		{
			const string __id = "makeFieldSJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue ((fieldType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldType).Handle);
				__args [5] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (fieldType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class']]"
		[Register ("makeFieldSig", "(ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class fieldType)
		{
			const string __id = "makeFieldSig.(ILjava/lang/String;Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/FieldSignature;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (modifiers);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue ((fieldType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fieldType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (fieldType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFieldSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (string stringRep)
		{
			const string __id = "makeFieldSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeFieldSig' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("makeFieldSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IFieldSignature MakeFieldSig (string modifiers, string name, string declaringType, string fieldType)
		{
			const string __id = "makeFieldSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/FieldSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_fieldType = JNIEnv.NewString (fieldType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_declaringType);
				__args [3] = new JniArgumentValue (native_fieldType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IFieldSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_fieldType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerESJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='int']]"
		[Register ("makeInitializerESJP", "(Ljava/lang/String;ILjava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeInitializerESJP (string kind, int modifiers, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeInitializerESJP.(Ljava/lang/String;ILjava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='int']]"
		[Register ("makeInitializerSJP", "(Ljava/lang/String;ILjava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeInitializerSJP (string kind, int modifiers, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeInitializerSJP.(Ljava/lang/String;ILjava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Class']]"
		[Register ("makeInitializerSig", "(ILjava/lang/Class;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (int modifiers, global::Java.Lang.Class declaringType)
		{
			const string __id = "makeInitializerSig.(ILjava/lang/Class;)Lorg/aspectj/lang/reflect/InitializerSignature;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (modifiers);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeInitializerSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (string stringRep)
		{
			const string __id = "makeInitializerSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeInitializerSig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("makeInitializerSig", "(Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IInitializerSignature MakeInitializerSig (string modifiers, string declaringType)
		{
			const string __id = "makeInitializerSig.(Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/InitializerSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_declaringType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInitializerSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=3 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target)
		{
			const string __id = "makeJP.(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((staticPart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) staticPart).Handle);
				__args [1] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [2] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (staticPart);
				global::System.GC.KeepAlive (_this);
				global::System.GC.KeepAlive (target);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object arg0)
		{
			const string __id = "makeJP.(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((staticPart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) staticPart).Handle);
				__args [1] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [2] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [3] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (staticPart);
				global::System.GC.KeepAlive (_this);
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (arg0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=5 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object arg0, global::Java.Lang.Object arg1)
		{
			const string __id = "makeJP.(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((staticPart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) staticPart).Handle);
				__args [1] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [2] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [3] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				__args [4] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (staticPart);
				global::System.GC.KeepAlive (_this);
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (arg0);
				global::System.GC.KeepAlive (arg1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeJP' and count(parameter)=4 and parameter[1][@type='org.aspectj.lang.JoinPoint.StaticPart'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("makeJP", "(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;", "")]
		public static unsafe global::Org.Aspectj.Lang.IJoinPoint MakeJP (global::Org.Aspectj.Lang.IJoinPointStaticPart staticPart, global::Java.Lang.Object _this, global::Java.Lang.Object target, global::Java.Lang.Object[] args)
		{
			const string __id = "makeJP.(Lorg/aspectj/lang/JoinPoint$StaticPart;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Lorg/aspectj/lang/JoinPoint;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((staticPart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) staticPart).Handle);
				__args [1] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [2] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (staticPart);
				global::System.GC.KeepAlive (_this);
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int']]"
		[Register ("makeLockESJP", "(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeLockESJP (string kind, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeLockESJP.(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int']]"
		[Register ("makeLockSJP", "(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeLockSJP (string kind, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeLockSJP.(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=0]"
		[Register ("makeLockSig", "()Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig ()
		{
			const string __id = "makeLockSig.()Lorg/aspectj/lang/reflect/LockSignature;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("makeLockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig (global::Java.Lang.Class declaringType)
		{
			const string __id = "makeLockSig.(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/LockSignature;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeLockSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeLockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/LockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ILockSignature MakeLockSig (string stringRep)
		{
			const string __id = "makeLockSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/LockSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ILockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodESJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.Class[]'] and parameter[8][@type='java.lang.Class'] and parameter[9][@type='int']]"
		[Register ("makeMethodESJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeMethodESJP (string kind, int modifiers, string methodName, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] paramTypes, string[] paramNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType, int line)
		{
			const string __id = "makeMethodESJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_paramTypes = JNIEnv.NewArray (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewArray (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue (native_paramTypes);
				__args [5] = new JniArgumentValue (native_paramNames);
				__args [6] = new JniArgumentValue (native_exceptionTypes);
				__args [7] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				__args [8] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (paramTypes != null) {
					JNIEnv.CopyArray (native_paramTypes, paramTypes);
					JNIEnv.DeleteLocalRef (native_paramTypes);
				}
				if (paramNames != null) {
					JNIEnv.CopyArray (native_paramNames, paramNames);
					JNIEnv.DeleteLocalRef (native_paramNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (paramTypes);
				global::System.GC.KeepAlive (paramNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class'] and parameter[5][@type='java.lang.Class[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.Class[]'] and parameter[8][@type='java.lang.Class'] and parameter[9][@type='int']]"
		[Register ("makeMethodSJP", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeMethodSJP (string kind, int modifiers, string methodName, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] paramTypes, string[] paramNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType, int line)
		{
			const string __id = "makeMethodSJP.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_paramTypes = JNIEnv.NewArray (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewArray (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (modifiers);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [4] = new JniArgumentValue (native_paramTypes);
				__args [5] = new JniArgumentValue (native_paramNames);
				__args [6] = new JniArgumentValue (native_exceptionTypes);
				__args [7] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				__args [8] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_methodName);
				if (paramTypes != null) {
					JNIEnv.CopyArray (native_paramTypes, paramTypes);
					JNIEnv.DeleteLocalRef (native_paramTypes);
				}
				if (paramNames != null) {
					JNIEnv.CopyArray (native_paramNames, paramNames);
					JNIEnv.DeleteLocalRef (native_paramNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (paramTypes);
				global::System.GC.KeepAlive (paramNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.Class[]'] and parameter[7][@type='java.lang.Class']]"
		[Register ("makeMethodSig", "(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (int modifiers, string name, global::Java.Lang.Class declaringType, global::Java.Lang.Class[] parameterTypes, string[] parameterNames, global::Java.Lang.Class[] exceptionTypes, global::Java.Lang.Class returnType)
		{
			const string __id = "makeMethodSig.(ILjava/lang/String;Ljava/lang/Class;[Ljava/lang/Class;[Ljava/lang/String;[Ljava/lang/Class;Ljava/lang/Class;)Lorg/aspectj/lang/reflect/MethodSignature;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_parameterTypes = JNIEnv.NewArray (parameterTypes);
			IntPtr native_parameterNames = JNIEnv.NewArray (parameterNames);
			IntPtr native_exceptionTypes = JNIEnv.NewArray (exceptionTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (modifiers);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [3] = new JniArgumentValue (native_parameterTypes);
				__args [4] = new JniArgumentValue (native_parameterNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue ((returnType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) returnType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (parameterTypes != null) {
					JNIEnv.CopyArray (native_parameterTypes, parameterTypes);
					JNIEnv.DeleteLocalRef (native_parameterTypes);
				}
				if (parameterNames != null) {
					JNIEnv.CopyArray (native_parameterNames, parameterNames);
					JNIEnv.DeleteLocalRef (native_parameterNames);
				}
				if (exceptionTypes != null) {
					JNIEnv.CopyArray (native_exceptionTypes, exceptionTypes);
					JNIEnv.DeleteLocalRef (native_exceptionTypes);
				}
				global::System.GC.KeepAlive (declaringType);
				global::System.GC.KeepAlive (parameterTypes);
				global::System.GC.KeepAlive (parameterNames);
				global::System.GC.KeepAlive (exceptionTypes);
				global::System.GC.KeepAlive (returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeMethodSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (string stringRep)
		{
			const string __id = "makeMethodSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("makeMethodSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (string modifiers, string methodName, global::Java.Lang.Class declaringTypeClass, string paramTypes, string paramNames, string exceptionTypes, string returnType)
		{
			const string __id = "makeMethodSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue ((declaringTypeClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringTypeClass).Handle);
				__args [3] = new JniArgumentValue (native_paramTypes);
				__args [4] = new JniArgumentValue (native_paramNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue (native_returnType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
				global::System.GC.KeepAlive (declaringTypeClass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeMethodSig' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("makeMethodSig", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IMethodSignature MakeMethodSig (string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType)
		{
			const string __id = "makeMethodSig.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/aspectj/lang/reflect/MethodSignature;";
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_modifiers);
				__args [1] = new JniArgumentValue (native_methodName);
				__args [2] = new JniArgumentValue (native_declaringType);
				__args [3] = new JniArgumentValue (native_paramTypes);
				__args [4] = new JniArgumentValue (native_paramNames);
				__args [5] = new JniArgumentValue (native_exceptionTypes);
				__args [6] = new JniArgumentValue (native_returnType);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IMethodSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string returnType, int l)
		{
			const string __id = "makeSJP.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (native_modifiers);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue (native_declaringType);
				__args [4] = new JniArgumentValue (native_paramTypes);
				__args [5] = new JniArgumentValue (native_paramNames);
				__args [6] = new JniArgumentValue (native_returnType);
				__args [7] = new JniArgumentValue (l);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, string modifiers, string methodName, string declaringType, string paramTypes, string paramNames, string exceptionTypes, string returnType, int l)
		{
			const string __id = "makeSJP.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_modifiers = JNIEnv.NewString (modifiers);
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_declaringType = JNIEnv.NewString (declaringType);
			IntPtr native_paramTypes = JNIEnv.NewString (paramTypes);
			IntPtr native_paramNames = JNIEnv.NewString (paramNames);
			IntPtr native_exceptionTypes = JNIEnv.NewString (exceptionTypes);
			IntPtr native_returnType = JNIEnv.NewString (returnType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (native_modifiers);
				__args [2] = new JniArgumentValue (native_methodName);
				__args [3] = new JniArgumentValue (native_declaringType);
				__args [4] = new JniArgumentValue (native_paramTypes);
				__args [5] = new JniArgumentValue (native_paramNames);
				__args [6] = new JniArgumentValue (native_exceptionTypes);
				__args [7] = new JniArgumentValue (native_returnType);
				__args [8] = new JniArgumentValue (l);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_modifiers);
				JNIEnv.DeleteLocalRef (native_methodName);
				JNIEnv.DeleteLocalRef (native_declaringType);
				JNIEnv.DeleteLocalRef (native_paramTypes);
				JNIEnv.DeleteLocalRef (native_paramNames);
				JNIEnv.DeleteLocalRef (native_exceptionTypes);
				JNIEnv.DeleteLocalRef (native_returnType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l)
		{
			const string __id = "makeSJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue (l);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, int l, int c)
		{
			const string __id = "makeSJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;II)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue (l);
				__args [3] = new JniArgumentValue (c);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.Signature'] and parameter[3][@type='org.aspectj.lang.reflect.SourceLocation']]"
		[Register ("makeSJP", "(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeSJP (string kind, global::Org.Aspectj.Lang.ISignature sig, global::Org.Aspectj.Lang.Reflect.ISourceLocation loc)
		{
			const string __id = "makeSJP.(Ljava/lang/String;Lorg/aspectj/lang/Signature;Lorg/aspectj/lang/reflect/SourceLocation;)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [2] = new JniArgumentValue ((loc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) loc).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (sig);
				global::System.GC.KeepAlive (loc);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeSourceLoc' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("makeSourceLoc", "(II)Lorg/aspectj/lang/reflect/SourceLocation;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.ISourceLocation MakeSourceLoc (int line, int col)
		{
			const string __id = "makeSourceLoc.(II)Lorg/aspectj/lang/reflect/SourceLocation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (line);
				__args [1] = new JniArgumentValue (col);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISourceLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockESJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int']]"
		[Register ("makeUnlockESJP", "(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart MakeUnlockESJP (string kind, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeUnlockESJP.(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$EnclosingStaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointEnclosingStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSJP' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int']]"
		[Register ("makeUnlockSJP", "(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;", "")]
		public unsafe global::Org.Aspectj.Lang.IJoinPointStaticPart MakeUnlockSJP (string kind, global::Java.Lang.Class declaringType, int line)
		{
			const string __id = "makeUnlockSJP.(Ljava/lang/String;Ljava/lang/Class;I)Lorg/aspectj/lang/JoinPoint$StaticPart;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				__args [2] = new JniArgumentValue (line);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IJoinPointStaticPart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=0]"
		[Register ("makeUnlockSig", "()Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig ()
		{
			const string __id = "makeUnlockSig.()Lorg/aspectj/lang/reflect/UnlockSignature;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("makeUnlockSig", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig (global::Java.Lang.Class declaringType)
		{
			const string __id = "makeUnlockSig.(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/UnlockSignature;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((declaringType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) declaringType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (declaringType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.reflect']/class[@name='Factory']/method[@name='makeUnlockSig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeUnlockSig", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/UnlockSignature;", "")]
		public unsafe global::Org.Aspectj.Lang.Reflect.IUnlockSignature MakeUnlockSig (string stringRep)
		{
			const string __id = "makeUnlockSig.(Ljava/lang/String;)Lorg/aspectj/lang/reflect/UnlockSignature;";
			IntPtr native_stringRep = JNIEnv.NewString (stringRep);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_stringRep);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IUnlockSignature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_stringRep);
			}
		}

	}
}
