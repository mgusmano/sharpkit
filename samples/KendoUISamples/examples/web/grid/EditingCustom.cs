using SharpKit.JavaScript;
using SharpKit.KendoUI;
using SharpKit.KendoUI.Web;
using SharpKit.jQuery;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class EditingCustom
    {
        static EditingCustom()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var products = new JsArray<Product>
            {
                new Product {
                    ProductID = 1,
                    ProductName = "Chai",
                    Category = "Beverages",
                    UnitPrice = "18:00"
                }, 
                new Product {
                    ProductID = 2,
                    ProductName = "Chang",
                    Category = "Beverages",
                    UnitPrice = "19.00"
                }, 
                new Product {
                    ProductID = 3,
                    ProductName = "Aniseed Syrup",
                    Category = "Condiments",
                    UnitPrice = "10.00"
                }, 
                new Product{
                    ProductID = 4,
                    ProductName = "Chef Anton's Cajun Seasoning",
                    Category = "Condiments",
                    UnitPrice = "22.00"
                },
                new Product{
                    ProductID = 5,
                    ProductName = "Chef Anton's Gumbo Mix",
                    Category = "Condiments",
                    UnitPrice = "21.35"
                }, 
                new Product {
                    ProductID = 6,
                    ProductName = "Grandma's Boysenberry Spread",
                    Category = "Condiments",
                    UnitPrice = "25.00"            
                }
            };


            var fields = new JsObject<FieldConfig>();
            fields["ProductID"] = new FieldConfig { editable = false, nullable = true };
            fields["ProductName"] = new FieldConfig { validation = new ValidatorConfiguration { required = true } };
            fields["Category"] = "Category".As<FieldConfig>();
            fields["UnitPrice"] = new FieldConfig { type = "number", validation = new ValidatorConfiguration { required = true, min = 1 } };


            var dataSource = new DataSource(new DataSourceConfiguration
            {
                pageSize = 30,
                data = products,
                autoSync = true,
                schema = new DataSourceSchemaConfiguration
                {
                    model = new ModelObjectOptions
                    {
                        id = "productID",
                        fields = fields,
                    }
                }
            });
            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = dataSource,
                pageableBoolean = true,
                height = 260,
                toolbar = new GridSortableToolbarConfiguration { text = "create" },
                columns = new JsArray<GridColumnConfiguration> {
                    new GridColumnConfiguration { field = "ProductName", title = "Product Name" },
                   new GridColumnConfiguration { field = "Category", width = "150px", editor = categoryDropDownEditor },
                   new GridColumnConfiguration {  field = "UnitPrice", title = "Unit Price", format = "{0:c}", width = "150px" },
                   new GridColumnConfiguration { commandString = "destroy", title = " ", width = "110px" }
                },
                editableBoolean = true
            });
        }

        static void categoryDropDownEditor(jQuery container, GridColumnsEditorOptionsConfiguration options)
        {
            new jQuery("<input data-text-field='CategoryName' data-value-field='CategoryName' data-bind='value:' + options.field + ''/>")
            .appendTo(container)
            .kendoDropDownList(new DropDownListConfiguration
            {
                autoBind = false,
                dataSourceObject = new DataSourceConfiguration
                {
                    type = "odata",
                    transport = new DataSourceTransportConfiguration
                    {
                        readString = "http://demos.kendoui.com/service/Northwind.svc/Categories"
                    }
                }
            });
        }

        [JsType(JsMode.Json)]
        class Product
        {
            public JsNumber ProductID { get; set; }
            public JsString ProductName { get; set; }
            public JsString Category { get; set; }
            public JsString UnitPrice { get; set; }
        }
    }
}

