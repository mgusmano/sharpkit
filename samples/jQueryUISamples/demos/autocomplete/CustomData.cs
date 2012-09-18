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
        }
        
        //TODO: var projects = ?
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
            };
        }

    // 	$(function() {
    //    var projects = [
    //        {
    //            value: "jquery",
    //            label: "jQuery",
    //            desc: "the write less, do more, JavaScript library",
    //            icon: "jquery_32x32.png"
    //        },
    //        {
    //            value: "jquery-ui",
    //            label: "jQuery UI",
    //            desc: "the official user interface library for jQuery",
    //            icon: "jqueryui_32x32.png"
    //        },
    //        {
    //            value: "sizzlejs",
    //            label: "Sizzle JS",
    //            desc: "a pure-JavaScript CSS selector engine",
    //            icon: "sizzlejs_32x32.png"
    //        }
    //    ];

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