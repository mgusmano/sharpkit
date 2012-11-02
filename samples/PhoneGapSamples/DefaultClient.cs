using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.PhoneGap;

namespace PhoneGapSamples
{
    [JsType(JsMode.Prototype, Filename = "res/Default.js")]
    public class DefaultClient
    {
        void DefaultClient_Load()
        {
            var doc = HtmlContext.document.As<Events>();
            doc.deviceready += new JsAction(doc_deviceready);
            doc.deviceready -= new JsAction(doc_deviceready);
        }

        void doc_deviceready()
        {
        }
    }
}