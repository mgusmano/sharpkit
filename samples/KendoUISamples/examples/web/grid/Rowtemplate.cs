using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class Rowtemplate
    {
        static Rowtemplate()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#netflixTable").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    type = "odata",
                    serverFiltering = true,
                    filter = new JsArray { 
                        new {field = "Name", @operator = "contains", value = "Star Wars" },
                        new {field = "BoxArt.SmallUrl", @operator = "neq"} },
                    transport = new DataSourceTransportConfiguration
                    {
                        readString = "http://odata.netflix.com/Catalog/Titles"
                    }
                },
                //TODO: rowTemplate: kendo.template($("#rowTemplate").html()),
                // rowTemplate = 
                height = 200
            });
 
              //$(document).ready(function() {
              //      $("#netflixTable").kendoGrid({
              //          dataSource: {
              //              type: "odata",
              //              serverFiltering: true,
              //              filter: [{
              //                  field: "Name",
              //                  operator: "contains",
              //                  value: "Star Wars"
              //                  },{
              //                  field: "BoxArt.SmallUrl",
              //                  operator: "neq",
              //                  value: null
              //              }],
              //              transport: {
              //                  read: "http://odata.netflix.com/Catalog/Titles"
              //              }
              //          },
              //          rowTemplate: kendo.template($("#rowTemplate").html()),
              //          height: 200
              //      });
              //  });
        }
    }
}