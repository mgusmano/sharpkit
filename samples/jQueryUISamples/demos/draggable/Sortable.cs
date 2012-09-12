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
    public class Sortable
    {
        static Sortable()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#sortable").sortable(new SortableOptions { revert = true });
            new jQuery("#draggable").draggable(new DraggableOptions { connectToSortable = "#sortable", helper = "clone", revert = "invalid" });
            new jQuery("ul, li").disableSelection();
        }
    }
}