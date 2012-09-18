using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button.datepicker
{
    [JsType(JsMode.Global)]
    public class DateRange
    {
        static DateRange()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#from").datepicker(new DatepickerOptions
            {
                defaultDate = "+1w",
                changeMonth = true,
                numberOfMonths = 3,
                onSelect = (selectedDate, inst) => new jQuery("#to").datepicker("option", "minDate", selectedDate)
            });
            new jQuery("#to").datepicker(new DatepickerOptions
            {
                defaultDate = "+1w",
                changeMonth = true,
                numberOfMonths = 3,
                onSelect = (selectedDate, inst) => new jQuery("#from").datepicker("option", "maxDate", selectedDate)
            });
        }
    }
}