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
            //JsString dateString = dateNode["$t"];
        }
    }
}
