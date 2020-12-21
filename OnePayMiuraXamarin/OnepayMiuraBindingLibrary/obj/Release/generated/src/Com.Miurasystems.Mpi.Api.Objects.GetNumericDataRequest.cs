using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Miurasystems.Mpi.Api.Objects {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']"
	[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/GetNumericDataRequest", DoNotGenerateAcw=true)]
	public partial class GetNumericDataRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/constructor[@name='GetNumericDataRequest.Builder' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.GetNumericDataRequest.Builder']]"
			[Register (".ctor", "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;)V", "")]
			public unsafe Builder (global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder from)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (from);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/constructor[@name='GetNumericDataRequest.Builder' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(IIIII)V", "")]
			public unsafe Builder (int firstLineIndex, int secondLineIndex, int thirdLineIndex, int numIntDigits, int numFracDigits)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIIII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (firstLineIndex);
					__args [1] = new JniArgumentValue (secondLineIndex);
					__args [2] = new JniArgumentValue (thirdLineIndex);
					__args [3] = new JniArgumentValue (numIntDigits);
					__args [4] = new JniArgumentValue (numFracDigits);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest Build ()
			{
				const string __id = "build.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='clearOptions' and count(parameter)=0]"
			[Register ("clearOptions", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder ClearOptions ()
			{
				const string __id = "clearOptions.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='getBuilder' and count(parameter)=0]"
			[Register ("getBuilder", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder GetBuilder ()
			{
				const string __id = "getBuilder.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setAmountLine' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("setAmountLine", "(IIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetAmountLine (int amountInPennies, int currencyCode, int currencyExponent, int amountLine)
			{
				const string __id = "setAmountLine.(IIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (amountInPennies);
					__args [1] = new JniArgumentValue (currencyCode);
					__args [2] = new JniArgumentValue (currencyExponent);
					__args [3] = new JniArgumentValue (amountLine);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setAmountLine' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("setAmountLine", "(ILjava/lang/String;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetAmountLine (int currencyCode, string numberToEditAscii)
			{
				const string __id = "setAmountLine.(ILjava/lang/String;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				IntPtr native_numberToEditAscii = JNIEnv.NewString (numberToEditAscii);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (currencyCode);
					__args [1] = new JniArgumentValue (native_numberToEditAscii);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_numberToEditAscii);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setAutomaticEnter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutomaticEnter", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetAutomaticEnter (bool automaticEnter)
			{
				const string __id = "setAutomaticEnter.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (automaticEnter);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setFirstLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFirstLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetFirstLineIndex (int firstLineIndex)
			{
				const string __id = "setFirstLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (firstLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setNumFracDigits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumFracDigits", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetNumFracDigits (int numFracDigits)
			{
				const string __id = "setNumFracDigits.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (numFracDigits);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setNumIntDigits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumIntDigits", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetNumIntDigits (int numIntDigits)
			{
				const string __id = "setNumIntDigits.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (numIntDigits);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setNumberToEditAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNumberToEditAscii", "(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetNumberToEditAscii (string numberToEditAscii)
			{
				const string __id = "setNumberToEditAscii.(Ljava/lang/String;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				IntPtr native_numberToEditAscii = JNIEnv.NewString (numberToEditAscii);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_numberToEditAscii);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_numberToEditAscii);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setOption' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.GetCommandsOptions'] and parameter[2][@type='boolean']]"
			[Register ("setOption", "(Lcom/miurasystems/mpi/enums/GetCommandsOptions;Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetOption (global::Com.Miurasystems.Mpi.Enums.GetCommandsOptions option, bool set)
			{
				const string __id = "setOption.(Lcom/miurasystems/mpi/enums/GetCommandsOptions;Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((option == null) ? IntPtr.Zero : ((global::Java.Lang.Object) option).Handle);
					__args [1] = new JniArgumentValue (set);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (option);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetCommandsOptions...']]"
			[Register ("setOptions", "([Lcom/miurasystems/mpi/enums/GetCommandsOptions;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetOptions (params global::Com.Miurasystems.Mpi.Enums.GetCommandsOptions[] optionList)
			{
				const string __id = "setOptions.([Lcom/miurasystems/mpi/enums/GetCommandsOptions;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				IntPtr native_optionList = JNIEnv.NewArray (optionList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_optionList);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (optionList != null) {
						JNIEnv.CopyArray (native_optionList, optionList);
						JNIEnv.DeleteLocalRef (native_optionList);
					}
					global::System.GC.KeepAlive (optionList);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;']]"
			[Register ("setOptions", "(Ljava/util/EnumSet;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetOptions (global::Java.Util.EnumSet optionSet)
			{
				const string __id = "setOptions.(Ljava/util/EnumSet;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((optionSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) optionSet).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (optionSet);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setSecondLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecondLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetSecondLineIndex (int secondLineIndex)
			{
				const string __id = "setSecondLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (secondLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setStoreForOnlinePin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStoreForOnlinePin", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetStoreForOnlinePin (bool storeForOnlinePin)
			{
				const string __id = "setStoreForOnlinePin.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (storeForOnlinePin);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setStoreForSecureData' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStoreForSecureData", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetStoreForSecureData (bool storeForSecureData)
			{
				const string __id = "setStoreForSecureData.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (storeForSecureData);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setThirdLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThirdLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetThirdLineIndex (int thirdLineIndex)
			{
				const string __id = "setThirdLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (thirdLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.Builder']/method[@name='setTimeoutInSeconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimeoutInSeconds", "(Ljava/lang/Integer;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder SetTimeoutInSeconds (global::Java.Lang.Integer timeoutInSeconds)
			{
				const string __id = "setTimeoutInSeconds.(Ljava/lang/Integer;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (timeoutInSeconds);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']"
		[global::Android.Runtime.Register ("com/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder", DoNotGenerateAcw=true)]
		public sealed partial class MaskedBuilder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder", typeof (MaskedBuilder));
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

			internal MaskedBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/constructor[@name='GetNumericDataRequest.MaskedBuilder' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.GetNumericDataRequest.MaskedBuilder']]"
			[Register (".ctor", "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;)V", "")]
			public unsafe MaskedBuilder (global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder from)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (from);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/constructor[@name='GetNumericDataRequest.MaskedBuilder' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IIII)V", "")]
			public unsafe MaskedBuilder (int firstLineIndex, int secondLineIndex, int thirdLineIndex, int numIntDigits)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (firstLineIndex);
					__args [1] = new JniArgumentValue (secondLineIndex);
					__args [2] = new JniArgumentValue (thirdLineIndex);
					__args [3] = new JniArgumentValue (numIntDigits);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder Builder {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='getBuilder' and count(parameter)=0]"
				[Register ("getBuilder", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
				get {
					const string __id = "getBuilder.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest Build ()
			{
				const string __id = "build.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='clearOptions' and count(parameter)=0]"
			[Register ("clearOptions", "()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder ClearOptions ()
			{
				const string __id = "clearOptions.()Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setAutomaticEnter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutomaticEnter", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetAutomaticEnter (bool automaticEnter)
			{
				const string __id = "setAutomaticEnter.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (automaticEnter);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setFirstLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFirstLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetFirstLineIndex (int firstLineIndex)
			{
				const string __id = "setFirstLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (firstLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setNumIntDigits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumIntDigits", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetNumIntDigits (int numIntDigits)
			{
				const string __id = "setNumIntDigits.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (numIntDigits);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setOption' and count(parameter)=2 and parameter[1][@type='com.miurasystems.mpi.enums.GetCommandsOptions'] and parameter[2][@type='boolean']]"
			[Register ("setOption", "(Lcom/miurasystems/mpi/enums/GetCommandsOptions;Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetOption (global::Com.Miurasystems.Mpi.Enums.GetCommandsOptions option, bool set)
			{
				const string __id = "setOption.(Lcom/miurasystems/mpi/enums/GetCommandsOptions;Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((option == null) ? IntPtr.Zero : ((global::Java.Lang.Object) option).Handle);
					__args [1] = new JniArgumentValue (set);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (option);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.enums.GetCommandsOptions...']]"
			[Register ("setOptions", "([Lcom/miurasystems/mpi/enums/GetCommandsOptions;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetOptions (params global::Com.Miurasystems.Mpi.Enums.GetCommandsOptions[] optionList)
			{
				const string __id = "setOptions.([Lcom/miurasystems/mpi/enums/GetCommandsOptions;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				IntPtr native_optionList = JNIEnv.NewArray (optionList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_optionList);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (optionList != null) {
						JNIEnv.CopyArray (native_optionList, optionList);
						JNIEnv.DeleteLocalRef (native_optionList);
					}
					global::System.GC.KeepAlive (optionList);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.miurasystems.mpi.enums.GetCommandsOptions&gt;']]"
			[Register ("setOptions", "(Ljava/util/EnumSet;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetOptions (global::Java.Util.EnumSet optionSet)
			{
				const string __id = "setOptions.(Ljava/util/EnumSet;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((optionSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) optionSet).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (optionSet);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setSecondLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecondLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetSecondLineIndex (int secondLineIndex)
			{
				const string __id = "setSecondLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (secondLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setStoreForOnlinePin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStoreForOnlinePin", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetStoreForOnlinePin (bool storeForOnlinePin)
			{
				const string __id = "setStoreForOnlinePin.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (storeForOnlinePin);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setStoreForSecureData' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStoreForSecureData", "(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetStoreForSecureData (bool storeForSecureData)
			{
				const string __id = "setStoreForSecureData.(Z)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (storeForSecureData);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setThirdLineIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThirdLineIndex", "(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetThirdLineIndex (int thirdLineIndex)
			{
				const string __id = "setThirdLineIndex.(I)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (thirdLineIndex);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest.MaskedBuilder']/method[@name='setTimeoutInSeconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimeoutInSeconds", "(Ljava/lang/Integer;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
			public unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder SetTimeoutInSeconds (global::Java.Lang.Integer timeoutInSeconds)
			{
				const string __id = "setTimeoutInSeconds.(Ljava/lang/Integer;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((timeoutInSeconds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeoutInSeconds).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (timeoutInSeconds);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/miurasystems/mpi/api/objects/GetNumericDataRequest", typeof (GetNumericDataRequest));
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

		protected GetNumericDataRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAmountInPennies;
#pragma warning disable 0169
		static Delegate GetGetAmountInPenniesHandler ()
		{
			if (cb_getAmountInPennies == null)
				cb_getAmountInPennies = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAmountInPennies);
			return cb_getAmountInPennies;
		}

		static int n_GetAmountInPennies (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AmountInPennies;
		}
#pragma warning restore 0169

		public virtual unsafe int AmountInPennies {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getAmountInPennies' and count(parameter)=0]"
			[Register ("getAmountInPennies", "()I", "GetGetAmountInPenniesHandler")]
			get {
				const string __id = "getAmountInPennies.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAmountLine;
#pragma warning disable 0169
		static Delegate GetGetAmountLineHandler ()
		{
			if (cb_getAmountLine == null)
				cb_getAmountLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAmountLine);
			return cb_getAmountLine;
		}

		static int n_GetAmountLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AmountLine;
		}
#pragma warning restore 0169

		public virtual unsafe int AmountLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getAmountLine' and count(parameter)=0]"
			[Register ("getAmountLine", "()I", "GetGetAmountLineHandler")]
			get {
				const string __id = "getAmountLine.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrencyCode;
#pragma warning disable 0169
		static Delegate GetGetCurrencyCodeHandler ()
		{
			if (cb_getCurrencyCode == null)
				cb_getCurrencyCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrencyCode);
			return cb_getCurrencyCode;
		}

		static int n_GetCurrencyCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrencyCode;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getCurrencyCode' and count(parameter)=0]"
			[Register ("getCurrencyCode", "()I", "GetGetCurrencyCodeHandler")]
			get {
				const string __id = "getCurrencyCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrencyExponent;
#pragma warning disable 0169
		static Delegate GetGetCurrencyExponentHandler ()
		{
			if (cb_getCurrencyExponent == null)
				cb_getCurrencyExponent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrencyExponent);
			return cb_getCurrencyExponent;
		}

		static int n_GetCurrencyExponent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrencyExponent;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrencyExponent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getCurrencyExponent' and count(parameter)=0]"
			[Register ("getCurrencyExponent", "()I", "GetGetCurrencyExponentHandler")]
			get {
				const string __id = "getCurrencyExponent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFirstLineIndex;
#pragma warning disable 0169
		static Delegate GetGetFirstLineIndexHandler ()
		{
			if (cb_getFirstLineIndex == null)
				cb_getFirstLineIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFirstLineIndex);
			return cb_getFirstLineIndex;
		}

		static int n_GetFirstLineIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstLineIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int FirstLineIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getFirstLineIndex' and count(parameter)=0]"
			[Register ("getFirstLineIndex", "()I", "GetGetFirstLineIndexHandler")]
			get {
				const string __id = "getFirstLineIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAmountLineSet;
#pragma warning disable 0169
		static Delegate GetIsAmountLineSetHandler ()
		{
			if (cb_isAmountLineSet == null)
				cb_isAmountLineSet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAmountLineSet);
			return cb_isAmountLineSet;
		}

		static bool n_IsAmountLineSet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAmountLineSet;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAmountLineSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='isAmountLineSet' and count(parameter)=0]"
			[Register ("isAmountLineSet", "()Z", "GetIsAmountLineSetHandler")]
			get {
				const string __id = "isAmountLineSet.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAutomaticEnter;
#pragma warning disable 0169
		static Delegate GetIsAutomaticEnterHandler ()
		{
			if (cb_isAutomaticEnter == null)
				cb_isAutomaticEnter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAutomaticEnter);
			return cb_isAutomaticEnter;
		}

		static bool n_IsAutomaticEnter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutomaticEnter;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutomaticEnter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='isAutomaticEnter' and count(parameter)=0]"
			[Register ("isAutomaticEnter", "()Z", "GetIsAutomaticEnterHandler")]
			get {
				const string __id = "isAutomaticEnter.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMaskInput;
#pragma warning disable 0169
		static Delegate GetIsMaskInputHandler ()
		{
			if (cb_isMaskInput == null)
				cb_isMaskInput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMaskInput);
			return cb_isMaskInput;
		}

		static bool n_IsMaskInput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaskInput;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMaskInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='isMaskInput' and count(parameter)=0]"
			[Register ("isMaskInput", "()Z", "GetIsMaskInputHandler")]
			get {
				const string __id = "isMaskInput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isStoreForOnlinePin;
#pragma warning disable 0169
		static Delegate GetIsStoreForOnlinePinHandler ()
		{
			if (cb_isStoreForOnlinePin == null)
				cb_isStoreForOnlinePin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStoreForOnlinePin);
			return cb_isStoreForOnlinePin;
		}

		static bool n_IsStoreForOnlinePin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStoreForOnlinePin;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStoreForOnlinePin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='isStoreForOnlinePin' and count(parameter)=0]"
			[Register ("isStoreForOnlinePin", "()Z", "GetIsStoreForOnlinePinHandler")]
			get {
				const string __id = "isStoreForOnlinePin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isStoreForSecureData;
#pragma warning disable 0169
		static Delegate GetIsStoreForSecureDataHandler ()
		{
			if (cb_isStoreForSecureData == null)
				cb_isStoreForSecureData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStoreForSecureData);
			return cb_isStoreForSecureData;
		}

		static bool n_IsStoreForSecureData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStoreForSecureData;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStoreForSecureData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='isStoreForSecureData' and count(parameter)=0]"
			[Register ("isStoreForSecureData", "()Z", "GetIsStoreForSecureDataHandler")]
			get {
				const string __id = "isStoreForSecureData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNumFracDigits;
#pragma warning disable 0169
		static Delegate GetGetNumFracDigitsHandler ()
		{
			if (cb_getNumFracDigits == null)
				cb_getNumFracDigits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNumFracDigits);
			return cb_getNumFracDigits;
		}

		static int n_GetNumFracDigits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumFracDigits;
		}
#pragma warning restore 0169

		public virtual unsafe int NumFracDigits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getNumFracDigits' and count(parameter)=0]"
			[Register ("getNumFracDigits", "()I", "GetGetNumFracDigitsHandler")]
			get {
				const string __id = "getNumFracDigits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNumIntDigits;
#pragma warning disable 0169
		static Delegate GetGetNumIntDigitsHandler ()
		{
			if (cb_getNumIntDigits == null)
				cb_getNumIntDigits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNumIntDigits);
			return cb_getNumIntDigits;
		}

		static int n_GetNumIntDigits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumIntDigits;
		}
#pragma warning restore 0169

		public virtual unsafe int NumIntDigits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getNumIntDigits' and count(parameter)=0]"
			[Register ("getNumIntDigits", "()I", "GetGetNumIntDigitsHandler")]
			get {
				const string __id = "getNumIntDigits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNumberToEditAscii;
#pragma warning disable 0169
		static Delegate GetGetNumberToEditAsciiHandler ()
		{
			if (cb_getNumberToEditAscii == null)
				cb_getNumberToEditAscii = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNumberToEditAscii);
			return cb_getNumberToEditAscii;
		}

		static IntPtr n_GetNumberToEditAscii (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NumberToEditAscii);
		}
#pragma warning restore 0169

		public virtual unsafe string NumberToEditAscii {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getNumberToEditAscii' and count(parameter)=0]"
			[Register ("getNumberToEditAscii", "()Ljava/lang/String;", "GetGetNumberToEditAsciiHandler")]
			get {
				const string __id = "getNumberToEditAscii.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptions);
			return cb_getOptions;
		}

		static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Options);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.EnumSet Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Ljava/util/EnumSet;", "GetGetOptionsHandler")]
			get {
				const string __id = "getOptions.()Ljava/util/EnumSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecondLineIndex;
#pragma warning disable 0169
		static Delegate GetGetSecondLineIndexHandler ()
		{
			if (cb_getSecondLineIndex == null)
				cb_getSecondLineIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecondLineIndex);
			return cb_getSecondLineIndex;
		}

		static int n_GetSecondLineIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecondLineIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int SecondLineIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getSecondLineIndex' and count(parameter)=0]"
			[Register ("getSecondLineIndex", "()I", "GetGetSecondLineIndexHandler")]
			get {
				const string __id = "getSecondLineIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getThirdLineIndex;
#pragma warning disable 0169
		static Delegate GetGetThirdLineIndexHandler ()
		{
			if (cb_getThirdLineIndex == null)
				cb_getThirdLineIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetThirdLineIndex);
			return cb_getThirdLineIndex;
		}

		static int n_GetThirdLineIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThirdLineIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int ThirdLineIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getThirdLineIndex' and count(parameter)=0]"
			[Register ("getThirdLineIndex", "()I", "GetGetThirdLineIndexHandler")]
			get {
				const string __id = "getThirdLineIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimeoutInSeconds;
#pragma warning disable 0169
		static Delegate GetGetTimeoutInSecondsHandler ()
		{
			if (cb_getTimeoutInSeconds == null)
				cb_getTimeoutInSeconds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeoutInSeconds);
			return cb_getTimeoutInSeconds;
		}

		static IntPtr n_GetTimeoutInSeconds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeoutInSeconds);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer TimeoutInSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='getTimeoutInSeconds' and count(parameter)=0]"
			[Register ("getTimeoutInSeconds", "()Ljava/lang/Integer;", "GetGetTimeoutInSecondsHandler")]
			get {
				const string __id = "getTimeoutInSeconds.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='GetBuilder' and count(parameter)=1 and parameter[1][@type='com.miurasystems.mpi.api.objects.GetNumericDataRequest.Builder']]"
		[Register ("GetBuilder", "(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder GetBuilder (global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder from)
		{
			const string __id = "GetBuilder.(Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (from);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='GetBuilder' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("GetBuilder", "(IIIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder GetBuilder (int firstLineIndex, int secondLineIndex, int thirdLineIndex, int numIntDigits, int numFracDigits)
		{
			const string __id = "GetBuilder.(IIIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (firstLineIndex);
				__args [1] = new JniArgumentValue (secondLineIndex);
				__args [2] = new JniArgumentValue (thirdLineIndex);
				__args [3] = new JniArgumentValue (numIntDigits);
				__args [4] = new JniArgumentValue (numFracDigits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.miurasystems.mpi.api.objects']/class[@name='GetNumericDataRequest']/method[@name='GetMaskedBuilder' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("GetMaskedBuilder", "(IIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;", "")]
		public static unsafe global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder GetMaskedBuilder (int firstLineIndex, int secondLineIndex, int thirdLineIndex, int numIntDigits)
		{
			const string __id = "GetMaskedBuilder.(IIII)Lcom/miurasystems/mpi/api/objects/GetNumericDataRequest$MaskedBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (firstLineIndex);
				__args [1] = new JniArgumentValue (secondLineIndex);
				__args [2] = new JniArgumentValue (thirdLineIndex);
				__args [3] = new JniArgumentValue (numIntDigits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Miurasystems.Mpi.Api.Objects.GetNumericDataRequest.MaskedBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
