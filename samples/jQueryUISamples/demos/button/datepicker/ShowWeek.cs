using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class ShowWeek
    {
        static ShowWeek()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#datepicker").datepicker(new DatepickerOptions
            {
                showWeek = true,
                firstDay = 1
            });
        }
    }
}