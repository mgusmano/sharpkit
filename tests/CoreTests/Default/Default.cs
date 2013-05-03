using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Default
{
    [JsType(JsMode.Clr)]
    class Default
    {
        void foo()
        {
            var y = default(MyEnum);
        }
    }

    [JsType(JsMode.Clr)]
    enum MyEnum
    {
        A,
        B,
        C
    }
}
