using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        static CustomCommand()
        {
        }

        static void OnReady()
        {
            JsContext.JsCode("var detailsTemplate");
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
                    new GridColumnConfiguration { command = new {text="Details", click= new JsAction<Event, Window>(showDetails)}.As<GridColumnsCommandOptions>(), title = " ", widthString = "110px"}
                }
                
            }).data("kendoGrid");

            var wnd = new jQuery("#details").kendoWindow(new WindowConfiguration
            {
                title = "Customer Details",
                modal = true,
                visible = false,
                resizable = false,
                maxWidth = 300
            }).data("kendoWindow");
            JsContext.JsCode(" detailsTemplate = kendo.template($('#template').html());");
            //TODO: var detailsTemplate = kendo.template(new jQuery("#template").html());
               
           
        }
        static void showDetails(Event e, Window wnd) {
            e.preventDefault();
            var dataItem = JsContext.@this.As<Grid>().dataItem(new jQuery(e.currentTarget).closest("tr"));
            wnd.center().open();
        }
    }
}