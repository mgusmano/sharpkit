using SharpKit.JavaScript;
using SharpKit.Html;
using SharpKit.jQuery;
using SharpKit.LinqJs;

namespace LinqJsSamples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient
    {
        static void DefaultClient_Load()
        {
            var x = Enumerable.From(new JsArray<JsString>{"asdsad", "ASdsad"}).Where(t=>t.substr(0, 1)=="a").ToArray();
        }
        static void btnTest_click(DOMEvent e)
        {
            new jQuery(HtmlContext.document.body).append("Hello world<br/>");
        }
    }
}