using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
[assembly: JsType(JsMode.Prototype, TargetType = typeof(System.ComponentModel.RefreshProperties), Filename = "~/Enums/Enums.js")]
namespace CoreTests.Enums
{
    [JsType(JsMode.Prototype)]
    class Enums
    {
        void foo()
        {
            var proto = Enum1Proto.a;
            var protoName = Enum2ProtoName.b;
            var jsonName = Enum3JsonName.c;
            var json = Enum4Json.a;
            var clrName = Enum5ClrName.b;
            var clr = Enum6Clr.b;


        }
        void WithDefault()
        {
            var a = default(Enum1Proto);
            var b = default(Enum2ProtoName);
            var c = default(Enum3JsonName);
            var d = default(Enum4Json);
            var e = default(Enum5ClrName);
            var f = default(Enum6Clr);

        }
        void Reflect()
        {
            var type = JsContext.CtorOf<Enum1Proto>().As<JsObject>();
            foreach (var name in type)
            {
                var value = type[name];
                alert(name + "=" + value);
            }
        }

        private void alert(string p)
        {
            var x = Enum1Proto.b;
            var y = Enum2ProtoName.c;
        }
        public Enum1Proto Enum1 { get; set; }
        public Enum2ProtoName Enum2 { get; set; }
        public Enum3JsonName Enum3 { get; set; }
        public Enum4Json Enum4 { get; set; }
        public Enum5ClrName Enum5 { get; set; }
    }

    [JsType(JsMode.Prototype)]
    enum Enum1Proto
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Prototype)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum2ProtoName
    {
        a,
        b,
        c,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum3JsonName
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Json)]
    enum Enum4Json
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Clr)]
    [JsEnum(ValuesAsNames = true)]
    enum Enum5ClrName
    {
        a = 1,
        b = 2,
        c = 3,
    }

    [JsType(JsMode.Clr)]
    enum Enum6Clr
    {
        a = 1,
        b = 2,
        c = 3,
    }

}
