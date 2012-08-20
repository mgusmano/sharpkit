using SharpKit.Html4;
using SharpKit.JavaScript;
using SharpKit.jQuery;

namespace SharpKitGridSample
{
    public partial class GridDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {

        }
    }
    [JsType(JsMode.Global, Filename = "GridDemo.js")]
    public class GridDemoClient : jQueryContextBase
    {
        public static void Load()
        {
            var list = new JsArray<Contact>
                (
                new Contact { Name = "Shooki", Age = 7, Description = "Hey", PhoneNumber = "234234" },
                new Contact { Name = "Booki", Age = 23, Description = "You", PhoneNumber = "6546" },
                new Contact { Name = "Mooki", Age = 54, Description = "What's", PhoneNumber = "1235" },
                new Contact { Name = "Looki", Age = 13, Description = "Up", PhoneNumber = "27457" },
                new Contact { Name = "Tooki", Age = 2, Description = "Dude", PhoneNumber = "9856587" },
                new Contact { Name = "Cookie", Age = 8, Description = "Gotta", PhoneNumber = "4768" },
                new Contact { Name = "Rookie", Age = 34, Description = "Minute", PhoneNumber = "4567456" },
                new Contact { Name = "Zooki", Age = 45, Description = "For", PhoneNumber = "56464" },
                new Contact { Name = "Xooxi", Age = 2, Description = "Me", PhoneNumber = "23452456" }
                );

            Grid = new Grid { Element = document.getElementById("MyGrid") };
            Grid.Render();
            foreach (var c in list)
            {
                var row = new GridRow { Element = Grid.CreateRowElement(document.getElementById("MyGridRowTemplate")), Data = c };
                var tr = J(row.Element);
                tr.find(".CellName").text(c.Name);
                tr.find(".CellPhoneNumber").text(c.PhoneNumber);
                tr.find(".CellAge").text(c.Age.ToString());
                tr.find(".CellDescription").text(c.Description);
                Grid.AddRow(row);

            }
        }
        static Grid Grid;
        static HtmlTableCell LastSortHeader;
        static JsString LastSort;
        static bool IsLastSortDescending;
        public static void SortBy(HtmlTableCell header, JsString pe)
        {
            J(LastSortHeader).removeClass("Sorted").removeClass("Descending");
            IsLastSortDescending = LastSort == pe && !IsLastSortDescending;
            LastSort = pe;
            LastSortHeader = header;
            J(LastSortHeader).addClass("Sorted");
            J(LastSortHeader).toggleClass("Descending", IsLastSortDescending);

            var rows = Grid.Rows.OrderBy(t => t.Data.As<JsObject>()[pe], IsLastSortDescending);
            Grid.DeleteAllRows();
            foreach (var row in rows)
                Grid.AddRow(row);
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

    [JsType(JsMode.Prototype, Filename = "GridDemo.js")]
    static class JsArrayExtensions
    {
        static JsNumber Compare(object x, object y)
        {
            var xx = x.As<int>();
            var yy = y.As<int>();
            if (xx > yy)
                return 1;
            if (xx < yy)
                return -1;
            return 0;
        }
        static JsNumber CompareDesc(object x, object y)
        {
            var xx = x.As<int>();
            var yy = y.As<int>();
            if (xx > yy)
                return -1;
            if (xx < yy)
                return 1;
            return 0;
        }
        public static JsArray<T> OrderBy<T>(this JsArray<T> array, JsFunc<T, object> selector, bool desc)
        {
            var array2 = array.slice(0);
            if (!desc)
                array2.sort((x, y) => Compare(selector(x), selector(y)));
            else
                array2.sort((x, y) => CompareDesc(selector(x), selector(y)));
            return array2;
        }

    }
}