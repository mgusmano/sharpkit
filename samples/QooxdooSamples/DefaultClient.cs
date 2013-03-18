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
            root.Add(button, new LayoutProperties { Left = 50, Top = 50 });

            button.AddListener("execute", a =>
            {
                var wnd = new qx.ui.window.Window("my window", null);
                // hide the window buttons
                wnd.SetShowClose(false);
                wnd.SetShowMaximize(false);
                wnd.SetShowMinimize(false);

                // adjust position
                wnd.MoveTo(200, 50);

                // adjust size
                wnd.SetWidth(250);
                wnd.SetHeight(300);

                // add the layout
                var layout = new qx.ui.layout.Grid(0, 0);
                layout.SetRowFlex(1, 1);
                layout.SetColumnFlex(0, 1);
                wnd.SetLayout(layout);
                wnd.SetContentPadding(0, 0, 0, 0);

                // toolbar
                var toolbar = new qx.ui.toolbar.ToolBar();
                wnd.Add(toolbar, new { row = 0, column = 0, colSpan = 2});

                // reload button
                var reloadButton = new qx.ui.toolbar.Button("Reload");
                toolbar.Add(reloadButton);
                reloadButton.SetToolTipText("Reload the tweets.");
                reloadButton.AddListener("execute", e => {
                    wnd.Debug("reload");
                }, wnd);

                // list
                var list = new qx.ui.form.List();
                wnd.Add(list, new {row = 1, column = 0, colSpan = 2});

                // textarea
                var postButton = new qx.ui.form.Button("Post");
                var textarea = new qx.ui.form.TextArea();
                wnd.Add(textarea, new { row = 2, column = 0});
                textarea.SetPlaceholder("Enter your message here...");
                textarea.AddListener("input", e => {
                  string value = e.GetData().As<string>();
                  postButton.SetEnabled(value.Length < 140 && value.Length > 0);
                }, wnd);

                // post button
                wnd.Add(postButton, new {row = 2, column = 1});
                postButton.SetToolTipText("Post wnd message on identi.ca");
                postButton.AddListener("execute", e => {
                    wnd.Debug("post: " + textarea.GetValue());
                }, wnd);
                postButton.SetWidth(60);
                postButton.SetEnabled(false);
                wnd.Open();
            });
        }
    }
}