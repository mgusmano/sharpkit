using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.selectable
{
    [JsType(JsMode.Global)]
    public class Serialize
    {
        static Serialize()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#selectable").selectable(new SelectableOptions
            {
                stop = (e, ui) =>
                    {
                        var result = new jQuery("#select-result").empty();
                        new jQuery(".ui-selected", e.currentTarget).each((number, elemnt) =>
                        {
                            var index = new jQuery("#selectable li").index(elemnt);
                            result.append(" #" + (index + 1));
                        });
                    }
            });
        }
    }
}