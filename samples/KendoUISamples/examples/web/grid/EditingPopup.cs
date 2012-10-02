using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;
namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class EditingPopup
    {
        static EditingPopup()
        {
            new jQuery(OnReady);
        }
        static void OnReady()
        {
            var crudServiceBaseUrl = "http://demos.kendoui.com/service";
            var fields = new JsObject<FieldConfig>();
            fields["ProductID"] = new FieldConfig { editable = false, nullable = true };
            fields["ProductName"] = new FieldConfig { validation = new ValidatorConfiguration { required = true } };
            fields["UnitPrice"] = new FieldConfig { type = "number", validation = new ValidatorConfiguration { required = true, } }; //TODO: min: 1
            fields["Discontinued"] = new FieldConfig { type = "boolean" };
            fields["UnitsInStock"] = new FieldConfig { type = "number", validation = new ValidatorConfiguration { required = true } };//TODO: min: 0,


            var dataSource = new DataSource(new DataSourceConfiguration
            {
                transport = new DataSourceTransportConfiguration
                {
                    read = new DataSourceTransportReadConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Update",
                        dataType = "jsonp"
                    },
                    destroy = new DataSourceTransportDestroyConfiguration
                    {
                        url = crudServiceBaseUrl + "/Products/Destroy",
                        dataType = "jsonp"
                    },
                    parameterMap = (options, operations) =>
                         {
                             var models = options.As<JsObject>()["models"];
                             if (operations.ExactNotEquals("read") && models.As<bool>())
                             {
                                 //TODO : find return new stringify {models= Kendo.stringify(models)};
                                 return null;
                             }
                             return null;
                         }

                },
                batch = true,
                pageSize = 30,
                schema = new DataSourceSchemaConfiguration
                {
                    model = new ModelObjectOptions
                    {
                        id = "ProductID",
                        fields = fields,
                    }
                }
            });

            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = dataSource,
                pageableBoolean = true,
                height = 400,
                toolbar = new GridSortableToolbarConfiguration { text = "create" },
                columns = new JsArray<GridColumnConfiguration> {
                    new GridColumnConfiguration { field ="ProductName", title = "Product Name" },
                    new GridColumnConfiguration{ field = "UnitPrice", title ="Unit Price", format = "{0 =c}", width = "150px" },
                    new GridColumnConfiguration{ field = "UnitsInStock", title ="Units In Stock", width = "150px" },
                    new GridColumnConfiguration{ field = "Discontinued", width = "100px" },
                    //TODO:  enum    { command: ["edit", "destroy"], title: "&nbsp;", width: "210px" }],
                    new GridColumnConfiguration{ commandStringArray = new JsArray<JsString> {"create", "destroy"}, title = "&nbsp;", width = "210px" }
                },
                editableString = "popup",
            });


           
        }
    }
}