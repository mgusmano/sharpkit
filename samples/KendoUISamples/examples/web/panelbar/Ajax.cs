using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.panelbar
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
            new jQuery("#panelbar").kendoPanelBar(new PanelBarConfiguration
            {
                expandMode = "single",
                contentUrls = new JsArray<JsString> {
                        "../../content/web/panelbar/ajax/ajaxContent1.html",
                        "../../content/web/panelbar/ajax/ajaxContent2.html",
                        "../../content/web/panelbar/ajax/ajaxContent3.html",
                        "../../content/web/panelbar/ajax/ajaxContent4.html"
                   }
            });
                

        }
    }
}