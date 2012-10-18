using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using KendoUISamples.examples.content.shared.js;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class CustomCommand
    {
        //TODO: ask Danel about template.
        static JsFunc<JsString, JsString> detailsTemplate;
        static Window wnd;
        static CustomCommand()
        {
            new jQuery(OnReady);
        }
        
        static void OnReady()
        {
            var grid = new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    pageSize = 10,
                    data = People.createRandomData(50)
                },
                pageableBoolean = true,
                height = 260,
                columns = new JsArray<GridColumnConfiguration> {
                    new GridColumnConfiguration { field = "FirstName", title = "First Name" },
                    new GridColumnConfiguration { field = "LastName", title = "Last Name" },
                    new GridColumnConfiguration { field = "Title" },
                    new GridColumnConfiguration { command = new {text="Details", click= new JsAction<Event>(showDetails)}.As<GridColumnsCommandOptions>(), title = " ", widthString = "110px"}
                }

            }).data("kendoGrid");

            wnd = new jQuery("#details").kendoWindow(new WindowConfiguration
            {
                title = "Customer Details",
                modal = true,
                visible = false,
                resizable = false,
                width = "300"
            }).data("kendoWindow").As<Window>();
           detailsTemplate = Kendo.template(new jQuery("#template").html());
           
        }
        static void showDetails(Event e)
        {
            e.preventDefault();
            var dataItem = JsContext.@this.As<Grid>().dataItem(new jQuery(e.currentTarget).closest("tr"));
           // wnd.content(detailsTemplate(dataItem.As<JsString));
            wnd.center().open();
        }
    }
}