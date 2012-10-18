using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using KendoUISamples.examples.content.shared.js;

namespace KendoUISamples.examples.web.listview
{
    [JsType(JsMode.Global)]
    public class Selection
    {
        public static DataSource dataSource = new DataSource(new DataSourceConfiguration
        {
            transport = new DataSourceTransportConfiguration
            {
                read = new DataSourceTransportReadConfiguration
                {
                    url = "http://demos.kendoui.com/service/Products",
                    dataType = "jsonp"
                }
            },
            pageSize = 12
        });

        static Selection()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#pager").kendoPager(new PagerConfiguration {
                dataSource = dataSource
            });

            new jQuery("#listView").kendoListView(new ListViewConfiguration {
                dataSource = dataSource,
                selectableString = "multiple",
                dataBound = onDataBound,
                change = onChange,
                template = Kendo.template(new jQuery("#template").html())
            });

            
        }
        static void onDataBound()
        {
            kendoConsole.log("ListView data bound");
        }

        static void onChange() {
            JsArray data = dataSource.view(),
                selected = jQuery.map(JsContext.@this.As<SharpKit.KendoUI.Web.ListView>().select(), item => data[new jQuery(item).index()].As<JsObject>()["ProductName"]);
                kendoConsole.log("Selected = " + selected.length + " item(s), [" + selected.join(", ") + "]");
            }
    }
}