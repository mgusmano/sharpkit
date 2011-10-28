using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryUITabsSample : jQueryContext
{

    static void jQueryUITabsSample_Load()
    {
        J("#tabs").tabs();
    }

}

