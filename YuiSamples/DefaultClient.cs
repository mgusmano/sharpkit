using SharpKit.JavaScript;
using SharpKit.Html4;
using Y_;

namespace YuiSamples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : HtmlContext
    {
        static DefaultClient()
        {
            YUI.Current = new YUI();

            YUI.Current.use(new[] { "editor", "node", "event" }, OnLoad);

        }
        static void OnLoad()
        {
            var x = new EditorBase { content = "asdfadsf" };
            x.render("#editor");
            YUI.Current.one("#close-button").on("click", () => alert("Hello"));
        }
    }
}