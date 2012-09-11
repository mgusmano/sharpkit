using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.resizable
{
    [JsType(JsMode.Global)]
    public class MaxMin
    {
        static MaxMin()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {

            new jQuery("#resizable").resizable(new ResizableOptions { maxHeight = 250, maxWidth = 350, minHeight = 150, minWidth = 200 });
        }
    }
}