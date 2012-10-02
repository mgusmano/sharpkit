using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.autocomplete
{
    [JsType(JsMode.Global)]
    public class Template
    {
        static Template()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#titles").kendoAutoComplete(new AutoCompleteConfiguration
            {
                minLength = 3,
                dataTextField = "Name",
                template = "<img src='${ data.BoxArt.SmallUrl }' alt='${ data.Name }' />" +
                                  "<h3>" +
                                      "${ data.Name } " +
                                      "<span>${ data.ReleaseYear }</span>" +
                                  "</h3>",
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
            // set width of the drop-down list
        }

    }
}