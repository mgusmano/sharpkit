
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI;
namespace KendoUISamples.examples.web.calendar
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
            new jQuery("#calendar").kendoCalendar(new CalendarConfiguration
            {
                change = onChange,
                navigate = onNavigate
            });
        }
        static void onChange()
        {
            kendoConsole.log("Change :: " + Kendo.toString(JsContext.@this.As<Calendar>().value().As<JsNumber>(), "d"));
        }

        static void onNavigate()
        {
            kendoConsole.log("Navigate");
        }
    }
}