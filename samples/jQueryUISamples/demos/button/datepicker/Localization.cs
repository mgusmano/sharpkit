using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.datepicker
{
    [JsType(JsMode.Global)]
    public class Localization
    {
        static Localization()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            
            //TODO:   DatePicker.setDefaults(DatePicker.regional[""]);
            
            //TODO: $("#datepicker").datepicker($.datepicker.regional["fr"]);
            new jQuery("#datepicker").datepicker();

            //TODO: $("#locale").change(function () { $("#datepicker").datepicker("option",$.datepicker.regional[$(this).val()]);});
            new jQuery("#locale").change(e => new jQuery("#datepicker").datepicker("option"));
        }
    //        $(function () {
    //    $.datepicker.setDefaults($.datepicker.regional[""]);
    //    $("#datepicker").datepicker($.datepicker.regional["fr"]);
    //    $("#locale").change(function () {
    //        $("#datepicker").datepicker("option",
    //        $.datepicker.regional[$(this).val()]);
    //    });
    //});

    }
}