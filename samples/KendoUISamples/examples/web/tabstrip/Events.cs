using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using KendoUISamples.examples.content.shared.js;
namespace KendoUISamples.examples.web.tabstrip
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }
        static void onSelect(TabStripSelectEventData e)
        {
            kendoConsole.log("Selected: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onActivate(TabStripSelectEventData e)
        {
            kendoConsole.log("Activated: " + new jQuery(e.item).find("> .k-link").text());
        }

        static void onContentLoad(TabStripSelectEventData e)
        {
            kendoConsole.log("Content loaded in <b>" + new jQuery(e.item).find("> .k-link").text() + "</b> and starts with <b>" + new jQuery(e.contentElement).text().substr(0, 20) + "...</b>");
        }

        static void onError(TabStripErroEventData e)
        {
            kendoConsole.error("Loading failed with " + e.xhr.statusText + " " + e.xhr.status);
        }
        //TODO: the example doesn't work correctly.
        static void OnReady()
        {
            new jQuery("#tabstrip").kendoTabStrip(new TabStripConfiguration
            {
                select = onSelect,
                activate = onActivate,
                contentLoad = onContentLoad,
                error = onError,
                contentUrls = new JsArray<JsString> { "", "", "", "", "", "../../content/web/tabstrip/ajax/ajaxContent1.html", "error.html" }
            });
        }
       
    }
}