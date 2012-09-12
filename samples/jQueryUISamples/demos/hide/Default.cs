using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.hide
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
        }
        static void OnReady()
        {

        }
        // TODO
        // run the currently selected effect
        static void runEffect()
        {
            // get effect type from 
            var selectedEffect = new jQuery("#effectTypes").val();
            // most effect types need no options passed by default
            //var options =  { };
            if (selectedEffect.ExactEquals("scale"))
            {
                //  options = {
            }
            else
            {

            }
            //$( "#effect" ).hide( selectedEffect, options, 1000, callback );
            //new jQuery( "#effect" ).hide(

        }

        static void callback()
        {
        }
        // most effect types need no options passed by default

        //    $(function() {
        //    // run the currently selected effect
        //    function runEffect() {
        //        // get effect type from 
        //        var selectedEffect = $( "#effectTypes" ).val();

        //        // most effect types need no options passed by default
        //        var options = {};
        //        // some effects have required parameters
        //        if ( selectedEffect === "scale" ) {
        //            options = { percent: 0 };
        //        } else if ( selectedEffect === "size" ) {
        //            options = { to: { width: 200, height: 60 } };
        //        }

        //        // run the effect
        //        $( "#effect" ).hide( selectedEffect, options, 1000, callback );
        //    };

        //    // callback function to bring a hidden box back
        //    function callback() {
        //        setTimeout(function() {
        //            $( "#effect" ).removeAttr( "style" ).hide().fadeIn();
        //        }, 1000 );
        //    };

        //    // set effect from select menu value
        //    $( "#button" ).click(function() {
        //        runEffect();
        //        return false;
        //    });
        //});



    }
}