using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI;

namespace KendoUISamples.examples.web.datasource
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
            // create a template using the above definition
            var template = Kendo.template(new jQuery("#template").html());
            var movies = new JsArray<Movie> {
                new Movie { rank = 1, rating = 9.2, year = 1994, title = "The Shawshank Redemption" },
                new Movie { rank = 2, rating = 9.2, year = 1972, title = "The Godfather" },
                new Movie { rank = 3, rating = 9, year = 1974, title = "The Godfather = Part II" },
                new Movie { rank = 4, rating = 8.9, year = 1966, title = "Il buono, il brutto, il cattivo." },
                new Movie { rank = 5, rating = 8.9, year = 1994, title = "Pulp Fiction" },
                new Movie { rank = 6, rating = 8.9, year = 1957, title = "12 Angry Men" },
                new Movie { rank = 7, rating = 8.9, year = 1993, title = "Schindler's List" },
                new Movie { rank = 8, rating = 8.8, year = 1975, title = "One Flew Over the Cuckoo's Nest" },
                new Movie { rank = 9, rating = 8.8, year = 2010, title = "Inception" },
                new Movie { rank = 10, rating = 8.8, year = 2008, title = "The Dark Knight" } 
            };
            var dataSource = new DataSource(new DataSourceConfiguration
            {
                data = movies,
                change = () => new jQuery("#movies tbody").html(Kendo.render(template, JsContext.@this.As<DataSource>().view()))
            });
            dataSource.read();
        }

        [JsType(JsMode.Json)]
        class Movie
        {
            public JsNumber rank { get; set; }
            public JsNumber rating { get; set; }
            public JsNumber year { get; set; }
            public JsString title { get; set; }
        }
    }
}