using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;

namespace SharpKitRaytracer
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContext
    {
        static void DefaultClient_Load()
        {
            J(document.body).append("Ready<br/>");
        }
        static void btnTest_click(HtmlDomEventArgs e)
        {
            RaytracerRunner rr = new RaytracerRunner();
            rr.exec();
        }
    }
}