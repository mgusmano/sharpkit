using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class Placeholder
    {
        static Placeholder()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#sortable").sortable(new SortableOptions { placeholder = "ui-state-highlight" });
            new jQuery("#sortable").disableSelection();
        }
    }
}