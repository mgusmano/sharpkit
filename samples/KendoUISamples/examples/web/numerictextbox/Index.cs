using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.numerictextbox
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            // create NumericTextBox from input HTML element
            new jQuery("#numeric").kendoNumericTextBox();

            // create Curerncy NumericTextBox from input HTML element
            new jQuery("#currency").kendoNumericTextBox(new NumericTextBoxConfiguration
            {
                format = "c",
                decimals = 3
            });

            // create Percentage NumericTextBox from input HTML element
            new jQuery("#percentage").kendoNumericTextBox(new NumericTextBoxConfiguration
            {
                format = "p0",
                min = 0,
                max = 0.1,
                step = 0.01
            });

            // create NumericTextBox from input HTML element using custom format
            new jQuery("#custom").kendoNumericTextBox(new NumericTextBoxConfiguration
            {
                format = "#.00 kg"
            });
        }
    }
}