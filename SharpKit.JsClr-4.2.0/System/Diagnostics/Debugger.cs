using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Diagnostics.Debugger", Filename = "~/res/System.Diagnostics/Debugger.js")]
	public class JsImplDebugger
	{
		[JsMethod(Code = "debugger;")]
		public static void Break()
		{
		}
	}
}
