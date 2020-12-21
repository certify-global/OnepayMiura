using System;

namespace Org.Aspectj.Internal.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.internal.lang.annotation.ajcITD")]
	public partial class AjcITDAttribute : Attribute
	{
		[global::Android.Runtime.Register ("modifiers")]
		public int Modifiers { get; set; }

		[global::Android.Runtime.Register ("name")]
		public string Name { get; set; }

		[global::Android.Runtime.Register ("targetType")]
		public string TargetType { get; set; }

	}
}
