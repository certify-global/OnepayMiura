using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/Conversions", DoNotGenerateAcw=true)]
	public sealed partial class Conversions : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/runtime/internal/Conversions", typeof (Conversions));
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

		internal Conversions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='booleanObject' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("booleanObject", "(Z)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object BooleanObject (bool i)
		{
			const string __id = "booleanObject.(Z)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='booleanValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("booleanValue", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool BooleanValue (global::Java.Lang.Object o)
		{
			const string __id = "booleanValue.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='byteObject' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("byteObject", "(B)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ByteObject (sbyte i)
		{
			const string __id = "byteObject.(B)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='byteValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("byteValue", "(Ljava/lang/Object;)B", "")]
		public static unsafe sbyte ByteValue (global::Java.Lang.Object o)
		{
			const string __id = "byteValue.(Ljava/lang/Object;)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='charObject' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("charObject", "(C)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CharObject (char i)
		{
			const string __id = "charObject.(C)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='charValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("charValue", "(Ljava/lang/Object;)C", "")]
		public static unsafe char CharValue (global::Java.Lang.Object o)
		{
			const string __id = "charValue.(Ljava/lang/Object;)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='doubleObject' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("doubleObject", "(D)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object DoubleObject (double i)
		{
			const string __id = "doubleObject.(D)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='doubleValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("doubleValue", "(Ljava/lang/Object;)D", "")]
		public static unsafe double DoubleValue (global::Java.Lang.Object o)
		{
			const string __id = "doubleValue.(Ljava/lang/Object;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='floatObject' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("floatObject", "(F)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object FloatObject (float i)
		{
			const string __id = "floatObject.(F)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='floatValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("floatValue", "(Ljava/lang/Object;)F", "")]
		public static unsafe float FloatValue (global::Java.Lang.Object o)
		{
			const string __id = "floatValue.(Ljava/lang/Object;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='intObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intObject", "(I)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object IntObject (int i)
		{
			const string __id = "intObject.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='intValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("intValue", "(Ljava/lang/Object;)I", "")]
		public static unsafe int IntValue (global::Java.Lang.Object o)
		{
			const string __id = "intValue.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='longObject' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longObject", "(J)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object LongObject (long i)
		{
			const string __id = "longObject.(J)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='longValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("longValue", "(Ljava/lang/Object;)J", "")]
		public static unsafe long LongValue (global::Java.Lang.Object o)
		{
			const string __id = "longValue.(Ljava/lang/Object;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='shortObject' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("shortObject", "(S)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object ShortObject (short i)
		{
			const string __id = "shortObject.(S)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='shortValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("shortValue", "(Ljava/lang/Object;)S", "")]
		public static unsafe short ShortValue (global::Java.Lang.Object o)
		{
			const string __id = "shortValue.(Ljava/lang/Object;)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='voidObject' and count(parameter)=0]"
		[Register ("voidObject", "()Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object VoidObject ()
		{
			const string __id = "voidObject.()Ljava/lang/Object;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='Conversions']/method[@name='voidValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("voidValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object VoidValue (global::Java.Lang.Object o)
		{
			const string __id = "voidValue.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

	}
}
