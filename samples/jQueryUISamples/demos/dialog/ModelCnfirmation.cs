using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.dialog
{
    [JsType(JsMode.Global)]
    public class ModelCnfirmation
    {
        static ModelCnfirmation()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            // a workaround for a flaw in the demo system (http://dev.jqueryui.com/ticket/4375), ignore!
            new jQuery("#dialog:ui-dialog").dialog("destroy");
            //new jQuery("#dialog-confirm").dialog(new DialogOptions
            //{
            //    resizable = false,
            //    height = 140,
            //    modal = true,
            //    buttons = 
            //    {
            //        new DialogButton{text = "delete all items", click = () => new jQuery(JsContext.@this).dialog("close") },
            //        new DialogButton { text = "cancal", click = () => new jQuery(JsContext.@this).dialog("close") }
            //    }
            //});

        }
    }
}