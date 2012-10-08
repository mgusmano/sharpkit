using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace Html5Samples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    [JsType(JsMode.Global)]
    class DefaultClient
    {
        static void Main()
        {
            var geo = HtmlContext.navigator.As<NavigatorGeolocation>().geolocation;
            geo.getCurrentPosition(pos =>
                {
                    HtmlContext.alert(pos);
                    return JsContext.undefined.As<bool>();
                });
        }
    }

}