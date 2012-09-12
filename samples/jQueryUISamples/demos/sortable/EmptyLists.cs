using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class EmptyLists
    {
        static EmptyLists()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("ul.droptrue").sortable(new SortableOptions { connectWith = "ul" });
            new jQuery("ul.dropfalse").sortable(new SortableOptions { connectWith = "ul", dropOnEmpty = false });
            new jQuery("#sortable1, #sortable2, #sortable3").disableSelection();
        }
    }
}