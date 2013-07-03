using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Numbers
{
    [JsType(JsMode.Prototype)]
    class Numbers
    {
        void foo()
        {
            double x = 7;
            int y = (int)x;
        }
    }
}
