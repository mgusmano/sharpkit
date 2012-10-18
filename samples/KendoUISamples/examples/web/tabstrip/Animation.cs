using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

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

        static JsString getEffects()
        {
            var expand = new jQuery("#expand")[0].As<HtmlInputRadio>().@checked;
            var opacity = new jQuery("#opacity")[0].As<HtmlInputRadio>().@checked;
            var s = "";
            if (expand)
                s += "expand:vertical ";
            if (opacity)
                s += "fadeIn";
            if (s == "")
                return false.As<JsString>();
            return s;

        }
        static void initTabStrip()
        {
            new jQuery("#tabstrip").kendoTabStrip(new TabStripConfiguration
            {

                animation = new PanelBarAnimationConfiguration
                {
                    open = new PanelBarAnimationOpenConfiguration { effects = getEffects() }
                }
            })
                   .css(new Map { marginRight = "220px" });
        }
    }
}