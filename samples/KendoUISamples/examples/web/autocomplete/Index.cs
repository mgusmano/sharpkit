using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.autocomplete
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
                            "Albania",
                            "Andorra",
                            "Armenia",
                            "Austria",
                            "Azerbaijan",
                            "Belarus",
                            "Belgium",
                            "Bosnia & Herzegovina",
                            "Bulgaria",
                            "Croatia",
                            "Cyprus",
                            "Czech Republic",
                            "Denmark",
                            "Estonia",
                            "Finland",
                            "France",
                            "Georgia",
                            "Germany",
                            "Greece",
                            "Hungary",
                            "Iceland",
                            "Ireland",
                            "Italy",
                            "Kosovo",
                            "Latvia",
                            "Liechtenstein",
                            "Lithuania",
                            "Luxembourg",
                            "Macedonia",
                            "Malta",
                            "Moldova",
                            "Monaco",
                            "Montenegro",
                            "Netherlands",
                            "Norway",
                            "Poland",
                            "Portugal",
                            "Romania",
                            "Russia",
                            "San Marino",
                            "Serbia",
                            "Slovakia",
                            "Slovenia",
                            "Spain",
                            "Sweden",
                            "Switzerland",
                            "Turkey",
                            "Ukraine",
                            "United Kingdom",
                            "Vatican City"
                    };

            //create AutoComplete UI component
            new jQuery("#input").kendoAutoComplete(new AutoCompleteConfiguration
            {
                dataSourceObject = data,
                filter = "startswith",
                placeholder = "Select country...",
                separator = ", "
            });
        }
    }
}