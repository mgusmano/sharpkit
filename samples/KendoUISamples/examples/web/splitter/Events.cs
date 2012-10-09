using SharpKit.JavaScript;
using KendoUISamples.examples.content.shared.js;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;
namespace KendoUISamples.examples.web.splitter
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#splitter").kendoSplitter(new SplitterConfiguration
            {
                orientation = OrientationOptions.vertical,
                panes = new JsArray<SplitterPaneConfiguration> {
                        new SplitterPaneConfiguration { collapsible = true, size = "100px" },
                        new SplitterPaneConfiguration { collapsible = false, contentUrlString = "../../content/web/splitter/ajax/ajaxContent1.html" },
                        new SplitterPaneConfiguration { collapsible = true, size = "20%" }
                    },
                expand = onExpand,
                collapse = onCollapse,
                contentLoad = onContentLoad,
                resize = onResize
            });
        }
        static void onResize(SplitterEventData e)
        {
            kendoConsole.log("Resized :: Splitter <b>#" + JsContext.@this.As<Splitter>().element["0"].As<HtmlElement>().id + "</b>");
        }

        static void onExpand(SplitterEventData e)
        {
            kendoConsole.log("Expanded :: Pane <b>#" + e.pane.id + "</b> from splitter <b>#" + JsContext.@this.As<Splitter>().element["0"].As<HtmlElement>().id + "</b> expanded");
        }

        static void onCollapse(SplitterEventData e)
        {
            kendoConsole.log("Collapsed :: Pane <b>#" + e.pane.id + "</b> from splitter <b>#" + JsContext.@this.As<Splitter>().element["0"].As<HtmlElement>().id + "</b> collapsed");
        }

        static void onContentLoad(SplitterEventData e)
        {
            kendoConsole.log("Content loaded in <b>#" + e.pane.id +
                "</b> and starts with <b>" + new jQuery(e.pane).text().substr(0, 20) + "...</b>");
        }
    }
}