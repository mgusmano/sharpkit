using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace Ext
{
    [JsType(JsMode.Global, Export=false)]
    public class ExtJsContext : JsContext
    {
        public static ExtGlobal Ext { get; set; }
    }

    partial class ExtGlobal
    {
        public T create<T>(object config) { return default(T); }
    }
}
