using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.editor
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
            new jQuery("#editor").kendoEditor();

            var editor = new jQuery("#editor").data("kendoEditor").As<Editor>();

            JsAction setValue = () =>
                editor.value(new jQuery("#value").val().As<JsString>());
            
            new jQuery("#get").click(() => HtmlContext.window.alert(editor.value()));
            new jQuery("#set").click(setValue);

        }
    }
}