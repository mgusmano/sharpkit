using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.progressbar
{
    [JsType(JsMode.Global)]
    public class Animated
    {
        static Animated()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#progressbar").progressbar(new ProgressbarOptions { value = 59 });
        }
    }
}