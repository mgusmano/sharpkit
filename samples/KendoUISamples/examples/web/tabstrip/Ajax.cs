using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.tabstrip
{
    [JsType(JsMode.Global)]
    public class Ajax
    {
        static Ajax()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#tabstrip").kendoTabStrip(new TabStripConfiguration
            {
                animation = new PanelBarAnimationConfiguration { open = new PanelBarAnimationOpenConfiguration { effects = "fadeIn" } },
                contentUrls = new JsArray<JsString> {
                        "../../content/web/tabstrip/ajax/ajaxContent1.html",
                        "../../content/web/tabstrip/ajax/ajaxContent2.html",
                        "../../content/web/tabstrip/ajax/ajaxContent3.html"
                }
            });
        }
    }
}