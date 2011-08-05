using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Enum", Filename = "~/Internal/Core.js")]
	internal class JsImplEnum
	{
		public static string[] GetNames(Type type)
		{
			var jsType = type.As<JsImplType>()._JsType;
			var array = new JsExtendedArray();
			foreach (var p in jsType.staticDefinition)
			{
				array.push(p);
			}
			return array.As<string[]>();
		}
		public static object[] GetValues(Type type)
		{
			var jsType = type.As<JsImplType>()._JsType;
			var array = new JsExtendedArray();
			foreach (var p in jsType.staticDefinition)
			{
				array.push(jsType.staticDefinition[p]);
			}
			return array.As<object[]>();
		}
	}

}
