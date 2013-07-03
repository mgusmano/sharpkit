using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace NoClrTests
{
    [JsType(JsMode.Prototype)]
    class Test
    {
        List<int> list;
        public void Test2()
        {
            var x = list.Count;
        }
    }
}
