using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.grid
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
            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    data = People.createRandomData(50),
                    pageSize = 5
                },
                change = OnChange,
                dataBound = OnDataBound,
                selectable = "multiple cell",
                pageableBoolean = true,
                sortable = true,
                scrollable = false,
                columns = new JsArray<GridColumnConfiguration> {
                    new GridColumnConfiguration { field = "FirstName", title = "First Name" },
                    new GridColumnConfiguration { field = "LastName", title = "Last Name" },
                    new GridColumnConfiguration { field = "Age"}
                }
            });
        }
        //TODO: the example doesn't work correctly.
        static void OnChange(object arg)
        {
            var selected = jQuery.map(JsContext.@this.As<Grid>().select(), (index, item) => new jQuery(item).text());
            //kendoConsole.log("Selected: " + selected.length + " item(s), [" + selected.join(", ") + "]");
            JsContext.JsCode("kendoConsole.log('Selected: ' + selected.length + ' item(s), [' + selected.join(', ') + ']');");
        }
        //           kendoConsole.log("Selected: " + selected.length + " item(s), [" + selected.join(", ") + "]");


        static void OnDataBound(object arg)
        {
            kendoConsole.log("Grid data bound");
        }
    }
}