using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.addClass
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
        }

        static void OnReady()
        {
            new jQuery("#button").click(x =>
            {
                //TODO: $( "#effect" ).addClass( "newClass", 1000, callback );
                //new jQuery("#effect").addClass("newClas", 1000, callback);
            });

        }
        static void callback()
        {
            HtmlContext.window.setTimeout(() => new jQuery("#effect").removeClass("newClass"), 1500);
        }
    }
    //        $(function() {
    //    $( "#button" ).click(function() {
    //        $( "#effect" ).addClass( "newClass", 1000, callback );
    //        return false;
    //    });


    //    function callback() {
    //        setTimeout(function() {
    //            $( "#effect" ).removeClass( "newClass" );
    //        }, 1500 );
    //    }
    //});
   
}