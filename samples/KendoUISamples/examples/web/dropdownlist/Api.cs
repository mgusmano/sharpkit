using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.dropdownlist
{
    [JsType(JsMode.Global)]
    public class Api
    {
        static Api()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
              var data = new JsArray<DropDownListConfiguration> { 
                        new DropDownListConfiguration {text = "The Shawshank Redemption", value ="1"},
                        new DropDownListConfiguration {text = "The Godfather", value ="2"},
                        new DropDownListConfiguration {text = "The Godfather = Part II", value ="3"},
                        new DropDownListConfiguration {text = "Il buono, il brutto, il cattivo.", value ="4"},
                        new DropDownListConfiguration {text = "Pulp Fiction", value ="5"},
                        new DropDownListConfiguration {text = "12 Angry Men", value ="6"},
                        new DropDownListConfiguration {text = "Schindler's List", value ="7"},
                        new DropDownListConfiguration {text = "One Flew Over the Cuckoo's Nest", value ="8"},
                        new DropDownListConfiguration {text = "Inception", value ="9"},
                        new DropDownListConfiguration {text = "The Dark Knight", value ="10"}
              };

                    new jQuery("#products").kendoDropDownList(new DropDownListConfiguration {
                                      dataTextField = "text",
                                      dataValueField = "value",
                                      dataSourceObject = data
                                  })
                                  .closest(".k-widget")
                                  .attr("id", "products_wrapper");

                    var dropdownlist = new jQuery("#products").data("kendoDropDownList").As<DropDownList>();
                        JsAction<Event> setValue = e => {
                            if (e.type != "keypress")  //TODO || Kendo.keys.ENTER == e.keyCode)
                                dropdownlist.value(new jQuery("#value").val().As<JsString>());
                        },
                        setIndex = e => {
                            if (e.type != "keypress") { //|| kendo.keys.ENTER == e.keyCode) {
                                var index = int.Parse(new jQuery("#index").val().As<JsString>());
                                dropdownlist.select(index);
                            }
                        },
                        setSearch = e => {
                            if (e.type != "keypress") //|| kendo.keys.ENTER == e.keyCode)
                                dropdownlist.search(new jQuery("#word").val().As<JsString>());
                        };

            new jQuery("#enable").click(() => dropdownlist.enable());
            new jQuery("#disable").click(() =>
                dropdownlist.enable(false));


            new jQuery("#open").click(() =>
                dropdownlist.open());


            new jQuery("#close").click(() =>
                dropdownlist.close());


            new jQuery("#getValue").click(() =>
                HtmlContext.window.alert(dropdownlist.value()));


            new jQuery("#getText").click(() =>
               HtmlContext.window.alert(dropdownlist.text()));


            new jQuery("#setValue").click(setValue);
            new jQuery("#value").keypress(setValue);

            new jQuery("#select").click(setIndex);
            new jQuery("#index").keypress(setIndex);

            new jQuery("#find").click(setSearch);
            new jQuery("#word").keypress(setSearch);
        }
    }
}