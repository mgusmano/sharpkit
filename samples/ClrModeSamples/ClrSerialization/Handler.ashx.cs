using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ClrModeSamples.ClrSerialization
{
    /// <summary>
    /// Summary description for Handler
    /// </summary>
    public class Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            SendClrObject(context, new MyContact { Name = "Asdsad" });
        }


        void SendClrObject(HttpContext context, object obj)
        {
            var ser = new JsClrSerializer
            {
                Writer = context.Response.Output,
            };
            var s = ser.Serialize(obj);
            context.Response.Write("return ");
            context.Response.Write(s);
            context.Response.Write(";");
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}