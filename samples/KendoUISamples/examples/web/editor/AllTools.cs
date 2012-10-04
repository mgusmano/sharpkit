using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.editor
{
    [JsType(JsMode.Global)]
    public class AllTools
    {
        static AllTools()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
           
        new jQuery("#editor").kendoEditor(new EditorConfiguration {
            tools = new[] {
                "bold",
                "italic",
                "underline",
                "strikethrough",
                "fontName",
                "fontSize",
                "foreColor",
                "backColor",
                "justifyLeft",
                "justifyCenter",
                "justifyRight",
                "justifyFull",
                "insertUnorderedList",
                "insertOrderedList",
                "indent",
                "outdent",
                "formatBlock",
                "createLink",
                "unlink",
                "insertImage",
                "subscript",
                "superscript"
            }
        });
   
        }
    }
}