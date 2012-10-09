using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;

namespace KendoUISamples.examples.content.shared.js
{
    [JsType(JsMode.Prototype, Name="kendoConsole", Export = false)] 
    public class kendoConsole
    {
        public static void log(JsString msg, bool isError){}
        public static void log(JsString msg) { }
        public static void error(JsString str) { }
    }
}