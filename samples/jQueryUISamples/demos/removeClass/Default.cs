using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.removeClass
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
        }
        static void OnReady()
        {
            new jQuery("#button").click(e =>
            {
                //TODO
                new jQuery("#effect").removeClass();//"newClass", 1000, callback);
                JsContext.@return(false);
            });
        }
    //        $(function() {
    //    $( "#button" ).click(function() {
    //        $( "#effect" ).removeClass( "newClass", 1000, callback );
    //        return false;
    //    });

    //    function callback() {
    //        setTimeout(function() {
    //            $( "#effect" ).addClass( "newClass" );
    //        }, 1500 );
    //    }
    //});
        static void  callback()
        {
            HtmlContext.window.setTimeout(() =>
            {
                new jQuery("#effect").addClass("newClass");

            }, 1500);
         
            
        }
    }
}