using SharpKit.JavaScript;
using SharpKit.Html4;

//Writing Json syntax JavaScript code from C#:
//Annotate the class with JsType attribute, Mode=JsMode.Json
[JsType(JsMode.Json)]
class JsonSample
{
    //Use fields or automatic properties to define fields
    public JsString Prop2;
    public JsString Prop1 { get; set; }
}

[JsType(JsMode.Global, Filename = "Default.js")]
class JsonSample_Test : HtmlContext
{
    static void btn_onclick()
    {
        var jso = new JsonSample { Prop1 = "111", Prop2 = "222"};
        alert("New Json was created: {Prop1:\"" + jso.Prop1 + "\", Prop2:\"" + jso.Prop2 + "\"}");
    }
}

