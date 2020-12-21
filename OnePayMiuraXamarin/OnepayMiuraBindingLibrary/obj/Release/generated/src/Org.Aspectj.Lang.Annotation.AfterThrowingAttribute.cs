using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.AfterThrowing")]
	public partial class AfterThrowingAttribute : Attribute
	{
		[global::Android.Runtime.Register ("argNames")]
		public string ArgNames { get; set; }

		[global::Android.Runtime.Register ("pointcut")]
		public string Pointcut { get; set; }

		[global::Android.Runtime.Register ("throwing")]
		public string Throwing { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
