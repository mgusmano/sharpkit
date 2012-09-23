using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class FromTable
    {
        static FromTable()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            // TODO: property height??
            JsContext.JsCode(" new jQuery('#grid').kendoGrid{ height: 250 });");
        }
          //$(document).ready(function() {
          //          $("#grid").kendoGrid({
          //              height: 250
          //          });
          //      });
    }
}