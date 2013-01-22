using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Inheritance
{
    [JsType(JsMode.Clr)]
    class ClrFromGlobal : Global2
    {
    }

    [JsType(JsMode.Global)]
    class Global1 : JsContext
    {
    }
    [JsType(JsMode.Global)]
    class Global2 : Global1
    {
    }

}
