using SharpKit.JavaScript;
using SharpKit.Html4;


[JsType(JsMode.Global, Filename = "Default.js")]
class InlineJSCodeSample : HtmlContext
{
    static InlineJSCodeSample()
    {
        var SharpKitSamples = new { };

    }

    [JsMethod(Code = "alert('This is native JS code!');return false;")]
    static JsBoolean btn_onclick()
    {
        //The following code is ignored because JsMethod.Code is defined
        //The actual function code will be copied from the JsMethod.Code property
        throw new System.NotImplementedException();
    }
}



