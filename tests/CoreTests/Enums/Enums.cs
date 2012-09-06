using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Enums
{
    [JsType(JsMode.Prototype)]
    class Enums
    {
        void Reflect()
        {
            var type = JsContext.CtorOf<Enum1>().As<JsObject>();
            foreach (var name in type)
            {
                var value = type[name];
                alert(name + "=" + value);
            }
        }

        private void alert(string p)
        {
            throw new NotImplementedException();
        }
    }

    [JsType(JsMode.Prototype)]
    enum Enum1
    {
        a=1,
        b=2,
        c=3,
    }
}
