using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Collapsible
    {
        static Collapsible()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#tabs").tabs(new TabsOptions { collapsible = true });
        }
    }
}