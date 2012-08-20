using SharpKit.JavaScript;
using SharpKit.Html4;

//Writing Json syntax JavaScript code from C#:
//Annotate the class with JsType attribute, Mode=JsMode.Json
[JsType(JsMode.Prototype, Filename = "Default.js")]
[JsEnum(ValuesAsNames = true)]
enum MyStringEnum
{
    ValueA,
    ValueB
}

[JsType(JsMode.Prototype, Filename = "Default.js")]
[JsEnum(ValuesAsNames = false)]
enum MyIntEnum
{
    ValueA,
    ValueB
}

[JsType(JsMode.Global, Filename = "Default.js")]
class EnumSample_Test : HtmlContext
{
    static void btn_onclick()
    {
        alert("MyStringEnum.ValueA:" +  MyStringEnum.ValueA + " MyIntEnum.ValueA:" + MyIntEnum.ValueA);
    }
}

