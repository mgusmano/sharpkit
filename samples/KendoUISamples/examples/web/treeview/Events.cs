using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using KendoUISamples.examples.content.shared.js;

namespace KendoUISamples.examples.web.treeview
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
            new jQuery("#treeview").kendoTreeView(new TreeViewConfiguration
            {
                dataSource = new JsArray {
                            new { text = "Furniture", expanded = true, items = new JsArray {
                                new { text = "Tables & Chairs" },
                                new { text = "Sofas" },
                                new { text = "Occasional Furniture" }
                            }
                            },
                            new { text = "Decor", items = new JsArray {
                                new { text = "Bed Linen" },
                                new { text = "Curtains & Blinds" },
                                new { text = "Carpets" }
                            }
                            },
                            new { text = "Storage" }
                        },
                select = onSelect,
                collapse = onCollapse,
                expand = onExpand,
                dragAndDrop = true,
                /* drag & drop events */
                dragstart = onDragStart,
                drag = onDrag,
                drop = onDrop,
                dragend = onDragEnd
            });


        }
        static void onSelect(TreeViewEventData e)
        {
            kendoConsole.log("Selected: " + JsContext.@this.As<TreeView>().text(e.node.As<JsString>()));
        }

        static void onCollapse(TreeViewEventData e)
        {
            kendoConsole.log("Collapsing " + JsContext.@this.As<TreeView>().text(e.node.As<JsString>()));
        }

        static void onExpand(TreeViewEventData e)
        {
            kendoConsole.log("Expanding " + JsContext.@this.As<TreeView>().text(e.node.As<JsString>()));
        }

        static void onDragStart(TreeViewDragstartEventData e)
        {
            kendoConsole.log("Started dragging " + JsContext.@this.As<TreeView>().text(e.sourceNode.As<JsString>()));
        }

        static void onDrag(TreeViewDragEventData e)
        {
            kendoConsole.log("Started dragging " + JsContext.@this.As<TreeView>().text(e.sourceNode.As<JsString>()));
        }

        static void onDrop(TreeViewDropEventData e)
        {
            kendoConsole.log(
            "Dropped " + JsContext.@this.As<TreeView>().text(e.sourceNode.As<JsString>()) +
            " (" + (e.valid ? "valid" : "invalid") + ")"
            );
        }

        static void onDragEnd(TreeViewDragendEventData e)
        {
            kendoConsole.log("Finished dragging " + JsContext.@this.As<TreeView>().text(e.sourceNode.As<JsString>()));
        }


    }
}