using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Checkbox
    {
        static Checkbox()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#check").button();
            new jQuery("#format").buttonset();
        }
    }
}