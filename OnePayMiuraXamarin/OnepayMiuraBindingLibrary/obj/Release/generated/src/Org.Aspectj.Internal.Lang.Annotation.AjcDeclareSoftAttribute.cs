using System;

namespace Org.Aspectj.Internal.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.internal.lang.annotation.ajcDeclareSoft")]
	public partial class AjcDeclareSoftAttribute : Attribute
	{
		[global::Android.Runtime.Register ("exceptionType")]
		public string ExceptionType { get; set; }

		[global::Android.Runtime.Register ("pointcut")]
		public string Pointcut { get; set; }

	}
}
