using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.progressbar
{
    [JsType(JsMode.Global)]
    public class Resize
    {
        static Resize()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#progressbar").progressbar(new ProgressbarOptions { value = 37 });
            new jQuery("#progressbarWrapper").resizable();
        }
    }
}