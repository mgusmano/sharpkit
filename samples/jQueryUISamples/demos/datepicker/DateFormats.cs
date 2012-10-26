using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class DateFormats
    {
        static DateFormats()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#datepicker").datepicker();
            new jQuery("#format").change(
                e => new jQuery("#datepicker").datepicker("option", "dateFormat", new jQuery(e.currentTarget).val()));
        }
    }
}