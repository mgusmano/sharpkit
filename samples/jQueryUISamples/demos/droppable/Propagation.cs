using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class Propagation
    {
        static Propagation()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable();
            new jQuery("#droppable, #droppable-inner").droppable(new DroppableOptions
            {
                activeClass = "ui-state-hover",
                hoverClass = "ui-state-active",
                drop = (e, ui) =>
                    {

                        new jQuery(e.currentTarget).addClass("ui-state-highlight").find("> p").html("Dropped!");
                        JsContext.@return(false);
                    }
            });
            new jQuery("#droppable2, #droppable2-inner").droppable(new DroppableOptions
            {
                greedy = true,
                activeClass = "ui-state-hover",
                hoverClass = "ui-state-active",
                drop = (e, ui) =>
                    {
                        new jQuery(e.currentTarget).addClass("ui-state-highlight").find(" > p ").html("Dropped!");
                    }
            });
        }
    }
}