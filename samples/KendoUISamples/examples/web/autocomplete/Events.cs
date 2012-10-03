using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.autocomplete
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
            var data = new[] {
                            "Alabama",
                            "Alaska",
                            "American Samoa",
                            "Arizona",
                            "Arkansas",
                            "California",
                            "Colorado",
                            "Connecticut",
                            "Delaware",
                            "District of Columbia",
                            "Florida",
                            "Georgia",
                            "Guam",
                            "Hawaii",
                            "Idaho",
                            "Illinois",
                            "Indiana",
                            "Iowa",
                            "Kansas",
                            "Kentucky",
                            "Louisiana",
                            "Maine",
                            "Maryland",
                            "Massachusetts",
                            "Michigan",
                            "Minnesota",
                            "Mississippi",
                            "Missouri",
                            "Montana",
                            "Nebraska",
                            "Nevada",
                            "New Hampshire",
                            "New Jersey",
                            "New Mexico",
                            "New York",
                            "North Carolina",
                            "North Dakota",
                            "Northern Marianas Islands",
                            "Ohio",
                            "Oklahoma",
                            "Oregon",
                            "Pennsylvania",
                            "Puerto Rico",
                            "Rhode Island",
                            "South Carolina",
                            "South Dakota",
                            "Tennessee",
                            "Texas",
                            "Utah",
                            "Vermont",
                            "Virginia",
                            "Virgin Islands",
                            "Washington",
                            "West Virginia",
                            "Wisconsin",
                            "Wyoming"
                    };
            new jQuery("#products").kendoAutoComplete(new AutoCompleteConfiguration
            {
                dataSourceObject = data,
                select = e => onSelect(e),
                change = onChange,
                close = onClose,
                open = onOpen
            });
        }

        static void onOpen()
        {

            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event :: open");
            }
        }
        static void onClose()
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event :: close");
            }
        }

        static void onChange()
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event :: change");
            }
        }
        static void onSelect(Event e)
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                //TODO:
                //var dataItem = JsContext.@this.As<Grid>().dataItem(e.currentTarget.item.index());
                JsContext.JsCode("var dataItem = this.dataItem(e.item.index());");
                JsContext.JsCode(" kendoConsole.log('event :: select (' + dataItem + ')');");
            }
        }
    }
}