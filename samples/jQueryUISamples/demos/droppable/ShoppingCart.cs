using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class ShoppingCart
    {
        static ShoppingCart()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#catalog").accordion();
            new jQuery("#catalog li").draggable(new DraggableOptions
            {
                appendTo = "body",
                helper = "clone"
            });
            new jQuery("#cart ol").droppable(new DroppableOptions
            {
                activeClass = "ui-state-default",
                hoverClass = "ui-state-hover",
                accept = ":not(.ui-sortable-helper)",
                drop = (e, ui) =>
                    {
                        new jQuery(JsContext.@this).find(".placeholder").remove();
                        new jQuery("<li></li>").text(ui.draggable.text()).appendTo(JsContext.@this);
                    }
            })
                    .sortable(new SortableOptions
                    {
                        items = "li:not(.placeholder)",
                        sort = (e, ui) =>
                            // gets added unintentionally by droppable interacting with sortable
                            // using connectWithSortable fixes this, but doesn't allow you to customize active/hoverClass options
                    new jQuery(JsContext.@this).removeClass("ui-state-default")
                    });
        }
    }
}