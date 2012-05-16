using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;

namespace SharpKit.BackboneJs.Samples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContextBase
    {
        static void DefaultClient_Load()
        {
            J(document.body).append("Ready<br/>");
        }
        static void btnTest_click(HtmlDomEventArgs e)
        {
            J(document.body).append("Hello world<br/>");
        }
    }
}