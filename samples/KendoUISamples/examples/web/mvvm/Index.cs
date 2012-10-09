
using SharpKit.JavaScript;
using SharpKit.KendoUI;
namespace KendoUISamples.examples.web.mvvm
{
    [JsType(JsMode.Global)]
    public class Index
    {
        static Index()
        {
        }

        static void OnReady()
        {
            //TODO: observable doesn't exist.
            //  var viewModel = Kendo.observable(   {
            //    firstName = "John",
            //    lastName: "Doe",
            //    genders: ["Male", "Female"],
            //    gender: "Male",
            //    agreed: false,
            //    confirmed: false,
            //    register: function(e) {
            //        e.preventDefault();

            //        this.set("confirmed", true);
            //    },
            //    startOver: function() {
            //        this.set("confirmed", false);
            //        this.set("agreed", false);
            //        this.set("gender", "Male");
            //        this.set("firstName", "John");
            //        this.set("lastName", "Doe");
            //    }
            //});

            //kendo.bind($("#example"), viewModel);

        }
    }
}