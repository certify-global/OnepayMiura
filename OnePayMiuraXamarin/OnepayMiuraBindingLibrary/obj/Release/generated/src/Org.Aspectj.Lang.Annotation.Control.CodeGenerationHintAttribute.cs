using System;

namespace Org.Aspectj.Lang.Annotation.Control {

	[global::Android.Runtime.Annotation ("org.aspectj.lang.annotation.control.CodeGenerationHint")]
	public partial class CodeGenerationHintAttribute : Attribute
	{
		[global::Android.Runtime.Register ("ifNameSuffix")]
		public string IfNameSuffix { get; set; }

	}
}
