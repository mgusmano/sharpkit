using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
namespace jQueryUISamples.demos.spinner
{
    [JsType(JsMode.Global)]
    public class Decimal
    {
        static Decimal()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#spinner").spinner(new SpinnerOptions
            {
                step = 0.01,
                numberFormat = "n"
            });

            new jQuery("#culture").change(() =>
            {
                var current = new jQuery("#spinner").spinner("value");
                //TODO: Globalize.culture( new jQuery(JsContext.@this).val() );
                new jQuery("#spinner").spinner("value", current);
            });
        }
    }
}