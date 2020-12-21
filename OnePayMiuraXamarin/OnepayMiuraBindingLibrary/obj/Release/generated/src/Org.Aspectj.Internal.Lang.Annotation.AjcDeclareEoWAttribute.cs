using System;

namespace Org.Aspectj.Internal.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.internal.lang.annotation.ajcDeclareEoW")]
	public partial class AjcDeclareEoWAttribute : Attribute
	{
		[global::Android.Runtime.Register ("message")]
		public string Message { get; set; }

		[global::Android.Runtime.Register ("pointcut")]
		public string Pointcut { get; set; }

	}
}
