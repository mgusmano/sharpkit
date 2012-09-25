using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Constructors
{
    [JsType(JsMode.Prototype)]
    class Constructors
    {
        static Constructors()
        {
            var x = 7;
        }

        public Constructors()
        {
            
        }

        void foo()
        {
            var ctor = JsContext.CtorOf<Constructors>();
            var obj = JsContext.JsCode("new ctor()");
        }
    }
}
