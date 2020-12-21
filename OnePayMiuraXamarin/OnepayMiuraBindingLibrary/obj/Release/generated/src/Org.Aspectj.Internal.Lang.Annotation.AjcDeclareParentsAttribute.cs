using System;

namespace Org.Aspectj.Internal.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.internal.lang.annotation.ajcDeclareParents")]
	public partial class AjcDeclareParentsAttribute : Attribute
	{
		[global::Android.Runtime.Register ("parentTypes")]
		public string ParentTypes { get; set; }

		[global::Android.Runtime.Register ("targetTypePattern")]
		public string TargetTypePattern { get; set; }

	}
}
