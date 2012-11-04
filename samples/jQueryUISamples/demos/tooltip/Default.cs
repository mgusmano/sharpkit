using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html;
namespace jQueryUISamples.demos.tooltip
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
            new jQuery(HtmlContext.document).tooltip();
        }
    }
}