using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.animate
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#button").toggle(
                e => new jQuery("#effect").animate(new AnimationPropertiesExtensions
                {
                    backgroundColorString = "#aa0000",
                    colorString = "#fff",
                    width = 500
                }, 1000),
                e => new jQuery("#effect").animate(new AnimationPropertiesExtensions
                {
                    backgroundColorString = "#fff",
                    colorString = "#000",
                    width = 240
                }, 1000));
        }
    }
}