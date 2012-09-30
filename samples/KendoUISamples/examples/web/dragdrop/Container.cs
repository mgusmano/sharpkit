using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;


namespace KendoUISamples.examples.web.dragdrop
{
    [JsType(JsMode.Global)]
    public class Container
    {
        static Container()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
       
            new jQuery("#draggable-item").kendoDraggable(new DraggableConfiguration
            {
                container = new jQuery("#draggable-container"),
                hintFunction = () => new jQuery("#draggable-item").clone()    
            });
        }
    }
}