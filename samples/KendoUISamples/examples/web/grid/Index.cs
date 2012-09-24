using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using KendoUISamples.examples.content.shared.js;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {

            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    data = People.createRandomData(50),
                    pageSize = 10
                },
                groupable = true,
                sortableBoolean = true,
                pageableBoolean = true,
                columns = new JsArray<GridColumnConfiguration> { new GridColumnConfiguration
                {
                    field = "FirstName",
                    width = "90",
                    title = "FirstName"
                }, new GridColumnConfiguration
                {
                    field = "LastName",
                    width = "90",
                    title = "Last Name"
                },
                
                new GridColumnConfiguration { width = "100", field = "City" },
                new GridColumnConfiguration { field = "Title"},
                new GridColumnConfiguration { field = "BirthDate", title = "Birth Date", template = "#= kendo.toString(BirthDate,'dd MMMM yyyy') #"},
                new GridColumnConfiguration { width = "50", field = "Age"}
                }
            });
        }
    }
}