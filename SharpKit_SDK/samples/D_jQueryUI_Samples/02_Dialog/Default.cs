using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUIDialogSample : jQueryContext
{

    static void jQueryUIDialogSample_Load()
    {
        J("#dialog").dialog();
    }

}

