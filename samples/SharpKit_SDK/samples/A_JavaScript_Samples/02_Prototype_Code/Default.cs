using SharpKit.JavaScript;
using SharpKit.Html4;

//Writing Prototype syntax JavaScript code from C#:
//Annotate the class with JsType attribute, Mode=JsMode.Prototype
[JsType(JsMode.Prototype, Filename = "Default.js")]
class PrototypeCodeSample
{
    //Supported language constructs:

    //1. Constructor
    public PrototypeCodeSample()
    {
        InstanceProperty = "some default value";
    }

    //2. Instance members
    public JsString InstanceProperty { get; private set; }

    public void InstanceFunction(JsString value)
    {
        InstanceProperty = value;
    }

    //3. Static members
    public static JsString StaticProperty { get; private set; }

    public static void StaticFunction(JsString value)
    {
        StaticProperty = value;
    }
    
}

[JsType(JsMode.Global, Filename = "Default.js")]
class PrototypeCodeSample_Test : HtmlContext
{
    static void btn_onclick()
    {
        //Test static members
        PrototypeCodeSample.StaticFunction("some static value");
        alert("PrototypeCodeSample.StaticProperty: \"" + PrototypeCodeSample.StaticProperty +"\"");

        //Test instance members
        var obj = new PrototypeCodeSample();
        obj.InstanceFunction("some instance value");
        alert("obj.InstanceProperty: \"" + obj.InstanceProperty + "\"");
    }
}

