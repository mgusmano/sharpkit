using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using SharpKit.JavaScript;

namespace SharpKitGridSample.jQuerySamples.AjaxSample
{
    /// <summary>
    /// Simple HttpHandler to 
    /// </summary>
    public class MyHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //Deserialize parameters
            var prm = context.Request["prm"];

            //Create a Json for result
            var res = new MyResult { OriginalValue = prm };
            res.NewValue = prm.ToUpper();

            //Serialize the result
            var s = new JavaScriptSerializer().Serialize(res);
            context.Response.ContentType = "application/json";
            context.Response.Write(s);
        }

        public bool IsReusable { get { return false; } }
    }

}