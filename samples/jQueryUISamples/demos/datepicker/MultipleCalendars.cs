using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class MultipleCalendars
    {
        static MultipleCalendars()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#datepicker").datepicker(new DatepickerOptions { numberOfMonths = 3, showButtonPanel = true });
        }
    }
}