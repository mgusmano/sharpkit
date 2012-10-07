using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.listview
{
    [JsType(JsMode.Global)]
    public class RemoteData
    {
        static RemoteData()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var dataSource = new DataSource(new DataSourceConfiguration
            {
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        url = "http://search.twitter.com/search.json",
                        contentType = "application/json; charset=utf-8",
                        type = TransportType.GET,
                        dataType = "jsonp",
                        //TODO: q??
                        data = new
                        {
                            q = "#kendoui"
                        }
                    }
                },
                schema = new DataSourceSchemaConfiguration
                {
                    data = "results",
                    total = "results_per_page"
                }
            });

            new jQuery("#pager").kendoPager(new PagerConfiguration
            {
                dataSource = dataSource
            });

            new jQuery("#listView").kendoListView(new ListViewConfiguration
            {
                dataSource = dataSource,
                template = Kendo.template(new jQuery("#template").html())
            });

        }
    }
}