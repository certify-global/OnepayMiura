using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.AfterReturning")]
	public partial class AfterReturningAttribute : Attribute
	{
		[global::Android.Runtime.Register ("argNames")]
		public string ArgNames { get; set; }

		[global::Android.Runtime.Register ("pointcut")]
		public string Pointcut { get; set; }

		[global::Android.Runtime.Register ("returning")]
		public string Returning { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
