using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.datetimepicker
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
            new jQuery("#datetimepicker").kendoDateTimePicker()
                          .closest(".k-widget")
                          .attr("id", "datetimepicker_wrapper");
            
            var datetimepicker = new jQuery("#datetimepicker").data("kendoDateTimePicker").As<DateTimePicker>();
            
            JsAction setValue = () => datetimepicker.value(new jQuery("#value").val().As<JsString>());
            
            new jQuery("#enable").click(() => datetimepicker.enable());
            new jQuery("#disable").click(() => datetimepicker.enable(false));
            new jQuery("#openDateView").click(() => datetimepicker.open("date"));
            new jQuery("#openTimeView").click(() => datetimepicker.open("time"));
            new jQuery("#closeDateView").click(() => datetimepicker.close("date"));
            new jQuery("#closeTimeView").click(() => datetimepicker.close("time"));
            new jQuery("#value").kendoDateTimePicker(new DateTimePickerConfiguration
            {
                change = setValue
            });

            new jQuery("#set").click(setValue);
            new jQuery("#get").click(() => HtmlContext.window.alert(datetimepicker.value()));
        }
    }
}