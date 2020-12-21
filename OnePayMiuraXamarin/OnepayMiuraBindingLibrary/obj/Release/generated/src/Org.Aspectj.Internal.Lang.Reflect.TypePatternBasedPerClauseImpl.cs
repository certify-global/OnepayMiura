using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/TypePatternBasedPerClauseImpl", DoNotGenerateAcw=true)]
	public partial class TypePatternBasedPerClauseImpl : global::Org.Aspectj.Internal.Lang.Reflect.PerClauseImpl, global::Org.Aspectj.Lang.Reflect.ITypePatternBasedPerClause {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/internal/lang/reflect/TypePatternBasedPerClauseImpl", typeof (TypePatternBasedPerClauseImpl));
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

		protected TypePatternBasedPerClauseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']/constructor[@name='TypePatternBasedPerClauseImpl' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.PerClauseKind'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", "")]
		public unsafe TypePatternBasedPerClauseImpl (global::Org.Aspectj.Lang.Reflect.PerClauseKind kind, string pattern)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pattern = JNIEnv.NewString (pattern);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((kind == null) ? IntPtr.Zero : ((global::Java.Lang.Object) kind).Handle);
				__args [1] = new JniArgumentValue (native_pattern);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pattern);
				global::System.GC.KeepAlive (kind);
			}
		}

		static Delegate cb_getTypePattern;
#pragma warning disable 0169
		static Delegate GetGetTypePatternHandler ()
		{
			if (cb_getTypePattern == null)
				cb_getTypePattern = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypePattern);
			return cb_getTypePattern;
		}

		static IntPtr n_GetTypePattern (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.TypePatternBasedPerClauseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TypePattern);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Aspectj.Lang.Reflect.ITypePattern TypePattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='TypePatternBasedPerClauseImpl']/method[@name='getTypePattern' and count(parameter)=0]"
			[Register ("getTypePattern", "()Lorg/aspectj/lang/reflect/TypePattern;", "GetGetTypePatternHandler")]
			get {
				const string __id = "getTypePattern.()Lorg/aspectj/lang/reflect/TypePattern;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ITypePattern> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
