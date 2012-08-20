using System;
using System.Collections.Generic;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace SharpKit.JavaScript.NoClr.Samples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }

    [JsType(JsMode.Json)]
    class Contact
    {
        [JsMethod(InstanceImplementedAsExtension=true, Name="MyExtensions.CallContact")]
        public void Call()
        {
        }
    }

    [JsType(JsMode.Global, Filename = "res/Default.js")]
    public class DefaultClient : jQueryContext
    {
        static void DefaultClient_Load()
        {
        }
        static void btnTest_click(HtmlDomEventArgs e)
        {
            var xxxx = @"hello
world";
            new Contact().Call();
            var s = "asdsa";
            var xx = s[6];
            var y = s.Length;
            var arr2 = new string[]{"a","b"};
            y = arr2.Length;
            //new string("asdas");
            
            var list = new List<string>();
            list.IndexOf("Asdas");
            list.Insert(3, "Asdasd");
            list.Add("asdas");
            list.Add("ggg");
            list.RemoveAt(0);
            var x = list[0];
            list[0] = "aaa";
            alert(x);
            foreach (var item in list)
            {
                alert(item);
            }


            var dic = new Dictionary<string, object>();
            dic["asd"] = 7;
            dic["aasdsd"] = 8;
            dic["aasdd"] = 9;
            dic.Remove("asd");
            foreach (var key in dic.Keys)
            {
                var value = dic[key];
                alert(value);
            }
        }
    }

}