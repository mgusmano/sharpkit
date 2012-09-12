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
            new jQuery( "div, p" ).disableSelection();
        }
    }
}