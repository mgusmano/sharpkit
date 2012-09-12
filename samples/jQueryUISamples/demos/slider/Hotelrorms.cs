using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.slider
{
    [JsType(JsMode.Global)]
    public class Hotelrorms
    {
        static Hotelrorms()
        {
        }

        static void OnReady()
        {
            var select = new jQuery("#minbeds");
            //var slider = new jQuery("<div id='slider'></div>").insertAfter(select).slider(new SliderOptions
            //{
            //    min = 1,
            //    max = 6,
            //    range = "min",
            //     //TODO: 
            //     //value = select[0].
            //    //slide = (e, ui) =>
            //});
            // TODO:  slider.slider( "value", this.selectedIndex + 1 );
           // new jQuery("#minbeds").change(e => slider.slider("value", e.currentTarget));
 
    //            $(function() {
    //    var select = $( "#minbeds" );
    //    var slider = $( "<div id='slider'></div>" ).insertAfter( select ).slider({
    //        min: 1,
    //        max: 6,
    //        range: "min",
    //        value: select[ 0 ].selectedIndex + 1,
    //        slide: function( event, ui ) {
    //            select[ 0 ].selectedIndex = ui.value - 1;
    //        }
    //    });
    //    $( "#minbeds" ).change(function() {
    //        slider.slider( "value", this.selectedIndex + 1 );
    //    });
    //});

        }
    }
}