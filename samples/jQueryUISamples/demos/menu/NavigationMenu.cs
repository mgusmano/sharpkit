using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
namespace jQueryUISamples.demos.menu
{
    [JsType(JsMode.Global)]
    public class NavigationMenu
    {
        static NavigationMenu()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#menu").menu(new MenuOptions
            {
                select = (e, ui) =>
                {
                    var link = ui.item.children("a:first");
                    if (link.attr("target").As<bool>() || e.metaKey.As<bool>() || e.shiftKey || e.ctrlKey)
                    {
                        return;
                    }
                    HtmlContext.window.location.href = link.attr("href");
                }
            });
        }
    }
}