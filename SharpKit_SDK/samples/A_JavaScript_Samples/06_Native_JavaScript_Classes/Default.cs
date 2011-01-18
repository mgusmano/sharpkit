using SharpKit.JavaScript;
using SharpKit.Html4;

namespace SharpKitSamples
{
    [JsType(JsMode.Global, Filename = "Default.js")]
    class Native_JavaScript_Classes : HtmlContext
    {
        static Native_JavaScript_Classes()
        {
            var SharpKitSamples = new { };
            
        }

        static void btn_onclick()
        {
            int num1 = parseInt(document.getElementById("textbox1").As<HtmlInput>().value);
            JsNumber num2 = parseInt(document.getElementById("textbox2").As<HtmlInput>().value);


            if (isNaN(num1) || isNaN(num2))
            {
                alert("Please enter two valid numbers");
                return;
            }

            var biggerNum = JsMath.max(num1, num2);
            alert("The bigger number is " + biggerNum);
        }
    }
}


