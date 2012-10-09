using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
namespace KendoUISamples.examples.web.templates
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
        }
        //TODO: function preview()
        static void OnReady()
        {
            var template = Kendo.template(new jQuery("#template").html());


        }

    //    var template = kendo.template($("#template").html());

    //function preview() {
    //    $("#blog-preview").html(template({
    //        title: $("#blog-title").val(),
    //        twitter: $("#blog-twitter").val(),
    //        content: $("#blog-content").val()
    //    }));
    //}

    //preview();

    //$("#preview").click(preview);
    }
}