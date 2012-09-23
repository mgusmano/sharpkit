using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.removeClass
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#button").click(e =>
            {
                new jQuery("#effect").removeClass("newClass", 1000, callback);
                JsContext.@return(false);
            });
        }

        static void callback(Event e, object ui)
        {
            HtmlContext.window.setTimeout(() =>
            {
                new jQuery("#effect").addClass("newClass");

            }, 1500);
        }
    }
}