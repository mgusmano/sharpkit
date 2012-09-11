using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.JavaScript;
namespace SharpKitWebApp5
{
    [JsType(JsMode.Prototype, Export=false)]
    public interface Iface
    {
        object message { get; set; }
    }

    [JsType(JsMode.Prototype)]
    public class MyClass : Iface
    {
        public object message { get; set; }
    }
}