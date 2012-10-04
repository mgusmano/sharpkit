using SharpKit.JavaScript;
using SharpKit.jQuery;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.datetimepicker
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
            new jQuery("#datetimepicker").kendoDateTimePicker(new DateTimePickerConfiguration
            {
                change = onChange,
                close = onClose,
                open = onOpen
            });
        }
        static void onOpen(Event e)
        {
            kendoConsole.log("Open: " + e.view + " view");
        }

        static void onClose(Event e)
        {
            kendoConsole.log("Close: " + e.view + " view");
        }

        static void onChange()
        {
            kendoConsole.log("Change :: " + Kendo.toString(JsContext.@this.As<DateTimePicker>().value().As<JsNumber>(), "g"));
        }
    }
}