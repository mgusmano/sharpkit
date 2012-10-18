
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;
namespace KendoUISamples.examples.web.panelbar
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
            var original = new jQuery("#panelbar").clone(true);
            original.find(".k-state-active").removeClass("k-state-active");

            new jQuery(".configuration input").change(e =>
                {
                    var panelBar = new jQuery("#panelbar").As<PanelBar>();
                    jQuery clone = original.clone(true);
                    panelBar.data("kendoPanelBar").collapse(new jQuery("#panelbar .k-link"));
                    panelBar.replaceWith(clone);
                    initPanelBar();
                });
            initPanelBar();

        }
        static JsString getEffects()
        {
            var expand = new jQuery("#expand")[0].As<HtmlInputRadio>().@checked;
            var opacity = new jQuery("#opacity")[0].As<HtmlInputCheckBox>().@checked;
            var s = "";
            if (expand)
                s += "expand:vertical ";
            if (opacity)
                s += "fadeIn";
            if (s == "")
                return false.As<JsString>();
            return s;
        }

        static void initPanelBar()
        {
            new jQuery("#panelbar").kendoPanelBar(new PanelBarConfiguration
            {
                animation = new PanelBarAnimationConfiguration
                    {
                        expand = new PanelBarAnimationExpandConfiguration
                            {
                                effects = getEffects()
                            }
                    }
            });

        }

    }
}