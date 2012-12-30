using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.Html;
using SharpKit.NodeJs;
using SharpKit.JavaScript;

namespace NodeJsSamples
{
    [JsType(JsMode.Global)]
    static class HelloWorld
    {
         static void OnReady()
        {
            console.log("Hello World");
        }
    }
}