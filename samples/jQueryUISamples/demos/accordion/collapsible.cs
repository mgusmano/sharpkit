using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
{
    [JsType(JsMode.Global)]
    public class collapsible
    {
        static collapsible()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#accordion").accordion(new AccordionOptions { collapsible = true });
        }
    }
}