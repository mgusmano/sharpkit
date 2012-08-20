using SharpKit.JavaScript;
using SharpKit.Html4;

[JsType(JsMode.Global, Filename = "Default.js")]
class NamespaceSample_Global : HtmlContext
{
    static NamespaceSample_Global()
    {
        //Declare the namespace objects
        var NamespaceSample = new { Namespace1 = new { }, Namespace2 = new { } };
    }

    static void btn_onclick()
    {
        var c1 = new NamespaceSample.Namespace1.SomeClass();
        alert("new NamespaceSample.Namespace1.SomeClass() returned:" + c1);

        var c2 = new NamespaceSample.Namespace2.SomeClass();
        alert("new NamespaceSample.Namespace2.SomeClass() returned:" + c2);
    }
}

namespace NamespaceSample.Namespace1
{
    [JsType(JsMode.Prototype, Filename = "Default.js")]
    public class SomeClass
    {
        public JsString Prop1 { get; set; }
    }
}

namespace NamespaceSample.Namespace2
{
    [JsType(JsMode.Prototype, Filename = "Default.js")]
    public class SomeClass
    {
    }
}


