using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
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
            new jQuery( "#accordion" ).accordion(new AccordionOptions { @event = "mouseover" });
    //        $(function() {
    //    $( "#accordion" ).accordion({
    //        event: "mouseover"
    //    });
    //});
        }
    }
}