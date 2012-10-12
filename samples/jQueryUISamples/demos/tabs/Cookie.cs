using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Cookie
    {
        static Cookie()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#tabs").tabs(new TabsOptions { cookie = new { expires = 1 } });
        }
    }
}