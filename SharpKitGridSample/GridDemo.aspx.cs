using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.Html4;
using SharpKit.JavaScript;
using SharpKit.jQuery;

namespace SharpKitGridSample
{
    public partial class GridDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    [JsType(JsMode.Global, Filename = "GridDemo.js")]
    public class GridDemoClient : jQueryContextBase
    {
        public static void Load()
        {
            var list = new JsArray<Contact>();

            for (var i = 0; i < 10; i++)
            {
                var c = new Contact { Name = "MyContact" + i, Age = i, PhoneNumber = "44557799" + i, Description="This is a contact "+i };
                list.push(c);
            }
            var grid = new Grid { Element = document.getElementById("MyGrid") };
            grid.Render();
            foreach (var c in list)
            {
                var row = new GridRow { Element = grid.CreateRowElement(document.getElementById("MyGridRowTemplate")), Data = c };
                var tr = J(row.Element);
                tr.find(".CellName").text(c.Name);
                tr.find(".CellPhoneNumber").text(c.PhoneNumber);
                tr.find(".CellAge").text(c.Age.ToString());
                tr.find(".CellDescription").text(c.Description);
                grid.AddRow(row);

            }
        }
    }

    [JsType(JsMode.Json)]
    class Contact
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}