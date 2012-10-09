
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.tabstrip
{
    [JsType(JsMode.Global)]
    public class Animation
    {
        static Animation()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var original = new jQuery("#tabstrip").clone(true);
            original.find(".k-state-active").removeClass("k-state-active");
            JsFunc<JsString> getEffects = null;
            //TODO:         
            JsContext.JsCode("var getEffects = function () {return (($('#expand')[0].checked ? 'expand:vertical ' : '') + ($('#opacity')[0].checked ? 'fadeIn' : '')) || false;};");

            JsAction initTabStrip = () => new jQuery("#tabstrip").kendoTabStrip(new TabStripConfiguration
            {
                animation = new PanelBarAnimationConfiguration
                {
                    open = new PanelBarAnimationOpenConfiguration { effects = getEffects() }
                }
            })
                    .css(new Map { marginRight = "220px" });


            new jQuery(".configuration input").change(e =>
                {
                    jQuery tabStrip = new jQuery("#tabstrip"),

                        clone = original.clone(true);
                    JsNumber selectedIndex = tabStrip.data("kendoTabStrip").As<TabStrip>().select().As<JsNumber>();
                    clone.children("ul")
                         .children("li")
                         .eq(selectedIndex)
                         .addClass("k-state-active")
                         .end();

                    tabStrip.replaceWith(clone);

                    initTabStrip();
                });

            initTabStrip();

        }
    }
}