using SharpKit.JavaScript;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;
namespace KendoUISamples.examples.web.slider
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
            new jQuery("#slider").kendoSlider(new SliderConfiguration
            {
                change = sliderOnChange,
                slide = sliderOnSlide,
                min = 0,
                max = 30,
                smallStep = 1,
                largeStep = 10,
                value = 18
            });

            new jQuery("#rangeslider").kendoRangeSlider(new RangeSliderConfiguration
            {
                change = rangeSliderOnChange,
                slide = rangeSliderOnSlide,
                min = 0,
                max = 10,
                smallStep = 1,
                largeStep = 2,
                tickPlacement = RangeSliderTickPlacementOptions.both
            });
        }
        static void sliderOnSlide(SliderConfiguration e)
        {
            kendoConsole.log("Slide :: new slide value is: " + e.value);
        }

        static void sliderOnChange(SliderConfiguration e)
        {
            kendoConsole.log("Change :: new value is: " + e.value);
        }

        static void rangeSliderOnSlide(RangeSliderEventData e)
        {
            kendoConsole.log("Slide :: new slide value is: " + e.value.toString().replace(",", " - "));
        }

        static void rangeSliderOnChange(RangeSliderEventData e)
        {
            kendoConsole.log("Change :: new value is: " + e.value.toString().replace(",", " - "));
        }
    }
}