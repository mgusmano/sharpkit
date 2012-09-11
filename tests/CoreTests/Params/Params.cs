using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Params
{
    [JsType(JsMode.Clr)]
    class Params
    {
        void foo()
        {
            var x = String.Format("{0}{1}{2}", "a", "b", "c", "d");
            foo2("a", "b", "c");
        }
        [JsMethod(NativeParams=false)]
        void foo2(params string[] prms)
        {
        }
    }
}


