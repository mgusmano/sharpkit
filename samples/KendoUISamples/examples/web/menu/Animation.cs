using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;
namespace KendoUISamples.examples.web.menu
{
    [JsType(JsMode.Global)]
    public class Animation
    {

        static Animation()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            JsFunc<JsString> getEffects = () =>
        {
            return ((checked(new jQuery("#expand")[0].As<bool>()) ? "expand:vertical " : "") +
                    (checked(new jQuery("#slide")[0].As<bool>()) ? "slideIn:down " : "") +
                    (checked(new jQuery("#opacity")[0].As<bool>()) ? "fadeIn" : "")); //TODO: || false;
        };

            JsAction initMenu = () =>
            {
                new jQuery("#menu").kendoMenu(new MenuConfiguration
                {
                    animation = new AnimationConfiguration { open = new PanelBarAnimationCloseConfiguration { effects = getEffects() } },

                    //TODO: hoverDelay = new jQuery("#delay")[0].value
                    hoverDelay = new jQuery("#delay")[0].As<JsNumber>().valueOf()
                })
                .css(new Map
                {
                    marginRight = "220px"
                });
            };
            var original = new jQuery("#menu").clone(true);
            original.find(".k-state-active").removeClass("k-state-active");

            new jQuery(".configuration input").change(e =>
                {
                    jQuery menu = new jQuery("#menu");
                    jQuery clone = original.clone(true);

                    menu.data("kendoMenu").As<Menu>().close(new jQuery("#menu .k-link"));

                    menu.replaceWith(clone);

                    initMenu();
                });

            initMenu();

        }
    }
}