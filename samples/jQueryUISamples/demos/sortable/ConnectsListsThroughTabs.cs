using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class ConnectsListsThroughTabs
    {
        static ConnectsListsThroughTabs()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#sortable1, #sortable2").sortable().disableSelection();
            var tabs = new jQuery("#tabs").tabs();
            var tab_items = new jQuery("ul:first li", tabs);
            tab_items = tab_items.droppable(new DroppableOptions
            {
                accept = ".connectedSortable li",
                hoverClass = "ui-state-hover",
                drop = (e, ui) =>
                    {
                        var item = new jQuery(e.currentTarget);
                        var list = new jQuery(item.find("a").attr("href"))
                        .find(".connectedSortable");
                        ui.draggable.hide("slow", () =>
                            {
                                tabs.tabs("select", tab_items.index(item));
                                new jQuery(e.currentTarget).appendTo(list).show("slow");
                            });
                    }
            });
        }
    }
}