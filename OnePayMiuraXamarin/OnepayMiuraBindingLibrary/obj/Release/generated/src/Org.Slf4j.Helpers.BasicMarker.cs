using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j.Helpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']"
	[global::Android.Runtime.Register ("org/slf4j/helpers/BasicMarker", DoNotGenerateAcw=true)]
	public partial class BasicMarker : global::Java.Lang.Object, global::Org.Slf4j.IMarker {


		public static class InterfaceConsts {

			// The following are fields from: org.slf4j.Marker

			// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/field[@name='ANY_MARKER']"
			[Register ("ANY_MARKER")]
			public const string AnyMarker = (string) "*";

			// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/field[@name='ANY_NON_NULL_MARKER']"
			[Register ("ANY_NON_NULL_MARKER")]
			public const string AnyNonNullMarker = (string) "+";
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/helpers/BasicMarker", typeof (BasicMarker));
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

		protected BasicMarker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasChildren;
#pragma warning disable 0169
		static Delegate GetHasChildrenHandler ()
		{
			if (cb_hasChildren == null)
				cb_hasChildren = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasChildren);
			return cb_hasChildren;
		}

		static bool n_HasChildren (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasChildren;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasChildren {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='hasChildren' and count(parameter)=0]"
			[Register ("hasChildren", "()Z", "GetHasChildrenHandler")]
			get {
				const string __id = "hasChildren.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_hasReferences;
#pragma warning disable 0169
		static Delegate GetHasReferencesHandler ()
		{
			if (cb_hasReferences == null)
				cb_hasReferences = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasReferences);
			return cb_hasReferences;
		}

		static bool n_HasReferences (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasReferences;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasReferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='hasReferences' and count(parameter)=0]"
			[Register ("hasReferences", "()Z", "GetHasReferencesHandler")]
			get {
				const string __id = "hasReferences.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_add_Lorg_slf4j_Marker_ == null)
				cb_add_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Lorg_slf4j_Marker_);
			return cb_add_Lorg_slf4j_Marker_;
		}

		static void n_Add_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reference)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var reference = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_reference, JniHandleOwnership.DoNotTransfer);
			__this.Add (reference);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("add", "(Lorg/slf4j/Marker;)V", "GetAdd_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe void Add (global::Org.Slf4j.IMarker reference)
		{
			const string __id = "add.(Lorg/slf4j/Marker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((reference == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reference).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (reference);
			}
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
		public virtual unsafe bool Contains (string name)
		{
			const string __id = "contains.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_contains_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_contains_Lorg_slf4j_Marker_ == null)
				cb_contains_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_slf4j_Marker_);
			return cb_contains_Lorg_slf4j_Marker_;
		}

		static bool n_Contains_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("contains", "(Lorg/slf4j/Marker;)Z", "GetContains_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool Contains (global::Org.Slf4j.IMarker other)
		{
			const string __id = "contains.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetRemove_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_remove_Lorg_slf4j_Marker_ == null)
				cb_remove_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Lorg_slf4j_Marker_);
			return cb_remove_Lorg_slf4j_Marker_;
		}

		static bool n_Remove_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_referenceToRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.Helpers.BasicMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var referenceToRemove = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_referenceToRemove, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (referenceToRemove);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j.helpers']/class[@name='BasicMarker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("remove", "(Lorg/slf4j/Marker;)Z", "GetRemove_Lorg_slf4j_Marker_Handler")]
		public virtual unsafe bool Remove (global::Org.Slf4j.IMarker referenceToRemove)
		{
			const string __id = "remove.(Lorg/slf4j/Marker;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((referenceToRemove == null) ? IntPtr.Zero : ((global::Java.Lang.Object) referenceToRemove).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (referenceToRemove);
			}
		}

	}
}
