using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;


[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryEventsSample : jQueryContextBase
{
    static void jQueryEventsSample_Load()
    {
        J("#button1").click(e =>
        {
            J(@this).text("I have been clicked!");
        });
        alert("Button click was bound");
    }
}

