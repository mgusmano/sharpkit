using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.datepicker
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
            new jQuery("#datepicker").kendoDatePicker()
                .closest(".k-widget")
                .attr("id", "datepicker_wrapper");

            var datepicker = new jQuery("#datepicker").data("kendoDatePicker").As<DatePicker>();
            JsAction setValue = () => datepicker.value(new jQuery("#value").val().As<JsString>());
            new jQuery("#enable").click(() => datepicker.enable());
            new jQuery("#disable").click(() => datepicker.enable(false));
            new jQuery("#open").click(() => datepicker.open());
            new jQuery("#close").click(() => datepicker.close());
            new jQuery("#value").kendoDatePicker(new DatePickerConfiguration
            {
                change = setValue
            });
            new jQuery("#set").click(setValue);
            new jQuery("#get").click(() =>
                HtmlContext.window.alert(datepicker.value()));
        }
    }
}