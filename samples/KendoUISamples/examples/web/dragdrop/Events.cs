using SharpKit.JavaScript;
using SharpKit.jQuery;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.dragdrop
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").kendoDraggable(new DraggableConfiguration
            {
                hintFunction = () => new jQuery("#draggable").clone(),
                dragstart = draggableOnDragStart,
                drag = draggableOnDrag,
                dragend = draggableOnDragEnd,
                dragcancel = draggableOnCancel

            });

            new jQuery("#droptarget").kendoDropTarget(new DropTargetConfiguration
            {
                dragenter = droptargetOnDragEnter,
                dragleave = droptargetOnDragLeave,
                drop = droptargetOnDrop
            });
        }

        static void draggableOnDragStart(Event e)
        {
            kendoConsole.log("dragstart");
            new jQuery("#draggable").addClass("hollow");
            new jQuery("#droptarget").text("(Drop here)");
        }

        static void draggableOnDrag(Event e)
        {
            kendoConsole.log("drag");
        }
        static void draggableOnCancel(Event e)
        {
            kendoConsole.log("drag cancel");
        }
        static void draggableOnDragEnd(Event e)
        {
            kendoConsole.log("dragend");
            var draggable = new jQuery("#draggable");
          //  if (!draggable.data("kendoDraggable").As<Draggable>().dropped)

            //{
            //    new jQuery("#droptarget").text("Try again!");
            //}
            draggable.removeClass("hollow");
        }

        static void droptargetOnDragEnter(Event e)
        {
            kendoConsole.log("dragenter");
            new jQuery("#droptarget").text("Now you can drop it.");
        }
        static void droptargetOnDragLeave(Event e)
        {
            kendoConsole.log("dragleave");
            new jQuery("#droptarget").text("(Drop here)");
        }
        static void droptargetOnDrop(Event e)
        {
            kendoConsole.log("drop");
            new jQuery("#droptarget").text("You did great!");
            new jQuery("#draggable").removeClass("hollow");
        }
    }
}