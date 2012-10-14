using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.autocomplete
{
    [JsType(JsMode.Global)]
    public class CustomData
    {
        static CustomData()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var projects = new JsArray<AutocompleteItem>
            {
                new AutocompleteItem
                {
                    value= "jquery",
                    label= "jQuery",
                    desc= "the write less, do more, JavaScript library",
                    icon= "jquery_32x32.png"
                },
                new AutocompleteItem 
                {
                    value= "jquery-ui",
                    label= "jQuery UI",
                    desc= "the official user interface library for jQuery",
                    icon= "jqueryui_32x32.png"
                },
                new AutocompleteItem 
                {
                    value = "sizzlejs",
                    label = "Sizzle JS",
                    desc = "a pure-JavaScript CSS selector engine",
                    icon = "sizzlejs_32x32.png"
                }
            };
            new jQuery("#project").autocomplete(new AutocompleteOptions
            {
                source = projects,
                focus = (e, ui) =>
                    {
                        var ui2 = ui.As<UIWithItem>();
                        new jQuery("#project").val(ui2.item.label);
                        JsContext.JsCode(" new jQuery( '#project' ).val(ui.item.label)");
                        JsContext.@return(false);
                    },
                select = (e, ui) =>
                    {
                        new jQuery("#project").val(ui.As<UIWithItem>().item.label);
                        new jQuery("#project-id").val(ui.As<UIWithItem>().item.value);
                        new jQuery("#project-description").html(ui.As<UIWithItem>().item.As<AutocompleteItem>().desc);
                        new jQuery("#project-icon").attr("src", "images/" + ui.As<UIWithItem>().item.As<AutocompleteItem>().icon);
                        JsContext.@return(false);
                    }
            }).data("autocomplete").As<UIWithItem>()._renderItem = (ul, item) =>

                    new jQuery("<li></li>")
                        .data("item.autocomplete", item)
                        .append("<a>" + item.label + "<br>" + item.desc + "</a>")
                        .appendTo(ul);
        }
    }

    [JsType(JsMode.Json)]
    class UIWithItem
    {
        public UIItem item { get; set; }
        public JsFunc<jQuery, AutocompleteItem, jQuery> _renderItem { get; set; }
    }

    [JsType(JsMode.Json)]
    class UIItem
    {
        public JsString label { get; set; }
        public JsString value { get; set; }

    }


}