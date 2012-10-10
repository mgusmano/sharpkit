using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.treeview
{
    [JsType(JsMode.Global)]
    public class LocalData
    {
        static LocalData()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var inlineDefault = new HierarchicalDataSource(new HierarchicalDataSourceConfiguration
            {
                data = new JsArray {
                        new { text = "Furniture", items = new JsArray {
                            new { text = "Tables & Chairs" },
                            new { text = "Sofas" },
                            new { text = "Occasional Furniture" }
                        } },
                        new { text = "Decor", items = new JsArray {
                            new { text = "Bed Linen" },
                            new { text = "Curtains & Blinds" },
                            new { text = "Carpets" }
                        } }
                    }
            });

            var inline = new HierarchicalDataSource(new HierarchicalDataSourceConfiguration
            {
                data = new JsArray {
                        new { categoryName = "Storage", subCategories = new JsArray {
                            new { subCategoryName = "Wall Shelving" },
                            new { subCategoryName = "Floor Shelving" },
                            new{ subCategoryName = "Kids Storage" }
                        } },
                        new { categoryName = "Lights", subCategories = new JsArray {
                            new { subCategoryName = "Ceiling" },
                            new { subCategoryName = "Table" },
                            new { subCategoryName = "Floor" }
                        } }
                    },
                schema = new HierarchicalDataSourceSchemaConfiguration
                {
                    model = new HierarchicalDataSourceSchemaModelConfiguration
                    {
                        children = "subCategories"
                    }
                }
            });
            new jQuery("#treeview-left").kendoTreeView(new TreeViewConfiguration
            {
                dataSource = inlineDefault.As<JsArray>()
            });
            new jQuery("#treeview-right").kendoTreeView(new TreeViewConfiguration
            {
                dataSource = inline.As<JsArray>(),
                dataTextField = new JsArray<JsString> { "categoryName", "subCategoryName" }.As<JsString>()
            });
        }
    }
}