using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace CoreTests.Inheritance
{

    [JsType]
    class TypeCheck
    {
        public void test(object obj)
        {
            if (obj is HtmlElement)
            {
            }
        }
    }

}
