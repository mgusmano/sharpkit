using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ext;
using SharpKit.JavaScript;

namespace ExtJsSamples
{
    [JsType(JsMode.Prototype)]
    public class Test1
    {
        void foo()
        {
            //var x = ExtContext.create<Ext.window.Window>(new Ext.window.WindowConfig());
            foo2<MyClass>();
        }
        [JsMethod(IgnoreGenericArguments=false)]
        void foo2<T>()
        {
        }
    }
    [JsType(JsMode.Prototype, GenericArgumentJsCode="\"MyClass\"")]
    class MyClass
    {
    }
}