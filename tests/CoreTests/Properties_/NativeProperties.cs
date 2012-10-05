using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Properties_
{
    [JsType(JsMode.Prototype, NativeProperty = true)]
    class NativeProperties
    {
        [JsProperty(NativeProperty=true)]
        public string Name { get; set; }
    }
}
