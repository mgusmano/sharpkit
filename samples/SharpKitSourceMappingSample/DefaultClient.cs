using SharpKit.JavaScript;
using SharpKit.Html;
using SharpKit.jQuery;
namespace SharpKitSourceMappingSample
{
    [JsType(JsMode.Global, Filename = "~/res/Default.js")]
    public class DefaultClient
    {
        static void DefaultClient_Load()
        {
            var doc = HtmlContext.document;
            new jQuery(doc.body).append("Ready<br/>");
            new jQuery(doc.body).append("Ready world2<br/>");
            new jQuery(doc.body).append("Ready world3<br/>");
            new jQuery(doc.body).append("Ready world4<br/>");
            new jQuery(doc.body).append("Ready world5<br/>");
        }

        static void btnTest_click(DOMEvent e)
        {
            var doc = HtmlContext.document;
            new jQuery(doc.body).append("Hello world<br/>");
            new jQuery(doc.body).append("Hello world2<br/>");
            new jQuery(doc.body).append("Hello world3<br/>");
            new jQuery(doc.body).append("Hello world4<br/>");
            new jQuery(doc.body).append("Hello world5<br/>");
        }
    }
}