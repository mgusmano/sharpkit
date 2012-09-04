using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
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
            new jQuery("#accordion").accordion(new AccordionOptions { header = ">div > h3" })
                .sortable(new SortableOptions
                {
                    axis = "y",
                    handle = "h3",
                    stop = (e, ui) => ui.item.children("h3").triggerHandler("focusout")
                });
        }
    }
}