using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.datepicker
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
                new JsDate(today.getFullYear(), today.getMonth(), 11).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 6).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() + 1, 27).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 1, 3).valueOf(),
                new JsDate(today.getFullYear(), today.getMonth() - 2, 22).valueOf()
 
            };
                    new jQuery("#datepicker").kendoDatePicker(new DatePickerConfiguration {
                        value = today,
                        month=  new MonthConfiguration {
                            // template for dates in month view
                            content = "# if ($.inArray(+data.date, [" + birthdays + "]) != -1) { #" +
                                         "<div class='birthday'></div>" +
                                     "# } #" +
                                     "#= data.value #"
                        },
                        footer = "Today - #=kendo.toString(data, 'd') #"
                    });

                    new jQuery("#datepicker").data("kendoDatePicker").As<DatePicker>();
                                    //TODO: .dateView.calendar.element
                                    //.width(300);
                

        }
    }
}