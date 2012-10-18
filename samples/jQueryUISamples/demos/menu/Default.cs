using SharpKit.JavaScript;
using SharpKit.jQuery;
namespace jQueryUISamples.demos.menu
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
            new jQuery("#menu").menu();
        }
    }
}