using SharpKit.jQuery;
using SharpKit.Html4;
using SharpKit.JavaScript;

namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class Scroll
    {
        static Scroll()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable(new DraggableOptions { scroll = true });
            new jQuery("#draggable2").draggable(new DraggableOptions { scroll = true, scrollSensitivity = 100 });
            new jQuery("#draggable3").draggable(new DraggableOptions { scroll = true, scrollSensitivity = 100 });
        }
    }
}