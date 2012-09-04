using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
{
    [JsType(JsMode.Global)]
    public class CustomIcons
    {
        static CustomIcons()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var icons = new IconOptions { header = "ui-icon-circle-arrow-e", headerSelected = "ui-icon-circle-arrow-s" };
            new jQuery("#accordion").accordion(new AccordionOptions { icons = icons });
            new jQuery("#toggle").button().toggle(e => new jQuery("#accordion").accordion("option", "icons", false),
                e => new jQuery("#accordion").accordion("option", "icons", icons)
            );
        }
    }
}