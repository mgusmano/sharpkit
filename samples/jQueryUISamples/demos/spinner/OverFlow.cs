using SharpKit.JavaScript;
using SharpKit.jQuery;
namespace jQueryUISamples.demos.spinner
{
    [JsType(JsMode.Global)]
    public class OverFlow
    {
        static OverFlow()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#spinner").spinner(new SpinnerOptions
            {
                spin = (e, ui) =>
                {
                    if (ui.value > 10)
                    {
                        new jQuery(JsContext.@this).spinner("value", -10);
                        JsContext.@return(false);
                    }
                    else if (ui.value < -10)
                    {
                        new jQuery(JsContext.@this).spinner("value", 10);
                        JsContext.@return(false);
                    }
                }
            });
        }
    }
}