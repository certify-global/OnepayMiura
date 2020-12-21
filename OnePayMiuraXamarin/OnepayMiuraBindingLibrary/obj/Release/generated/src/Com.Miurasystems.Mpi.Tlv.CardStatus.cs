using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Tlv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/tlv/CardStatus", DoNotGenerateAcw=true)]
	public partial class CardStatus : global::Java.Lang.Object, global::Java.IO.ISerializable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/tlv/CardStatus", typeof (CardStatus));
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

		protected CardStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/constructor[@name='CardStatus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardStatus ()
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

		static Delegate cb_isCardPresent;
#pragma warning disable 0169
		static Delegate GetIsCardPresentHandler ()
		{
			if (cb_isCardPresent == null)
				cb_isCardPresent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCardPresent);
			return cb_isCardPresent;
		}

		static bool n_IsCardPresent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardPresent;
		}
#pragma warning restore 0169

		static Delegate cb_setCardPresent_Z;
#pragma warning disable 0169
		static Delegate GetSetCardPresent_ZHandler ()
		{
			if (cb_setCardPresent_Z == null)
				cb_setCardPresent_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCardPresent_Z);
			return cb_setCardPresent_Z;
		}

		static void n_SetCardPresent_Z (IntPtr jnienv, IntPtr native__this, bool cardPresent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CardPresent = cardPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool CardPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isCardPresent' and count(parameter)=0]"
			[Register ("isCardPresent", "()Z", "GetIsCardPresentHandler")]
			get {
				const string __id = "isCardPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setCardPresent' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCardPresent", "(Z)V", "GetSetCardPresent_ZHandler")]
			set {
				const string __id = "setCardPresent.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEMVCompatible;
#pragma warning disable 0169
		static Delegate GetIsEMVCompatibleHandler ()
		{
			if (cb_isEMVCompatible == null)
				cb_isEMVCompatible = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEMVCompatible);
			return cb_isEMVCompatible;
		}

		static bool n_IsEMVCompatible (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EMVCompatible;
		}
#pragma warning restore 0169

		static Delegate cb_setEMVCompatible_Z;
#pragma warning disable 0169
		static Delegate GetSetEMVCompatible_ZHandler ()
		{
			if (cb_setEMVCompatible_Z == null)
				cb_setEMVCompatible_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEMVCompatible_Z);
			return cb_setEMVCompatible_Z;
		}

		static void n_SetEMVCompatible_Z (IntPtr jnienv, IntPtr native__this, bool EMVCompatible)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EMVCompatible = EMVCompatible;
		}
#pragma warning restore 0169

		public virtual unsafe bool EMVCompatible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isEMVCompatible' and count(parameter)=0]"
			[Register ("isEMVCompatible", "()Z", "GetIsEMVCompatibleHandler")]
			get {
				const string __id = "isEMVCompatible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setEMVCompatible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEMVCompatible", "(Z)V", "GetSetEMVCompatible_ZHandler")]
			set {
				const string __id = "setEMVCompatible.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMSRDataAvailable;
#pragma warning disable 0169
		static Delegate GetIsMSRDataAvailableHandler ()
		{
			if (cb_isMSRDataAvailable == null)
				cb_isMSRDataAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMSRDataAvailable);
			return cb_isMSRDataAvailable;
		}

		static bool n_IsMSRDataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MSRDataAvailable;
		}
#pragma warning restore 0169

		static Delegate cb_setMSRDataAvailable_Z;
#pragma warning disable 0169
		static Delegate GetSetMSRDataAvailable_ZHandler ()
		{
			if (cb_setMSRDataAvailable_Z == null)
				cb_setMSRDataAvailable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMSRDataAvailable_Z);
			return cb_setMSRDataAvailable_Z;
		}

		static void n_SetMSRDataAvailable_Z (IntPtr jnienv, IntPtr native__this, bool MSRDataAvailable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MSRDataAvailable = MSRDataAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool MSRDataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isMSRDataAvailable' and count(parameter)=0]"
			[Register ("isMSRDataAvailable", "()Z", "GetIsMSRDataAvailableHandler")]
			get {
				const string __id = "isMSRDataAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setMSRDataAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMSRDataAvailable", "(Z)V", "GetSetMSRDataAvailable_ZHandler")]
			set {
				const string __id = "setMSRDataAvailable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTrack1DataAvailable;
#pragma warning disable 0169
		static Delegate GetIsTrack1DataAvailableHandler ()
		{
			if (cb_isTrack1DataAvailable == null)
				cb_isTrack1DataAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTrack1DataAvailable);
			return cb_isTrack1DataAvailable;
		}

		static bool n_IsTrack1DataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Track1DataAvailable;
		}
#pragma warning restore 0169

		static Delegate cb_setTrack1DataAvailable_Z;
#pragma warning disable 0169
		static Delegate GetSetTrack1DataAvailable_ZHandler ()
		{
			if (cb_setTrack1DataAvailable_Z == null)
				cb_setTrack1DataAvailable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTrack1DataAvailable_Z);
			return cb_setTrack1DataAvailable_Z;
		}

		static void n_SetTrack1DataAvailable_Z (IntPtr jnienv, IntPtr native__this, bool track1DataAvailable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Track1DataAvailable = track1DataAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Track1DataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isTrack1DataAvailable' and count(parameter)=0]"
			[Register ("isTrack1DataAvailable", "()Z", "GetIsTrack1DataAvailableHandler")]
			get {
				const string __id = "isTrack1DataAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setTrack1DataAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrack1DataAvailable", "(Z)V", "GetSetTrack1DataAvailable_ZHandler")]
			set {
				const string __id = "setTrack1DataAvailable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTrack2DataAvailable;
#pragma warning disable 0169
		static Delegate GetIsTrack2DataAvailableHandler ()
		{
			if (cb_isTrack2DataAvailable == null)
				cb_isTrack2DataAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTrack2DataAvailable);
			return cb_isTrack2DataAvailable;
		}

		static bool n_IsTrack2DataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Track2DataAvailable;
		}
#pragma warning restore 0169

		static Delegate cb_setTrack2DataAvailable_Z;
#pragma warning disable 0169
		static Delegate GetSetTrack2DataAvailable_ZHandler ()
		{
			if (cb_setTrack2DataAvailable_Z == null)
				cb_setTrack2DataAvailable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTrack2DataAvailable_Z);
			return cb_setTrack2DataAvailable_Z;
		}

		static void n_SetTrack2DataAvailable_Z (IntPtr jnienv, IntPtr native__this, bool track2DataAvailable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Track2DataAvailable = track2DataAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Track2DataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isTrack2DataAvailable' and count(parameter)=0]"
			[Register ("isTrack2DataAvailable", "()Z", "GetIsTrack2DataAvailableHandler")]
			get {
				const string __id = "isTrack2DataAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setTrack2DataAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrack2DataAvailable", "(Z)V", "GetSetTrack2DataAvailable_ZHandler")]
			set {
				const string __id = "setTrack2DataAvailable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTrack3DataAvailable;
#pragma warning disable 0169
		static Delegate GetIsTrack3DataAvailableHandler ()
		{
			if (cb_isTrack3DataAvailable == null)
				cb_isTrack3DataAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTrack3DataAvailable);
			return cb_isTrack3DataAvailable;
		}

		static bool n_IsTrack3DataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Track3DataAvailable;
		}
#pragma warning restore 0169

		static Delegate cb_setTrack3DataAvailable_Z;
#pragma warning disable 0169
		static Delegate GetSetTrack3DataAvailable_ZHandler ()
		{
			if (cb_setTrack3DataAvailable_Z == null)
				cb_setTrack3DataAvailable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTrack3DataAvailable_Z);
			return cb_setTrack3DataAvailable_Z;
		}

		static void n_SetTrack3DataAvailable_Z (IntPtr jnienv, IntPtr native__this, bool track3DataAvailable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Tlv.CardStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Track3DataAvailable = track3DataAvailable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Track3DataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='isTrack3DataAvailable' and count(parameter)=0]"
			[Register ("isTrack3DataAvailable", "()Z", "GetIsTrack3DataAvailableHandler")]
			get {
				const string __id = "isTrack3DataAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.tlv']/class[@name='CardStatus']/method[@name='setTrack3DataAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrack3DataAvailable", "(Z)V", "GetSetTrack3DataAvailable_ZHandler")]
			set {
				const string __id = "setTrack3DataAvailable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
