using SharpKit.JavaScript;
using SharpKit.Html4;
using YUI_.Plugin_;
using YUI_;

namespace YuiSamples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : HtmlContext
    {
        static DefaultClient()
        {
            new YUI().use(new []{"node", "event"}, y=>
            {
                y.one("#close-button").on("click", () => alert("Hello"));
            });
        }
    }
}