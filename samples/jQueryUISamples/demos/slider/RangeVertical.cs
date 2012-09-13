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
            //new jQuery("#slider-range").slider(new SliderOptions
            //{
            //    orientation = "vertical",
            //    range = true,
            //    values = { 17, 67 },
            //    // TODO:   slide = (e, ui) => new jquery( "#amount" ).val( "$" + ui.values[0] + " - $" + ui.values[1]);
            //});
           // new jQuery("#amount").val("$" + new jQuery("#slider-range").slider("values", 0) + " - $" + new jQuery( "#slider-range" ).slider( "values", 1 ));
   
        }
    }
}