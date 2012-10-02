using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.calendar
{
    [JsType(JsMode.Global)]
    public class Api
    {
        static Api()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            new jQuery("#calendar").kendoCalendar();
            var calendar = new jQuery("#calendar").data("kendoCalendar").As<Calendar>();
            calendar.value(new JsDate());
            JsAction navigate = () =>
            {
                var value = new jQuery("#direction").val().As<JsString>();
                switch (value)
                {
                    case "up":
                        calendar.navigateUp();
                        break;
                    case "down":
                        calendar.navigateDown(calendar.value());
                        break;
                    case "past":
                        calendar.navigateToPast();
                        break;
                    default:
                        calendar.navigateToFuture();
                        break;
                };
            };
            JsAction setValue = () => calendar.value(new jQuery("#value").val().As<JsString>());
            new jQuery("#get").click(() =>
                           HtmlContext.window.alert(calendar.value()));

            new jQuery("#value").kendoDatePicker(new DatePickerConfiguration
            {
                change = setValue
            });
            new jQuery("#set").click(setValue);
            new jQuery("#direction").kendoDropDownList(new DropDownListConfiguration
            {
                change = navigate
            });
            new jQuery("#navigate").click(navigate);
        }
    }
}