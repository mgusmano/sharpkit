using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Delegates
{
    [JsType(JsMode.Prototype, ForceDelegatesAsNativeFunctions=true)]
    class Delegates
    {
        void foo()
        {
            Action x = foo;
        }
    }
}
