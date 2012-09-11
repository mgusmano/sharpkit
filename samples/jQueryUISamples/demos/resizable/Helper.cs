using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.resizable
{
    [JsType(JsMode.Global)]
    public class Helper
    {
        static Helper()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#resizable").resizable(new ResizableOptions { helper = "ui-resizable-helper" });
        }
    }
}