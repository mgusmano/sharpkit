using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class DelayStart
    {
        static DelayStart()
        {
            new jQuery(Onready);
        }
        static void Onready()
        {
            new jQuery("#sortable1").sortable(new SortableOptions { delay = 300 });
            new jQuery("#sortable2").sortable(new SortableOptions { distance = 15 });
            new jQuery("li").disableSelection();
        }
    }
}