using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class MinMax
    {
        static MinMax()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#datepicker").datepicker( new DatepickerOptions { minDate = -20, maxDate = "+1M +10D" });
        }
    }
}