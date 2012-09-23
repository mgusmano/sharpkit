using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.sortable
{
    [JsType(JsMode.Global)]
    public class ConnectsListsThroughTabs
    {
        static ConnectsListsThroughTabs()
        {
        }
        static void OnReady()
        {
            new jQuery("#sortable1, #sortable2").sortable().disableSelection();
            var tabs = new jQuery("#tabs").tabs();
            var tab_items = new jQuery("ul:first li", tabs).droppable(new DroppableOptions
            {
                accept = ".connectedSortable li",
                hoverClass = "ui-state-hover",
                drop = (e, ui) =>
                    {
                        var item = new jQuery(e.currentTarget);
                        var list = new jQuery(item.find("a").attr("href"))
                        .find(".connectedSortable");
                       
                        // TODO: tab_items definition 
                        ui.draggable.hide("slow", () =>
                            {
                                //tabs.tabs("select", tab_items.index(item));
                                new jQuery(e.currentTarget).appendTo(list).show("slow");
                            });

                    }

            });
    //            $(function() {
    //    $( "#sortable1, #sortable2" ).sortable().disableSelection();

    //    var $tabs = $( "#tabs" ).tabs();

    //    var $tab_items = $( "ul:first li", $tabs ).droppable({
    //        accept: ".connectedSortable li",
    //        hoverClass: "ui-state-hover",
    //        drop: function( event, ui ) {
    //            var $item = $( this );
    //            var $list = $( $item.find( "a" ).attr( "href" ) )
    //                .find( ".connectedSortable" );

    //            ui.draggable.hide( "slow", function() {
    //                $tabs.tabs( "select", $tab_items.index( $item ) );
    //                $( this ).appendTo( $list ).show( "slow" );
    //            });
    //        }
    //    });
    //});

        }
    }
}