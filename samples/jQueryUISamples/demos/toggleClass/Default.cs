using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.toggleClass
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
                    new jQuery("#effect").toggleClass("newClass", 1000);
                    JsContext.@return(false);
                });
        }
    }
}