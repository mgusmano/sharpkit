using SharpKit.JavaScript;
using KendoUISamples.examples.content.shared.js;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.panelbar
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
            new jQuery("#panelbar").kendoPanelBar(new PanelBarConfiguration
            {
                expandMode = "single",
                select = onSelect,
                expand = onExpand,
                collapse = onCollapse,
                activate = onActivate,
                contentLoad = onContentLoad,
                error = onError,
                contentUrls = new JsArray<JsString> { "", "", "", "../../content/web/panelbar/ajax/ajaxContent1.html", "error.html" }
            }).css(new Map { width = "250px" }).css(new Map { margin = "20px auto" });
        }
        static void onSelect(PanelBarContentLoadEventData e)
        {
            kendoConsole.log("Select: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onExpand(PanelBarContentLoadEventData e)
        {
            kendoConsole.log("Expand: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onCollapse(PanelBarContentLoadEventData e)
        {
            kendoConsole.log("Collapse: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onActivate(PanelBarContentLoadEventData e)
        {
            kendoConsole.log("Activate: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onContentLoad(PanelBarContentLoadEventData e)
        {
            kendoConsole.log("Content loaded in <b>" + new jQuery(e.item).find("> .k-link").text() +
                             "</b> and starts with <b>" + new jQuery(e.contentElement).text().substr(0, 20) + "...</b>");
        }

        static void onError(PanelBarErrorEventData e)
        {
            kendoConsole.error("Loading failed with " + e.xhr.statusText + " " + e.xhr.status);
        }
    }
}