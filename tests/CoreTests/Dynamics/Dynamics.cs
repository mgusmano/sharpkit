using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Dynamics
{
    [JsType(JsMode.Prototype)]
    class Dynamics
    {
        void TestMethod() { dynamic d; }


        public void parse(dynamic dateNode)
        {
            JsString dateString = dateNode["$t"];
            dateNode("asdas");
            var x = dateNode.ggg.aaa;
            dateNode.aa.bb = "dd";

        }

        public static bool ContainsIgnoreCase(string str, string other)
        {
            return (str.As<dynamic>().ToLower().IndexOf(other.As<dynamic>().ToLower())) > -1;
        }

    }
}
