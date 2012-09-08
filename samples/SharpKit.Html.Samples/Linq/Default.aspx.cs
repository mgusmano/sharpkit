using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.JavaScript;

namespace SharpKit.Html.Samples.Linq
{
    [JsType(JsMode.Global, Filename = "Default.js")]
    public class DefaultClient : HtmlContextBase
    {
        //static void Descendents(DOMEvent e)
        //{
        //    var divTest = document.getElementById("divTest");
        //    foreach (var node in divTest.Descendents())
        //    {
        //        WriteLine(node.nodeName);
        //    }
        //}
        //static void Children(DOMEvent e)
        //{
        //    var divTest = document.getElementById("divTest");
        //    foreach (var node in divTest.Children())
        //    {
        //        WriteLine(node.nodeName);
        //    }
        //}

        //private static void WriteLine(JsString s)
        //{
        //    var div = document.createElement("div");
        //    div.appendChild(document.createTextNode(s));
        //    document.body.appendChild(div);
        //}
    }

}