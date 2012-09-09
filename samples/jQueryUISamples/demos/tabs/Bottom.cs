using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Bottom
    {
        static Bottom()
        {
            new jQuery(Onready);        
        }

        static void Onready()
        {
            new jQuery("#tabs").tabs();
            new jQuery( ".tabs-bottom .ui-tabs-nav, .tabs-bottom .ui-tabs-nav > *" )
                .removeClass("ui-corner-all ui-corner-top")
                .addClass("ui-corner-bottom");
        }
    }
}