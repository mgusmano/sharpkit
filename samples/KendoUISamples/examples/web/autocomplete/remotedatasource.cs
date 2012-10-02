using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.autocomplete
{
    [JsType(JsMode.Global)]
    public class Remotedatasource
    {
        static Remotedatasource()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#titles").kendoAutoComplete(new AutoCompleteConfiguration
            {
                minLength = 3,
                dataTextField = "Name",
                dataSourceObject = new DataSourceConfiguration
                {
                    type = "odata",
                    serverFiltering = true,
                    serverPaging = true,
                    pageSize = 20,
                    transport = new DataSourceTransportConfiguration
                    {
                        readString = "http://odata.netflix.com/Catalog/Titles"
                    }
                }
            });
        }
    }
}