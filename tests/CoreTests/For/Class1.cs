using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.For
{
    [JsType(JsMode.Prototype)]
    class HasNext
    {
        public HasNext Next { get; set; }
    }
    [JsType(JsMode.Prototype)]
    class Bug249
    {
        static void Foo()
        {
            var p = new HasNext();
            var count = 0;
            for (; p != null; p = p.Next, count++)
            {
            }

            int x = 0, y = 0;

            for (x = 7, y = 8; x < 7 && y < 8; x++, y++)
            {
            }

            for (int a = 7, b = 8; x < 7 && y < 8; x++, y++)
            {
            }
        }
    }
}

