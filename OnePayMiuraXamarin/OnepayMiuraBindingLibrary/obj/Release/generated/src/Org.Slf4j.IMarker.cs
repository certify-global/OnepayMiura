using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Slf4j {

	[Register ("org/slf4j/Marker", DoNotGenerateAcw=true)]
	public abstract class Marker : Java.Lang.Object {

		internal Marker ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/field[@name='ANY_MARKER']"
		[Register ("ANY_MARKER")]
		public const string AnyMarker = (string) "*";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/field[@name='ANY_NON_NULL_MARKER']"
		[Register ("ANY_NON_NULL_MARKER")]
		public const string AnyNonNullMarker = (string) "+";

		// The following are fields from: java.io.Serializable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable
	}

	[Register ("org/slf4j/Marker", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Marker' type. This type will be removed in a future release.", error: true)]
	public abstract class MarkerConsts : Marker {

		private MarkerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']"
	[Register ("org/slf4j/Marker", "", "Org.Slf4j.IMarkerInvoker")]
	public partial interface IMarker : global::Java.IO.ISerializable {

		bool HasChildren {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='hasChildren' and count(parameter)=0]"
			[Register ("hasChildren", "()Z", "GetHasChildrenHandler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool HasReferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='hasReferences' and count(parameter)=0]"
			[Register ("hasReferences", "()Z", "GetHasReferencesHandler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("add", "(Lorg/slf4j/Marker;)V", "GetAdd_Lorg_slf4j_Marker_Handler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		void Add (global::Org.Slf4j.IMarker p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("contains", "(Lorg/slf4j/Marker;)Z", "GetContains_Lorg_slf4j_Marker_Handler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		bool Contains (global::Org.Slf4j.IMarker p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		bool Equals (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		int GetHashCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.slf4j']/interface[@name='Marker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.slf4j.Marker']]"
		[Register ("remove", "(Lorg/slf4j/Marker;)Z", "GetRemove_Lorg_slf4j_Marker_Handler:Org.Slf4j.IMarkerInvoker, OnepayMiuraBindingLibrary")]
		bool Remove (global::Org.Slf4j.IMarker p0);

	}

	[global::Android.Runtime.Register ("org/slf4j/Marker", DoNotGenerateAcw=true)]
	internal partial class IMarkerInvoker : global::Java.Lang.Object, IMarker {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/slf4j/Marker", typeof (IMarkerInvoker));

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

		public static IMarker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMarker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.slf4j.Marker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMarkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasChildren;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHasChildrenHandler ()
		{
			if (cb_hasChildren == null)
				cb_hasChildren = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasChildren);
			return cb_hasChildren;
		}

		[Obsolete]
		static bool n_HasChildren (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasChildren;
		}
#pragma warning restore 0169

		IntPtr id_hasChildren;
		public unsafe bool HasChildren {
			get {
				if (id_hasChildren == IntPtr.Zero)
					id_hasChildren = JNIEnv.GetMethodID (class_ref, "hasChildren", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasChildren);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasReferences;
		}
#pragma warning restore 0169

		IntPtr id_hasReferences;
		public unsafe bool HasReferences {
			get {
				if (id_hasReferences == IntPtr.Zero)
					id_hasReferences = JNIEnv.GetMethodID (class_ref, "hasReferences", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasReferences);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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

		static void n_Add_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		IntPtr id_add_Lorg_slf4j_Marker_;
		public unsafe void Add (global::Org.Slf4j.IMarker p0)
		{
			if (id_add_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_add_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/slf4j/Marker;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_slf4j_Marker_, __args);
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public unsafe bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_contains_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_contains_Lorg_slf4j_Marker_ == null)
				cb_contains_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lorg_slf4j_Marker_);
			return cb_contains_Lorg_slf4j_Marker_;
		}

		static bool n_Contains_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lorg_slf4j_Marker_;
		public unsafe bool Contains (global::Org.Slf4j.IMarker p0)
		{
			if (id_contains_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_contains_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_remove_Lorg_slf4j_Marker_;
#pragma warning disable 0169
		static Delegate GetRemove_Lorg_slf4j_Marker_Handler ()
		{
			if (cb_remove_Lorg_slf4j_Marker_ == null)
				cb_remove_Lorg_slf4j_Marker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Lorg_slf4j_Marker_);
			return cb_remove_Lorg_slf4j_Marker_;
		}

		static bool n_Remove_Lorg_slf4j_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Slf4j.IMarker)global::Java.Lang.Object.GetObject<global::Org.Slf4j.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Lorg_slf4j_Marker_;
		public unsafe bool Remove (global::Org.Slf4j.IMarker p0)
		{
			if (id_remove_Lorg_slf4j_Marker_ == IntPtr.Zero)
				id_remove_Lorg_slf4j_Marker_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lorg/slf4j/Marker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lorg_slf4j_Marker_, __args);
			return __ret;
		}

	}

}
