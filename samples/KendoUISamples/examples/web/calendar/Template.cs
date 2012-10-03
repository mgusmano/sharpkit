using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.calendar
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
            var today = new JsDate();
            var birthdays = new JsArray<JsNumber> {
                new JsDate(today.getFullYear(), today.getMonth(), 8).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth(), 12).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth(), 24).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 6).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 7).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 25).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 27).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 1, 3).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 1, 5).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 2, 22).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 2, 27).valueOf()
            };
            new jQuery("#calendar").kendoCalendar(new CalendarConfiguration
            {
                value = today,
                dates = birthdays,
                month = new MonthConfiguration
                {
                    // template for dates in month view
                    content = "# if ($.inArray(+data.date, data.dates) != -1) { #" +
                                        "<div class='" +
                                           "# if (data.value < 10) { #" +
                                               "exhibition" +
                                           "# } else if ( data.value < 20 ) { #" +
                                               "party" +
                                           "# } else { #" +
                                               "cocktail" +
                                           "# } #" +
                                        "'></div>" +
                                     "# } #" +
                                     "#= data.value #"

                },
                footer = "Today - #=kendo.toString(data, 'd') #"
            });
        }
    }
}