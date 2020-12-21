using System;

namespace Org.Aspectj.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.DeclarePrecedence")]
	public partial class DeclarePrecedenceAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
