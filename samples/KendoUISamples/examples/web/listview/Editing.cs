using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;

namespace KendoUISamples.examples.web.listview
{
    [JsType(JsMode.Global)]
    public class Editing
    {
        static Editing()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var fields = new JsObject<FieldConfig>();
            fields["ProductID"] = new FieldConfig { editable = false, nullable = true };
            fields["ProductName"] = "ProductName".As<FieldConfig>();
            fields["UnitPrice"] = new FieldConfig { type = "number" };
            fields["Discontinued"] = new FieldConfig { type = "boolean" };
            fields["UnitsInStock"] = new FieldConfig { type = "number" };
            var crudServiceBaseUrl = "http://demos.kendoui.com/service";
            var dataSource = new DataSource(new DataSourceConfiguration
            {
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Update",
                        dataType = "jsonp"
                    },
                    update = new DataSourceTransportUpdateConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Update",
                        dataType = "jsonp"
                    },
                    destroy = new DataSourceTransportDestroyConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Destroy",
                        dataType = "jsonp"
                    },
                    create = new DataSourceTransportCreateConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Create",
                        data = "jsonp"
                    },

                    parameterMap = (options, operation) =>
                        {
                            if (operation.ExactNotEquals("read") && options.As<JsObject>()["models"].As<bool>())
                            {
                                //TODO: return {models: kendo.stringify(options.models)};
                                JsContext.JsCode("return {models: kendo.stringify(options.models)};");
                                return null;
                            }
                            return null;
                        }
                },
                batch = true,
                pageSize = 4,
                schema = new DataSourceSchemaConfiguration
                {
                    model = new ModelObjectOptions
                    {
                        id = "ProductID",
                        fields = fields
                    }
                }
            });
            new jQuery("#pager").kendoPager(new PagerConfiguration
            {
                dataSource = dataSource
            });
            var listView = new jQuery("#listView").kendoListView(new ListViewConfiguration
            {
                dataSource = dataSource,
                template = Kendo.template(new jQuery("#template").html()),
                editTemplate = Kendo.template(new jQuery("#editTemplate").html()),
            }).data("kendoListView").As<ListView>();
            new jQuery(".k-add-button").click(e =>
            {
                listView.add();
                e.preventDefault();
            });
        }
    }
}