
using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using System.Collections.Generic;

namespace ClrModeSamples
{
    [JsType(JsMode.Global)]
    public class DefaultClient : jQueryContext
    {
        static void DefaultClient_Load()
        {
            MyApp.Main();
        }
    }

}