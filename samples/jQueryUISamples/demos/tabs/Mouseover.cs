using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Mouseover
    {
        static Mouseover()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#tabs").tabs(new TabsOptions { @event = "mouseover" });
        }
    }
}