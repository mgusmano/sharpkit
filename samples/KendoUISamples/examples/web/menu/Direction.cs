
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.menu
{
    [JsType(JsMode.Global)]
    public class Direction
    {
        static Direction()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            JsFunc<JsString> getDirection = () =>
            {
                var @checked = new jQuery("input:[type=radio]:checked")[0].id;
                //TODO: return /custom|customValue/.test(@checked) ? new jQuery("#customValue").val() : @checked;
                return null;
            };

            JsAction initMenu = () =>
            {
                new jQuery("#menu").kendoMenu(new MenuConfiguration
                {
                    direction = getDirection()
                })
                .css(new Map
                {
                    marginRight = "220px"
                });
            };

            var original = new jQuery("#menu").clone(true);

            original.find(".k-state-active").removeClass("k-state-active");

            new jQuery("#apply").click(e =>
            {
                e.preventDefault();
                jQuery menu = new jQuery("#menu"),
                    clone = original.clone(true);

                menu.data("kendoMenu").As<Menu>().close(new jQuery("#menu .k-link"));

                menu.replaceWith(clone);

                initMenu();
            });
            initMenu();
        }
    }
}