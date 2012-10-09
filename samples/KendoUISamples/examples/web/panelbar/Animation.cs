
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;
namespace KendoUISamples.examples.web.panelbar
{
    [JsType(JsMode.Global)]
    public class Animation
    {
        static Animation()
        {
        }

        static void OnReady()
        {
            
             JsAction initPanelBar = () =>
                 {
                     //TODO: getEffects()
                        //new jQuery("#panelbar").kendoPanelBar(new PanelBarConfiguration { animation = new PanelBarAnimationConfiguration 
                        //{  expand = new PanelBarAnimationExpandConfiguration
                        //{ effects = getEffects()
                        //}
                        //} });
                    };
                                var original = new jQuery("#panelbar").clone(true);
                    original.find(".k-state-active").removeClass("k-state-active");

                    new jQuery(".configuration input").change( e =>
                        {
                        //PanelBar panelBar = new jQuery("#panelbar").As<PanelBar>();
                            PanelBar panelBar = new jQuery("#panelbar").As<PanelBar>();
                            jQuery clone = original.clone(true);
                        

                        panelBar.data("kendoPanelBar").collapse(new jQuery("#panelbar .k-link"));

                        panelBar.replaceWith(clone);

                        initPanelBar();
                    });
                   //TODO:      
                   JsContext.JsCode("var getEffects = function () { return ((new jQuery('#expand')[0].checked ? 'expand:vertical ' : '') + (new jQuery('#opacity')[0].checked ? 'fadeIn' : '')) || false;};");

                    initPanelBar();

        }
    }
}