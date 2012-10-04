using SharpKit.JavaScript;
using SharpKit.jQuery;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.dropdownlist
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            var data = new JsArray<DropDownListConfiguration> {
                new DropDownListConfiguration {text = "Item1", value ="1"},
                new DropDownListConfiguration{text = "Item2", value ="2"},
                new DropDownListConfiguration{text = "Item3", value ="3"}
            };

                    new jQuery("#input").kendoDropDownList(new DropDownListConfiguration {
                        dataTextField = "text",
                        dataValueField = "value",
                        dataSourceObject = data,
                        select = onSelect,
                        change = onChange,
                        close = onClose,
                        open = onOpen
                    });
        }
        static void onOpen()
        {
            kendoConsole.log("Open: open");
        }

        static void onClose()
        {
            kendoConsole.log("Close: close");
        }

        static void onChange()
        {
            kendoConsole.log("Change : change");
        }
        static void onSelect(Event e)
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                JsContext.JsCode("var dataItem = this.dataItem(e.item.index());");
                JsContext.JsCode("kendoConsole.log('event :: select (' + dataItem.text + ' : ' + dataItem.value + ')' );");
            }
        }
    }
}