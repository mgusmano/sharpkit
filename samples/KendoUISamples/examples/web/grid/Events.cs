using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                //TODO: change: onChange,
                //TODO: dataBound: onDataBound,
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

        static JsString OnChange(object arg)
        {
            //TODO: 
         //   var selected = jQuery.map(JsContext.@this.As<Grid>().select(null), (index, item) => new jQuery(item).text());
            JsContext.JsCode("var selected = $.map(this.select(), function(item) {return $(item).text();});");
            JsContext.JsCode("kendoConsole.log('Selected: ' + selected.length + ' item(s), [' + selected.join(', ') + ']');");
            return null;
        }
        static void OnDataBound(object arg)
        {
            kendoConsole.log("Grid data bound");
        }
    }
}