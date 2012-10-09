using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.slider
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
             var slider = new jQuery("#slider").kendoSlider(new SliderConfiguration {
                increaseButtonTitle = "Right",
                decreaseButtonTitle = "Left",
                min = -10,
                max = 10,
                smallStep = 2,
                largeStep = 1
            }).data("kendoSlider");

            new jQuery(".eqSlider").kendoSlider(new SliderConfiguration {
                orientation = OrientationOptions.vertical,
                min = -20,
                max = 20,
                smallStep = 1,
                largeStep = 20,
                showButtons = false
            });
        }
    }
}