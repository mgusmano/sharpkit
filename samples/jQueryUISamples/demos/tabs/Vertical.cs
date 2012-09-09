using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Vertical
    {
        static Vertical()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#tabs").tabs().addClass("ui-tabs-vertical ui-helper-clearfix");
            new jQuery("#tabs li").removeClass("ui-corner-top").addClass("ui-corner-left");
        }
    }
}