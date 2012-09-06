using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.dialog
{
    [JsType(JsMode.Global)]
    public class Modal
    {
        static Modal()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            // a workaround for a flaw in the demo system (http://dev.jqueryui.com/ticket/4375), ignore!
            new jQuery("#dialog:ui-dialog").dialog("destroy");
            new jQuery("#dialog-modal").dialog( new DialogOptions { height = 140, modal= true });
        }
    }
}