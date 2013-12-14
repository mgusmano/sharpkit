using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.AnonymousObjects
{
    [JsType(JsMode.Prototype, NativeJsons = false)]
    public class NonNativeJsons
    {
        public void F()
        {
            var xx = new object();
            var x = new { a = "b" };
            var a = x.a;
        }
    }
}
