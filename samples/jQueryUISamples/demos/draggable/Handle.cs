using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.jQuery;
using SharpKit.Html4;
using SharpKit.JavaScript;


namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class Handle
    {
        static Handle()
        {
            new jQuery(OnReady);
        }
        
        static void OnReady()
        {
            new jQuery("#draggable").draggable(new DraggableOptions { handle = "p" });
            new jQuery("#draggable2").draggable(new DraggableOptions { cancel = "p.ui-widget-header" });
            //TODO: undocumented core util method: $( "div, p" ).disableSelection();
            JsContext.JsCode("$( 'div, p' ).disableSelection();");
        }

    }
}