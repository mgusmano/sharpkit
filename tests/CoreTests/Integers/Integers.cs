using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Integers
{
    [JsType(JsMode.Prototype)]
    class Integers
    {
        void foo()
        {
            var x = 7;
            var y = 8;
            var z = x / y;
            var a = 7.8;
            var b = (int)a;
        }
    }
}
