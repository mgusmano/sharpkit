using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Methods
{

    [JsType(JsMode.Prototype)]
    class NamedParameters
    {
        public void Foo(string prm1, string prm2, string prm3)
        {
        }

        void Foo2()
        {
            Foo(prm3 : "prm3", prm2 : "prm2", prm1 : "prm1");
        }
    }
}
