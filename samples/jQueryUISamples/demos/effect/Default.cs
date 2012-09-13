using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.effect
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
         
        static void runEffect()
        {
            // run the currently selected effect
            var selectedEffect = new jQuery("#effectTypes").val();
            var options = new AnimationPropertiesEx { };
            if (selectedEffect.ExactEquals("scale"))
            {
                     //options = {   };
                //}
                //        $( "#effect" ).effect( selectedEffect, options, 500, callback );

          //      new jQuery("#effect").effect(selectedEffect, options, 500, callback);
            }
        }

        static void callback()
        {
            HtmlContext.window.setTimeout(() =>
                {
                    new jQuery("#effect").removeAttr("style").hide().fadeIn();
                }, 1000);
            }
            //        setTimeout(function() {
            //            $( "#effect" ).removeAttr( "style" ).hide().fadeIn();
            //        }, 1000 );
            //    };
        //}
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
        //        } else if ( selectedEffect === "transfer" ) {
        //            options = { to: "#button", className: "ui-effects-transfer" };
        //        } else if ( selectedEffect === "size" ) {
        //            options = { to: { width: 200, height: 60 } };
        //        }

        //        // run the effect
        //        $( "#effect" ).effect( selectedEffect, options, 500, callback );
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