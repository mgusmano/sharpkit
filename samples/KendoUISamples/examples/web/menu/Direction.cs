
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

        static JsString getDirection()
        {
            var @checked = new jQuery("input:[type=radio]:checked")[0].id;
            var regex = new JsRegExp("custom|customValue");
            if (regex.test(@checked))
                return new jQuery("#customValue").val().As<JsString>();
            else
                return @checked;
        }

        static void OnReady()
        {

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