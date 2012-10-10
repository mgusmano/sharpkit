
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
namespace KendoUISamples.examples.web.validator
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var data = new[] {
                    "12 Angry Men",
                    "Il buono, il brutto, il cattivo.",
                    "Inception",
                    "One Flew Over the Cuckoo's Nest",
                    "Pulp Fiction",
                    "Schindler's List",
                    "The Dark Knight",
                    "The Godfather",
                    "The Godfather: Part II",
                    "The Shawshank Redemption"
                    };

            new jQuery("#search").kendoAutoComplete(new AutoCompleteConfiguration
            {
                dataSourceObject = data,
                separator = ", "
            });

            var validator = new jQuery("#tickets").kendoValidator().data("kendoValidator").As<Validator>();
            var status = new jQuery(".status");

            new jQuery("button").click(() =>
            {
                if (validator.validate())
                {
                    status.text("Hooray! Your tickets has been booked!").addClass("valid");
                }
                else
                {
                    status.text("Oops! There is invalid data in the form.").addClass("invalid");
                }
            });
        }
    }
}