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
            var window = new jQuery("#window");
            var undo = new jQuery("#undo");

            undo.bind("click", e =>
            {
                window.data("kendoWindow").As<Window>().open();
                undo.hide();
            });

            if (window.data("kendoWindow") == null)
            {
                window.kendoWindow(new WindowConfiguration
                {
                    width = "500px",
                    actions = new JsArray { "Custom", "Minimize", "Maximize", "Close" },
                    title = "About Josef Hoffmann",
                    close = () => undo.show().As<Window>()

                });
            }
            //TODO: wrapper.find? 
            JsContext.JsCode("window.data('kendoWindow').wrapper.find('.k-i-custom').click(function(e){alert('Custom action button clicked');e.preventDefault();});");
        }
    }
}