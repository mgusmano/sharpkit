using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Sortable
    {
        static Sortable()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#tabs").tabs().find(".ui-tabs-nav").sortable(new SortableOptions { axis = "x" });
        }
    }
}