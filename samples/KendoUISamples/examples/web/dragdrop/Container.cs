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
        }
        static void OnReady()
        {
            //TODO
            new jQuery("#draggable-item").kendoDatePicker();
        }
    //     $("#draggable-item").kendoDraggable({
    //    container: $("#draggable-container"),
    //    hint: function() {
    //        return $("#draggable-item").clone();
    //    }
    //});
    }
}