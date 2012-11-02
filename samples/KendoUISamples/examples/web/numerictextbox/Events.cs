using SharpKit.JavaScript;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;

namespace KendoUISamples.examples.web.numerictextbox
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

            new jQuery("#numerictextbox").kendoNumericTextBox(new NumericTextBoxConfiguration
            {
                change = onChange,
                spin = onSpin
            });
        }
        static void onChange(ChangeEventData e)
        {
            kendoConsole.log("Change :: " + JsContext.@this.As<NumericTextBox>().value());
        }

        static void onSpin()
        {
            kendoConsole.log("Spin :: " + JsContext.@this.As<NumericTextBox>().value());
        }

    }
}