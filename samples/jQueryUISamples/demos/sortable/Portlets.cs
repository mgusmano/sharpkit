using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class Portlets
    {
        static Portlets()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery(".column").sortable(new SortableOptions
            {
                connectWith = ".column"
            });
            new jQuery(".portlet").addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
                .find(".portlet-header")
                .addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
                .prepend("<span class='ui-icon ui-icon-minusthick'></span>")
                .end().find(".portlet-content");

            new jQuery(".portlet-header .ui-icon").click(e =>
                {
                    new jQuery(e.currentTarget).toggleClass("ui-icon-minusthick").toggleClass("ui-icon-plusthick");
                    new jQuery(e.currentTarget).parents(".portlet:first").find(".portlet-content").toggle();
                });
            new jQuery(".column").disableSelection();
        }
    }
}