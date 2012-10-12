using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Ajax
    {
        static Ajax()
        {
        }

        static void OnReady()
        {
            //// TODO:
            new jQuery("#tabs").tabs(new TabsOptions
            {
                //ajaxOptions = new AjaxSetting
                // {
                //     error = (xhr, status, index, anchor) =>
                //         new jQuery(anchor.hash).html("Couldn't load this tab. We'll try to fix this as soon as possible. " +
                //         "If this wouldn't be a demo.")
                // }
            });
               
                

    //        $(function() {
    //    $( "#tabs" ).tabs({
    //        ajaxOptions: {
    //            error: function( xhr, status, index, anchor ) {
    //                $( anchor.hash ).html(
                        //"Couldn't load this tab. We'll try to fix this as soon as possible. " +
                        //"If this wouldn't be a demo." );
    //            }
    //        }
    //    });
    //});
        }
    }
}