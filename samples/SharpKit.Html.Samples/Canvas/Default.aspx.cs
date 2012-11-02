using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpKit.JavaScript;

namespace SharpKit.Html.Samples.Canvas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    [JsType(JsMode.Global, Filename="Default.js")]
    public class DefaultClient
    {
        static void btn_click(DOMEvent e)
        {
            var canvas = HtmlContext.document.getElementsByTagName("canvas")[0].As<HtmlCanvasElement>();
            var ctx = canvas.getContext("2d").As<CanvasRenderingContext2D>();
            ctx.beginPath();
            ctx.arc(75, 75, 10, 0, JsMath.PI * 2, true);
            ctx.closePath();
            ctx.fill();
        }
    }
}