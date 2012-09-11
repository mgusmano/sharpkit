using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.selectable
{
    [JsType(JsMode.Global)]
    public class DisplayGrid
    {
        static DisplayGrid()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#selectable").selectable();
        }
    }
}