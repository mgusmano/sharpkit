using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.slider
{
    [JsType(JsMode.Global)]
    public class Hotelrooms
    {
        static Hotelrooms()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var select = new jQuery("#minbeds");
            var slider = new jQuery("<div id='slider'></div>").insertAfter(select).slider(new SliderOptions
            {
                min = 1,
                max = 6,
                range = "min",

                value = select[0].As<HtmlSelect>().selectedIndex + 1,
                slide = (e, ui) => select[0].As<HtmlSelect>().selectedIndex = ui.value - 1
            });
            new jQuery("#minbeds").change(e => slider.slider("value", e.currentTarget.As<HtmlSelect>().selectedIndex + 1));
        }
    }
}