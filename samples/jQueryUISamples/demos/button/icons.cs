using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Icons
    {
        static Icons()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery(".demo button:first").button(new ButtonOptions
            {
                icons = new IconOptions { primary = "ui-icon-locked" },
                text = false
            })
                .next().button(new ButtonOptions { icons = new IconOptions { primary = "ui-icon-locked" } })
                .next().button(new ButtonOptions { icons = new IconOptions { primary = "ui-icon-gear", secondary = "ui-icon-triangle-1-s" } })
                .next().button(new ButtonOptions
                {
                    icons = new IconOptions { primary = "ui-icon-gear", secondary = "ui-icon-triangle-1-s" },
                    text = false
                });
        }
    }
}