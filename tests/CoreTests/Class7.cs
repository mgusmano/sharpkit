using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType(JsMode.Prototype, AutomaticPropertiesAsFields = true)]
    public class Foo
    {
        public int MyProperty { get; set; }
        Foo() { MyProperty = 1; }
    }
}