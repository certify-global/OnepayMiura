using System;

namespace Org.Aspectj.Internal.Lang.Annotation {

	[global::Android.Runtime.Annotation ("org.aspectj.internal.lang.annotation.ajcDeclareAnnotation")]
	public partial class AjcDeclareAnnotationAttribute : Attribute
	{
		[global::Android.Runtime.Register ("annotation")]
		public string Annotation { get; set; }

		[global::Android.Runtime.Register ("kind")]
		public string Kind { get; set; }

		[global::Android.Runtime.Register ("pattern")]
		public string Pattern { get; set; }

	}
}
