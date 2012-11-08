using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html5Sdk;


namespace AttHtml5SdkSamples.demos
{
     [JsType(JsMode.Prototype, Name = "Ext", Export = false)] 
    public class MyExt
    {
         public static Prov create(JsString name) { return null; }
         public static Prov create(JsString name, object obj) { return null; }
    }
}
