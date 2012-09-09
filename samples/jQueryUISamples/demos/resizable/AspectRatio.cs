using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.resizable
{
    [JsType(JsMode.Global)]
    public class AspectRatio
    {
        static AspectRatio()
        {
            new jQuery(Onready);
        }

        static void Onready()
        {
            new jQuery("#resizable").resizable(new ResizableOptions { aspectRatio = 16 / 9 });
        }
    }
}