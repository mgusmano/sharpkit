using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
{
    [JsType(JsMode.Global)]
    public class FillSpace
    {
        static FillSpace()
        {
        }

        static void OnReady()
        {

            new jQuery("#accordion").accordion(new AccordionOptions { fillSpace = true });
           // new jQuery("#accordionResizer").resizable(new ResizableOptions { minHeight = 140, resize = (e, ui) => (new jQuery( "#accordion" ).accordion( "resize" ))};
                //        $(function() {
    //    $( "#accordion" ).accordion({
    //        fillSpace: true
    //    });
    //});
    //$(function() {
    //    $( "#accordionResizer" ).resizable({
    //        minHeight: 140,
    //        resize: function() {
    //            $( "#accordion" ).accordion( "resize" );
    //        }
    //    });
    //});
        }
    }
}