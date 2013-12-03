using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.For
{
    [JsType(JsMode.Prototype)]
    class FieldsTest
    {
        public string a2;
        public string a = "aaa", b = "bbb", c = "ccc";
        public int a1 = 1, b1, c1 = 3;
        public string a3 = "aa";
        public System.Collections.ArrayList list = new System.Collections.ArrayList();
        public System.Collections.Generic.List<string> a4 = new System.Collections.Generic.List<string>(new string[] { "a", "b", "c" });

    }
}

