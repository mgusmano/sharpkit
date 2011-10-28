using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUIDialogSample : jQueryContext
{

    static void jQueryUIDialogSample_Load()
    {
        J("#dialog").dialog();
    }

}

