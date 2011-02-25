using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Activator", Filename = "~/Internal/Core.js")]
	internal static class JsImplActivator
	{

		[JsMethod(Code = "return new type._JsType.ctor();")]
		public static object CreateInstance(Type type)
		{
			throw new NotImplementedException();
		}
//    [JsMethod(Code =
//    @"if(args==null)
//				return new type.ctor();
//			return new type.ctor(args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7]);")]
//    public static object CreateInstance(Type type, object[] args)
//    {
//      throw new NotImplementedException();
//    }

	}
}
