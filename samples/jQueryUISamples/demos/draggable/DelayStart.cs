using SharpKit.jQuery;
using SharpKit.Html4;
using SharpKit.JavaScript;

namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class DelayStart
    {
        static DelayStart()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable(new DraggableOptions { distance = 20 });
            new jQuery("#draggable2").draggable(new DraggableOptions { delay = 1000 });
            new jQuery(".ui-draggable").disableSelection();
        }
    }
}