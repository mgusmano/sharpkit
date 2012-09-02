using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#draggable").draggable();
        }
    }
}