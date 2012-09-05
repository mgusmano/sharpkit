using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class AcceptedElements
    {
        static AcceptedElements()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable, #draggable-nonvalid").draggable();
            new jQuery("#droppable").droppable(new DroppableOptions
            {
                accept = "#draggable",
                activeClass = "ui-state-hover",
                hoverClass = "ui-state-active",
                drop = (e, ui) =>
                {
                    new jQuery(e.currentTarget).addClass("ui-state-highlight").find("p").html("dropped!");
                }
            });
        }
    }
}