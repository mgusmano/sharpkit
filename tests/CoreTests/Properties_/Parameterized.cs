using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Properties_
{

    [JsType(JsMode.Clr)]
    internal static class ClrParameterizedTest
    {

        public static void CreateColorFromExpression()
        {
            var obj = new ClrClass() { Property = 5 };
        }

    }

    [JsType(JsMode.Clr)]
    public class ClrClass
    {
        public int Property { get; set; }
    }

}
