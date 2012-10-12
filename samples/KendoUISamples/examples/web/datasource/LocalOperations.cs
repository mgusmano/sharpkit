using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI;
using KendoUISamples.examples.content.shared.js;
using SharpKit.Html4;


namespace KendoUISamples.examples.web.datasource
{
    [JsType(JsMode.Global)]
    public class LocalOperations
    {
        static LocalOperations()
        {
            new jQuery(OnReady);
        }

        //TODO: Compile error: Uncaught ReferenceError: System is not defined 
        static void OnReady()
        {
            // create a template using the above definition
            var template = Kendo.template(new jQuery("#template").html());
            var dataSource = new DataSource(new DataSourceConfiguration
            {
                pageSize = 10,
                data = People.createRandomData(500),
                // subscribe to the CHANGE event of the data source
                change = () =>
                    {
                        // update the max attribute of the "page" input
                        new jQuery("#page").attr("max", JsContext.@this.As<DataSource>().totalPages());
                        new jQuery("#people tbody").html(Kendo.render(template, JsContext.@this.As<DataSource>().view()));
                    }
            });
            // read the data
            dataSource.read();
            new jQuery("#apply").click(() =>
                {
                    var page = int.Parse(new jQuery("#page").val().As<JsString>());// ,10)
                    // validate the page - it must be a number within the allowed range
                    if (JsContext.isNaN(page) || page < 1 || page > dataSource.totalPages())
                    {
                        HtmlContext.window.alert(Kendo.format("Page must be a number between 1 and {0}", dataSource.totalPages()));
                        return;
                    }
                    //// query the remote service
                    dataSource.query(new DataSourceConfiguration
                    {
                        page = page,
                        pageSize = 10,
                        //TODO: sortOPtions
                        sort = new { field = new jQuery("#order").val(), dir = new jQuery("#dir").val() }

                    });
                });
                   //initialize dropdownlist components
                   new jQuery("#order").kendoDropDownList();
                   new jQuery("#dir").kendoDropDownList();
        }
    }
}