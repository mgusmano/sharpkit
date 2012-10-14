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
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            // set effect from select menu value
            new jQuery("#button").click(e =>
            {
                runEffect();
                JsContext.@return(false);
            });
        }

        // run the currently selected effect
        static void runEffect()
        {
            // get effect type from 
            var selectedEffect = new jQuery("#effectTypes").val().As<EffectType>();
            var options = new JsObject { };
            if (selectedEffect.ExactEquals("scale"))
            {
                options = new { percent = 0 }.As<JsObject>();
            }
            else if (selectedEffect.ExactEquals("transfer"))
            {
                options = new { to = "#button", className = "ui-effects-transfer" }.As<JsObject>();
            }
            else if (selectedEffect.ExactEquals("size"))
            {
                options = new { to = new Size { width = 200, height = 60 } }.As<JsObject>();
            }
            // run the effect
            new jQuery("#effect").effect(selectedEffect, options, 500, callback);
        }

        static void callback(Event ev, object ui)
        {
            HtmlContext.window.setTimeout(() =>
                {
                    new jQuery("#effect").removeAttr("style").hide().fadeIn();
                }, 1000);
        }
    }
}