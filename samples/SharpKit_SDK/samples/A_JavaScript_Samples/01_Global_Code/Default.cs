using SharpKit.JavaScript;
using SharpKit.Html4;

//Writing Global JavaScript code from C#:
//Annotate the class with JsType attribute, Mode=JsMode.Global
//Inherit from HtmlContext to gain access to global Html/JS members such as window and alert()
[JsType(JsMode.Global, Filename = "Default.js")]
class GlobalCodeSample : HtmlContext
{
    //Static fields are converted to global fields
    static JsString message = "showMessage() global function was invoked!";

    //Static method are converted to global functions
    static void showMessage()
    {
        alert(message);
    }

    //Static constructors are converted to global code (without a function)
    static GlobalCodeSample()
    {
        showMessage();
    }
}

