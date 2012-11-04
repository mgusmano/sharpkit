using SharpKit.JavaScript;
using SharpKit.jQuery;
namespace jQueryUISamples.demos.tooltip
{
    [JsType(JsMode.Global)]
    public class Forms
    {
        static Forms()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var tooltips = new jQuery("[title]").tooltip();
            new jQuery("<button>")
                .text("Show help")
                .button()
                .click(() => tooltips.tooltip("open"))
                .insertAfter("form");
        }
    }
}