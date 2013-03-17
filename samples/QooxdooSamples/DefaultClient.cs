using SharpKit.JavaScript;
using SharpKit.Html;
using qx.ui.form;
using qx.ui.root;

namespace QooxDooTest
{
    [JsType(JsMode.Global, Filename = "script/generated/main.js")]
    public class DefaultClient : HtmlContext
    {
        static void Main()
        {
            var button = new Button("click me");
            var root = qx.core.Init.GetApplication().GetRootApp();
            root.Add(button, new LayoutProperties { Left = 100, Top = 50 });
            
            button.AddListener("execute", a =>
            {
                alert("ok!");
            });
        }
    }
}