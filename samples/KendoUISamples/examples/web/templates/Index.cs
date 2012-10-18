using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
namespace KendoUISamples.examples.web.templates
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static JsFunc<JsArray, JsString> template;
        static Index()
        {
            new jQuery(OnReady);
        }
        //TODO: Error: "title is not defind
        static void OnReady()
        {
            template = Kendo.template(new jQuery("#template").html()).As < JsFunc<JsArray, JsString>>();
            preview();
            new jQuery("#preview").click(preview);

        }

        //    var template = kendo.template($("#template").html());

        //function preview() {
        //    $("#blog-preview").html(template({
        //        title: $("#blog-title").val(),
        //        twitter: $("#blog-twitter").val(),
        //        content: $("#blog-content").val()
        //    }));
        //}



        //
        static void preview()
        {
            new jQuery("#blog-preview").html(template(new JsArray
            {
                new { title = new jQuery("#blog-title").val() },
                new { twitter = new jQuery("#blog-twitter").val() },
                new {content = new jQuery("#blog-content").val()}
            }));

        }
    }
}