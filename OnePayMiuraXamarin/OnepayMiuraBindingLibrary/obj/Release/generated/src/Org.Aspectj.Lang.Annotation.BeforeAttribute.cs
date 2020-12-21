using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.Before")]
	public partial class BeforeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("argNames")]
		public string ArgNames { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
