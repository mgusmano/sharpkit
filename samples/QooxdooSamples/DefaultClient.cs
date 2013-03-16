using SharpKit.JavaScript;
using SharpKit.Html;
using SharpKit.jQuery;
using qx.ui.form;
using qx.ui.root;
using System.Collections.Generic;

namespace QooxDooTest
{
    [JsType(JsMode.Global, Filename = "testapp/source/script/generated/main.js")]
    public class DefaultClient : HtmlContext
    {
        static void Main()
        {
            var button = new Button("test");
            var root = qx.core.Init.GetApplication().GetRootApp();
            root.Add(button, new LayoutProperties { Left = 100, Top = 50 });
            
            button.AddListener("execute", a =>
            {
                alert("ok!");
            });
        }
    }
}