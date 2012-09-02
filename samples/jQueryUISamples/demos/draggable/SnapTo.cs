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
    public class SnapTo
    {
        static SnapTo()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable(new DraggableOptions { snap = true });
            new jQuery("#draggable2").draggable(new DraggableOptions { snap = ".ui-widget-header" });
            new jQuery("#draggable3").draggable(new DraggableOptions { snap = ".ui-widget-header", snapMode = "outer" });
            new jQuery("#draggable4").draggable(new DraggableOptions { grid = new int[2] { 20, 20 } });
            new jQuery("#draggable5").draggable(new DraggableOptions { grid = new int[2] { 80, 80 } });
        }
    }
}