using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Radio
    {
        static Radio()
        {
            new jQuery(OnRaedy);
        }
        static void OnRaedy()
        {
            new jQuery("#radio").buttonset();
        }
    }
}