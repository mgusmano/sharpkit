using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Splitbutton
    {
        static Splitbutton()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#rerun").button().click(e => HtmlContext.alert("Running the last action"))
                .next().button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-triangle-1-s" } })
                .click(e => HtmlContext.alert("Could display a menu to select an action")).parent().buttonset();
        }
    }
}