using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.treeview
{
    [JsType(JsMode.Global)]
    public class Templates
    {
        static Templates()
        {
            // Delete button behavior
            new jQuery(OnReady).on("click", ".delete-link", () =>
            {
                var treeview = new jQuery("#treeview").data("kendoTreeView").As<TreeView>();
                treeview.remove(new jQuery(JsContext.@this).closest(".k-item").As<JsString>());
                showSerializedData();

            });
        }

        static void OnReady()
        {
            new jQuery("#treeview").kendoTreeView(new TreeViewConfiguration
            {
                templateFunction = Kendo.template(new jQuery("#treeview-template").html()),

                checkboxTemplateFunc = Kendo.template(new jQuery("#treeview-checkbox-template").html()),

                dataSource = new JsArray {
                new  { id = 1, text = "My Documents", expanded = true, spriteCssClass = "rootfolder", items = new JsArray {
                       new {
                            id = 2, text = "Kendo UI Project", expanded = true, spriteCssClass = "folder", items = new JsArray {
                                new { id = 3, text = "about.html", spriteCssClass = "html" },
                                new { id = 4, text = "index.html", spriteCssClass = "html" },
                                new { id = 5, text = "logo.png", spriteCssClass = "image" }
                            }
                        },
                        new {
                            id = 6, text = "New Web Site", expanded = true, spriteCssClass = "folder", items = new JsArray {
                                new { id = 7, text = "mockup.jpg", spriteCssClass = "image" },
                                new { id = 8, text = "Research.pdf", spriteCssClass = "pdf" },
                            }
                        },
                        new {
                            id = 9, text = "Reports", expanded = true, spriteCssClass = "folder", items = new JsArray {
                                new { id = 10, text = "February.pdf", spriteCssClass = "pdf" },
                                new { id = 11, text = "March.pdf", spriteCssClass = "pdf" },
                                new { id = 12, text = "April.pdf", spriteCssClass = "pdf" }
                            }
                        }
                }
                }}
            });
            new jQuery("#treeview [type=checkbox]").change(showSerializedData);
        }
        //TODO: ask about JsRegExp: example doesnt work correctly.
        static void showSerializedData()
        {
            var serializedData = new jQuery("#treeview input").serialize()
                    .replace(new JsRegExp("%5B", "g"), "[")
                    .replace(new JsRegExp("%5D", "g"), "]")
                    .replace(new JsRegExp("&", "g"), "&amp;");

            new jQuery("#checked-nodes").html(serializedData);
        }
    }
}