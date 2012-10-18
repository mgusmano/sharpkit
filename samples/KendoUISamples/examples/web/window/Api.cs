using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.window
{
    [JsType(JsMode.Global)]
    public class Api
    {
        static Api()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var wnd = new jQuery("#window");

            new jQuery("#open").click(e => wnd.data("kendoWindow").As<Window>().open());
            new jQuery("#close").click(e => wnd.data("kendoWindow").As<Window>().close());
            new jQuery("#refresh").click(e => wnd.data("kendoWindow").As<Window>().refresh());
            wnd.kendoWindow(new WindowConfiguration
            {
                width = "505px",
                height = "315px",
                title = "Rams's Ten Principles of Good Design",
                actions = new[] { "Refresh", "Maximize", "Close" },
                contentString = "../../content/web/window/ajax/ajaxContent1.html"
            });
        }
    }
}