using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.DeclareMixin")]
	public partial class DeclareMixinAttribute : Attribute
	{
		[global::Android.Runtime.Register ("interfaces")]
		public global::Java.Lang.Class[] Interfaces { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
