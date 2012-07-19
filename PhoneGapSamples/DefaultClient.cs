using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.PhoneGap;

namespace PhoneGapSamples
{
    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContextBase
    {
        static void DefaultClient_Load()
        {
            var doc = new DocumentEx();
            doc.deviceready += new JsAction(doc_deviceready);
        }

        static void doc_deviceready()
        {
            throw new System.NotImplementedException();
        }
    }
}