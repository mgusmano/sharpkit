using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;


namespace jQueryUISamples.demos.accordion
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery( "#accordion" ).accordion();
        }
    }
}