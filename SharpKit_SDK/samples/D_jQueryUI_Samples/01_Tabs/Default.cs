using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.jQuery.UI;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUITabsSample : jQueryContext
{

    static void jQueryUITabsSample_Load()
    {
        J("#tabs").tabs();
    }

}

