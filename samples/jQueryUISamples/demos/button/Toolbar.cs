using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.button
{
    [JsType(JsMode.Global)]
    public class Toolbar
    {
        static Toolbar()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#beginning").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-seek-start" } });
            new jQuery("#rewind").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-seek-prev" } });
            new jQuery("#play").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-play" } })
                .click(e =>
                {
                    var option = (new jQuery(e.currentTarget).text().ExactEquals("play")) ?
                        new ButtonOptions { label = "pause", icons = new IconOptions { primary = "ui-icon-pause" } } :
                        new ButtonOptions { label = "play", icons = new IconOptions { primary = "ui-icon-play" } };

                    new jQuery(e.currentTarget).button("option", option);
                });
            new jQuery("#stop").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-stop" } })
                .click(e => new jQuery("#play").button("option", new ButtonOptions
                {
                    label = "play",
                    icons = new IconOptions { primary = "ui-icon-slay" }
                }));
            
            new jQuery("#forward").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-seek-next" } });
            new jQuery("#end").button(new ButtonOptions { text = false, icons = new IconOptions { primary = "ui-icon-seek-end" } });
            new jQuery("#shuffle").button();
            new jQuery("#repeat").buttonset();
        }
    }
}