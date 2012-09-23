using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.slider
{
    [JsType(JsMode.Global)]
    public class RangeVertical
    {
        static RangeVertical()
        {
            new jQuery(OnReady);
        }
        
        static void OnReady()
        {
            new jQuery("#slider-range").slider(new SliderOptions
            {
                orientation = "vertical",
                range = true,
                values = new[] { 17, 67 },
                // TODO: ui.values[0], ui.values[1]
                slide = (e, ui) => new jQuery("#amount").val("$" + ui.value + " - $" + ui.value),
            });
            
            new jQuery("#amount").val("$" + new jQuery("#slider-range").slider("values", 0) + " - $" + new jQuery("#slider-range").slider("values", 1));
   
        }
    }
}