using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
namespace SharpKitSourceMappingSample
{
    [JsType(JsMode.Global, Filename = "~/res/Default.js")]
    public class DefaultClient : jQueryContextBase
    {
        static void DefaultClient_Load()
        {
            J(document.body).append("Ready<br/>");
            J(document.body).append("Ready world2<br/>");
            J(document.body).append("Ready world3<br/>");
            J(document.body).append("Ready world4<br/>");
            J(document.body).append("Ready world5<br/>");
        }

        static void btnTest_click(HtmlDomEventArgs e)
        {
            J(document.body).append("Hello world<br/>");
            J(document.body).append("Hello world2<br/>");
            J(document.body).append("Hello world3<br/>");
            J(document.body).append("Hello world4<br/>");
            J(document.body).append("Hello world5<br/>");
        }
    }
}