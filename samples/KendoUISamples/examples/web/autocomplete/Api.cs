using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using SharpKit.Html4;
namespace KendoUISamples.examples.web.autocomplete
{
    [JsType(JsMode.Global)]
    public class Api
    {
        static AutoComplete autoComplete;
        static Api()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var data = new[] {
                        "Red-violet",
                        "Red",
                        "Red-orange",
                        "Orange",
                        "Yellow-orange",
                        "Yellow",
                        "Yellow-green",
                        "Green",
                        "Blue-green",
                        "Blue",
                        "Blue-violet",
                        "Violet"
            };

            new jQuery("#products").kendoAutoComplete(data.As<AutoCompleteConfiguration>());

            autoComplete = new jQuery("#products").data("kendoAutoComplete").As<AutoComplete>();
            JsAction<Event> setValue = SetValue;
            JsAction<Event> setSearch = SetSearch;

            new jQuery("#set").click(setValue);
            new jQuery("#value").keypress(setValue);
            new jQuery("#search").click(setSearch);
            new jQuery("#word").keypress(setSearch);

            //new jQuery("#get").click(() => HtmlContext.window.alert(autoComplete.value()));


        }
        static void SetValue(Event e)
        {

            if (e.type != "keypress" || Kendo.keys.ENTER == e.keyCode)
                autoComplete.value(new jQuery("#value").val().As<JsString>());
        }
        static void SetSearch(Event e)
        {
            if (e.type != "keypress" || Kendo.keys.ENTER == e.keyCode)
                autoComplete.search(new jQuery("#word").val().As<JsString>());
        }
    }
}