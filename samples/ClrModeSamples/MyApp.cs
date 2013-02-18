using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace ClrModeSamples
{
    [JsType(JsMode.Clr)]
    public class MyApp
    {
        public static void Main()
        {
            var list = new List<Contact>();
            list.Add(new Contact { Name = "Asdas" });
            foreach (var item in list)
                HtmlContext.alert(item.Name);
            list.First().CallMe();
            list.First().CallMe("Hello");

        }
    }
    [JsType(JsMode.Clr)]
    class Contact
    {
        public string Name { get; set; }
        public void CallMe()
        {
            HtmlContext.alert("CallMe1");
        }
        public void CallMe(string s)
        {
            HtmlContext.alert("CallMe2 "+s);
        }
    }
}