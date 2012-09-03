using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.accordion
{
    [JsType(JsMode.Global)]
    public class CustomIcons
    {
        static CustomIcons()
        {
            new jQuery(OnReady);
        }


        static void OnReady()
        {
            var x = "shuki";
            var icon = new IconOptions { header = "ui-icon-circle-arrow-e", headerSelected = "ui-icon-circle-arrow-s" };
            new jQuery("#accordion").accordion(new AccordionOptions { icons = icon });
            new jQuery("#toggle").button().toggle(e => new jQuery("#accordion").accordion("option", "icons", false),
                e => new jQuery("#accordion").accordion("option", "icons", icon)
            );


            //    $(function() {
            //      var icons = {
            //        header: "ui-icon-circle-arrow-e",
            //        headerSelected: "ui-icon-circle-arrow-s"
            //       };
            //      $( "#accordion" ).accordion({
            //        icons: icons
            //        });
            //      $( "#toggle" ).button().toggle(function() {
            //           $( "#accordion" ).accordion( "option", "icons", false );
            //      }, function() {
            //        $( "#accordion" ).accordion( "option", "icons", icons );
            //    });
            //});

        }
    }
}