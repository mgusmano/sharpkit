using SharpKit.JavaScript;
using SharpKit.jQuery;

namespace KendoUISamples.examples.web.timepicker
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#treeview").kendoTreeView();
        }
    }
}