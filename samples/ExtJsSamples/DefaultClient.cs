using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using Ext.window;
using Ext;

namespace ExtJsSamples
{
    [JsType(JsMode.Global)]
    public class DefaultClient
    {
        static void Main()
        {
            var win = new Window(new WindowConfig { width = 300, height = 200 });
            win.show();
            //ExtContext.create<Window>(new WindowConfig { width = 100, height = 100 }).show();
        }
    }
}