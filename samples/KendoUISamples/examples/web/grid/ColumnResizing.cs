using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;
using SharpKit.KendoUI;
using KendoUISamples.examples.content.shared.js;

namespace KendoUISamples.examples.web.grid
{
    [JsType(JsMode.Global)]
    public class ColumnResizing
    {
        static ColumnResizing()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            var fields = new JsObject<FieldConfig>();
            fields["FirstName"] = new FieldConfig { type = "string" };
            fields["LastName"] = new FieldConfig { type = "string" };
            fields["City"] = new FieldConfig { type = "string" };
            fields["Title"] = new FieldConfig { type = "string" };
            fields["BirthDate"] = new FieldConfig { type = "date" };
            fields["Age"] = new FieldConfig { type = "number" };

            new jQuery("#grid").kendoGrid(new GridConfiguration
            {
                dataSourceObject = new DataSourceConfiguration
                {
                    data = People.createRandomData(50),
                    schema = new DataSourceSchemaConfiguration
                    {
                        model = new ModelObjectOptions
                        {
                            fields = fields
                        }
                    },
                    pageSize = 10
                },
                height = 350,
                sortableBoolean = true,
                resizable = true,
                pageableBoolean = true,
                columns = new JsArray<GridColumnConfiguration> {
                    new GridColumnConfiguration 
                    {
                        field = "FirstName",
                        title = "First Name",
                        widthNumber = 100
                    },
                    new GridColumnConfiguration 
                    {
                        field = "LastName",
                        title = "Last Name",
                        widthNumber = 100
                    },
                    new GridColumnConfiguration 
                    {
                        field = "City",
                        widthNumber =100
                    },
                    new GridColumnConfiguration 
                    {
                        field = "Title",
                        widthNumber = 100
                    },
                    new GridColumnConfiguration 
                    {
                        field = "BirthDate",
                        title = "Birth Date",
                        template = "#= kendo.toString(BirthDate,'MM/dd/yyyy') #"
                    },
                    new GridColumnConfiguration 
                    {
                        field = "Age",
                        widthNumber = 50
                    }
                }

            });
                            
        }
    }
}