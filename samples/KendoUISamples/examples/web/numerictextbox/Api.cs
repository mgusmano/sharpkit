using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.numerictextbox
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

            new jQuery("#numerictextbox").kendoNumericTextBox();

            var numerictextbox = new jQuery("#numerictextbox").data("kendoNumericTextBox").As<NumericTextBox>();

            JsAction setValue = () => numerictextbox.value(new jQuery("#value").val().As<JsString>());
            new jQuery("#enable").click(() => numerictextbox.enable());
            new jQuery("#disable").click(() => numerictextbox.enable(false));
            new jQuery("#value").kendoNumericTextBox(new NumericTextBoxConfiguration
            {
                change = e=>setValue()
            });
            new jQuery("#set").click(setValue);
            new jQuery("#get").click(() => HtmlContext.window.alert(numerictextbox.value()));
        }
    }
}