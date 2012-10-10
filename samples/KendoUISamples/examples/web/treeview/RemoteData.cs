using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.treeview
{
    [JsType(JsMode.Global)]
    public class RemoteData
    {
        static RemoteData()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var serviceRoot = "http://demos.kendoui.com/service";
            var homogeneous = new HierarchicalDataSource(new HierarchicalDataSourceConfiguration
            {
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        url = serviceRoot + "/Employees",
                        dataType = "jsonp"
                    }
                },
                schema = new HierarchicalDataSourceSchemaConfiguration
                {
                    model = new HierarchicalDataSourceSchemaModelConfiguration
                    {
                        id = "EmployeeId",
                        hasChildrenString = "HasEmployees"
                    }
                }
            });

            new jQuery("#treeview").kendoTreeView(new TreeViewConfiguration
            {
                dataSource = homogeneous.As<JsArray>(),
                dataTextField = "FullName"
            });

        }
    }
}