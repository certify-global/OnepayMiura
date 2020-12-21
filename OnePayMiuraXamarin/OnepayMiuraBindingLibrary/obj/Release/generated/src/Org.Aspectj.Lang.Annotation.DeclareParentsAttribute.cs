using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.DeclareParents")]
	public partial class DeclareParentsAttribute : Attribute
	{
		[global::Android.Runtime.Register ("defaultImpl")]
		public global::Java.Lang.Class DefaultImpl { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
