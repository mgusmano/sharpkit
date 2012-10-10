using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
namespace KendoUISamples.examples.web.treeview
{
    [JsType(JsMode.Global)]
    public class DragDrop
    {
        static DragDrop()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#treeview-left").kendoTreeView(new TreeViewConfiguration
            {
                dragAndDrop = true,
                dataSource = new JsArray {
                    new { text = "Furniture", expanded = true, items = new JsArray {
                        new {text = "Tables & Chairs" },
                        new { text = "Sofas" },
                        new { text = "Occasional Furniture" }
                    }},
                    new { text = "Decor", items = new JsArray {
                        new { text = "Bed Linen" },
                        new { text = "Curtains & Blinds" },
                        new { text = "Carpets" }
                        }   
                    }
                }
            }).data("kendoTreeView");

            new jQuery("#treeview-right").kendoTreeView(new TreeViewConfiguration
            {
                dragAndDrop = true,
                dataSource = new JsArray {
                    new { text = "Storage", expanded = true, items = new JsArray {
                        new { text = "Wall Shelving" },
                        new { text = "Floor Shelving" },
                        new { text = "Kids Storage" }
                        }
                    },
                    new { text = "Lights", items = new JsArray {
                        new { text = "Ceiling" },
                        new { text = "Table" },
                        new{ text = "Floor" }
                        }
                    }
                }
            }).data("kendoTreeView");
        }
    }
}