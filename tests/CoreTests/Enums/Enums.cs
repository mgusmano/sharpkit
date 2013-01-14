using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
[assembly: JsType(JsMode.Prototype, TargetType = typeof(System.ComponentModel.RefreshProperties), Filename="~/Enums/Enums.js")]
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
            var x = Enum1.b;
            var y = Enum2.c;
        }
    }

    [JsType(JsMode.Prototype)]
    enum Enum1
    {
        a=1,
        b=2,
        c=3,
    }

    [JsType(JsMode.Prototype)]
    [JsEnum(ValuesAsNames=true)]
    enum Enum2
    {
        a = 1,
        b = 2,
        c = 3,
    }

}
