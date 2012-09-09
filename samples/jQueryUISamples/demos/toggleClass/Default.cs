using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.toggleClass
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#button").click(e =>
                {
                    //TODO: $("#effect").toggleClass("newClass", 1000);
                    new jQuery("#effect").toggleClass("newClass");
                    JsContext.@return(false);
                });
        }
        //$(function () {
        //    $("#button").click(function () {
        //        $("#effect").toggleClass("newClass", 1000);
        //        return false;
        //    });
        //});    
    }
}