using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class ColumnMenu
    {
        static ColumnMenu()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var fields = new JsObject<FieldConfig>();
            fields["OrderID"] = new FieldConfig { type = "number" };
            fields["ShipCountry"] = new FieldConfig { type = "string" };
            fields["ShipName"] = new FieldConfig { type = "string" };
            fields["ShipAddress"] = new FieldConfig { type = "string" };

            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    type = "odata",
                    transport = new DataSourceTransportConfiguration
                    {
                        readString = "http://demos.kendoui.com/service/Northwind.svc/Orders"
                    },
                    schema = new DataSourceSchemaConfiguration
                    {
                        model = new ModelObjectOptions
                        {
                            fields = fields
                        }
                    },
                    pageSize = 10,
                    serverPaging = true,
                    serverFiltering = true,
                    serverSorting = true
                },
                height = 250,
                sortableBoolean = true,
                filterable = true,
                columnMenu = true,
                pageableBoolean = true,

                columns = new JsArray<GridColumnConfiguration> 
                { 
                    new GridColumnConfiguration{ field = "OrderID" },
                    new GridColumnConfiguration{ field = "ShipCountry" },
                    new GridColumnConfiguration{ field = "ShipName" },
                    new GridColumnConfiguration 
                    {
                        field = "ShipAddress",
                        filterable = false
                    }
                }

            });
        }
    }
}