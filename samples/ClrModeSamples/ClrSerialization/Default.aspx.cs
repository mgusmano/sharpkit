using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html;

namespace ClrModeSamples.ClrSerialization
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }




    [JsType(JsMode.Global, Filename="Default.js")]
    class DefaultClient
    {
        public static void OnLoad()
        {
            jQuery.ajax(new AjaxSettings
            {
                url = "Handler.ashx",
                dataType = "text",
                success = (js, b, cc) =>
                    {
                        var func = new JsFunction(js.As<JsString>());
                        var x = func.call();
                        var c = x.As<Contact>();
                        HtmlContext.alert(c.GetType().FullName+","+c.Name);
                    }
            });
        }
    }

    [JsType(JsMode.Clr, Filename = "Default.js")]
    public class MyContact
    {
        public string Name { get; set; }
    }
}