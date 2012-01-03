using SharpKit.JavaScript;
using SharpKit.Html4;

namespace SharpKitGridSample
{
    [JsType(JsMode.Global, Filename = "Default.js")]
    class TypeCastingSample : HtmlContext
    {
        static TypeCastingSample()
        {
            var SharpKitSamples = new { };
        }

        static void btn_onclick()
        {
            var value = document.getElementById("textbox1").As<HtmlInput>().value;
            alert(value);
        }
    }
}


