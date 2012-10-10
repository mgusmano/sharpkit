using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.window
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
            var window = new jQuery("#window");
            var undo = new jQuery("#undo")
                    .bind("click", e =>
                    {
                        window.data("kendoWindow").As<Window>().open();

                    });
            undo.hide();
            
            JsAction onClose = () => undo.show().As<Window>();
            
            if (window.data("kendoWindow") == null)
            {
                window.kendoWindow(new WindowConfiguration
                {
                    width = "615px",
                    title = "Rams's Ten Principles of Good Design",
                    contentString = "../../content/web/window/ajax/ajaxContent.html",
                    close = onClose
                });
            }
        }
    }
}