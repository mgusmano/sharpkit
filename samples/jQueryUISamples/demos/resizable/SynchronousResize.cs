using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.resizable
{
    [JsType(JsMode.Global)]
    public class SynchronousResize
    {
        static SynchronousResize()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#resizable").resizable(new ResizableOptions { alsoResize = "#also" });
            new jQuery("#also").resizable();
        }
    }
}