using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;
using SharpKit.KendoUI;
using SharpKit.Html4;

namespace KendoUISamples.examples.web.combobox
{
    [JsType(JsMode.Global)]
    public class Api
    {
        //TODO: sample doesn't work correctly.
        static Api()
        {
            new jQuery(OnReady);
        }

       
        static ComboBox combobox; 
        static void OnReady()
        {
            var data = new JsArray<ComboBoxConfiguration> {
                new ComboBoxConfiguration     { text = "12 Angry Men", value = "1" },
                new ComboBoxConfiguration{ text = "Il buono, il brutto, il cattivo.", value = "2" },
                new ComboBoxConfiguration{ text = "Inception", value = "3" },
                new ComboBoxConfiguration{ text = "One Flew Over the Cuckoo's Nest", value = "4" },
                new ComboBoxConfiguration{ text = "Pulp Fiction", value = "5" },
                new ComboBoxConfiguration{ text = "Schindler's List", value = "6" },
                new ComboBoxConfiguration { text = "The Dark Knight", value = "7" },
                new ComboBoxConfiguration{ text = "The Godfather", value = "8" },
                new ComboBoxConfiguration{ text = "The Godfather = Part II", value = "9" },
                new ComboBoxConfiguration{ text = "The Shawshank Redemption", value = "10" },
                new ComboBoxConfiguration{ text = "The Shawshank Redemption 2", value = "11" }
        };
            new jQuery("#products").kendoComboBox(new ComboBoxConfiguration
            {
                dataTextField = "text",
                dataValueField = "value",
                dataSourceObject = data
            })
            .closest(".k-widget")
            .attr("id", "products_wrapper");
            
            new jQuery("#filter").kendoDropDownList(new DropDownListConfiguration
            {
                change = filterTypeOnChanged

            });
            combobox = new jQuery("#products").data("kendoComboBox").As<ComboBox>();
          
            new jQuery("#enable").click(() => combobox.enable());
            new jQuery("#disable").click(() => combobox.enable(false));
            new jQuery("#open").click(() => combobox.open());
            new jQuery("#close").click(() => combobox.close());
            new jQuery("#getValue").click(() => HtmlContext.window.alert(combobox.value()));
            new jQuery("#getText").click(() => HtmlContext.window.alert(combobox.value()));
            new jQuery("#setValue").click(setValue);
            new jQuery("#value").keypress(setValue);
            new jQuery("#select").click(setIndex);
            new jQuery("#index").keypress(setIndex);
            new jQuery("#find").click(setSearch);
            new jQuery("#word").keypress(setSearch);
        }
        static void setValue(Event e)
        {
            if (e.ExactNotEquals("keypress") || Kendo.keys.ENTER == e.keyCode)
            {
                var index = JsContext.parseInt(new jQuery("#index").val().As<JsString>());
                combobox.select(index);
            }
        }

        static void setIndex(Event e)
        {

            if (e.type != "keypress" || Kendo.keys.ENTER == e.keyCode)
            {
                var index = JsContext.parseInt(new jQuery("#index").val().As<JsString>());
                combobox.select(index);
            }
        }

        static void setSearch(Event e)
        {
            if (e.type != "keypress" || Kendo.keys.ENTER == e.keyCode)
                combobox.search(new jQuery("#word").val().As<JsString>());
        }
    
       
        static void filterTypeOnChanged()
        {
          
            combobox.As<JsObject>()["options"].As<ComboBoxConfiguration>().filter = new jQuery("#filter").val().As<JsString>();
        }
    }
}