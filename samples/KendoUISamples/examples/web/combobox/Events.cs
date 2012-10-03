using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html4;
using KendoUISamples.examples.content.shared.js;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;

namespace KendoUISamples.examples.web.combobox
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
            var data = new JsArray<ComboBoxConfiguration> {
                new ComboBoxConfiguration { text = "Item 1", value = "1" },
                new ComboBoxConfiguration{ text = "Item 2", value = "2" },
                new ComboBoxConfiguration{ text = "Item 3", value = "3" } 
            };
            new jQuery("#input").kendoComboBox(new ComboBoxConfiguration
            {
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
            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event: open");
            }
        }
        static void onClose()
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event: close");
            }
        }

        static void onChange()
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                kendoConsole.log("event: change");
            }
        }
        static void onSelect(Event e)
        {
            if ("kendoConsole".@in(HtmlContext.window))
            {
                JsContext.JsCode("var dataItem = this.dataItem(e.item.index());");
                JsContext.JsCode("kendoConsole.log('event :: select (' + dataItem.text + ' : ' + dataItem.value + ')');");
                //TODO: var dataItem = JsContext.@this.As<ComboBox>().dataItem(e.item.index());
                //kendoConsole.log("event :: select (" + dataItem.text + " : " + dataItem.value + ")");
            }
        }
    }
}