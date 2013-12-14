using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Indexers
{
    [JsType(JsMode.Prototype)]
    class Indexers
    {
        void foo()
        {
            var stringToInt = new Dictionary<string, int>();
            var res = stringToInt["seven"] = 7;
            Console.WriteLine("Result: " + res.ToString());
        }
    }
}
