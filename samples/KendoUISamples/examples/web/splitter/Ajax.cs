using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
namespace KendoUISamples.examples.web.splitter
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
            new jQuery("#splitter").kendoSplitter(new SplitterConfiguration
            {
                panes = new JsArray<SplitterPaneConfiguration> {
                     new SplitterPaneConfiguration { contentUrlString = "../../content/web/splitter/ajax/ajaxContent1.html"},
                     new SplitterPaneConfiguration { contentUrlString = "../../content/web/splitter/ajax/ajaxContent2.html"}
                 }
            });
        }
    }
}