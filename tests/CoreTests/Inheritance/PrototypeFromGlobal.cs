using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Inheritance
{
    [JsType(JsMode.Prototype)]
    class PrototypeFromGlobal : Global
    {
    }

    [JsType(JsMode.Global)]
    class Global
    {
    }
}
