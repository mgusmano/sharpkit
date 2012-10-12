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
            dynamic x = null;

            var xx = x.item.label.shooki.booki;
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
                        //TODO: $( "#project" ).val( ui.item.label );
                        new jQuery("#project").val(ui2.item.label);
                        JsContext.JsCode(" new jQuery( '#project' ).val(ui.item.label)");
                        JsContext.@return(false);
                    },
                select = (e, ui) =>
                    {
                        JsContext.JsCode("new jQuery( '#project' ).val( ui.item.label );)");
                        JsContext.JsCode("new jQuery( '#project-id' ).val( ui.item.value );");
                        JsContext.JsCode("new jQuery('#project-description').html(ui.item.desc);");
                        JsContext.JsCode("('#project-icon').attr('src', 'images/' + ui.item.icon);");
                        JsContext.@return(false);

                    },

            });// TODO:   .data( "autocomplete" )._renderItem ...


            //    $( "#project" ).autocomplete({
            //        minLength: 0,
            //        source: projects,
            //        focus: function( event, ui ) {
            //            $( "#project" ).val( ui.item.label );
            //            return false;
            //        },
            //        select: function( event, ui ) {
            //            $( "#project" ).val( ui.item.label );
            //            $( "#project-id" ).val( ui.item.value );
            //            $( "#project-description" ).html( ui.item.desc );
            //            $( "#project-icon" ).attr( "src", "images/" + ui.item.icon );

            //            return false;
            //        }
            //    })
            //    .data( "autocomplete" )._renderItem = function( ul, item ) {
            //        return $( "<li></li>" )
            //            .data( "item.autocomplete", item )
            //            .append( "<a>" + item.label + "<br>" + item.desc + "</a>" )
            //            .appendTo( ul );
            //    };
            //});
        }
    }

    [JsType(JsMode.Json)]
    class UIWithItem
    {
        public UIItem item { get; set; }
    }

    [JsType(JsMode.Json)]
    class UIItem
    {
        public JsString label { get; set; }
    }
}