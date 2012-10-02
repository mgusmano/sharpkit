using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.timepicker
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
            new jQuery("#timepicker").kendoTimePicker()
                .closest(".k-widget")
                .attr("id", "timepicker_wrapper");
            var timepicker = new jQuery("#timepicker").data("kendoTimePicker").As<TimePicker>();
            JsAction setValue = () => timepicker.value(new jQuery("#value").val().As<JsString>());

            new jQuery("#enable").click(() => timepicker.enable());
            new jQuery("#disable").click(() => timepicker.enable(false));
            new jQuery("#open").click(() => timepicker.open());
            new jQuery("#close").click(() => timepicker.close());
            new jQuery("#value").kendoTimePicker(new TimePickerConfiguration
            {
                change = setValue

            });

            new jQuery("#set").click(setValue);

            new jQuery("#get").click(() => HtmlContext.window.alert(timepicker.value()));
        }
    }
}