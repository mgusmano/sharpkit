using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class IconTrigger
    {
        static IconTrigger()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery(() => new jQuery("#datepicker").datepicker(new DatepickerOptions { 
                showOn = "button", 
                buttonImage = "images/calendar.gif",
                buttonImageOnly = true}));
        }
    }
}