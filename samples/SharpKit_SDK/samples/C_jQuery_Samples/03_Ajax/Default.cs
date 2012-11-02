using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;

[JsType(JsMode.Global, Filename = "Default.js")]
class jQueryAjaxSample : jQueryContext
{
    static void btn_onclick()
    {
        JsString prmValue = J("#textbox1").val().As<JsString>();

        jQuery.getJSON("MyHandler.ashx", new { prm = prmValue }, (data, status, req) => 
        { 
            alert("Server returned: "+ data.As<MyResult>().NewValue); 
        });
    }

}

