using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.tabs
{
    [JsType(JsMode.Global)]
    public class Cookie
    {
        static Cookie()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            // TODO : CookieOption

           // new jQuery("#tabs").tabs(new TabsOptions 
        //            $(function () {
        //    $("#tabs").tabs({
        //        cookie: {
        //            // store cookie for a day, without, it would be a session cookie
        //            expires: 1
        //        }
        //    });
        //});

        }
    }
}