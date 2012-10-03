using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.datepicker
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#datepicker").kendoDatePicker(new DatePickerConfiguration
                        {
                            change = onChange,
                            close = onClose,
                            open = onOpen
                        });
        }
        
        static void onOpen()
        {
            kendoConsole.log("Open");
        }

        static void onClose()
        {
            kendoConsole.log("Close");
        }

        static void onChange()
        {
            kendoConsole.log("Change :: " + Kendo.toString(JsContext.@this.As<DatePicker>().value().As<JsNumber>(), "d"));
        }
    }
}