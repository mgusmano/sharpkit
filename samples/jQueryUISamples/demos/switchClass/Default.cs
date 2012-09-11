using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.switchClass
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#button").click(e =>
                {
                    // TODO: new jQuery(".newClass").switchClass("newClass", "anotherNewClass", 1000);
                    //TODO: new jQuery(".anotherNewClass").swithClass("newClass", "anotherNewClass", 1000);
                    JsContext.@return(false);
                });
        }
        //        $(function () {
        //    $("#button").click(function () {
        //        $(".newClass").switchClass("newClass", "anotherNewClass", 1000);
        //        $(".anotherNewClass").switchClass("anotherNewClass", "newClass", 1000);
        //        return false;
        //    });
        //});

    }
}