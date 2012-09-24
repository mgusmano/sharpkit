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
            JsContext.JsCode("columns: ['OrderID','ShipCountry','ShipName',{field: 'ShipAddress',filterable: false}]");
            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    type = "odata",
                    //transport = new T
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
                // TODO: colomnMenu = true,
                pageableBoolean = true,
              
               //columns = new JsArray<GridColumnConfiguration> { 
                //       //TODO:"OrdeId", "shipContry", "shipName",
                //        new GridColumnConfiguration {
                //            field = "ShipAssress",
                //            filterable = false
                //    }
                //}

            });
            

            //            height: 250,
            //            sortable: true,
            //            filterable: true,
            //            columnMenu: true,
            //            pageable: true,
                        //columns: [
                        //    "OrderID",
                        //    "ShipCountry",
                        //    "ShipName",
                        //    {
                        //        field: "ShipAddress",
                        //        filterable: false
                        //    }
                        //]
            //        });
            //    });
            //</script>
        }
    }
}