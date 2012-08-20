using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType(JsMode.Prototype, AutomaticPropertiesAsFields = false)]
    public class Class6
    {
        public int MyProperty { get;  set; }
        public static int MyStaticProperty { get; set; }
        public void Foo()
        {
            MyProperty = 1;
            MyStaticProperty = 4;
        }
    }
}