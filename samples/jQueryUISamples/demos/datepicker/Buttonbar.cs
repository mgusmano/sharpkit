using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class Buttonbar
    {
        static Buttonbar()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#datepicker").datepicker(new DatepickerOptions { showButtonPanel = true });
        }
    }
}