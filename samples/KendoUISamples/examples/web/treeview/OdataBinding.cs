using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using SharpKit.jQuery;

namespace KendoUISamples.examples.web.treeview
{
    [JsType(JsMode.Global)]
    public class OdataBinding
    {
        static OdataBinding()
        {
            new jQuery(OnReady);
        }

        //TODO: the example doesn't work.
        static void OnReady()
        {
            // TreeView bound to Categories > Products > OrderDetails
            var OrderDetails = new DataSourceConfiguration
            {
                type = "odata",
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        urlFunc = options => Kendo.format("http://demos.kendoui.com/service/Northwind.svc/Products({0})/Order_Details", options.As<JsObject>()["ProductID"].As<JsNumber>())
                    }
                },
                schema = new HierarchicalDataSourceSchemaConfiguration
                {
                    model = new HierarchicalDataSourceSchemaModelConfiguration
                    {
                        hasChildrenFunc = () => false

                    }
                }
            };

            var Products = new HierarchicalDataSourceConfiguration
            {
                type = "odata",
                schema = new HierarchicalDataSourceSchemaConfiguration
                {
                    model = new HierarchicalDataSourceSchemaModelConfiguration
                    {
                        id = "ProductID",
                        hasChildrenString = "Order_Details",
                        children = OrderDetails
                    }
                },
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        urlFunc = options => Kendo.format("http://demos.kendoui.com/service/Northwind.svc/Categories({0})/Products", options.As<JsObject>()["CategoryID"].As<JsNumber>())
                    }
                }
            };

            var Categories = new HierarchicalDataSource(new HierarchicalDataSourceConfiguration
            {
                type = "odata",
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        url = "http://demos.kendoui.com/service/Northwind.svc/Categories"
                    }
                },
                schema = new HierarchicalDataSourceSchemaConfiguration
                {
                    model = new HierarchicalDataSourceSchemaModelConfiguration
                    {
                        hasChildrenString = "Products",
                        id = "CategoryID",
                        children = Products
                    }
                }
            });

            new jQuery("#treeview").kendoTreeView(new TreeViewConfiguration
            {
                dataSource = Categories.As<JsArray>(),
                dataTextField = new JsArray<JsString> { "CategoryName", "ProductName", "OrderID" }.As<JsString>()
            });
        }
    }
}