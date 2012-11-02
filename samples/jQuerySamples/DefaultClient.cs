using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;

namespace jQuerySamples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContext
    {
        static void DefaultClient_Load()
        {
            J(document.body).myPlugin();
        }
        static void btnTest_click(HtmlDomEventArgs e)
        {
            J(document.body).myPlugin();
        }
    }
}