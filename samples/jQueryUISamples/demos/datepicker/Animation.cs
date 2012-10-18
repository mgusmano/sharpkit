using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class Animation
    {
        static Animation()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#datepicker").datepicker();
            new jQuery("#anim").change(e => new jQuery("#datepicker").datepicker("option", "showAnim", new jQuery(e.currentTarget).val()));
        }
    }
}