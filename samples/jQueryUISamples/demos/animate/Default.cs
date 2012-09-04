using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.animate
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
        }

        static void OnReady()
        {
           //new jQuery( "#button" ).toggle(
           //    e =>  new jQuery( "#effect" ).animate(new AnimationPropertiesExtensions { 
           //    backgroundColorString = "#aa0000",
           //    colorString = "#fff", 
           //    width = 500}, 1000),
           //    () => new jQuery( "#effect" ).animate(new AnimationPropertiesExtensions { 
           //        backgroundColorString ="#fff",
           //        colorString = "#000",
           //        width= 240}, 1000)});
    //        $(function() {
    //    $( "#button" ).toggle(
    //        function() {
    //            $( "#effect" ).animate({
    //                backgroundColor: "#aa0000",
    //                color: "#fff",
    //                width: 500
    //            }, 1000 );
    //        },
    //        function() {
    //            $( "#effect" ).animate({
    //                backgroundColor: "#fff",
    //                color: "#000",
    //                width: 240
    //            }, 1000 );
    //        }
    //    );
    //});
        }
    }
}