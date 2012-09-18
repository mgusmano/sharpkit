using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.dialog
{
    [JsType(JsMode.Global)]
    public class Animate
    {
        static Animate()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            //JsContext.JsCode("
            // increase the default animation speed to exaggerate the effect
            // TODO: //$.fx.speeds._default = 1000;
            //jQuery.fx.sp
            new jQuery("#dialog").dialog(new DialogOptions
            {
                autoOpen = false,
                show = "blind",
                hide = "explode",
            });
            new jQuery("#opener").click(e =>
                {
                    new jQuery("#dialog").dialog("open");
                    JsContext.@return(false);
                });
        }
    }
}