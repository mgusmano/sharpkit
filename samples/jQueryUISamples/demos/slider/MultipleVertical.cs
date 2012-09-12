using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.slider
{
    [JsType(JsMode.Global)]
    public class MultipleVertical
    {
        static MultipleVertical()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            // setup master volume
            new jQuery("#master").slider(new SliderOptions
            {
                value = 60,
                orientation = "horizontal",
                range = "min",
                animate = true
            });

            // setup graphic EQ
            new jQuery("#eq > span").each((number, e) =>
                {
                    // read initial values from markup and remove that
                    var value = HtmlContext.parseInt(new jQuery(JsContext.@this).text(), 10);
                    new jQuery(JsContext.@this).empty().slider(new SliderOptions
                    {
                        value = value,
                        range = "min",
                        animate = true,
                        orientation = "vertical"
                    });
                });
        }
    }
}