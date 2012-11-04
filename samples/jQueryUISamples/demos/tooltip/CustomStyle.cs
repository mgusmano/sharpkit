using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
namespace jQueryUISamples.demos.tooltip
{
    [JsType(JsMode.Global)]
    public class CustomStyle
    {
        static CustomStyle()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery(HtmlContext.document).tooltip(new TooltipOptions
            {
               
                position = new PositionOptions
                {
                    my = "center bottom-20",
                    at = "center top",
                    usingExtend = (position, feedback) =>
                    {
                        new jQuery(JsContext.@this).css(position);
                        new jQuery("<div>")
                            .addClass("arrow")
                            .addClass(feedback["vertical"].As<JsString>())
                            .addClass(feedback["horizontal"].As<JsString>())
                            .appendTo(JsContext.@this);
                    }
                }
            });
        }
    }
}