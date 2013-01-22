using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.NativeJs
{
    [JsType(JsMode.Prototype)]
    class JsDateTest
    {
        void foo()
        {
            var x = new JsDate().As<object>();
            if (x is JsDate)
            {
            }
        }
    }
}
