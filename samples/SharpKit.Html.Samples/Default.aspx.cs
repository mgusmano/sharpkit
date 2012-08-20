using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Html.Samples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    [JsType(JsMode.Global, Filename = "Default.js")]
    public class DefaultClient : HtmlContextBase
    {
        static void btnHello_click(DOMEvent e)
        {
            WriteLine("Hello world");
        }

        private static void WriteLine(JsString s)
        {
            var div = document.createElement("div");
            div.appendChild(document.createTextNode(s));
            document.body.appendChild(div);
        }
    }

}