using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Properties_
{
    [JsType(JsMode.Prototype)]
    class CustomPropertyName
    {
        public CustomPropertyName()
        {
            this.CSharpName = "Bar";
        }
        [JsProperty(Name = "jsName")]
        public JsString CSharpName { get; private set; }
    }
}
