using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class Revert
    {
        static Revert()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable(new DraggableOptions { revert = "valid" });
            new jQuery("#draggable2").draggable(new DraggableOptions { revert = "invalid" });
            new jQuery("#droppable").droppable(new DroppableOptions
            {
                activeClass = "ui-state-hover",
                hoverClass = "ui-state-active",
                drop = (e, ui) => new jQuery(e.currentTarget).addClass("ui-state-highlight").find("p").html("Dropped!")
            });
        }
    }
}