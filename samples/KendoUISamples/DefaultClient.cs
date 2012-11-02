using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples
{
    [JsType(JsMode.Global)]
    public class DefaultClient
    {
        static void DefaultClient_Load()
        {
            new jQuery("aaa").kendoNumericTextBox().data("kendoNumericTextBox").As<NumericTextBox>().change += new JsAction<EmptyEventData>(DefaultClient_change);
        }

        static void DefaultClient_change(EmptyEventData arg)
        {
            throw new System.NotImplementedException();
        }
    }
}