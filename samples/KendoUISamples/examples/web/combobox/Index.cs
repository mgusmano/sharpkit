using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.combobox
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
            // create ComboBox from input HTML element
            new jQuery("#input").kendoComboBox(new ComboBoxConfiguration
            {
                dataTextField = " text",
                dataValueField = "value",
                dataSourceObject = new JsArray<ComboBoxConfiguration> {
                    new ComboBoxConfiguration { text = "Cotton", value = "1"},
                    new ComboBoxConfiguration { text = "Polyester", value = "2" },
                            new ComboBoxConfiguration{ text = "Cotton/Polyester", value = "3" },
                            new ComboBoxConfiguration{ text = "Rib Knit", value = "4" }
                },
                filter = "contains",
                suggest = true,
                index = 3
            });
            // create ComboBox from select HTML element
            new jQuery("#select").kendoComboBox();

            var input = new jQuery("#input").data("kendoComboBox").As<ComboBox>();
            var select = new jQuery("#select").data("kendoComboBox").As<ComboBox>();


            new jQuery("#get").click(() => HtmlContext.window.alert("Thank you! Your Choice is:\n\nFabric ID: " + input.value() + " and Size: " + select.value()));
        }
    }
}