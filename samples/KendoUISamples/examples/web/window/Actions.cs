using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.window
{
    [JsType(JsMode.Global)]
    public class Actions
    {
        static Actions()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var win = new jQuery("#window");
            var undo = new jQuery("#undo");

            undo.bind("click", e =>
            {
                win.data("kendoWindow").As<Window>().open();
                undo.hide();
            });

            if (win.data("kendoWindow") == null)
            {
                win.kendoWindow(new WindowConfiguration
                {
                    width = "500px",
                    actions = new JsArray { "Custom", "Minimize", "Maximize", "Close" },
                    title = "About Josef Hoffmann",
                    close = () => undo.show().As<Window>()

                });
            }
            win.data("kendoWindow").As<Window>().wrapper.find(".k-i-custom").click(e =>
            {
                HtmlContext.alert("Custom action button clicked");
                e.preventDefault();
            });
        }
    }
}